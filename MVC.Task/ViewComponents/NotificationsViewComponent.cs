using Microsoft.AspNetCore.Mvc;
using MVC.Task.Models;
using MVC.Task.Services;

namespace MVC.Task.ViewComponents
{
    public class NotificationsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Tuple<List<Notification>, int> notificationsData)
        {
            notificationsData.Item1.Any();
            return View(notificationsData);
        }
    }
}
