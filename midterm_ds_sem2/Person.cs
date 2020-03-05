using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace midterm
{
    public class Person : IComparable<String>
    {
        private String firstName;
        private String lastName;
        private String email;

        private List<Person> persons;

        public List<Person> Persons { get => persons; set => persons = value; }

        public Person(String firstName, String lastName, String email){
            this.firstName=firstName;
            this.lastName=lastName;
            this.email=email;
        }

        public String getFirstName(){
            return firstName;
        }
        public String getLastName(){
            return lastName;
        }
        public String getEmail(){
            return email;
        }

        public int CompareTo(Person obj)
        {
            Person other = (Person)obj;

                 
                 

             if (String.Compare(lastName, other.lastName) < 0)
                 return -1;

                 return 1;
        }

        public int CompareTo([AllowNull] string other)
        {
            throw new NotImplementedException();
        }
    }
}