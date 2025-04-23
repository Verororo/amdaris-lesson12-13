public class Notification
{
    public required string Sender { get; set; }
    public required string Recipient { get; set; }
    public required string Subject { get; set; }
    public required string Body { get; set; }
    public NotificationType Type { get; set; }
}
