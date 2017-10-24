using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}
