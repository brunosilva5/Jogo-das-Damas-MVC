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
        public string Username { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }

        public PReal(string name, string username, string password, string country, string email, string photo, string numgames, string numwins, string numdefeats, string numleave)
        {
            this.Name = name;
            this.Username = username;
            this.Password = password;
            this.Country = country;
            this.Email = email;
            this.Photo = Image.FromFile("Photos\\" + photo);
            this.NumGames = Convert.ToInt32(numgames);
            this.NumWins = Convert.ToInt32(numwins);
            this.NumDefeats = Convert.ToInt32(numdefeats);
            this.NumLeave = Convert.ToInt32(numleave);
        }
    }
    
}
