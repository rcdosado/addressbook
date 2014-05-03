using System.Collections.Generic;

namespace AddressBook.SearchForm
{
    class SearchFormModel
    {
        public List<string> GetCategories()
        {
            //but this should accessed db
            var cat =  new List<string> {"Minny", "Miney", "Moo"};
            return cat;
        }
    }
}
