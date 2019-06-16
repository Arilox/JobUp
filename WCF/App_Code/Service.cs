using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service" dans le code, le fichier svc et le fichier de configuration.
public class Service : IOffreService
{
	public Offre GetDataUsingDataContract(Offre composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.Id == 1)
		{
			composite.Intitule += "Suffix";
		}
		return composite;
	}

    public Offre GetOffre(int id)
    {
        throw new NotImplementedException();
    }

    public string GetOffres()
    {
        throw new NotImplementedException();
    }

    public string GetOffreTitle(int id)
    {
        throw new NotImplementedException();
    }
}
