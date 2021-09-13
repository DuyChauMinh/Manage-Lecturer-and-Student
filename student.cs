using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    class student : human // use abstract class human
    {
        List<student> studentList = new List<student>(); // create a list to contain students values.
        private string Batch;
        public student()
        {

        }

        // Constructor
        public student(string ID, string Name, string Email, string Address, string DoB, string Batch) : base(ID, Name, Email, Address, DoB)
        {
            this.Batch = Batch;
        }
        // show out the list of submenu of student menu
        public void StudentMenu()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("1. Add new student");
            Console.WriteLine("2. View all students");
            Console.WriteLine("3. Search students");
            Console.WriteLine("4. Delete students");
            Console.WriteLine("5. Update students");
            Console.WriteLine("6. Main Menu");
            Console.WriteLine("====================");
            Console.Write("Please select a submenu: ");
            string studentMenuSelect = Console.ReadLine();
            switch (studentMenuSelect) 
            // Divide options into cases then call corresponding methods
            {
                case "1":
                    Add();
                    break;
                case "2":
                    View();
                    break;
                case "3":
                    Search();
                    break;
                case "4":
                    Delete();
                    break;
                case "5":
                    Update();
                    break;
                case "6":
                    mainmenu.MainMenu();
                    break;
            }
        }

        // Use methods inherited from human to use the add function
        public override void Add()
        {
            Console.Clear();
            Console.Write("Student ID: "); string tempID = Console.ReadLine();
            Console.Write("Student Name: "); string tempName = Console.ReadLine();
            Console.Write("Student DoB: "); string tempDoB = Console.ReadLine();
            Console.Write("Student Email: "); string tempEmail = Console.ReadLine();
            Console.Write("Student Address: "); string tempAddress = Console.ReadLine();
            Console.Write("Student Batch: "); string tempBatch = Console.ReadLine();
            student st1 = new student(tempID, tempName, tempEmail, tempAddress, tempDoB, tempBatch);
            studentList.Add(st1);
            Console.WriteLine("Added successfully!");
            Console.WriteLine("Press any button to get back to student menu.");
            Console.ReadKey();
            StudentMenu();
        }

        // Use methods inherited from human to use the view function
        public override void View()
        {
            Console.Clear();
            Console.WriteLine("ID\t\t\t\tName\t\t\t\tDoB\t\t\t\tEmail\t\t\t\tAddress\t\t\t\t\t\t\tBatch");
            foreach (student i in studentList)
            {
                Console.WriteLine("{0,-32}{1,-32}{2,-32}{3,-32}{4,-60}{5,-32}", i.ID, i.Name, i.DoB, i.Email, i.Address, i.Batch);
            }
            Console.WriteLine("Press any button to get back to student menu.");
            Console.ReadKey();
            StudentMenu();
        }

        // Use methods inherited from human to use the search function
        public override void Search()
        {
            Console.Clear();
            Console.Write("Enter ID : ");
            String temp = Console.ReadLine();
            while (true)
            {
                foreach (student i in studentList)
                {
                    if (i.ID == temp)
                    {
                        Console.WriteLine("ID:\t\t\t\t{0}\nFull Name:\t\t\t{1}\nBatch:\t\t\t\t{2}" +
                            "\nDate of Birth:\t\t\t{3}\nEmail:\t\t\t\t{4}\nAddress:\t\t\t{5}", i.ID, i.Name, i.Batch, i.DoB, i.Email, i.Address);
                        Console.WriteLine("\n\nPress any button to get back to student menu.");
                        Console.ReadKey();
                        StudentMenu();
                    }
                    else
                    {
                        Console.WriteLine("No ID found. Please enter ID again.");
                        Console.Write("Enter ID :");
                        temp = Console.ReadLine();
                    }
                }
            }
        }

        // Use methods inherited from human to use the delete function
        public override void Delete()
        {
            Console.Clear();
            Console.Write("Enter ID :");
            String temp = Console.ReadLine();
            while (true)
            {
                foreach (student i in studentList)
                {
                    if (i.ID == temp)
                    {
                        studentList.Remove(i);
                        Console.WriteLine("Removed sucessfully");
                        Console.WriteLine("Press any button to get back to student menu.");
                        Console.ReadKey();
                        StudentMenu();
                    }
                    else
                    {
                        Console.WriteLine("No ID found. Please enter ID again.");
                        Console.Write("Enter ID :");
                        temp = Console.ReadLine();
                    }
                }

            }
        }

        // Use methods inherited from human to use the update function
        public override void Update()
        {
            Console.Clear();
            Console.Write("Enter ID :");
            String temp = Console.ReadLine();
            while (true)
            {
                foreach (student i in studentList)
                {
                    if (i.ID == temp)
                    {
                        Console.Write("Student ID: "); string tempID = Console.ReadLine();
                        Console.Write("Student Name: "); string tempName = Console.ReadLine();
                        Console.Write("Student DoB: "); string tempDoB = Console.ReadLine();
                        Console.Write("Student Mail: "); string tempEmail = Console.ReadLine();
                        Console.Write("Student Address: "); string tempAddress = Console.ReadLine();
                        Console.Write("Student Batch: "); string tempBatch = Console.ReadLine();
                        i.ID = tempID; i.Name = tempName; i.DoB = tempDoB; i.Email = tempEmail; i.Address = tempAddress; i.Batch = tempBatch;
                        Console.WriteLine("Updated sucessfully");
                        Console.WriteLine("nPress any button to get back to student menu.");
                        Console.ReadKey();
                        StudentMenu();
                    }
                    else
                    {
                        Console.WriteLine("No ID found. Please enter ID again.");
                        Console.Write("Enter ID :");
                        temp = Console.ReadLine();
                    }
                }
            }
        }

        // Use methods inherited from human to use the return mainmenu function
        public override void Back()
        {
            Console.Clear();
            mainmenu.MainMenu();
        }
    }
}
    
