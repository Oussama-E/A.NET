using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Be.Ipl.Domaine
{
    [Serializable]
    internal class Actor : Person 
    {
        private static readonly long serialVersionUID = 1L;
        private readonly int sizeInCentimeter;
        private IList<Movie> movies;

        public int SizeInCentimeter
        {
            get { return sizeInCentimeter; }
        }



        public Actor(string name, string firstname, DateTime birthDate, int sizeInCentimeter): base(name, firstname, birthDate)
        {
            this.sizeInCentimeter = sizeInCentimeter;
            movies = new List<Movie>();
        }


        public override string ToString()
        {
            return $"Actor [name = { Name.ToUpper() } firstname = { base.Firstname } sizeInCentimeter = { sizeInCentimeter} birthdate = {base.BirthDate:dd - MM - yyyy} ]";
        }

        /**
         * 
         * @return list of movies in which the actor has played
         */
        public IEnumerator<Movie> Movies()
        {
            return movies.GetEnumerator();
        }

        /**
         * add movie to the list of movies in which the actor has played
         * @param movie
         * @return false if the movie is null or already present
         */
        public bool AddMovie(Movie movie)
        {
            if ((movie == null) || movies.Contains(movie))
                return false;

            if (!movie.ContainsActor(this))
                movie.AddActor(this);

            movies.Add(movie);

            return true;
        }

        public bool ContainsMovie(Movie movie)
        {
            return movies.Contains(movie);
        }

        public override string Name
        {
            get { return base.Name.ToUpper(); }
        }
    }
}
