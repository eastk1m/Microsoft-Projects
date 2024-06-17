namespace _4._1
{
    internal static class ProgramBase1
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        static void Main()
        {
            PhoneBook phoneBook = new PhoneBook();

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
                        Console.Write("Enter the name to delete: ");
                        string nameToDelete = Console.ReadLine();
                        phoneBook.DeleteContact(nameToDelete);
                        break;
                    case "4":
                        Console.Write("Enter the name to search: ");
                        string nameToSearch = Console.ReadLine();
                        phoneBook.SearchByName(nameToSearch);
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
}