using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ex1.Be.Ipl.Domaine
{
    [Serializable]
    internal class Person
    {
        private static readonly long serialVersionUID = 1L;

        private readonly string _name;
	    private readonly string _firstname;
	    private readonly DateTime _birthDate;
	
	    public virtual string Name
        {
            get => _name;
        }

        public string Firstname
        {
            get { return _firstname; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
        }


        public Person(string name, string firstname, DateTime birthDate)
        {
            this._name = name;
            this._firstname = firstname;
            this._birthDate = birthDate;
        }

        public override string ToString()
        {
            return $"Person [name = {_name} , firstname = {_firstname} , birthDate = {BirthDate: dd - MM - yyyy} ]";
        }

    }
}
