using EventManagementPOO.Controller;
using EventManagementPOO.Model.Singleton;
using EventManagementPOO.View;

namespace EventManagementPOO
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EventRegisterView eventView = new EventRegisterView();
            eventView.Visible = false;

            EventManager eventManager = EventManager.GetInstance();

            EventController eventController = new EventController(eventView, eventManager);
            eventView.ShowDialog();
        }
    }
}