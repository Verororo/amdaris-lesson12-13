public interface INotificationSender
{
    public NotificationType Type { get; }

    public void SendNotification(Notification notification);
}
