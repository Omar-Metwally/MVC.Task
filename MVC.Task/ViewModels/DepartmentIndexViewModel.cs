using MVC.Task.Models;

namespace MVC.Task.ViewModels
{
    public interface INotificationsViewModel
    {
        public Tuple<List<Notification>, int> Notifications { get; set; }
    }

    public class DepartmentIndexViewModel : INotificationsViewModel
    {
        public List<Department> Departments { get; set; }
        public Tuple<List<Notification>, int> Notifications { get; set; }
    }
}
