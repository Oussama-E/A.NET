using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Be.Ipl.Domaine
{
    internal class PersonList
    {
        private static PersonList? instance;
        private IDictionary<String, Person> personMap;

        private PersonList()
        {
            personMap = new Dictionary<String, Person>();
        }

        public static PersonList Instance
        {

            get
            {
                if (instance == null)
                instance = new PersonList();
                return instance; 
            }
        }

        public void AddPerson(Person person)
        {
            if (person == null)
                throw new ArgumentNullException();
            personMap.Add(person.Name, person);
        }

        public IEnumerator<Person> personList()
        {
            return personMap.Values.GetEnumerator();
        }

    }
}
