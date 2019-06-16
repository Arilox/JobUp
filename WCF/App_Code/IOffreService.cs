using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService" à la fois dans le code et le fichier de configuration.
[ServiceContract]
public interface IOffreService
{
    [OperationContract]
    string GetOffres();

    [OperationContract]
	string GetOffreTitle(int id);

	[OperationContract]
    Offre GetDataUsingDataContract(Offre composite);

	// TODO: ajoutez vos opérations de service ici
}

// Utilisez un contrat de données comme indiqué dans l'exemple ci-après pour ajouter les types composites aux opérations de service.
[DataContract]
public class Offre
{
    public Offre(int id, string intitule, DateTime date, 
                float salaire, string description, Boolean statut,
                int responsableid)
    {
        Id = id;
        Intitule = intitule;
        Date = date;
        Salaire = salaire;
        Description = description;
        Statut = statut;
        ResponsableId = responsableid;
    }


    public int Id { get; set; }

    public string Intitule { get; set; }

    public DateTime Date { get; set; }

    public float Salaire { get; set; }

    public string Description { get; set; }

    public Boolean Statut { get; set; }

    public int ResponsableId { get; set; }
}
