using Dapper;
using MySqlConnector;
using projektas.Model;
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
    /// Interaction logic for AdminEditWindow.xaml
    /// </summary>
    public partial class AdminEditWindow : Window
    {
        private User user;
        public AdminEditWindow(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void LogOutbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
           // LoggedInWindow semesterWindow = new LoggedInWindow((Student)user);
           // semesterWindow.Show();
            //this.Close();
        }

        private void btnIssaugotiGrupe_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnIssaugotiStudenta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection("Server=MYSQL6008.site4now.net;Database=db_aa1d25_kristup;Uid=aa1d25_kristup;Pwd=Staniulis9"))
                {
                    connection.Open();
                    string sql = @"insert into studentas(username,pasword,fname,lname,grupe)
                               values(@username,@password,@fname,@lname,@grupe)";


                    var x = connection.Query(sql, new
                    {
                        username = txtNewVardas.Text,
                        password = txtNewPavarde.Text,
                        fname = txtNewVardas.Text,
                        lname = txtNewPavarde.Text,
                        grupe = txtGrupe.Text
                    });

                    MessageBox.Show("Sekmingai išsaugotas studentas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveDestytojas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection("Server=MYSQL6008.site4now.net;Database=db_aa1d25_kristup;Uid=aa1d25_kristup;Pwd=Staniulis9"))
                {
                    connection.Open();
                    string sql = @"insert into destytojas(fname,lname,username,pasword)
                               values(@fname,@lname,@username,@password)";


                    var x = connection.Query(sql, new
                    {
                        username = txtNewDestytojoVardas.Text,
                        password = txtNewDestytojoPavarde.Text,
                        fname = txtNewDestytojoVardas.Text,
                        lname = txtNewDestytojoPavarde.Text
                    });

                    MessageBox.Show("Sekmingai išsaugotas dėstytojas");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
