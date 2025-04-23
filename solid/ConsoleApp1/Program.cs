
// single responsibility
// open for extension, closed for modification
// liskov substitution
// interface segregation
// dependency inverse (depend on abstractions instead of implementations)

// here, S, O, and D principles are used

Notification notificationEmail = new Notification
{
    Sender = "example@example.com",
    Recipient = "example2@example.com",
    Subject = "subject",
    Body = "body",
    Type = NotificationType.Email
};

Notification notificationSMS = new Notification
{
    Sender = "+3735042303120",
    Recipient = "+7321312421",
    Subject = "subject",
    Body = "body",
    Type = NotificationType.SMS
};

Notification notificationPush = new Notification
{
    Sender = "senderUsername",
    Recipient = "recipientUsername",
    Subject = "subject",
    Body = "body",
    Type = NotificationType.Push
};

NotificationSender notificationSender = new NotificationSender();

notificationSender.AddNotificationSender(new NotificationSenderEmail());
notificationSender.AddNotificationSender(new NotificationSenderSMS());
notificationSender.AddNotificationSender(new NotificationSenderPush());

notificationSender.SendNotification(notificationEmail);
notificationSender.SendNotification(notificationSMS);
notificationSender.SendNotification(notificationPush);
