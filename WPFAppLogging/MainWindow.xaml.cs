﻿namespace WPFAppLogging {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        public MainWindow() {
            InitializeComponent();
            DoLog();
        }

        private void DoLog() {
            Logger.Info("App Starting");
        }
    }
}