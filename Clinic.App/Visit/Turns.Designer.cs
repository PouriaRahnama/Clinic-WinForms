namespace Clinic.App.Patient_Visit
{
    partial class Turns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turns));
            toolStrip1 = new ToolStrip();
            btnUpdateNobat = new ToolStripButton();
            btnDeleteNobat = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtFromDate = new MaskedTextBox();
            dgPatient = new DataGridView();
            PatientId = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Reason = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            TheCostOfTheVisit = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPatient).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnUpdateNobat, btnDeleteNobat, btnRefresh });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(802, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnUpdateNobat
            // 
            btnUpdateNobat.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnUpdateNobat.Image = (Image)resources.GetObject("btnUpdateNobat.Image");
            btnUpdateNobat.ImageTransparentColor = Color.Magenta;
            btnUpdateNobat.Name = "btnUpdateNobat";
            btnUpdateNobat.RightToLeft = RightToLeft.Yes;
            btnUpdateNobat.Size = new Size(95, 24);
            btnUpdateNobat.Text = "ویرایش نوبت";
            btnUpdateNobat.Click += btnUpdateNobat_Click;
            // 
            // btnDeleteNobat
            // 
            btnDeleteNobat.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDeleteNobat.Image = (Image)resources.GetObject("btnDeleteNobat.Image");
            btnDeleteNobat.ImageTransparentColor = Color.Magenta;
            btnDeleteNobat.Name = "btnDeleteNobat";
            btnDeleteNobat.Size = new Size(81, 24);
            btnDeleteNobat.Text = "حذف نوبت";
            btnDeleteNobat.Click += btnDeleteNobat_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(76, 24);
            btnRefresh.Text = "بروزرسانی";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 61);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "تاریخ :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtFromDate);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(781, 125);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "جستجو";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(214, 58);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "انجام";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtFromDate
            // 
            txtFromDate.Location = new Point(314, 58);
            txtFromDate.Mask = "0000/00/00";
            txtFromDate.Name = "txtFromDate";
            txtFromDate.Size = new Size(175, 27);
            txtFromDate.TabIndex = 2;
            // 
            // dgPatient
            // 
            dgPatient.AllowUserToAddRows = false;
            dgPatient.AllowUserToDeleteRows = false;
            dgPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPatient.BackgroundColor = SystemColors.ButtonFace;
            dgPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPatient.Columns.AddRange(new DataGridViewColumn[] { PatientId, FullName, Reason, Data, Time, TheCostOfTheVisit });
            dgPatient.Location = new Point(12, 161);
            dgPatient.Name = "dgPatient";
            dgPatient.ReadOnly = true;
            dgPatient.RightToLeft = RightToLeft.Yes;
            dgPatient.RowHeadersWidth = 51;
            dgPatient.RowTemplate.Height = 29;
            dgPatient.Size = new Size(778, 186);
            dgPatient.TabIndex = 4;
            // 
            // PatientId
            // 
            PatientId.HeaderText = "PatientId";
            PatientId.MinimumWidth = 6;
            PatientId.Name = "PatientId";
            PatientId.ReadOnly = true;
            PatientId.Visible = false;
            // 
            // FullName
            // 
            FullName.HeaderText = "نام و نام خانوادگی";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Reason
            // 
            Reason.HeaderText = "علت مراجعه";
            Reason.MinimumWidth = 6;
            Reason.Name = "Reason";
            Reason.ReadOnly = true;
            // 
            // Data
            // 
            Data.HeaderText = "تاریخ ویزیت ";
            Data.MinimumWidth = 6;
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // Time
            // 
            Time.HeaderText = "ساعت ویزیت";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.ReadOnly = true;
            // 
            // TheCostOfTheVisit
            // 
            TheCostOfTheVisit.HeaderText = "هزینه ویزیت";
            TheCostOfTheVisit.MinimumWidth = 6;
            TheCostOfTheVisit.Name = "TheCostOfTheVisit";
            TheCostOfTheVisit.ReadOnly = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(701, 353);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(89, 35);
            btnSave.TabIndex = 5;
            btnSave.Text = "ویزیت";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button2_Click;
            // 
            // Turns
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 398);
            Controls.Add(btnSave);
            Controls.Add(dgPatient);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Turns";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PatientsTurn";
            Load += Turns_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnUpdateNobat;
        private ToolStripButton btnDeleteNobat;
        private ToolStripButton btnRefresh;
        private Label label1;
        private GroupBox groupBox1;
        private Button btnSearch;
        private MaskedTextBox txtFromDate;
        private DataGridView dgPatient;
        private Button btnSave;
        private DataGridViewTextBoxColumn PatientId;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Reason;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn TheCostOfTheVisit;
    }
}