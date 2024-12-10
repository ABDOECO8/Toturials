using System;
using System.ComponentModel.DataAnnotations;

namespace Toturials.Models
{
	public class User
	{
        [Key] // Ajoutez cette annotation pour définir la clé primaire
        public int UserId { get; set; }

        // Ajoutez d'autres propriétés ici (FirstName, LastName, etc.)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

       
        public User()
        {
            FirstName = "";
            LastName = "";
            UserName = "";
            Password = "";
        }
	}
}

