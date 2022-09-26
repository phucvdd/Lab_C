using System;

namespace Lab_C
{
    public class Student
    {
        private string _rollNo;
        public string RollNo
        {
            get { return _rollNo; }
            set
            {
                bool check;
                string rollNo = value;
                while (true)
                {
                    check = true;
                    if (rollNo.Length != 6)
                    {
                        System.Console.WriteLine(" The length of Roll ID is 6!");
                        System.Console.Write("Input again: ");
                        rollNo = Console.ReadLine();
                        continue;
                    }

                    if (rollNo[0] != 'A')
                    {
                        System.Console.WriteLine("The first character is A!");
                        System.Console.Write("Input again: ");
                        rollNo = Console.ReadLine();
                        continue;
                    }
                    for (int i = 1; i < rollNo.Length; i++)
                    {
                        if (rollNo[i] < '0' || rollNo[i] > '9')
                        {
                            check = false;
                            System.Console.WriteLine("The last characters is digit!");
                            System.Console.Write("Input again: ");
                            rollNo = Console.ReadLine();
                            break;
                        }
                    }
                    if(!check) continue;
                    int num = Int32.Parse(rollNo.Substring(1, rollNo.Length - 1));
                    if (num < 12001 || num > 12999)
                    {
                        System.Console.WriteLine("The last characters is in range [12001;12999]!");
                        System.Console.Write("Input again: ");
                        rollNo = Console.ReadLine();
                        continue;
                    }

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
                bool check;
                while (true)
                {
                    check = true;
                    if (classNo.Length != 11)
                    {
                        System.Console.WriteLine(" The length of class No is 11!");
                        System.Console.Write("Input again: ");
                        classNo = Console.ReadLine();
                        continue;
                    }

                    if (!classNo.StartsWith("CP") && !classNo.StartsWith("DI") && !classNo.StartsWith("DM"))
                    {
                        System.Console.WriteLine("The class No  is start with CP, DI, or DM!");
                        System.Console.Write("Input again: ");
                        classNo = Console.ReadLine();
                        continue;
                    }

                    for (int i = 2; i < 8; i++)
                    {
                        if (classNo[i] < '0' || classNo[i] > '9')
                        {
                            check = false;
                            System.Console.WriteLine("The 6 characters next is digit!");
                            System.Console.Write("Input again: ");
                            classNo = Console.ReadLine();
                            break;
                        }
                    }
                    if(!check) continue;
                    int year = int.Parse(classNo.Substring(2, 4));
                    int month = int.Parse(classNo.Substring(6, 2));

                    System.Console.WriteLine(year + month);
                    if (year > 2022 || year < 1 || month < 1 || month > 12)
                    {
                        System.Console.WriteLine("Time is not valid");
                        System.Console.Write("Input again: ");
                        classNo = Console.ReadLine();
                        continue;
                    }
                    //G/H/I/J/K/F/M
                    if (classNo[8] != 'G' && classNo[8] != 'H' && classNo[8] != 'I' && classNo[8] != 'J' && classNo[8] != 'K' && classNo[8] != 'F' && classNo[8] != 'M')
                    {
                        System.Console.WriteLine("ClassNo is not valid");
                        System.Console.Write("Input again: ");
                        classNo = Console.ReadLine();
                        continue;
                    }

                    for (int i = 9; i < 11; i++)
                    {
                        if (classNo[i] < '0' || classNo[i] > '9')
                        {
                            check = false;
                            System.Console.WriteLine("The 2 last characters is digit!");
                            System.Console.Write("Input again: ");
                            classNo = Console.ReadLine();
                            continue;
                        }
                    }
                    if(!check) continue; 
                    break;
                }
                _classNo = classNo;
            }
        }

    }
}
