namespace _4._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




   internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} | Mobile: {MobilePhone} | Work: {WorkPhone} | Address: {Address}";
        }
    }

    class PhoneBook
    {
        private Dictionary<string, Person> contacts = new Dictionary<string, Person>();

        public void AddContact(Person person)
        {
            string key = $"{person.FirstName} {person.LastName}";
            if (!contacts.ContainsKey(key))
            {
                contacts.Add(key, person);
                Console.WriteLine("Contact added successfully!");
            }
            else
            {
                Console.WriteLine("Contact already exists.");
            }
        }

        public void DisplayAllContacts()
        {
            foreach (var person in contacts.Values)
            {
                Console.WriteLine(person);
            }
        }

        public void DeleteContact(string fullName)
        {
            if (contacts.ContainsKey(fullName))
            {
                contacts.Remove(fullName);
                Console.WriteLine($"{fullName} deleted from contacts.");
            }
            else
            {
                Console.WriteLine($"{fullName} not found in contacts.");
            }
        }

        public void SearchByName(string fullName)
        {
            if (contacts.ContainsKey(fullName))
            {
                Console.WriteLine(contacts[fullName]);
            }
            else
            {
                Console.WriteLine($"{fullName} not found in contacts.");
            }
        }
    }
