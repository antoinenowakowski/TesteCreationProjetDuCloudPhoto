using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCreationProjetCloudPhoto.Fonctions
{
    internal class Connexion
    {
        public string Email { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Demande à l'utilisateur de se connecter
        /// -> email et password
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="pswrd">Mot de passe</param>
        public Connexion(string email, string pswrd) 
        {
            this.Email = email;  
            this.Password = pswrd;
        }
    }
}
