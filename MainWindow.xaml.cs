using DataDocs.Views;
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

namespace MediCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private TimeSpan timeLeft;

        public MainWindow()
        {
            InitializeComponent();
            StartCountdown();
        }

        private void StartCountdown()
        {
            timeLeft = TimeSpan.FromMinutes(5);
            timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Add(TimeSpan.FromSeconds(-1));
            CountdownLabel.Content = $"Time left: {timeLeft:mm\\:ss}";

            if (timeLeft <= TimeSpan.Zero)
            {
                timer.Stop();
                Logout();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Logout();

        }
        private void Logout()
        {
            // Öffnen des Login-Screens
            Login_Screen loginScreen = new Login_Screen();
            loginScreen.Show();
            this.Close(); // Schließt das Hauptfenster
        }
      
    }
}
