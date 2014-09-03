
#region Using

using System.Windows;

using Elsewhere.Vindinium.GUI.View;

#endregion Using

namespace Elsewhere.Vindinium.GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        #region Life-Cycle

        /// <summary>
        /// When the application is started, data and view models are created
        /// and assigned to views.
        /// </summary>
        /// <param name="arguments">None used.</param>
        protected override void OnStartup(StartupEventArgs arguments)
        {
            VindiniumView window = new VindiniumView();
            window.Show();
        }

        #endregion Life-Cycle

    }
}
