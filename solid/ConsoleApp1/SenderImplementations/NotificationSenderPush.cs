public class NotificationSenderPush : INotificationSender
{
    public NotificationType Type => NotificationType.Push;
    public void SendNotification(Notification notification)
    {
        Console.WriteLine("Push notification sent");
    }
}
