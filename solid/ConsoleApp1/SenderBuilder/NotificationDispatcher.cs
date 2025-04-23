public class NotificationSender
{
    private readonly Dictionary<NotificationType, INotificationSender> notificationSenders;

    public NotificationSender()
    {
        notificationSenders = new Dictionary<NotificationType, INotificationSender>();
    }

    public void AddNotificationSender(INotificationSender notificationSender)
    {
        notificationSenders.Add(notificationSender.Type, notificationSender);
    }

    public void SendNotification(Notification notification)
    {
        if (notificationSenders.TryGetValue(notification.Type, out INotificationSender? notificationSender))
        {
            try
            {
                notificationSender.SendNotification(notification);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            throw new InvalidOperationException($"Invalid notification type: {notification.Type}");
        }
    }
}