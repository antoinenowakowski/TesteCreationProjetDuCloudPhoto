using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCreationProjetCloudPhoto.classes
{
    internal class CreerCompte
    {
        public string Name { get; set; }   
        public string Email { get; set; }
        public string Password { get; set; }
        public int Pin { get; set; }

        public CreerCompte(string name, string email, string password, int pin)
        { 
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.Pin = pin;
        }
    }
}
