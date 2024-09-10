using ex1.Be.Ipl.Domaine;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Be.Ipl.Client
{
    internal class Test2
    {
        public static void Main(string[] args)
        {
            Actor[] myActors =  {
                new Actor( "Assange", "Julian", new DateTime(1961, 7, 3), 187),
                new Actor( "Paul", "Newmann", new DateTime(1925, 1, 26), 187),
                new Actor( "Becker", "Norma Jean", new DateTime(1926, 6, 1), 187)
            };

            Director[] myDirectors = {
                new Director("Spielberg", "Steven", new DateTime(1946, 12, 18)),
                new Director("Coen", "Ettan", new DateTime(1957, 9, 21)),
                new Director("Coppolla", "Francis Ford", new DateTime(1939, 4, 7))
            };


            Movie bigLebow = new Movie("The Big Lebowski", 1996);
            Movie eT = new Movie("E.T.", 1982);

            eT.AddActor(myActors[0]);
            eT.AddActor(myActors[2]);
            eT.Director = myDirectors[0];

            bigLebow.AddActor(myActors[1]);
            bigLebow.AddActor(myActors[2]);
            bigLebow.Director = myDirectors[1];

            PersonList myPersons = PersonList.Instance;

            foreach (Actor act in myActors) {
                myPersons.AddPerson(act);
            }

            foreach (Director director in myDirectors) {
                myPersons.AddPerson(director);
            }

            /*IEnumerator<Person> ActorIt = myPersons.personList();*/
            List<Person> personList = new List<Person>();
            IEnumerator<Person> enumerator = myPersons.personList();

            while (enumerator.MoveNext())
            {
                personList.Add(enumerator.Current);
            }

            var sortedPersons = personList
                .Cast<Person>()
                .OrderBy(p => p is Actor)
                .ThenBy(p => p.Name);

            foreach (var person in sortedPersons)
            {
                /*Person person = ActorIt.Current;*/
                Console.WriteLine(person);

                IEnumerator<Movie> MoviesIt;
                if (person is Actor) {
                    Console.WriteLine("a joué dans les films suivants ");
                    MoviesIt = ((Actor)person).Movies();
                }
                else
                {
                    if (person is Director) 
                    {
                        Console.WriteLine("a dirigé les films suivants :");
                        MoviesIt = ((Director)person).Movies();
                    }
                    else
                    {
                        Console.WriteLine("est inconnu et n'a rien à faire ici !!! ");
                        continue;
                    }
                }
                while (MoviesIt.MoveNext())
                {
                    Movie Movie = MoviesIt.Current;
                    Console.WriteLine(Movie);
                }
            }
        }
    }
}
    
