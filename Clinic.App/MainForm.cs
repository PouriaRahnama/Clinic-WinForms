using Clinic.App.Login;
using Clinic.App.Patient_Info;
using Clinic.App.Patient_Reception;
using Clinic.App.Patient_Visit;
using Clinic.Data.Entities;
using Clinic.Utility.Convertor;

namespace Clinic.App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                DateDay.Text = DateTime.Now.ToShamsi().ToString();
                DateDay.Text = DateTime.Now.ToShamsi().ToString();
                time.Text = DateTime.Now.ToString("hh:mm:ss");
            }
            else
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void txtInformation_Click(object sender, EventArgs e)
        {
            Patient_Info.PatientInfo patient = new Patient_Info.PatientInfo();
            patient.ShowDialog();
        }

        private void txtReception_Click(object sender, EventArgs e)
        {
            PatientReception reception = new PatientReception();
            if (reception.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("اطلاعات با موفقیت ثبت شد");
            }
        }

        private void txtVisit_Click(object sender, EventArgs e)
        {
            Turns frm = new Turns();
            frm.ShowDialog();
        }

        private void txtReport_Click(object sender, EventArgs e)
        {
            Reports show = new Reports();
            show.ShowDialog();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.IsEdit = true;
            frmLogin.ShowDialog();
        }
    }
}