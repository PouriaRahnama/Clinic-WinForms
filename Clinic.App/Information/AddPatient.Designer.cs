namespace Clinic.App.Patient_Info
{
    partial class AddPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatient));
            groupBox1 = new GroupBox();
            txtAge = new NumericUpDown();
            btnSave = new Button();
            groupBox2 = new GroupBox();
            btnPic = new Button();
            pic = new PictureBox();
            txtAddress = new TextBox();
            label4 = new Label();
            txtMobile = new TextBox();
            txtFullName = new TextBox();
            label3 = new Label();
            lbl_Mobile = new Label();
            lbl_Name = new Label();
            requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(components);
            requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(components);
            requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMobile);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl_Mobile);
            groupBox1.Controls.Add(lbl_Name);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(699, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "اطلاعات بیمار";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(257, 130);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(301, 27);
            txtAge.TabIndex = 10;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(588, 257);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 45);
            btnSave.TabIndex = 9;
            btnSave.Text = "ثبت";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPic);
            groupBox2.Controls.Add(pic);
            groupBox2.Location = new Point(20, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(231, 276);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "تصویر";
            // 
            // btnPic
            // 
            btnPic.BackColor = SystemColors.AppWorkspace;
            btnPic.Location = new Point(6, 234);
            btnPic.Name = "btnPic";
            btnPic.Size = new Size(219, 36);
            btnPic.TabIndex = 1;
            btnPic.Text = "انتخاب تصویر";
            btnPic.UseVisualStyleBackColor = false;
            btnPic.Click += btnPic_Click;
            // 
            // pic
            // 
            pic.Image = (Image)resources.GetObject("pic.Image");
            pic.Location = new Point(6, 26);
            pic.Name = "pic";
            pic.Size = new Size(219, 202);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.TabIndex = 0;
            pic.TabStop = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(257, 169);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(301, 76);
            txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(564, 172);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 6;
            label4.Text = "آدرس :";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(257, 84);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(301, 27);
            txtMobile.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(257, 41);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(301, 27);
            txtFullName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(564, 130);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "سن :";
            // 
            // lbl_Mobile
            // 
            lbl_Mobile.AutoSize = true;
            lbl_Mobile.Location = new Point(564, 87);
            lbl_Mobile.Name = "lbl_Mobile";
            lbl_Mobile.Size = new Size(87, 20);
            lbl_Mobile.TabIndex = 1;
            lbl_Mobile.Text = "شماره تلفن :";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(564, 41);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(131, 20);
            lbl_Name.TabIndex = 0;
            lbl_Name.Text = "نام و نام خانوادگی :";
            // 
            // requiredFieldValidator1
            // 
            requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator1.ControlToValidate = txtFullName;
            requiredFieldValidator1.ErrorMessage = "لطفا نام و نام خانوادگی را وارد کنید";
            requiredFieldValidator1.Icon = (Icon)resources.GetObject("requiredFieldValidator1.Icon");
            // 
            // requiredFieldValidator2
            // 
            requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator2.ControlToValidate = txtMobile;
            requiredFieldValidator2.ErrorMessage = "لطفا شماره تلفن را وارد کنید";
            requiredFieldValidator2.Icon = (Icon)resources.GetObject("requiredFieldValidator2.Icon");
            // 
            // requiredFieldValidator3
            // 
            requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            requiredFieldValidator3.ControlToValidate = txtAddress;
            requiredFieldValidator3.ErrorMessage = "لطفا آدرس را وارد کنید";
            requiredFieldValidator3.Icon = (Icon)resources.GetObject("requiredFieldValidator3.Icon");
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 332);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddPatient";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddPatient";
            Load += AddPatient_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMobile;
        private TextBox txtFullName;
        private Label label3;
        private Label lbl_Mobile;
        private Label lbl_Name;
        private GroupBox groupBox2;
        private PictureBox pic;
        private TextBox txtAddress;
        private Label label4;
        private Button btnSave;
        private Button btnPic;
        private NumericUpDown txtAge;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
    }
}