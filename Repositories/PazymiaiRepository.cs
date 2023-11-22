using Dapper;
using MySqlConnector;
using projektas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektas.Repositories
{
    public class PazymiaiRepository : IUserRepository<pazymiai>
    {
        public void Add(pazymiai Entity)
        {
            throw new NotImplementedException();
        }

        public pazymiai Get(string LogIn)
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public List<pazymiai> GetAllBySemestrasKursasirStudentas(int semestras,int kursas,int studentId)
        {
            using (var connection = new MySqlConnection("Server=MYSQL6008.site4now.net;Database=db_aa1d25_kristup;Uid=aa1d25_kristup;Pwd=Staniulis9"))
            {
                connection.Open();
                string sql = $"Select * from `db_aa1d25_kristup`.pazymiai where Studentas_id = '{studentId}' AND kursas = '{kursas}' AND semestras = '{semestras}'";

                var x = (connection.Query<pazymiai>(sql)).ToList();
                //S046823
                return x;
            }
        }
    }
}
