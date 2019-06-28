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

                List<Offre> offres = new List<Offre>();
                offres.Add(new Offre
                {
                    Id = 1,
                    Date = new DateTime(2018, 10, 6),
                    Description = "Nous recherchons un développeur C# formé au frameworks .NET afin de finir ce site," +
                    " pour plus d'info, contactez PATRICK COURT par mail à l'adresse patrick.court@jobup.fr",
                    Intitule = "Developpeu.r.se C#/.NET Junior expérimenté",
                    ResponsableId = 2,
                    Salaire = 1800,
                    Statut = false
                });
                offres.Add(new Offre
                {
                    Id = 2,
                    Date = new DateTime(2019, 2, 10),
                    Description = "Nous recherchons une personne ayant de l'expérience en design " +
                    "et en interface graphiques pour maquetter un futur projet, vous êtes créatifs, " +
                    "force de proposition et avez déjà un bagage artistique ? " +
                    "Alors contactez dès maintenant PATRICK COURT par mail à l'adresse patrick.court@jobup.fr",
                    Intitule = "Graphiste - UI / UX Designer",
                    ResponsableId = 2,
                    Salaire = 2000,
                    Statut = false
                });


                for (int i = 0; i < offres.Count; i++)
                {
                    int id = offres[i].Id;
                    if (!db.Offres.Any(item => item.Id == id))
                    {
                        db.Offres.Add(offres[i]);
                    }
                }

                db.SaveChanges();

                List<Employe> dbemployes = db.Employes.ToList();
                List<Offre> dboffres = db.Offres.ToList();
                List<Postulation> dbpostulation = db.Postulations.ToList();

                foreach (var employe in dbemployes)
                {
                    Console.WriteLine(employe.Prenom);
                    Console.WriteLine(employe.Nom);
                    Console.WriteLine();
                }

                foreach (var offre in dboffres)
                {
                    Console.WriteLine(offre.Intitule);
                    Console.WriteLine(offre.Description);
                    Console.WriteLine();
                }

                foreach (var postulation in dbpostulation)
                {
                    Console.WriteLine(postulation.Id);
                    Console.WriteLine(postulation.EmployeeId);
                    Console.WriteLine(postulation.Date);
                    Console.WriteLine(postulation.Status);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
