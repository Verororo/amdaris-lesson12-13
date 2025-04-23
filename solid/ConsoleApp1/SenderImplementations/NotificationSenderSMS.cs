public class NotificationSenderSMS : INotificationSender
{
    public NotificationType Type => NotificationType.SMS;
    public void SendNotification(Notification notification)
    {
        Console.WriteLine("SMS notification sent");
    }
}
