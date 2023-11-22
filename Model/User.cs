using projektas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektas
{
    public class User : Entity
    { 
        public string username { get; set; }
        public string pasword { get; set; }

        public string fname { get; set; }   
        public string lname { get; set; }
    }
   
}
