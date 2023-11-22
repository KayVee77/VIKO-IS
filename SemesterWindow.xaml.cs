using projektas.Repositories;
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
    /// Interaction logic for SemesterWindow.xaml
    /// </summary>
    public partial class SemesterWindow : Window
    {
        User User;
        PazymiaiRepository pazrep;
        public SemesterWindow(User s,int semestras,int kursas)
        {
            InitializeComponent();
            User = s;
            pazrep = new PazymiaiRepository();
            dtgPazymiai.ItemsSource = pazrep.GetAllBySemestrasKursasirStudentas(semestras,kursas,User.id);
        }

        private void LogOutbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            LoggedInWindow loggedInWindow = new LoggedInWindow((Student)User);
            loggedInWindow.Show();
            this.Close();
        }
    }
}
