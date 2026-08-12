using EShop.Console.Abstractions;

namespace EShop.Console.Services;

public class EmailNotification: Notification
{
    public override bool SendConfirmationMessage()
    {
        System.Console.WriteLine("EmailNotification msg");
        return true;
    }
}