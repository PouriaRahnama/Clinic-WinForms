namespace Clinic.App.Patient_Reception
{
    partial class PatientReception
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientReception));
            groupBox1 = new GroupBox();
            dgName = new DataGridView();
            PatientId = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            txtSearch = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtTime = new MaskedTextBox();
            txtDateTime = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSave = new Button();
            txtReason = new TextBox();
            txtPay = new TextBox();
            txtNamePatient = new TextBox();
            requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(components);
            requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(components);
            requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgName).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgName);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(345, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(246, 315);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "مراجعان";
            // 
            // dgName
            // 
            dgName.AllowUserToAddRows = false;
            dgName.AllowUserToDeleteRows = false;
            dgName.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgName.BackgroundColor = SystemColors.ButtonFace;
            dgName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgName.Columns.AddRange(new DataGridViewColumn[] { PatientId, FullName });
            dgName.Location = new Point(9, 59);
            dgName.Name = "dgName";
            dgName.ReadOnly = true;
            dgName.RowHeadersWidth = 51;
            dgName.RowTemplate.Height = 29;
            dgName.Size = new Size(224, 247);
            dgName.TabIndex = 6;
            dgName.CellClick += dgName_CellClick;
            // 
            // PatientId
            // 
            PatientId.DataPropertyName = "PatientId";
            PatientId.HeaderText = "id";
            PatientId.MinimumWidth = 6;
            PatientId.Name = "PatientId";
            PatientId.ReadOnly = true;
            PatientId.Visible = false;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "نام و نام خانوادگی";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(23, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(157, 27);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 29);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 2;
            label1.Text = "جستجو :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTime);
            groupBox2.Controls.Add(txtDateTime);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(txtReason);
            groupBox2.Controls.Add(txtPay);
            groupBox2.Controls.Add(txtNamePatient);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.RightToLeft = RightToLeft.Yes;
            groupBox2.Size = new Size(327, 321);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "گزارش";
            // 
            // txtTime
            // 
            txtTime.Location = new Point(6, 94);
            txtTime.Mask = "00:00:00";
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(215, 27);
            txtTime.TabIndex = 15;
            txtTime.ValidatingType = typeof(DateTime);
            // 
            // txtDateTime
            // 
            txtDateTime.Location = new Point(6, 61);
            txtDateTime.Mask = "0000/00/00";
            txtDateTime.Name = "txtDateTime";
            txtDateTime.Size = new Size(215, 27);
            txtDateTime.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(227, 165);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 13;
            label6.Text = "علت مراجعه :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(227, 33);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 12;
            label5.Text = "نام بیمار :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 68);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 11;
            label4.Text = "تاریخ ویزیت :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 101);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 10;
            label3.Text = "زمان ویزیت :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 134);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 9;
            label2.Text = "هزینه ویزیت :";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(6, 270);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 39);
            btnSave.TabIndex = 8;
            btnSave.Text = "پذیرش";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtReason
            // 
            txtReason.Location = new Point(6, 165);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.Size = new Size(215, 99);
            txtReason.TabIndex = 7;
            // 
            // txtPay
            // 
            txtPay.Location = new Point(6, 127);
            txtPay.Name = "txtPay";
            txtPay.Size = new Size(215, 27);
            txtPay.TabIndex = 6;
            // 
            // txtNamePatient
            // 
            txtNamePatient.Location = new Point(6, 26);
            txtNamePatient.Name = "txtNamePatient";
            txtNamePatient.ReadOnly = true;
            txtNamePatient.Size = new Size(215, 27);
            txtNamePatient.TabIndex = 4;
            // 
            // requiredFieldValidator1
            // 
            requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator1.ControlToValidate = txtNamePatient;
            requiredFieldValidator1.ErrorMessage = "لطفا نام را انتخاب کنید";
            requiredFieldValidator1.Icon = (Icon)resources.GetObject("requiredFieldValidator1.Icon");
            // 
            // requiredFieldValidator2
            // 
            requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator2.ControlToValidate = txtPay;
            requiredFieldValidator2.ErrorMessage = "لطفا هزینه را وارد کنید";
            requiredFieldValidator2.Icon = (Icon)resources.GetObject("requiredFieldValidator2.Icon");
            // 
            // requiredFieldValidator3
            // 
            requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator3.ControlToValidate = txtReason;
            requiredFieldValidator3.ErrorMessage = "لطفا علت مراجعه را بنویسید";
            requiredFieldValidator3.Icon = (Icon)resources.GetObject("requiredFieldValidator3.Icon");
            // 
            // PatientReception
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 345);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PatientReception";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PatientReception";
            Load += PatientReception_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgName).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgName;
        private TextBox txtSearch;
        private Label label1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSave;
        private TextBox txtReason;
        private TextBox txtPay;
        private TextBox txtNamePatient;
        private MaskedTextBox txtTime;
        private MaskedTextBox txtDateTime;
        private DataGridViewTextBoxColumn PatientId;
        private DataGridViewTextBoxColumn FullName;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
    }
}