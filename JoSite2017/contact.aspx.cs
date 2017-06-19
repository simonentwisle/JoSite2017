using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace JoSite2017
{
    public partial class ContactForm : System.Web.UI.Page
    {
        private simonsUtils myUtils = new simonsUtils();
        private string ErrorMessage = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //do some validation
           
            if (doValidation() == true)
            {
                //send email
                sendEmail();
            }
            else
            {
               
            }
        }

        protected Boolean doValidation()
        {
            Boolean isEverythingCool = true;
            ErrorMessage = "";
            //Reset back colour of controls to be validated
            myUtils.resetControlsBackColours(Page.Controls[0]);
            //check we have values for the required fields
            if (Name.Text == "" || Name.Text  == "Please enter your name.")
            {
                myUtils.highlightControl(Name);
                Name.ForeColor = System.Drawing.Color.LightGray;
                Name.Text = "Please enter your name.";
                isEverythingCool = false;
                return isEverythingCool;
            }else
            {
                Name.BorderColor = System.Drawing.Color.FromName("#cccccc");
            }
            if (Email.Text == "" || Email.Text == "Please enter your email address.")
            {
                myUtils.highlightControl(Email);
                Email.ForeColor = System.Drawing.Color.LightGray;
                Email.Text = "Please enter your email address.";
                isEverythingCool = false;
                return isEverythingCool;
            }
            else
            {
                Email.BorderColor = System.Drawing.Color.FromName("#cccccc"); 
            }
            if (Message.Text == "")
            {
                myUtils.highlightControl(Message);
                isEverythingCool = false;
                return isEverythingCool;
            }
            else
            {
                Message.BorderColor = System.Drawing.Color.FromName("#cccccc");
            }
            if (!myUtils.isEmail(Email.Text))
            {
                myUtils.highlightControl(Email);
                isEverythingCool = false;
                return isEverythingCool;
            }
            return isEverythingCool;
        }

        protected void sendEmail()
        {
            //create the mail message
            MailMessage mail = new MailMessage();

            //set the addresses
            mail.From = new MailAddress(Email.Text);
            //mail.To.Add("supergirl2050@hotmail.com");
            mail.To.Add("bibiplone@hotmail.com");

            //set the content
            mail.Subject = "EMAIL FROM WEBSITE";
            mail.Body = Message.Text;

            //send the message
            SmtpClient smtp = new SmtpClient("auth.smtp.1and1.co.uk");
            ////SmtpClient smtp = new SmtpClient("localhost");
            smtp.Send(mail);

            Literal1.Visible = false;
            Email.Visible = false;
            Message.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Button1.Visible = false;
            Name.ForeColor = System.Drawing.Color.FromName("#ffffff");
            Name.Text = "Thank you! Your submission has been received!";

        }
    }
}