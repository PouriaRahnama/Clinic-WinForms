namespace Clinic.App.Patient_Visit
{
    partial class PatientVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientVisit));
            groupBox1 = new GroupBox();
            txtReason = new TextBox();
            txtPay = new TextBox();
            txtTime = new TextBox();
            txtDateTime = new TextBox();
            txtNamePatient = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtDescriptionDoctor = new TextBox();
            txtMedicine = new TextBox();
            txtDoctor = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSave = new Button();
            requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(components);
            requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(components);
            requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtReason);
            groupBox1.Controls.Add(txtPay);
            groupBox1.Controls.Add(txtTime);
            groupBox1.Controls.Add(txtDateTime);
            groupBox1.Controls.Add(txtNamePatient);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(504, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "مشخصات بیمار";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(240, 119);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ReadOnly = true;
            txtReason.Size = new Size(125, 81);
            txtReason.TabIndex = 13;
            // 
            // txtPay
            // 
            txtPay.Location = new Point(8, 80);
            txtPay.Name = "txtPay";
            txtPay.ReadOnly = true;
            txtPay.Size = new Size(125, 27);
            txtPay.TabIndex = 12;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(8, 38);
            txtTime.Name = "txtTime";
            txtTime.ReadOnly = true;
            txtTime.Size = new Size(125, 27);
            txtTime.TabIndex = 11;
            // 
            // txtDateTime
            // 
            txtDateTime.Location = new Point(240, 80);
            txtDateTime.Name = "txtDateTime";
            txtDateTime.ReadOnly = true;
            txtDateTime.Size = new Size(125, 27);
            txtDateTime.TabIndex = 10;
            // 
            // txtNamePatient
            // 
            txtNamePatient.Location = new Point(240, 38);
            txtNamePatient.Name = "txtNamePatient";
            txtNamePatient.ReadOnly = true;
            txtNamePatient.Size = new Size(125, 27);
            txtNamePatient.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 38);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "نام بیمار :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 80);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 3;
            label4.Text = "تاریخ ویزیت :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 122);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "علت مراجعه :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 45);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "زمان ویزیت :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 80);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "هزینه ویزیت :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDescriptionDoctor);
            groupBox2.Controls.Add(txtMedicine);
            groupBox2.Controls.Add(txtDoctor);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(12, 224);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 193);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "نسخه پزشک";
            // 
            // txtDescriptionDoctor
            // 
            txtDescriptionDoctor.Location = new Point(8, 26);
            txtDescriptionDoctor.Multiline = true;
            txtDescriptionDoctor.Name = "txtDescriptionDoctor";
            txtDescriptionDoctor.Size = new Size(125, 101);
            txtDescriptionDoctor.TabIndex = 15;
            // 
            // txtMedicine
            // 
            txtMedicine.Location = new Point(240, 64);
            txtMedicine.Multiline = true;
            txtMedicine.Name = "txtMedicine";
            txtMedicine.Size = new Size(125, 81);
            txtMedicine.TabIndex = 14;
            // 
            // txtDoctor
            // 
            txtDoctor.Location = new Point(240, 26);
            txtDoctor.Name = "txtDoctor";
            txtDoctor.Size = new Size(125, 27);
            txtDoctor.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(371, 29);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 12;
            label6.Text = "نام پزشک :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(371, 64);
            label7.Name = "label7";
            label7.Size = new Size(122, 20);
            label7.TabIndex = 11;
            label7.Text = "نسخه تجویز شده :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(139, 29);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 10;
            label8.Text = "توضیحات :";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(398, 427);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "انجام";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // requiredFieldValidator1
            // 
            requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator1.ControlToValidate = txtDoctor;
            requiredFieldValidator1.ErrorMessage = "لطفا نام دکتر را وارد کنید";
            requiredFieldValidator1.Icon = (Icon)resources.GetObject("requiredFieldValidator1.Icon");
            // 
            // requiredFieldValidator2
            // 
            requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator2.ControlToValidate = txtMedicine;
            requiredFieldValidator2.ErrorMessage = "لطفا نسخه را وارد کنید";
            requiredFieldValidator2.Icon = (Icon)resources.GetObject("requiredFieldValidator2.Icon");
            // 
            // requiredFieldValidator3
            // 
            requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator3.ControlToValidate = txtDescriptionDoctor;
            requiredFieldValidator3.ErrorMessage = "لطفا توضیحات را وارد کنید";
            requiredFieldValidator3.Icon = (Icon)resources.GetObject("requiredFieldValidator3.Icon");
            // 
            // PatientVisit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 468);
            Controls.Add(btnSave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PatientVisit";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterParent;
            Text = "PatientVisit";
            Load += PatientVisit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNamePatient;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtDescriptionDoctor;
        private TextBox txtMedicine;
        private TextBox txtDoctor;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSave;
        private TextBox txtReason;
        private TextBox txtPay;
        private TextBox txtTime;
        private TextBox txtDateTime;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
    }
}