using Dapper;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projektas
{
    public class AdminRepository : IUserRepository<Admin>
    {
       

        public void Add(Admin Entity)
        {
            throw new NotImplementedException();
        }

        public Admin Get(string LogIn)
        {
            using (var connection = new MySqlConnection("Server=MYSQL6008.site4now.net;Database=db_aa1d25_kristup;Uid=aa1d25_kristup;Pwd=Staniulis9"))
            {
                connection.Open();
                string sql = "Select * from admin where username = @LogIn";
               var x = connection.QuerySingle<Admin>(sql, new { LogIn = LogIn });
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
