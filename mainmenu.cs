using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    class mainmenu
    {
        public static void MainMenu() // This method create the user interface and change to submenu as user choose
        {
            student stu = new student();
            lecturer lec = new lecturer();
            Console.Clear();
            Console.WriteLine("====================");
            Console.WriteLine("1. Manage Students");
            Console.WriteLine("2. Manage Lecturers");
            Console.WriteLine("3. Exit");
            Console.WriteLine("====================");
            Console.Write("Please select a submenu: ");
            string mainMenuSelect = Console.ReadLine();
            switch (mainMenuSelect) 
             // Divide submenu into different cases
            {
                case "1":
                    stu.StudentMenu();
                    break;
                case "2":
                    lec.LecturerMenu();
                    break;
                case "3":
                    break;
            }
        }
    }
}
