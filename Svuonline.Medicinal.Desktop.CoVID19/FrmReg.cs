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
using Guna.UI2.WinForms;
using System.Drawing.Drawing2D;

namespace Svuonline.Medicinal.Desktop.CoVID19
{
    public partial class FrmReg : Form
    {
        ClsUIVaildator UserInterfaceValidatorObj = new ClsUIVaildator();
        bool IsClearing = false;
        public override System.Drawing.Color BackColor { get; set; }
        public FrmReg()
        {
            InitializeComponent();
            TxtBoxScreenUserName.MaxLength = 15;
            LoginPanel.Visible = true;
            RegPanel.Visible = false;
        }
        private void Common_TxtBoxValidating(object sender, CancelEventArgs e)
        {
            if (sender is Guna2TextBox ValidatingTxtBox)
            {
                if (string.IsNullOrWhiteSpace(ValidatingTxtBox.Text))
                {
                    ValidatingTxtBox.Focus();
                    TxtBoxerrorProvider.SetError((Guna2TextBox)sender, ClsAppMsgs.RequiredFieldErrorMsg);
                    ValidatingTxtBox.BackColor = System.Drawing.Color.Red;
                    ValidatingTxtBox.BorderThickness = 2;
                    ValidatingTxtBox.BorderColor = Color.Red;
                    ValidatingTxtBox.PlaceholderForeColor = ColorTranslator.FromHtml("#ff0033");
                    ValidatingTxtBox.Font = new Font("Changa", 11, FontStyle.Bold);
                }
                else
                {
                    TxtBoxerrorProvider.Clear();
                    ValidatingTxtBox.BorderThickness = 1;
                    ValidatingTxtBox.BorderColor = ColorTranslator.FromHtml("#0CBCB2");
                    ValidatingTxtBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    ValidatingTxtBox.ForeColor = ColorTranslator.FromHtml("#0CBCB2");
                    ValidatingTxtBox.Font = new Font("Changa", 9, FontStyle.Regular);
                }
            }
            if (sender is Guna2ComboBox ValidatingCombBox)
            {
                if (ValidatingCombBox.SelectedItem == null || ValidatingCombBox.SelectedIndex == -1)
                {
                    ValidatingCombBox.Focus();
                    TxtBoxerrorProvider.SetError((Guna2ComboBox)sender, ClsAppMsgs.RequiredFieldErrorMsg);
                    ValidatingCombBox.BackColor = System.Drawing.Color.Red;
                    ValidatingCombBox.BorderThickness = 2;
                    ValidatingCombBox.BorderColor = Color.Red;
                    ValidatingCombBox.Font = new Font("Changa", 11, FontStyle.Bold);
                }
                else
                {
                    TxtBoxerrorProvider.Clear();
                    ValidatingCombBox.BorderThickness = 1;
                    ValidatingCombBox.BorderColor = ColorTranslator.FromHtml("#0CBCB2");
                    ValidatingCombBox.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    ValidatingCombBox.ForeColor = ColorTranslator.FromHtml("#0CBCB2");
                    ValidatingCombBox.Font = new Font("Changa", 9, FontStyle.Regular);
                }
            }

        }
        private void TxtBoxScreenUserName_Enter(object sender, EventArgs e)
        {
            InputLanguage OriginalDefaultLanguage = InputLanguage.DefaultInputLanguage;
            if (InputLanguage.InstalledInputLanguages.Count == 1)
                return;
           if(!InputLanguage.CurrentInputLanguage.Culture.Name.Contains("ar"))
            {
                // Get index of current Input Language
                int currentLang = InputLanguage.InstalledInputLanguages.IndexOf(InputLanguage.CurrentInputLanguage);
                // Calculate next Input Language
                InputLanguage nextLang = ++currentLang == InputLanguage.InstalledInputLanguages.Count ?
                   InputLanguage.InstalledInputLanguages[0] : InputLanguage.InstalledInputLanguages[currentLang];
                //TxtBoxUserEmail.Text = nextLang.LayoutName;
                //TxtBoxUserEmail.Text = InputLanguage.CurrentInputLanguage.LayoutName;
                // Change current Language to the calculated:
                InputLanguage InputLang = nextLang;
                // Check is this Language really installed. Raise exception to warn if it is not:
                if (InputLanguage.InstalledInputLanguages.IndexOf(InputLang) == -1)
                    InputLanguage.CurrentInputLanguage = OriginalDefaultLanguage;
                // InputLAnguage changes here:
                InputLanguage.CurrentInputLanguage = InputLang;
                //TxtBoxUserEmail.Text = InputLanguage.CurrentInputLanguage.Culture.Name;
            }
        }
        private void TxtBoxScreenUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserInterfaceValidatorObj.InputcharCheck(e, "TxtBoxScreenUserName");
        }
        private void TxtBoxUserEmail_Enter(object sender, EventArgs e)
        {
            InputLanguage OriginalDefaultLanguage = InputLanguage.DefaultInputLanguage;
            InputLanguage.CurrentInputLanguage = OriginalDefaultLanguage;
        }
        private void TxtBoxUserEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            UserInterfaceValidatorObj.InputcharCheck(e, "TxtBoxUserEmail");
        }
        private async void TxtBoxUserEmail_Validating(object sender, CancelEventArgs e)
        {
            Common_TxtBoxValidating(sender, e);
            if (!string.IsNullOrWhiteSpace(TxtBoxUserEmail.Text.Trim()))
            {
                if (!UserInterfaceValidatorObj.EmailValidator(TxtBoxUserEmail.Text.Trim()))
                {
                    lblMsgBox.Text = ClsAppMsgs.EmailEntryIncorrectMsg;
                    lblMsgBox.BackColor = ColorTranslator.FromHtml("#ffedf6");
                    lblMsgBox.ForeColor = ColorTranslator.FromHtml("#d20051");
                    lblMsgBox.Visible = true;
                    TxtBoxUserEmail.Focus();
                    await Task.Delay(3000);
                    lblMsgBox.Visible = false;
                }
            }
        }
        private void Common_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox TxtBox)
                TxtBox.BorderThickness = 2;
            if (sender is Guna2ComboBox CombBox)
                CombBox.BorderThickness = 2;
        }
        private void Common_MouseHover(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox TxtBox)
                TxtBox.BorderThickness = 2;
            if (sender is Guna2ComboBox CombBox)
                CombBox.BorderThickness = 2;
        }
        private void Common_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Guna2TextBox TxtBox)
                TxtBox.BorderThickness = 2;
            if (sender is Guna2ComboBox CombBox)
                CombBox.BorderThickness = 2;
        }
        private void Common_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox TxtBox)
                TxtBox.BorderThickness = 1;
            if (sender is Guna2ComboBox CombBox)
                CombBox.BorderThickness = 1;
        }
        private void Common_TxtBoxIconLeftClick(object sender, EventArgs e)
        {
            if (sender is Guna2TextBox ShowIconTxtBox)
            {

                if (ShowIconTxtBox.UseSystemPasswordChar == true)
                {
                    ShowIconTxtBox.UseSystemPasswordChar = false;
                }
                else
                {
                    ShowIconTxtBox.UseSystemPasswordChar = true;
                }
            }
        }
        private void Common_TxtBoxMouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Guna2TextBox ShowIconTxtBox)
            {
                if (ShowIconTxtBox.UseSystemPasswordChar == true)
                {
                    ShowIconTxtBox.UseSystemPasswordChar = false;
                }
            }
        }
        private void Common_TxtBoxMouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Guna2TextBox ShowIconTxtBox)
            {
                if (ShowIconTxtBox.UseSystemPasswordChar == false)
                {
                    ShowIconTxtBox.UseSystemPasswordChar = true;
                }
            }
        }
        internal void TxtBoxPasswordConfirmCheck()
        {
            if (TxtBoxPasswordConfirm.Text.Trim() != TxtBoxPassword.Text.Trim() && !String.IsNullOrWhiteSpace(TxtBoxPassword.Text.Trim()))
            {
                TxtBoxerrorProvider.SetError(TxtBoxPasswordConfirm, ClsAppMsgs.ConfirmPasswordErrorMsg);
                TxtBoxPasswordConfirm.BackColor = Color.Red;
                TxtBoxPasswordConfirm.BorderThickness = 2;
                TxtBoxPasswordConfirm.BorderColor = ColorTranslator.FromHtml("#6b1421");
                TxtBoxPasswordConfirm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                TxtBoxPasswordConfirm.Font = new Font("Changa", 11, FontStyle.Bold);
                TxtBoxPasswordConfirm.Focus();
            }
            else
            {
                TxtBoxerrorProvider.Clear();
                TxtBoxPasswordConfirm.BorderThickness = 1;
                TxtBoxPasswordConfirm.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                TxtBoxPasswordConfirm.BorderColor = ColorTranslator.FromHtml("#0CBCB2");
                TxtBoxPasswordConfirm.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                TxtBoxPasswordConfirm.ForeColor = ColorTranslator.FromHtml("#0CBCB2");
                TxtBoxPasswordConfirm.Font = new Font("Changa", 9, FontStyle.Regular);
            }
        }
        private void TxtBoxPasswordConfirm_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtBoxPasswordConfirm.Text.Trim()) && !String.IsNullOrWhiteSpace(TxtBoxPassword.Text.Trim()))
            {
                TxtBoxPasswordConfirmCheck();
            }
        }
        private void TxtBoxPasswordConfirm_TextChanged(object sender, EventArgs e)
        {
            if (!IsClearing)
            {
                TxtBoxPasswordConfirmCheck();
                IsClearing = false;
            }
        }
        private void TxtBoxPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(TxtBoxPassword.Text.Trim()))
            {
                if (string.IsNullOrWhiteSpace(TxtBoxPasswordConfirm.Text.Trim()))
                {
                    TxtBoxPasswordConfirm.Focus();
                    TxtBoxerrorProvider.SetError(TxtBoxPasswordConfirm, ClsAppMsgs.RequiredFieldErrorMsg);
                    TxtBoxPasswordConfirm.BackColor = System.Drawing.Color.Red;
                    TxtBoxPasswordConfirm.BorderThickness = 2;
                    TxtBoxPasswordConfirm.BorderColor = Color.Red;
                    TxtBoxPasswordConfirm.PlaceholderForeColor = ColorTranslator.FromHtml("#ff0033");
                    TxtBoxPasswordConfirm.Font = new Font("Changa", 11, FontStyle.Bold);
                }
                else
                {
                    TxtBoxerrorProvider.Clear();
                    TxtBoxPasswordConfirm.BorderThickness = 1;
                    TxtBoxPasswordConfirm.BorderColor = ColorTranslator.FromHtml("#0CBCB2");
                    TxtBoxPasswordConfirm.BackColor = ColorTranslator.FromHtml("#FFFFFF");
                    TxtBoxPasswordConfirm.ForeColor = ColorTranslator.FromHtml("#0CBCB2");
                    TxtBoxPasswordConfirm.Font = new Font("Changa", 9, FontStyle.Regular);
                }
            }
        }
        private async void BtnReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtBoxScreenUserName.Text.Trim()) || string.IsNullOrWhiteSpace(TxtBoxUserEmail.Text.Trim()) || CombBoxUserRole.SelectedItem == null || CombBoxUserRole.SelectedIndex == -1 || string.IsNullOrWhiteSpace(TxtBoxPassword.Text.Trim()) || string.IsNullOrWhiteSpace(TxtBoxPasswordConfirm.Text.Trim()))
            {
                lblMsgBox.Text = ClsAppMsgs.EmptyFielsAlertMsg;
                lblMsgBox.BackColor = ColorTranslator.FromHtml("#ffedf6");
                lblMsgBox.ForeColor = ColorTranslator.FromHtml("#d20051");
                lblMsgBox.Visible = true;
                await Task.Delay(3000);
                lblMsgBox.Visible = false;
                return;
            }
            if (TxtBoxPasswordConfirm.Text.Trim() != TxtBoxPassword.Text.Trim())
            {
                TxtBoxPasswordConfirmCheck();
                return;
            }
            String TxtBoxScreenUserNameValue = TxtBoxScreenUserName.Text.Trim();
            String TxtBoxUserEmailValue = TxtBoxUserEmail.Text.Trim();
            String TxtBoxPasswordValue = TxtBoxPassword.Text.Trim();
            int CombBoxUserRoleValueID = CombBoxUserRole.SelectedIndex + 1;
            UserAccount userAccountObj = new UserAccount
            {
                ScreenUserName = TxtBoxScreenUserNameValue,
                UserEmailAddress = TxtBoxUserEmailValue,
                Password = TxtBoxPasswordValue,
                UserRoleID = CombBoxUserRoleValueID,
            };
            try
            {
                ClsUserAccountsServices.Insert(userAccountObj);
                if (ClsUserAccountsServices.UserNameAlreadyExists)
                {
                    // UserNameAlreadyExistsMsg
                    lblMsgBox.Text = ClsAppMsgs.UserNameAlreadyExistsMsg;
                    lblMsgBox.BackColor = ColorTranslator.FromHtml("#fff5cc");
                    lblMsgBox.ForeColor = ColorTranslator.FromHtml("#856404");
                    lblMsgBox.Visible = true;
                    TxtBoxUserEmail.Focus();
                    await Task.Delay(3000);
                    lblMsgBox.Visible = false;
                    ClsUserAccountsServices.UserNameAlreadyExists = false;
                    return;
                }
                if (ClsUserAccountsServices.EmailAlreadyExists)
                {
                    // EmailAlreadyExistsMsg
                    lblMsgBox.Text = ClsAppMsgs.EmailAlreadyExistsMsg;
                    lblMsgBox.BackColor = ColorTranslator.FromHtml("#fff5cc");
                    lblMsgBox.ForeColor = ColorTranslator.FromHtml("#856404");
                    lblMsgBox.Visible = true;
                    TxtBoxUserEmail.Focus();
                    await Task.Delay(3000);
                    lblMsgBox.Visible = false;
                    ClsUserAccountsServices.EmailAlreadyExists = false;
                    return;
                }
                IsClearing = true;
                TxtBoxScreenUserName.Text = TxtBoxUserEmail.Text = CombBoxUserRole.Text = TxtBoxPassword.Text = TxtBoxPasswordConfirm.Text = "";
                CombBoxUserRole.SelectedItem = null;
                CombBoxUserRole.SelectedIndex = -1;
                CombBoxUserRole.Refresh();
                lblMsgBox.Text = ClsAppMsgs.RegisteredDataMsg;
                lblMsgBox.BackColor = ColorTranslator.FromHtml("#deffef");
                lblMsgBox.ForeColor = ColorTranslator.FromHtml("#009e52");
                lblMsgBox.Visible = true;
                await Task.Delay(5000);
                lblMsgBox.Visible = false;
                ImgBtnBack.Focus();
            }
            catch
            {
                lblMsgBox.Text = ClsAppMsgs.RegistrationErrorOccurredMsg;
                lblMsgBox.BackColor = ColorTranslator.FromHtml("#ffedf6");
                lblMsgBox.ForeColor = ColorTranslator.FromHtml("#d20051");
                lblMsgBox.Visible = true;
                TxtBoxUserEmail.Focus();
                await Task.Delay(3000);
                lblMsgBox.Visible = false;
            }
        }
        private void GoRegBtn_Click(object sender, EventArgs e)
        {
            PanelTransition.Hide(LoginPanel);
            PanelTransition.Show(RegPanel);
        }
        private void ImgBtnBack_Click(object sender, EventArgs e)
        {
            PanelTransition.Hide(RegPanel);
            PanelTransition.Show(LoginPanel);
        }
        private void FrmReg_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrWhiteSpace(TxtLoginUserName.Text.Trim()) || string.IsNullOrWhiteSpace(TxtLoginPassword.Text.Trim()) )
            {
                lblMsgBox.Text = ClsAppMsgs.EmptyFielsAlertMsg;
                lblMsgBox.BackColor = ColorTranslator.FromHtml("#ffedf6");
                lblMsgBox.ForeColor = ColorTranslator.FromHtml("#d20051");
                BtnLogin.Focus();
                lblMsgBox.Visible = true;
                await Task.Delay(3000);
                lblMsgBox.Visible = false;
                return;
            }
            else
            {
                String TxtBoxUserEmailValue = TxtLoginUserName.Text.Trim();
                String TxtBoxPasswordValue = TxtLoginPassword.Text.Trim();
                UserAccount userAccountObj = new UserAccount
                {
                    UserEmailAddress = TxtBoxUserEmailValue,
                    Password = TxtBoxPasswordValue,
                };
                try
                {
                    // ClsUserAccountsServices.Insert(userAccountObj);
                    ClsUserAccountsServices.UserAccountExist(userAccountObj);
                }
                catch
                {
                    lblMsgBox.Text = ClsAppMsgs.LoginErrorOccurredMsg;
                    lblMsgBox.BackColor = ColorTranslator.FromHtml("#ffedf6");
                    lblMsgBox.ForeColor = ColorTranslator.FromHtml("#d20051");
                    lblMsgBox.Visible = true;
                    BtnLogin.Focus();
                    await Task.Delay(3000);
                    lblMsgBox.Visible = false;
                }
            }
            if (!ClsUserAccountsServices.EmailAlreadyExists)
            {
                // UserEmailNotExistsMsg
                lblMsgBox.Text = ClsAppMsgs.UserEmailNotExistsMsg;
                lblMsgBox.BackColor = ColorTranslator.FromHtml("#fff5cc");
                lblMsgBox.ForeColor = ColorTranslator.FromHtml("#856404");
                lblMsgBox.Visible = true;
                BtnLogin.Focus();
                await Task.Delay(3000);
                lblMsgBox.Visible = false;
                ClsUserAccountsServices.EmailAlreadyExists = false;
                return;
            }
            else
            {
                if (ClsUserAccountsServices.UserCanLogin == true)
                {
                    ClsUserAccountsServices.UserCanLogin = false;
                    lblMsgBox.Text = "دخــــــول";
                    lblMsgBox.BackColor = ColorTranslator.FromHtml("#deffef");
                    lblMsgBox.ForeColor = ColorTranslator.FromHtml("#009e52");
                    lblMsgBox.Visible = true;
                    BtnLogin.Focus();
                    await Task.Delay(3000);
                    lblMsgBox.Visible = false;
                    //return;
                    Form frmMain = new FrmMainApp();
                    frmMain.Show();
                    this.Visible = false;
                    this.Hide();
                    //this.Close();
                    //this.Dispose();
                }
                else
                {
                    lblMsgBox.Text = ClsAppMsgs.UserCanNotLoginMsg;
                    lblMsgBox.BackColor = ColorTranslator.FromHtml("#fff5cc");
                    lblMsgBox.ForeColor = ColorTranslator.FromHtml("#856404");
                    lblMsgBox.Visible = true;
                    BtnLogin.Focus();
                    await Task.Delay(3000);
                    lblMsgBox.Visible = false;
                    ClsUserAccountsServices.EmailAlreadyExists = false;
                    ClsUserAccountsServices.UserCanLogin = false;
                    return;
                }
            }
        }
        private async void TxtLoginUserName_Validating(object sender, CancelEventArgs e)
        {
            Common_TxtBoxValidating(sender, e);
            if (!string.IsNullOrWhiteSpace(TxtLoginUserName.Text.Trim()))
            {
                if (!UserInterfaceValidatorObj.EmailValidator(TxtLoginUserName.Text.Trim()))
                {
                    lblMsgBox.Text = ClsAppMsgs.EmailEntryIncorrectMsg;
                    lblMsgBox.BackColor = ColorTranslator.FromHtml("#ffedf6");
                    lblMsgBox.ForeColor = ColorTranslator.FromHtml("#d20051");
                    lblMsgBox.Visible = true;
                    TxtLoginUserName.Focus();
                    await Task.Delay(3000);
                    lblMsgBox.Visible = false;
                }
            }
        }
    }
}