public class NotificationSenderEmail : INotificationSender
{
    public NotificationType Type => NotificationType.Email;

    public void SendNotification(Notification notification)
    {
        Console.WriteLine("Email notification sent");
    }
}
