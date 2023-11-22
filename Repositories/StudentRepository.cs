using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektas
{
    public class StudentRepository : IUserRepository<Student>
    {

        public void Add(Student Entity)
        {
            throw new NotImplementedException();
        }

        public Student Get(string LogIn)
        {
            using (var connection = new MySqlConnection("Server=MYSQL6008.site4now.net;Database=db_aa1d25_kristup;Uid=aa1d25_kristup;Pwd=Staniulis9"))
            {
                connection.Open();
                string sql = "Select * from studentas where username = @LogIn";
                var x = connection.QuerySingle<Student>(sql, new { LogIn = LogIn });
                return x;
            }
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
