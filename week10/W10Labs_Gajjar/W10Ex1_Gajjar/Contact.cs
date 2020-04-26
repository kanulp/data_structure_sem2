using System;
namespace W10Ex1_Gajjar
{
    public class Contact : IComponent
    {
        public string firstName;
        public string lastName;
        public string email;
        public string phoneNumber;

        public Contact(string firstName, string lastName, string email, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public void listContactDetails()
        {
            Console.WriteLine(firstName + " " + lastName + " " + email + " " + phoneNumber);
        }
    }
}
