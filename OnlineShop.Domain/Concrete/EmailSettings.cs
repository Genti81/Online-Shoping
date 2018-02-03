using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Concrete
{
    public class EmailSettings
    {
        //public string MailToAddress = "yllisahiti@gmail.com";
        public string MailToAddress = "sahiti.adelina@gmail.com";
        //public string MailToAddress = "black_cate@hotmail.com";
        //public string MailFromAddress = "sahiti.gentrit@gmail.com";
        public string MailFromAddress = "black_cate@hotmail.com";
        public bool UseSsl = true;
        public string Username = "sahiti.gentrit@gmail.com";
        public string Password = "disglgczztpxljna"; // Create your own google app password, In the video I have shown you how to create app password.
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
    }
}