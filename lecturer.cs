using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    class lecturer : human //use the abstract class human
    {
        List<lecturer> lecturerList = new List<lecturer>(); // create a list to contain lecturers values.
        private string Department;
        public lecturer()
        {

        }

        // Constructor
        public lecturer(string ID, string Name, string Email, string Address, string DoB, string Department) : base(ID, Name, Email, Address, DoB)
        {
            this.Department = Department;
        }

        // Show out the list of submenu of lecture.
        public void LecturerMenu()
        {
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("1. Add new lecturer");
            Console.WriteLine("2. View all lecturers");
            Console.WriteLine("3. Search lecturer");
            Console.WriteLine("4. Delete lecturer");
            Console.WriteLine("5. Update lecturer");
            Console.WriteLine("6. Main menu");
            Console.WriteLine("====================");
            Console.Write("Please select a submenu: ");
            string lecturerMenuSelect = Console.ReadLine();
            switch (lecturerMenuSelect) 
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
            Console.Write("Lecturer ID: "); string tempID = Console.ReadLine();
            Console.Write("Lecturer Name: "); string tempName = Console.ReadLine();
            Console.Write("Lecturer DoB: "); string tempDoB = Console.ReadLine();
            Console.Write("Lecturer Email: "); string tempEmail = Console.ReadLine();
            Console.Write("Lecturer Address: "); string tempAddress = Console.ReadLine();
            Console.Write("Lecturer Department: "); string tempDepartment = Console.ReadLine();
            lecturer lec1 = new lecturer(tempID, tempName, tempEmail, tempAddress, tempDoB, tempDepartment);
            lecturerList.Add(lec1);
            Console.WriteLine("Added successfully!");
            Console.WriteLine("Press any button to get back to lecturer menu.");
            Console.ReadKey();
            LecturerMenu();
        }

        //Use methods inherited from human to use the view function
        public override void View()
        {
            Console.Clear();
            Console.WriteLine("ID\t\t\t\tNAme\t\t\t\tDoB\t\t\t\tEmail\t\t\t\tAddress\t\t\t\t\tDepartment");
            foreach (lecturer i in lecturerList)
            {
                Console.WriteLine("{0,-32}{1,-32}{2,-32}{3,-32}{4,-50}{5,-32}", i.ID, i.Name, i.DoB, i.Email, i.Address, i.Department );
            }
            Console.WriteLine("Press any button to get back to lecturer menu.");
            Console.ReadKey();
            LecturerMenu();
        }

        // Use methods inherited from human to use the search function
        public override void Search()
        {
            Console.Clear();
            Console.Write("Enter ID :");
            String temp = Console.ReadLine();
            while (true)
            {
                foreach (lecturer i in lecturerList)
                {
                    if (i.ID == temp)
                    {
                        Console.WriteLine("ID:\t\t\t\t{0}\nFull Name:\t\t\t{1}\nDepartment:\t\t\t{2}" +
                             "\nDate of Birth:\t\t\t{3}\nEmail:\t\t\t\t{4}\nAddress:\t\t\t{5}", i.ID, i.Name, i.Department, i.DoB, i.Email, i.Address);
                        Console.WriteLine("Press any button to get back to lecturer menu.");
                        Console.ReadKey();
                        LecturerMenu();
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
                foreach (lecturer i in lecturerList)
                {
                    if (i.ID == temp)
                    {
                        lecturerList.Remove(i);
                        Console.WriteLine("Removed sucessfully");
                        Console.WriteLine("Press any button to get back to lecturer menu.");
                        Console.ReadKey();
                        LecturerMenu();
                    }
                    else
                    {
                        Console.WriteLine("No ID found. Please enter ID again.");
                        Console.Write("Enter ID : ");
                        temp = Console.ReadLine();
                    }
                }
            }
        }

        // Use methods inherited from human to use the update function
        public override void Update()
        {
            Console.Clear();
            Console.Write("Enter ID : ");
            String temp = Console.ReadLine();
            while (true)
            {
                foreach (lecturer i in lecturerList)
                {
                    if (i.ID == temp)
                    {
                        Console.Write("Lecturer ID: "); string tempID = Console.ReadLine();
                        Console.Write("Lecturer Name: "); string tempName = Console.ReadLine();
                        Console.Write("Lecturer DoB: "); string tempDoB = Console.ReadLine();
                        Console.Write("Lecturer Mail: "); string tempEmail = Console.ReadLine();
                        Console.Write("Lecturer Address: "); string tempAddress = Console.ReadLine();
                        Console.Write("Lecturer Deparment: "); string tempDepartment = Console.ReadLine();
                        i.ID = tempID; i.Name = tempName; i.DoB = tempDoB; i.Email = tempEmail; i.Address = tempAddress; i.Department = tempDepartment;
                        Console.WriteLine("Updated sucessfully");
                        Console.WriteLine("Press any button to get back to lecturer menu.");
                        Console.ReadKey();
                        LecturerMenu();
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

        // Use methods inherited from human to use the return to main menu function
        public override void Back()
        {
            Console.Clear();
            mainmenu.MainMenu();
        }
    }
}
     
