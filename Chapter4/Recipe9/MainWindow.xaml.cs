using System.Windows;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System;

namespace Recipe9 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ButtonSync_Click(object sender, RoutedEventArgs e) {
            ContentTextBlock.Text = string.Empty;
            try {

            }
            catch(Exception ex) {

            }
        }

        private void ButtonAsync_Click(object sender, RoutedEventArgs e) {

        }

        private void ButtonAsyncOK_Click(object sender, RoutedEventArgs e) {

        }

        Task<string> TaskMethod() {
            return TaskMethod(TaskScheduler.Default);
        }

        Task<string> TaskMethod(TaskScheduler scheduler) {
            Task delay = Task.Delay(TimeSpan.FromSeconds(5));

            return delay.ContinueWith(t => {
                string str =
                "Task is running on a thread id " +
                $"{CurrentThread.ManagedThreadId}. Is thread pool thread : " +
                $"{CurrentThread.IsThreadPoolThread}";

                ContentTextBlock.Text = str;
                return str;
            }, scheduler);
        }
    }
}
