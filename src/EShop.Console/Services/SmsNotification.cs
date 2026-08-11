using EShop.Console.Abstractions;

namespace EShop.Console.Services;

public class SmsNotification : Notification
{
    public override bool SendConfirmationMessage()
    {
        System.Console.WriteLine("SmsNotification msg");
        return true;
    }
}