using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektas.Model
{
    public class pazymiai : Entity
    {
        public int grade { get; set; }
        public int Dalykai_id { get; set; }
        public int Darbo_tipas_id { get; set; } 
        public int Studentas_id { get; set; }
        public int semestras { get; set; }
        public int kursas { get; set; }
    }
}
