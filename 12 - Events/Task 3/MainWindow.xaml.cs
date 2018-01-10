using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Task_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;
        private DateTime time;
        
        public MainWindow()
        {
            InitializeComponent();
            timer= new DispatcherTimer();
            timer.Tick += timer_Tick;
            timer.Interval = new TimeSpan(0,0,1);
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (UserProgressBar.Value == 60)
            {
                UserProgressBar.Value = 0;
            }
            if (UserProgressBar.Value<=60)
            {
                UserProgressBar.Value++;
                time += timer.Interval;
                TimerTextBox.Text = time.ToLongTimeString();
            }
        }

        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void ButtonStop_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }
    }
}
