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

namespace projektas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        StudentRepository studentRepository = new StudentRepository();
        TeacherRepository teacherRepository = new TeacherRepository();
        AdminRepository adminRepository = new AdminRepository();
        


        private void Studentasbtn_Click(object sender, RoutedEventArgs e)
        {
            var x = studentRepository.Get(txtVardas.Text);
            if (x != null)
            {
                LoggedInWindow studentLoginWindow = new LoggedInWindow(x);
                studentLoginWindow.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Neteisingas slaptažodis arba naudotojo vardas");
            }
        }

        private void Destytojasbtn_Click(object sender, RoutedEventArgs e)
        {
            var x = teacherRepository.Get(txtVardas.Text);
            if (x != null)
            {
                var teacherLoginWindow = new TeacherEditWindow(x);
                teacherLoginWindow.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Neteisingas slaptažodis arba naudotojo vardas");
            }
        }

        private void Adminbtn_Click(object sender, RoutedEventArgs e)
        {
            var x = adminRepository.Get(txtVardas.Text);
            if (x != null)
            {
                var adminLoginWindow = new AdminEditWindow(x);
                adminLoginWindow.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Neteisingas slaptažodis arba naudotojo vardas");
            }
           

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
