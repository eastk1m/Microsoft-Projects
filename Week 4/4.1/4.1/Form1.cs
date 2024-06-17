using System;
using System.Collections.Generic;

class Person
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
    private readonly Dictionary<string, Person> contacts = new();

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
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found.");
            return;
        }

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

    public void SearchByName(string partialName)
    {
        bool found = false;
        foreach (var person in contacts.Values)
        {
            if (person.FirstName.Contains(partialName) || person.LastName.Contains(partialName))
            {
                Console.WriteLine(person);
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"No contacts found matching '{partialName}'.");
        }
    }
}

class Program
{
    static void Main()
    {
        PhoneBook phoneBook = new();

        while (true)
        {
            Console.WriteLine("1. Display all contacts");
            Console.WriteLine("2. Add a new contact");
            Console.WriteLine("3. Delete a contact");
            Console.WriteLine("4. Search by name");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    phoneBook.DisplayAllContacts();
                    break;
                case "2":
                    // Input validation for required fields (non-empty names, etc.)
                    Console.Write("Enter first name: ");
                    string firstName = Console.ReadLine();
                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter mobile phone: ");
                    string mobilePhone = Console.ReadLine();
                    Console.Write("Enter work phone: ");
                    string workPhone = Console.ReadLine();
                    Console.Write("Enter address: ");
                    string address = Console.ReadLine();
                    phoneBook.AddContact(new Person
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        MobilePhone = mobilePhone,
                        WorkPhone = workPhone,
                        Address = address
                    });
                    break;
                case "3":
                    Console.Write("Enter the full name to delete: ");
                    string nameToDelete = Console.ReadLine();
                    phoneBook.DeleteContact(nameToDelete);
                    break;
                case "4":
                    Console.Write("Enter a partial name to search: ");
                    string partialName = Console.ReadLine();
                    phoneBook.SearchByName(partialName);
                    break;
                case "5":
                    Console.WriteLine("Exiting phonebook. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
