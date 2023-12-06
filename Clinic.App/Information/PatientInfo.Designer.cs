namespace Clinic.App.Patient_Info
{
    partial class PatientInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInfo));
            toolStrip1 = new ToolStrip();
            btnInsert = new ToolStripButton();
            btnUpdate = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            groupBox1 = new GroupBox();
            dgPatient = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Mobile = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPatient).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInsert, btnUpdate, btnDelete, btnRefresh });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(749, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInsert
            // 
            btnInsert.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnInsert.Image = (Image)resources.GetObject("btnInsert.Image");
            btnInsert.ImageTransparentColor = Color.Magenta;
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(113, 24);
            btnInsert.Text = "افزودن اطلاعات";
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.ImageTransparentColor = Color.Magenta;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 24);
            btnUpdate.Text = "ویرایش اطلاعات";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(102, 24);
            btnDelete.Text = "حذف اطلاعات";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnRefresh.Image = (Image)resources.GetObject("btnRefresh.Image");
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(133, 24);
            btnRefresh.Text = "بروزرسانی اطلاعات";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgPatient);
            groupBox1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(725, 345);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات بیماران";
            // 
            // dgPatient
            // 
            dgPatient.AllowUserToAddRows = false;
            dgPatient.AllowUserToDeleteRows = false;
            dgPatient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPatient.BackgroundColor = SystemColors.ButtonFace;
            dgPatient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPatient.Columns.AddRange(new DataGridViewColumn[] { Id, FullName, Age, Mobile, Address });
            dgPatient.GridColor = SystemColors.ActiveCaptionText;
            dgPatient.Location = new Point(6, 26);
            dgPatient.Name = "dgPatient";
            dgPatient.ReadOnly = true;
            dgPatient.RowHeadersWidth = 51;
            dgPatient.RowTemplate.Height = 29;
            dgPatient.Size = new Size(713, 313);
            dgPatient.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "نام و نام خانوادگی";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Age
            // 
            Age.DataPropertyName = "Age";
            Age.HeaderText = "سن";
            Age.MinimumWidth = 6;
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // Mobile
            // 
            Mobile.DataPropertyName = "Mobile";
            Mobile.HeaderText = "موبایل";
            Mobile.MinimumWidth = 6;
            Mobile.Name = "Mobile";
            Mobile.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "آدرس";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // PatientInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 384);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PatientInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Patients_Profile";
            Load += PatientInfo_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPatient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnInsert;
        private ToolStripButton btnUpdate;
        private ToolStripButton btnDelete;
        private ToolStripButton btnRefresh;
        private GroupBox groupBox1;
        private DataGridView dgPatient;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Mobile;
        private DataGridViewTextBoxColumn Address;
    }
}