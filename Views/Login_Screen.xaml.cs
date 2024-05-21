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
using System.Windows.Shapes;

using System.Windows;
using MediCore;

namespace DataDocs.Views
{
    public partial class Login_Screen : Window
    {
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Vordefinierte Anmeldeinformationen
            var users = new (string Username, string Password)[]
            {
                ("user1", "password1"),
                ("user2", "password2"),
                ("user3", "password3")
            };

            // Benutzereingaben
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Password;

            // Überprüfung der Anmeldedaten
            bool isValidUser = false;
            foreach (var user in users)
            {
                if (user.Username == enteredUsername && user.Password == enteredPassword)
                {
                    isValidUser = true;
                    break;
                }
            }

            // Ergebnis anzeigen
            if (isValidUser)
            {
                // Öffnen des MainWindow
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close(); // Schließt das Login-Fenster
            }
            else
            {
                // Falsche Anmeldedaten
                MessageBox.Show("Username or password incorrect!", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
