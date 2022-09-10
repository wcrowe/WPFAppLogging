namespace WPFAppLogging {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
            DoLog();
        }

        private void DoLog() {
            App.Logger.Info("App Starting");
        }
    }
}