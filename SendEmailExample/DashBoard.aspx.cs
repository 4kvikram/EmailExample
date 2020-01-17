using System;
using System.Net;
using System.Net.Mail;

namespace SendEmailExample
{
    public partial class DashBoard : System.Web.UI.Page
    {

        /*
        Example:-
       ===============================================================
         <appSettings>
             <add key="FromEmail" value="abcd@email.com" />
         </appSettings>
         ====================================================================
         use here as :-
         =====================================================================
          string FromEmail = ConfigurationManager.AppSettings["FromEmail"];
          =======================================================
      */
        //for testing enter Your Email Details here
        // you should Add these Details in config file (as appSetting) as above

        string PortNo = "Port";
        string FromEmail = "fromEmail";
        string FromPassword = "password";
        string Host = "Host";
     
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void SendEmail()
        {
            try
            {
                //get values from aspx
                string EmaiilTo = txtTo.Text;
                string CC = txtCC.Text;
                string BCC = txtBCC.Text;
                string EmailSubject = txtSubject.Text;
                string EmailBody = txtBody.Text;
                //=====
                MailMessage mailMessage = new MailMessage(FromEmail, EmaiilTo, EmailSubject, EmailBody);
                if (!string.IsNullOrEmpty(CC))
                {
                    mailMessage.CC.Add(CC);
                }
                if (!string.IsNullOrEmpty(BCC))
                {
                    mailMessage.Bcc.Add(BCC);
                }
                mailMessage.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = Host;
                NetworkCredential networkCredential = new NetworkCredential(FromEmail, FromPassword);
                smtp.Credentials = networkCredential;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Port = Convert.ToInt32(PortNo);
                //finally send
                smtp.Send(mailMessage);
                lblmessage.Text = "Message Send";
            }
            catch (Exception)
            {  
                     lblmessage.Text = "Message Not Send"; 
            }
        }
        protected void btnSend_Click(object sender, EventArgs e)
        {
            SendEmail();
        }
    }
}