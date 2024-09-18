using MVC.Task.Data;
using MVC.Task.Models;

namespace MVC.Task.Services
{
    public class NotificationService
    {
        private readonly ApplicationDbContext _context;

        public NotificationService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddNotification(string message, NotificationType type)
        {
            var notification = new Notification
            {
                Message = message,
                CreatedAt = DateTime.Now,
                Type = type,
                IsRead = false
            };

            _context.Notifications.Add(notification);
            _context.SaveChanges();
        }

        public List<Notification> GetRecentNotifications(int count = 4)
        {
            return _context.Notifications
                .OrderByDescending(n => n.CreatedAt)
                .Take(count)
                .ToList();
        }

        public int GetUnreadCount()
        {
            return _context.Notifications.Count(n => !n.IsRead);
        }
    }
}
