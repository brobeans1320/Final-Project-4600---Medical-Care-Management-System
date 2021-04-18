using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Final_Project_4600___Medical_Care_Management_System
{
    class EncryptPassword
    {
        string unencrypted;
        public EncryptPassword(String Password)      //Contructor that grabs password -EB
            {
            this.unencrypted = Password;            //Initalizes unencrypted password -EB
            }

        public string encrypt()                     //Method returns encrypted password -EB
        {
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())    
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(unencrypted));
                return Convert.ToBase64String(data);
            }
        }
        
    }
}
