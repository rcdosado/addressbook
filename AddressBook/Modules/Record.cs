using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Modules
{
    public class Record
    {
        private int id;
        private string firstname;
        private string lastname;
        private string sex;
        private int age;

        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        public string _firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string _lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string _sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public int _age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
