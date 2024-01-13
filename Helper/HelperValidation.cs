using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simrs.Helper
{
    internal class HelperValidation
    {
        public static bool CheckEmailAddressValid(string email)
        {
            bool valid = false;

            System.Text.RegularExpressions.Regex expr = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (expr.IsMatch(email))
            {
                valid = true;
            }   
           
            return valid;
        }
    }
}
