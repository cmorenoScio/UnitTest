using System;
using System.Text.RegularExpressions;

namespace unitTest
{
    public class Class1
    {
      public bool email(String mail)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)?$");
            Match match = regex.Match(mail);
            if (!match.Success){
                return false;
            }
            else
            {
                return true;
            }
;        }
    }
}
