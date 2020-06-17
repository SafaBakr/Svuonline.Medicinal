using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svuonline.Medicinal.BussinesslogicLayer;
using Svuonline.Medicinal.BussinessObjectLayer;
using Svuonline.Medicinal.GenericCode;

namespace Svuonline.Medicinal.Desktop.CoVID19
{
    public partial class FrmPatientData : Form
    {
        public FrmPatientData()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            String ImageLocation = "";
            try
            {
                OpenFileDialog OpenFileDialogObj = new OpenFileDialog();
                OpenFileDialogObj.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png)|*.jpg;*.jpeg;.*.gif;*.png";
                if (OpenFileDialogObj.ShowDialog() == DialogResult.OK)
                {
                    ImageLocation = OpenFileDialogObj.FileName;
                    PatientPictureBox.Image = new Bitmap(OpenFileDialogObj.FileName);
                }
            }
            catch
            {
                MessageBox.Show("حدث خطاء أثناء تحميل الصورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(TxtFirstName.Text.Trim()) || String.IsNullOrWhiteSpace(TxtMidName.Text.Trim()) || String.IsNullOrWhiteSpace(TxtLastName.Text.Trim()) || String.IsNullOrWhiteSpace(TxtFirstName.Text.Trim()) || String.IsNullOrWhiteSpace(TxtPatientAddress.Text.Trim()))
            {
                lblPstientFrmMsgBox.Text = ClsAppMsgs.EmptyFielsAlertMsg;
                lblPstientFrmMsgBox.BackColor = ColorTranslator.FromHtml("#ffedf6");
                lblPstientFrmMsgBox.ForeColor = ColorTranslator.FromHtml("#d20051");
                lblPstientFrmMsgBox.Visible = true;
                await Task.Delay(3000);
                lblPstientFrmMsgBox.Visible = false;
                BtnSaveData.Focus();
                return;
            }
            else
            {//////////////////////////////////////////////////////////////////////////////////////////

            }
        }
        private void BtnClearFields_Click(object sender, EventArgs e)
        {
            TxtFirstName.Text = null;
            TxtMidName.Text = null;
            TxtLastName.Text = null;
            TxtFirstName.Text = null;
            TxtPatientAddress.Text = null;
            ChkBoxBodyPain.Checked = false;
            ChkBoxCold.Checked = false;
            ChkBoxCough.Checked = false;
            ChkBoxFatigue.Checked = false;
            ChkBoxHeadache.Checked = false;
            ChkBoxHeat.Checked = false;
            ChkBoxSorethroat.Checked = false;
            PatientPictureBox.Image = null;
            BtnClearFields.Focus();
        }
    }
}
