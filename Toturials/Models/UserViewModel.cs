using System;
namespace Toturials.Models
{
	public class UserViewModel
	{

             public string UserName { get; set; }
             public string FirstName { get; set; }
             public string LastName { get; set; }
        public UserViewModel()
        {
            this.UserName = "idriss@gmail.com";
            this.LastName = "echakouki";
            this.FirstName = "idriss";
        }
	}
}

