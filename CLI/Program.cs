using System;
using System.Collections.Generic;
using System.Linq;
using Modele;
using Modele.Entities;

namespace CLI
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new MappingMetierBase())
            {
                List<Employe> employees = new List<Employe>();
                employees.Add(new Employe
                {
                    Id = 1,
                    Ancienete = 3,
                    Nom = "DUPONT",
                    Prenom = "Jack",
                    Biographie = "Travailleur expérimenté depuis 2010",
                    DateNaissance = new DateTime(1993, 5, 29)
                });
                employees.Add(new Employe
                {
                    Id = 2,
                    Ancienete = 3,
                    Nom = "COURT",
                    Prenom = "Patrick",
                    Biographie = "Travailleur exemplaire depuis 1983",
                    DateNaissance = new DateTime(1969, 2, 18)
                });

                for (int i = 0; i < employees.Count; i++)
                {
                    int id = employees[i].Id;
                    if (!db.Employes.Any(item => item.Id == id))
                    {
                        db.Employes.Add(employees[i]);
                    }
                }
                
                db.SaveChanges();

                foreach (var employe in db.Employes)
                {
                    Console.WriteLine(employe.Id);
                    Console.WriteLine(employe.Prenom);
                    Console.WriteLine(employe.Nom);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
