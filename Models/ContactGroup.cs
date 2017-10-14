using System;
using System.Collections.Generic;

namespace PracticeXaml.Models
{
    public class ContactGroup : List<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public ContactGroup(string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }

        //trying to create a method that returns the name of the contact so the 
        //user can enter more than 1 letter in the search bar to find the contact 
        public string getName(Contact _contact){
            string _name = _contact.Name;
            return _name;
        }

    }
}
