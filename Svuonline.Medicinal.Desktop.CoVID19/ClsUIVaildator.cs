using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Svuonline.Medicinal.Desktop.CoVID19
{
    public class ClsUIVaildator
    {
        public int TxtBoxValidator(String TxtBoxField)
        {
            if (string.IsNullOrWhiteSpace(TxtBoxField))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public void InputcharCheck(KeyPressEventArgs e, String ToolName)
        {
            if (ToolName == "TxtBoxScreenUserName")
            {
                char lastChar = e.KeyChar;
                if (e.KeyChar != 32 && e.KeyChar != 8 && e.KeyChar != 46)
                {
                    if (char.IsControl(lastChar) || char.IsDigit(lastChar) || char.IsNumber(lastChar) || char.IsPunctuation(lastChar))
                        e.Handled = true;
                    else if (lastChar < 1569)
                        e.Handled = true;
                }
            }
            if (ToolName == "TxtBoxUserEmail")
            {
                char lastChar = e.KeyChar;
                if (e.KeyChar != 32 && e.KeyChar != 8 && e.KeyChar != 46)
                {
                    if (char.IsControl(lastChar) || char.IsDigit(lastChar) || char.IsNumber(lastChar) || char.IsPunctuation(lastChar))
                        e.Handled = false;
                    else if (lastChar > 1569)
                        e.Handled = true;
                }

            }
        }
        public bool EmailValidator(String UserEmail)
        {
            if (string.IsNullOrWhiteSpace(UserEmail))
            {
                return false;
            }
            try
            {
                if (UserEmail != null && new EmailAddressAttribute().IsValid(UserEmail)) 
                {
                    var regex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,4})+)$";
                    bool IsValidEmail = Regex.IsMatch(UserEmail, regex, RegexOptions.IgnoreCase);
                    return IsValidEmail;
                }
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
