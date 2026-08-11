namespace EShop.Console.Notification;

public class EmailNotification : Notification
{
    public override void SendConfirmation()
    {
        System.Console.WriteLine("Email Notification sent");
    }
}