using Clinic.DataLayer;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using ValidationComponents;

namespace Clinic.App.Patient_Info
{
    public partial class AddPatient : Form
    {
        public int _patient = 0;
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            if (_patient == 0)
            {
                this.Text = "افزودن اطلاعات";
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var patient = db.patietInfoService.GetPatientById(_patient);
                    txtFullName.Text = patient.FullName;
                    txtMobile.Text = patient.Mobile;
                    txtAge.Value = patient.Age;
                    txtAddress.Text = patient.Address;
                    pic.ImageLocation = Application.StartupPath + "/Images/" + patient.ImageName;
                }

                this.Text = "ویرایش اطلاعات";
                btnSave.Text = "ویرایش";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pic.ImageLocation);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pic.Image.Save(path + imageName);

                using (UnitOfWork db = new UnitOfWork())
                {

                    Clinic.Data.Entities.PatientInfo patient = new Clinic.Data.Entities.PatientInfo()
                    {
                        FullName = txtFullName.Text,
                        Mobile = txtMobile.Text,
                        Age = int.Parse(txtAge.Text.ToString()),
                        Address = txtAddress.Text,
                        ImageName = imageName
                    };
                    if (_patient == 0)
                    {
                        db.patietInfoService.CreatePatientInfo(patient);
                        db.Save();
                    }
                    else
                    {
                        var pat = db.patietInfoService.GetPatientById(_patient);
                        var OldImage = pat.ImageName;
                        pat.FullName = txtFullName.Text;
                        pat.Mobile = txtMobile.Text;
                        pat.Age = int.Parse(txtAge.Text.ToString());
                        pat.Address = txtAddress.Text;
                        pat.ImageName = imageName;
                        patient.Id = _patient;
                        // db.patietInfoService.UpdatePatientInfo(patient);
                        db.Save();
                        File.Delete(Application.StartupPath + $"Images/{OldImage}");
                    }
                    db.Save();
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pic.ImageLocation = openFile.FileName;
            }
        }    
    }
}
