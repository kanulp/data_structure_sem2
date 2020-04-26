using System;

namespace W10Ex1_Gajjar
{
    class Program
    {
        public static void Main(string[] args)
        {
            ContactGroup myFriends = new ContactGroup("Friends", "All My Friends");
            ContactGroup myRelatives = new ContactGroup("Relatives", "All My Relatives");
            ContactGroup allContacts = new ContactGroup("All Contacts", "All My Contacts");

            allContacts.AddItem(myFriends);
            myFriends.AddItem(new Contact("Jack", "Baur", "jack.baur@somemeail.com", "416-999-3333"));
            myFriends.AddItem(new Contact("George", "Maison", "george.maison@somemeail.com", "416-111-4567"));
            myFriends.AddItem(new Contact("Nina", "Maison", "nina.maison@somemeail.com", "416-111-4567"));

            allContacts.AddItem(myRelatives);
            myRelatives.AddItem(new Contact("Ron", "Baur", "ron.baur@somemeail.com", "416-999-3333"));
            myRelatives.AddItem(new Contact("Rose", "Maison", "rose.maison@somemeail.com", "416-111-4567"));
            myRelatives.AddItem(new Contact("Ram", "Maison", "ram.maison@somemeail.com", "416-111-4567"));

            allContacts.listContactDetails();
        }
    }
}
