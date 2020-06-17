using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace Svuonline.Medicinal.Desktop.CoVID19
{
    public partial class FrmMainApp : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public FrmMainApp()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            SideMenuPanel.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void FrmMainApp_Load(object sender, EventArgs e)
        {
            FrmMainShadowForm.SetShadowForm(this);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(121, 80, 199);
            public static Color color2 = Color.FromArgb(249, 88, 155);
            public static Color color3 = Color.FromArgb(0, 120, 215);

        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(12, 188, 178); 
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(214, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                lblTitleChildForm.ForeColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(12, 188, 178);
                currentBtn.ForeColor = Color.Snow;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(230, 0, 112);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(230, 0, 112);
            lblTitleChildForm.Text = "الصفحة الرئيسية";
            lblTitleChildForm.ForeColor = Color.Snow;
        }
        private void BtnPatientData_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            currentBtn.IconColor = Color.FromArgb(222, 212, 245);
            iconCurrentChildForm.IconColor = Color.FromArgb(222, 212, 245);
            OpenChildForm(new FrmPatientData());
        }
        private void BtnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            currentBtn.IconColor = Color.FromArgb(0, 120, 215);
            iconCurrentChildForm.IconColor = Color.FromArgb(0, 120, 215);
            OpenChildForm(new FrmReports());
        }
        private void BtnUserInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            currentBtn.IconColor = Color.FromArgb(251, 143, 188);
            iconCurrentChildForm.IconColor = Color.FromArgb(251, 143, 188);
            OpenChildForm(new FrmUserInfo());

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
