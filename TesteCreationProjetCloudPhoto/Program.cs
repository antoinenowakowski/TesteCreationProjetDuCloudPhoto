using TesteCreationProjetCloudPhoto.classes;
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
            CreeCompte();
        }
        else
        {
            DemandeCompteCree();
        }
    }

    return EntreeUtilisateur;
}

void SeConnecter()
{
    Console.WriteLine("Renseignez votre email : ");
    string email = Console.ReadLine(); 
    Console.WriteLine("Renseignez votre mot de passe : ");
    string motDePasse = Console.ReadLine();   
    Console.WriteLine("Renseignez votre pin à 4 chiffres : ");
    string pin = Console.ReadLine();

    Connexion NouvelleConnexion = new Connexion(email, motDePasse, int.Parse(pin));
    Console.WriteLine($"Votre email est : {NouvelleConnexion.Email} \nVotre mot de passe est : {NouvelleConnexion.Password} \nEt votre pin est {pin}");
}

void CreeCompte()
{
    Console.WriteLine("Vous n'avez pas de compte ! ");

    Console.WriteLine("Renseignez votre nom : ");
    string name = Console.ReadLine();    
    Console.WriteLine("Renseignez votre email : ");
    string email = Console.ReadLine();
    Console.WriteLine("Renseignez votre mot de passe : ");
    string motDePasse = Console.ReadLine();
    Console.WriteLine("Renseignez votre pin à 4 chiffres : ");
    string pin = Console.ReadLine();

    CreerCompte NouveauCompte = new CreerCompte(name, email, motDePasse, int.Parse(pin));
    Console.WriteLine($"Votre nom est : {NouveauCompte.Name} \nVotre email est : {NouveauCompte.Email} \nVotre mot de passe est : {NouveauCompte.Password} \nEt votre pin est {pin}");
}

#endregion

DemandeCompteCree();