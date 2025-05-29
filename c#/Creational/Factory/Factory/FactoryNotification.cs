using System.Text.RegularExpressions;
using Interface.IBase;
using Notifications.Email;
using Notifications.Push;
using Notifications.Sms;

namespace Factory.FactoryNotification
{
    public static class CreateNotification
    {
        public static IBase Create(string type)
        {
            type = Regex.Replace(type.ToLower().Trim(), @"\s+", "");

            if (type == "email")
            {
                return new EmailDetails();
            }
            else if (type == "sms")
            {
                return new SmsDetails();
            }
            else if (type == "push")
            {
                return new PushDetails();
            }
            else
            {
                throw new Exception("Notification type not supported");
            }
        }
    }
}