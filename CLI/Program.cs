using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modele;
using Modele.Entities;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            MappingMetierBase mmp = new MappingMetierBase();
            List<Experience> le = new List<Experience>();
            le = mmp.Experiences.ToList();
            Console.WriteLine("Skurt");
            Console.WriteLine(le);
            Console.WriteLine("Cobain");
        }
    }
}
