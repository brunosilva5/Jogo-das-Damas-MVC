using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace CheckersGame
{
    public class PReal : Player
    {

        public new string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }

        public PReal(string name, string username, string password, string coutry, string email, string photo)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Country = coutry;
            this.Email = email;
            this.Photo = Image.FromFile("Photos\\" + photo);
        }

    }
    
}
