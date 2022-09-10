using System;
using System.Threading.Tasks;
using System.Windows;

namespace WPFAppLogging {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    //public partial class App { }
    public partial class App {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);

            SetupExceptionHandling();
        }

        private void SetupExceptionHandling() {
            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
                LogUnhandledException((Exception)e.ExceptionObject, "AppDomain.CurrentDomain.UnhandledException");

            DispatcherUnhandledException += (s, e) => {
                LogUnhandledException(e.Exception, "Application.Current.DispatcherUnhandledException");
                e.Handled = true;
            };
            TaskScheduler.UnobservedTaskException += (s, e) => {
                LogUnhandledException(e.Exception, "TaskScheduler.UnobservedTaskException");
                e.SetObserved();
            };
        }

        private static void LogUnhandledException(Exception exception, string source) {
            var message = $"Unhandled exception ({source})";
            try {
                System.Reflection.AssemblyName assemblyName =
                    System.Reflection.Assembly.GetExecutingAssembly().GetName();
                message = $"Unhandled exception in {assemblyName.Name} v{assemblyName.Version}";
            }
            catch (Exception ex) {
                Logger.Error(ex, "Exception in LogUnhandledException");
            }
            finally {
                Logger.Error(exception, message);
            }
        }
    }
}