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
    /// Interaction logic for TeacherEditWindow.xaml
    /// </summary>
    public partial class TeacherEditWindow : Window
    {
        User user;
        public TeacherEditWindow(User user)
        {
            InitializeComponent();
            this.user = user;
            cbGrupe.ItemsSource = GetAllGrupes();

            cbStudents.DisplayMemberPath = "lname";
            cbStudents.SelectedValuePath = "id";
            cbStudents.ItemsSource = GetAllStudents();

            cbDarboTipas.DisplayMemberPath = "work_type_name";
            cbDarboTipas.SelectedValuePath = "id";
            cbDarboTipas.ItemsSource = GetDarbo_Tipas();

            cbDalykai.DisplayMemberPath = "name";
            cbDalykai.SelectedValuePath= "id";
            cbDalykai.ItemsSource = GetAllDalykus();

            var PAZ = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            cbPazymiai.ItemsSource = PAZ;

            var semestras = new List<int>() {1,2 };
            var kursas = new List<int>() {1,2,3,4 };

            cbSemestras.ItemsSource = semestras;
            cbKursas.ItemsSource = kursas;
        }
        private void SaveMark_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var connection = new MySqlConnection("Server=MYSQL6008.site4now.net;Database=db_aa1d25_kristup;Uid=aa1d25_kristup;Pwd=Staniulis9"))
                {
                    connection.Open();
                    string sql = @"insert into pazymiai(grade, Dalykai_Id, Darbo_tipas_Id, Studentas_Id, semestras,kursas)
                               values(@grade,@dalykoId,@darboTipoId,@studentoId,@semestras,@kursas)";




                    var x = connection.Query(sql, new
                    {
                        grade = cbPazymiai.SelectedItem,
                        dalykoId = (cbDalykai.SelectedItem as dalykai).id,
                        darboTipoId = (cbDarboTipas.SelectedItem as darbo_tipas).id,
                        studentoId = (cbStudents.SelectedItem as Student).id,
                        semestras = cbSemestras.SelectedItem,
                        kursas = cbKursas.SelectedItem
                    });

                    MessageBox.Show("Sekmingai įrašytas pažymys");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<dalykai> GetAllDalykus()
        {
            using (var connection = new MySqlConnection("Server=MYSQL6008.site4now.net;Database=db_aa1d25_kristup;Uid=aa1d25_kristup;Pwd=Staniulis9"))
            {
                connection.Open();
                string sql = "Select * from dalykai";
                var x = connection.Query<dalykai>(sql);
                return x.ToList();
            }
        }

        public List<darbo_tipas> GetDarbo_Tipas()
        {
            using (var connection = new MySqlConnection("Server=MYSQL6008.site4now.net;Database=db_aa1d25_kristup;Uid=aa1d25_kristup;Pwd=Staniulis9"))
            {
                connection.Open();
                string sql = "Select * from darbo_tipas";
                var x = connection.Query<darbo_tipas>(sql);
                return x.ToList();
            }

        }

        public List<string> GetAllGrupes()
        {
            using (var connection = new MySqlConnection("Server=MYSQL6008.site4now.net;Database=db_aa1d25_kristup;Uid=aa1d25_kristup;Pwd=Staniulis9"))
            {
                connection.Open();
                string sql = "Select DISTINCT grupe from studentas";
                var x = connection.Query<string>(sql);
                return x.ToList();
            }
        }

        public List<Student> GetAllStudents()
        {
            using (var connection = new MySqlConnection("Server=MYSQL6008.site4now.net;Database=db_aa1d25_kristup;Uid=aa1d25_kristup;Pwd=Staniulis9"))
            {
                connection.Open();
                string sql = "Select * from studentas";
                var x = connection.Query<Student>(sql);
                return x.ToList();
            }
        }

        private void LogOutbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void MainMenu_Click(object sender, RoutedEventArgs e)
        {
            LoggedInWindow loggedInWindow = new LoggedInWindow((Student)user);
            loggedInWindow.Show();
            this.Close();
        }


    }
}
