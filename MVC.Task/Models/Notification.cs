namespace MVC.Task.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public NotificationType Type { get; set; }
        public bool IsRead { get; set; }
    }

    public enum NotificationType
    {
        Info,
        Success,
        Warning,
        Danger
    }
}
