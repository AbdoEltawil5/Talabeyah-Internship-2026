namespace EShop.Console.Notification;

public class SmsNotification : Notification
{
    public override void SendConfirmation()
    {
        System.Console.WriteLine("Sms Notification sent");
    }
}