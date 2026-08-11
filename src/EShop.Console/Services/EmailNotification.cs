using EShop.Console.Abstractions;

namespace EShop.Console.Services;

public class EmailNotification: Notification, INotification
{
    public bool SendConfirmationMessage()
    {
        System.Console.WriteLine("EmailNotification msg");
        return true;
    }
}