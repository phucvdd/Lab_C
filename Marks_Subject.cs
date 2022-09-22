using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Huy
namespace Lab_C_.obj
{
    public class Marks_Subject : Marks, IMarks
    {
        private string _rollNo;
        public int RollNo
        {
            get { return _rollNo; }
            set
            {
                string rollnum = value;

                if (!rollnum.StartsWith("a"))
                {
                    System.Console.Write("The first character must be A!");
                    System.Console.Write("Input again: ");
                    rollnum = MyConsole.ReadLine();
                }


                myVar = value;
            }
        }
        private string _studentName;
        public string StudentName
        {
            get { return _studentName; }
            set
            {
                string name = value;

                while (name.Length() > 50)
                {
                    if (name.Length() > 50)
                    {
                        System.Console.Write("Name only have 50 character! Input again: ");
                        name = Console.Readline();
                    }
                }

                Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
                while (regex.IsMatch(name))
                {
                    if(regex.IsMatch(name)){
                        System.Console.WriteLine("Name must be alphabet character!");
                        System.Console.Write("Input again: ");
                        name = Console.ReadLine();
                    }
                }
                _studentName = name;
            }
        }


    }



}
