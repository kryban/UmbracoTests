using Umbraco.Web.Mvc;
using System.Web.Mvc;
using UmbracoCmsTest.Models;
using System.Net.Mail;

namespace UmbracoCmsTest.Controllers
{
    public class BanContactSurfaceController : SurfaceController
    {
        
        public const string PARTIAL_VIEW_FOLDER = "~/Views/PArtials/BanContact/";
        public ActionResult RenderForm()
        {
            //this will house the form
            return PartialView(PARTIAL_VIEW_FOLDER + "_BanContact.cshtml");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(BanContactModel model)
        {
            if(ModelState.IsValid)
            {
                SendEmail(model);
                // this will do the post back
                return RedirectToCurrentUmbracoPage();
            }

            return CurrentUmbracoPage();
        }

        // bette to do this in a helper class
        private void SendEmail(Models.BanContactModel model)
        {
            var message = new MailMessage(model.Email, "kry.ban@gmail.com");
            message.Subject = string.Format("From the site, sent from {0} {1}", model.FirstName, model.LastName);
            message.Body = model.Message;

            SmtpClient client = new SmtpClient("127.0.0.1", 25);

            // a tool called "Papercut" can show you these mails, even when you have no smtp server
            client.Send(message);

        }
    }
}