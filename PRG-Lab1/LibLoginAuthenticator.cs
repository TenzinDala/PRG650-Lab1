using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PRG_Lab1
{
    public class LoginAuthenticator
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginAuthenticator(string userName, string password)
        {
            if (userName == "")
            {
                Username = null;
            }
            else
            {
                this.Username = userName;
            }
            if (password == "")
            {
                Password = null;
            }
            else
            { 
                this.Password = password;
            }
        }
        
        public bool? Authenticate()
        {
            if (Username == null || Password == null)
            {
                return null;
            }
            else
            {
                string userName1 = "Tenzin";
                string userName2 = "john";
                string userName3 = "Manu";

                string passWord1 = "12345678";
                string passWord2 = "doe";
                string passWord3 = "12345678";


                if (Username == userName1 && Password == passWord1 || Username == userName2 && Password == passWord2 || Username == userName3 && Password == passWord3)
                {
                    return true;
                }
                else
                {
                    return false;   
                }
            }
        }
    }
}
