using System;
using AddressBook.Modules;
using AddressBook.Helpers;

namespace AddressBook.AddingForm
{
    public class AddFormModel
    {

        public bool SaveRecord(Record r)
        {

            if (r != null)
            {
                var p = new Person {_firstname = r._firstname, 
                                    _lastname = r._lastname, 
                                    _age = r._age, 
                                    _sex = r._sex
                };
                return p.create() > 0 ? true : false;
            }
            return false;
        }
 

        public int ComputeAge(DateTime bday)
        {
            var age = new Age(bday);
            return age.Years;
        }
    }
}
