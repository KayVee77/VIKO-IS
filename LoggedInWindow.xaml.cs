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

namespace projektas
{
    /// <summary>
    /// Interaction logic for LoggedInWindow.xaml
    /// </summary>
    public partial class LoggedInWindow : Window
    {
        User User;

        public LoggedInWindow(Student s)
        {
            InitializeComponent();
            User = s;
        }

        public LoggedInWindow(Admin s)
        {
            InitializeComponent();
            User = s;
        }

        public LoggedInWindow(Teacher s)
        {
            InitializeComponent();
            User = s;
        }

        private void LogOutbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void FSemesterbtn_Click(object sender, RoutedEventArgs e)
        {
            SemesterWindow semesterWindow = new SemesterWindow(User,1,1);
            semesterWindow.Show();
            this.Close();
        }

        private void SSemesterbtn_Click(object sender, RoutedEventArgs e)
        {
            SemesterWindow semesterWindow = new SemesterWindow(User,2,2);
            semesterWindow.Show();
            this.Close();
        }

        private void TSemesterbtn_Click(object sender, RoutedEventArgs e)
        {
            SemesterWindow semesterWindow = new SemesterWindow(User,3,2);
            semesterWindow.Show();
            this.Close();
        }
    }
}
