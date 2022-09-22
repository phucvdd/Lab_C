using System;

namespace Lab_C
{
    class Student
    {
        private string _rollNo;
        public string RollNo
        {
            get { return _rollNo; }
            set
            {
                string rollNo = value;
                while (rollNo.Length != 6)
                {
                    System.Console.WriteLine(" The length of Roll ID is 6!");
                    System.Console.Write("Input again: ");
                    rollNo = Console.ReadLine();
                }

                while (rollNo[0] != 'A')
                {
                    System.Console.WriteLine("The first character is A!");
                    System.Console.Write("Input again: ");
                    rollNo = Console.ReadLine();
                }
                for (int i = 1; i < rollNo.Length; i++)
                {
                    while (rollNo[i] <= '0' || rollNo[i] >= '9')
                    {
                        System.Console.WriteLine("The last characters is digit!");
                        System.Console.Write("Input again: ");
                        rollNo = Console.ReadLine();
                    }
                }
                int num = Int32.Parse(rollNo.Substring(1, rollNo.Length - 1));
                while (num < 12001 || num > 12999)
                {
                    System.Console.WriteLine("The last characters is in range [12001;12999]!");
                    System.Console.Write("Input again: ");
                    rollNo = Console.ReadLine();
                }
            }
        }
        private string _classNo;
        public string ClassNo
        {
            get { return _classNo; }
            set
            {
                string classNo = value;
                while (classNo.Length != 11)
                {
                    System.Console.WriteLine(" The length of class No is 11!");
                    System.Console.Write("Input again: ");
                    classNo = Console.ReadLine();
                }
                while (!classNo.StartsWith("CP") && !classNo.StartsWith("DI") && !classNo.StartsWith("DM"))
                {
                    System.Console.WriteLine("The class No  is start with CP, DI, or DM!");
                    System.Console.Write("Input again: ");
                    classNo = Console.ReadLine();
                }
                for (int i = 2; i < 8; i++)
                {
                    while (classNo[i] <= '0' || classNo[i] >= '9')
                    {
                        System.Console.WriteLine("The 6 characters next is digit!");
                        System.Console.Write("Input again: ");
                        classNo = Console.ReadLine();
                    }
                }
                

            }
        }

    }
}
