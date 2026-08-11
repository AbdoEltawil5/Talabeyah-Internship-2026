using EShop.Console.Abstractions;

namespace EShop.Console.Services;

public class SmsNotification : Notification, INotification
{
    public bool SendConfirmationMessage()
    {
        System.Console.WriteLine("SmsNotification msg");
        return true;
    }
}