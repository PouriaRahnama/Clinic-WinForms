namespace Clinic.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            ToolStripMenuItem = new ToolStripMenuItem();
            toolStrip2 = new ToolStrip();
            txtInformation = new ToolStripButton();
            txtReception = new ToolStripButton();
            txtVisit = new ToolStripButton();
            txtReport = new ToolStripButton();
            pictureBox1 = new PictureBox();
            toolStrip3 = new ToolStrip();
            DateDay = new ToolStripLabel();
            time = new ToolStripLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(78, 24);
            toolStripDropDownButton1.Text = "تنظیمات";
            // 
            // ToolStripMenuItem
            // 
            ToolStripMenuItem.Name = "ToolStripMenuItem";
            ToolStripMenuItem.Size = new Size(180, 26);
            ToolStripMenuItem.Text = "تنظیمات ورود";
            ToolStripMenuItem.Click += ToolStripMenuItem_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { txtInformation, txtReception, txtVisit, txtReport });
            toolStrip2.Location = new Point(0, 27);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.RightToLeft = RightToLeft.Yes;
            toolStrip2.Size = new Size(800, 27);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // txtInformation
            // 
            txtInformation.DisplayStyle = ToolStripItemDisplayStyle.Text;
            txtInformation.Image = (Image)resources.GetObject("txtInformation.Image");
            txtInformation.ImageTransparentColor = Color.Magenta;
            txtInformation.Name = "txtInformation";
            txtInformation.Size = new Size(127, 24);
            txtInformation.Text = "ثبت اطلاعات بیمار";
            txtInformation.Click += txtInformation_Click;
            // 
            // txtReception
            // 
            txtReception.DisplayStyle = ToolStripItemDisplayStyle.Text;
            txtReception.Image = (Image)resources.GetObject("txtReception.Image");
            txtReception.ImageTransparentColor = Color.Magenta;
            txtReception.Name = "txtReception";
            txtReception.Size = new Size(54, 24);
            txtReception.Text = "پذیرش";
            txtReception.Click += txtReception_Click;
            // 
            // txtVisit
            // 
            txtVisit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            txtVisit.Image = (Image)resources.GetObject("txtVisit.Image");
            txtVisit.ImageTransparentColor = Color.Magenta;
            txtVisit.Name = "txtVisit";
            txtVisit.Size = new Size(53, 24);
            txtVisit.Text = "ویزیت";
            txtVisit.Click += txtVisit_Click;
            // 
            // txtReport
            // 
            txtReport.DisplayStyle = ToolStripItemDisplayStyle.Text;
            txtReport.Image = (Image)resources.GetObject("txtReport.Image");
            txtReport.ImageTransparentColor = Color.Magenta;
            txtReport.Name = "txtReport";
            txtReport.Size = new Size(71, 24);
            txtReport.Text = "گزارش ها";
            txtReport.Click += txtReport_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 365);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // toolStrip3
            // 
            toolStrip3.Dock = DockStyle.Bottom;
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Items.AddRange(new ToolStripItem[] { DateDay, time });
            toolStrip3.Location = new Point(0, 425);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.RightToLeft = RightToLeft.Yes;
            toolStrip3.Size = new Size(800, 25);
            toolStrip3.TabIndex = 3;
            toolStrip3.Text = "toolStrip3";
            // 
            // DateDay
            // 
            DateDay.Name = "DateDay";
            DateDay.Size = new Size(39, 22);
            DateDay.Text = "date";
            // 
            // time
            // 
            time.Name = "time";
            time.Size = new Size(39, 22);
            time.Text = "time";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip3);
            Controls.Add(pictureBox1);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStrip toolStrip2;
        private ToolStripButton txtInformation;
        private ToolStripButton txtReception;
        private ToolStripButton txtVisit;
        private ToolStripButton txtReport;
        private PictureBox pictureBox1;
        private ToolStrip toolStrip3;
        private ToolStripLabel DateDay;
        private ToolStripLabel time;
        private System.Windows.Forms.Timer timer1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem ToolStripMenuItem;
    }
}