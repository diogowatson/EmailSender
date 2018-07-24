using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using s=System.Net.Mail ;
using System.Web;
using System.IO;

namespace emailApp
{
    class Program
    {
        //The code is working, but in order to work in a google account you should select 
        //    "authorise the use of insecure apps :https://support.google.com/accounts/answer/6010255"
        static void Main(string[] args)
        {

            //  Sendmail m = new Sendmail("test", "diogowatson@gmail.com","test");
            //   m.SendWithHTMLBody();
            //SendEmail("diogowatson@gmail.com", "test", "test");
           
            s.MailMessage mail = new s.MailMessage("adastra.credit.project@gmail.com", "diogowatson@gmail.com");
            //mail.SubjectEncoding = Encoding.UTF8;
            s.SmtpClient client = new s.SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.DeliveryMethod = s.SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = true;
            client.EnableSsl = true;//important
            client.Credentials = new NetworkCredential("adastra.credit.project@gmail.com", "Adastra10");
            mail.IsBodyHtml = true;
            mail.Subject = "test";
            mail.Body = "test";
            Console.WriteLine("test");

            try
            {
                Console.WriteLine("test2");
               client.Send(mail);
                Console.WriteLine("email sent");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }


        //public class Sendmail
        //{
        //    global variable
        //    private string LocationOfFileBody { get; set; }
        //    private string MailAddress { get; set; }
        //    private string Subject { get; set; }
        //    private string Message { get; set; }
        //    public StreamReader reader = File.OpenText("C:/Users/diogo.watson/source/repos/emailApp/emailApp/emailBody.html");

        //    public static string bodyLocation = "C:/Users/diogo.watson/source/repos/emailApp/emailApp/emailBody.html";

        //    contructor that uses an HTML file as body message
        //    public Sendmail(string mailAddress,
        //                    string subject
        //                    )
        //    {
        //        try
        //        {
        //            StreamReader LocationOfHTMLFile = File.OpenText(bodyLocation);
        //            MailAddress = mailAddress;
        //            Subject = subject;
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);

        //        }

        //    }


        //    public Sendmail(string message,
        //                    string mailAddress,
        //                    string subject)
        //    {
        //        try
        //        {
        //            Message = Message;
        //            MailAddress = mailAddress;
        //            Subject = subject;
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);

        //        }

        //    }
        //    this function take 3 parameters
        //    param 1 -> an Streamreader Object that points to HTML of the email body
        //    ex:StreamReader reader = File.OpenText("C:/Users/diogo.watson/source/repos/emailApp/emailApp/emailBody.html");
        //    param 2 teh email address to send the email
        //    param 3 the subject of the email

        //    public void SendWithHTMLBody()
        //    {
        //        try
        //        {
        //            StreamReader reader = File.OpenText("C:/Users/diogo.watson/source/repos/emailApp/emailApp/emailBody.html");
        //            SendEmail(reader.ToString(), Message, Subject);

        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //        }

        //    }


        //    this function take 3 parameters
        //    param 1 -> an message string
        //    param 2 teh email address to send the email
        //    param 3 the subject of the email
        //    public void SendMessage()
        //    {
        //        SendEmail(MailAddress, Message, Subject);

        //    }
        //}
        //public static void SendEmail(string mailAddress, string message, string subject)
        //{
        //    // string message = reader.ReadToEnd();
        //    MailMessage mail = new MailMessage("adastra.credit.project@gmail.com", mailAddress);
        //    //mail.SubjectEncoding = Encoding.UTF8;
        //    SmtpClient client = new SmtpClient("smtp.gmail.com");
        //    client.Port = 26;
        //    client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    client.UseDefaultCredentials = true;
        //    client.EnableSsl = true;//important
        //    client.Credentials = new NetworkCredential("adastra.credit.project@gmail.com", "Adastra10");
        //    mail.IsBodyHtml = true;
        //    mail.Subject = subject;
        //    mail.Body = message;
        //    Console.WriteLine("test");

        //    try
        //    {
        //        client.Send(mail);
        //        Console.WriteLine("email sent");
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //}

    }

}
