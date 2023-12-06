using System.Runtime.InteropServices;
using System.Text;

namespace Clinic.App._Utilities.RtlMessageBox
{
    public class RtlMessageBox
    {
        static MessageBoxOptions rtlOptions = MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign;

        static RtlMessageBox()
        {
            MessageBoxManager.Register();
        }

        public static DialogResult Show(string text)
        {
            return MessageBox.Show(
                text,
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                rtlOptions);
        }

        public static DialogResult Show(string text, string caption)
        {
            return MessageBox.Show(
                text,
                caption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                rtlOptions);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            return MessageBox.Show(
                text,
                caption,
                buttons,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                rtlOptions);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MessageBox.Show(
                text,
                caption,
                buttons,
                icon,
                MessageBoxDefaultButton.Button1,
                rtlOptions);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
        {
            rtlOptions |= options;

            return MessageBox.Show(
                 text,
                 caption,
                 buttons,
                 icon,
                 MessageBoxDefaultButton.Button1,
                 rtlOptions);
        }

        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
        {
            return MessageBox.Show(
                text,
                caption,
                buttons,
                icon,
                defaultButton,
                rtlOptions);
        }
    }

    public class MessageBoxManager
    {
        private delegate nint HookProc(int nCode, nint wParam, nint lParam);
        private delegate bool EnumChildProc(nint hWnd, nint lParam);

        private const int WH_CALLWNDPROCRET = 12;
        private const int WM_DESTROY = 0x0002;
        private const int WM_INITDIALOG = 0x0110;
        private const int WM_TIMER = 0x0113;
        private const int WM_USER = 0x400;
        private const int DM_GETDEFID = WM_USER + 0;

        private const int MBOK = 1;
        private const int MBCancel = 2;
        private const int MBAbort = 3;
        private const int MBRetry = 4;
        private const int MBIgnore = 5;
        private const int MBYes = 6;
        private const int MBNo = 7;


        [DllImport("user32.dll")]
        private static extern nint SendMessage(nint hWnd, int Msg, nint wParam, nint lParam);

        [DllImport("user32.dll")]
        private static extern nint SetWindowsHookEx(int idHook, HookProc lpfn, nint hInstance, int threadId);

        [DllImport("user32.dll")]
        private static extern int UnhookWindowsHookEx(nint idHook);

        [DllImport("user32.dll")]
        private static extern nint CallNextHookEx(nint idHook, int nCode, nint wParam, nint lParam);

        [DllImport("user32.dll", EntryPoint = "GetWindowTextLengthW", CharSet = CharSet.Unicode)]
        private static extern int GetWindowTextLength(nint hWnd);

        [DllImport("user32.dll", EntryPoint = "GetWindowTextW", CharSet = CharSet.Unicode)]
        private static extern int GetWindowText(nint hWnd, StringBuilder text, int maxLength);

        [DllImport("user32.dll")]
        private static extern int EndDialog(nint hDlg, nint nResult);

        [DllImport("user32.dll")]
        private static extern bool EnumChildWindows(nint hWndParent, EnumChildProc lpEnumFunc, nint lParam);

        [DllImport("user32.dll", EntryPoint = "GetClassNameW", CharSet = CharSet.Unicode)]
        private static extern int GetClassName(nint hWnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        private static extern int GetDlgCtrlID(nint hwndCtl);

        [DllImport("user32.dll")]
        private static extern nint GetDlgItem(nint hDlg, int nIDDlgItem);

        [DllImport("user32.dll", EntryPoint = "SetWindowTextW", CharSet = CharSet.Unicode)]
        private static extern bool SetWindowText(nint hWnd, string lpString);


        [StructLayout(LayoutKind.Sequential)]
        public struct CWPRETSTRUCT
        {
            public nint lResult;
            public nint lParam;
            public nint wParam;
            public uint message;
            public nint hwnd;
        };

        private static HookProc hookProc;
        private static EnumChildProc enumProc;
        [ThreadStatic]
        private static nint hHook;
        [ThreadStatic]
        private static int nButton;

        /// <summary>
        /// OK text
        /// </summary>
        public static string OK = "&تایید";
        /// <summary>
        /// Cancel text
        /// </summary>
        public static string Cancel = "&انصراف";
        /// <summary>
        /// Abort text
        /// </summary>
        public static string Abort = "&توقف";
        /// <summary>
        /// Retry text
        /// </summary>
        public static string Retry = "&سعی مجدد";
        /// <summary>
        /// Ignore text
        /// </summary>
        public static string Ignore = "&نادیده گرفتن";
        /// <summary>
        /// Yes text
        /// </summary>
        public static string Yes = "&بله";
        /// <summary>
        /// No text
        /// </summary>
        public static string No = "&خیر";

        static MessageBoxManager()
        {
            hookProc = new HookProc(MessageBoxHookProc);
            enumProc = new EnumChildProc(MessageBoxEnumProc);
            hHook = nint.Zero;
        }

        /// <summary>
        /// Enables MessageBoxManager functionality
        /// </summary>
        /// <remarks>
        /// MessageBoxManager functionality is enabled on current thread only.
        /// Each thread that needs MessageBoxManager functionality has to call this method.
        /// </remarks>
        public static void Register()
        {
            if (hHook != nint.Zero)
                throw new NotSupportedException("One hook per thread allowed.");
            hHook = SetWindowsHookEx(WH_CALLWNDPROCRET, hookProc, nint.Zero, AppDomain.GetCurrentThreadId());
        }

        /// <summary>
        /// Disables MessageBoxManager functionality
        /// </summary>
        /// <remarks>
        /// Disables MessageBoxManager functionality on current thread only.
        /// </remarks>
        public static void Unregister()
        {
            if (hHook != nint.Zero)
            {
                UnhookWindowsHookEx(hHook);
                hHook = nint.Zero;
            }
        }

        private static nint MessageBoxHookProc(int nCode, nint wParam, nint lParam)
        {
            if (nCode < 0)
                return CallNextHookEx(hHook, nCode, wParam, lParam);

            CWPRETSTRUCT msg = (CWPRETSTRUCT)Marshal.PtrToStructure(lParam, typeof(CWPRETSTRUCT));
            nint hook = hHook;

            if (msg.message == WM_INITDIALOG)
            {
                int nLength = GetWindowTextLength(msg.hwnd);
                StringBuilder className = new StringBuilder(10);
                GetClassName(msg.hwnd, className, className.Capacity);
                if (className.ToString() == "#32770")
                {
                    nButton = 0;
                    EnumChildWindows(msg.hwnd, enumProc, nint.Zero);
                    if (nButton == 1)
                    {
                        nint hButton = GetDlgItem(msg.hwnd, MBCancel);
                        if (hButton != nint.Zero)
                            SetWindowText(hButton, OK);
                    }
                }
            }

            return CallNextHookEx(hook, nCode, wParam, lParam);
        }

        private static bool MessageBoxEnumProc(nint hWnd, nint lParam)
        {
            StringBuilder className = new StringBuilder(10);
            GetClassName(hWnd, className, className.Capacity);
            if (className.ToString() == "Button")
            {
                int ctlId = GetDlgCtrlID(hWnd);
                switch (ctlId)
                {
                    case MBOK:
                        SetWindowText(hWnd, OK);
                        break;
                    case MBCancel:
                        SetWindowText(hWnd, Cancel);
                        break;
                    case MBAbort:
                        SetWindowText(hWnd, Abort);
                        break;
                    case MBRetry:
                        SetWindowText(hWnd, Retry);
                        break;
                    case MBIgnore:
                        SetWindowText(hWnd, Ignore);
                        break;
                    case MBYes:
                        SetWindowText(hWnd, Yes);
                        break;
                    case MBNo:
                        SetWindowText(hWnd, No);
                        break;

                }
                nButton++;
            }

            return true;
        }


    }
}
