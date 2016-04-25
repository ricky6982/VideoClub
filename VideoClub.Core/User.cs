using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClub.Core.Enums;

namespace VideoClub.Core
{
    public class User
    {
        public string Name { set; get; }
        public string Lastname { set; get; }
        public int Number { get; set; }
        public int Type;
        public List<Pelicula> MoviesSelected = new List<Pelicula>();

        public User(string name, string lastname)
        {
            Name = name;
            Lastname = lastname;
            Type = (int)TypeUser.Member;
            var rnd = new Random();
            Number = rnd.Next(1, 100);
        }

        public User()
        {
            
        }

        public void SelectMovie(Pelicula pelicula)
        {
            MoviesSelected.Add(pelicula);
        }



    }
}
