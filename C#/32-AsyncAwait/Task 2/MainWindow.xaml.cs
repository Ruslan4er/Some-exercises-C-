using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Forms.Timer timer;

        public MainWindow()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer {Interval = 4000};
            timer.Tick += timer_Tick;
        }

        private async void timer_Tick(object sender, EventArgs e)
        {
            textBox.Text += await GetDataAsync();
            textBox.ScrollToEnd();
        }

        private Task<string> GetDataAsync()
        {
            return Task.Run(() => "data received" + Environment.NewLine);
        }
        
        private async void ConnectDBButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
            ConnectDBButton.IsEnabled = false;
            textBox.Text += await ConnectDBAsync();
            DisconnectDBButton.IsEnabled = true;
        }

        private async Task<string> ConnectDBAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(2000);
                return "Connected" + Environment.NewLine;
            });
        }

        private async void DisconnectDBButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            DisconnectDBButton.IsEnabled = false;
            textBox.Text += await DisconnectDBAsync();
            ConnectDBButton.IsEnabled = true;
        }

        private async Task<string> DisconnectDBAsync()
        {
           return await Task.Run(() =>
            {
                Thread.Sleep(3000);
                return "Disconnected" + Environment.NewLine;
            });
        }
    }
}
