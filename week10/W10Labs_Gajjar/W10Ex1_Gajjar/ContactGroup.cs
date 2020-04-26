using System;
using System.Collections.Generic;

namespace W10Ex1_Gajjar
{
    public class ContactGroup : IComponent
    {
        public string groupName;
        public string groupDescription;
        public List<IComponent> contactList = new List<IComponent>();

        public ContactGroup(string groupName, string groupDescription)
        {
            this.groupName = groupName;
            this.groupDescription = groupDescription;
        }

        public void listContactDetails()
        {
            Console.WriteLine("\n" + groupName + " " + groupDescription + "\n");
            foreach (var item in contactList)
            {
                item.listContactDetails();
            }
        }

        public void AddItem(IComponent item)
        {
            contactList.Add(item);
        }
    }
}
