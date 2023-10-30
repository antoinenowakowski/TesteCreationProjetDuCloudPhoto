/*
 * Création de classes et teste du projet cloud photo
 * app console, et demandes fictives
 * 
 * Demander compte ou pas compte
 * création compte ou connexion
 * demander importer photos ou supprimer photo
 */
using TesteCreationProjetCloudPhoto.Fonctions;


#region Fonctions


string DemandeCompteCree()
{
    bool EntreeUtilisateurNonVide = true;
    string EntreeUtilisateur;


    // demande compte
    do
    {
        Console.WriteLine("Avez-vous un compte ?");
        EntreeUtilisateur = Console.ReadLine();

        EntreeUtilisateurNonVide = string.IsNullOrEmpty(EntreeUtilisateur);

    } while (EntreeUtilisateurNonVide);

    if (EntreeUtilisateur == "oui".ToLower())
    {
        Console.WriteLine("Vous avez un compte");
        Console.WriteLine("Veillez vous connectez");
        SeConnecter();
    }
    else
    {
        if (EntreeUtilisateur == "non".ToLower())
        {
            Console.WriteLine("Vous n'avez pas de compte");
            Console.WriteLine("Veillez vous en créer un");
        }
        DemandeCompteCree();
    }

    return EntreeUtilisateur;
}

void SeConnecter()
{
    Console.WriteLine("Renseignez votre email : ");
    string email = Console.ReadLine(); 
    Console.WriteLine("Renseignez votre mot de passe : ");
    string motDePasse = Console.ReadLine();

    Connexion NouvelleConnexion = new Connexion(email, motDePasse);
    Console.WriteLine($"Votre email est : {NouvelleConnexion.Email} \nEt votre mot de passe est : {NouvelleConnexion.Password}");
}

void CreeCompte()
{

}
#endregion

DemandeCompteCree();