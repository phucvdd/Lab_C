using System;
using System.Text.RegularExpressions;
// Huy
namespace Lab_C
{
    public class Marks_Subject : Marks ,IMarks
    {
        private string _rollNo;
        public string RollNo
        {
            get { return _rollNo; }
            set
            {
                string rollnum = value;

                if (!rollnum.StartsWith("A"))
                {
                    System.Console.Write("The first character must be A!");
                    System.Console.Write("Input again: ");
                    rollnum = Console.ReadLine();
                }


                _rollNo = rollnum;
            }
        }
        private string _studentName;
        public string StudentName
        {
            get { return _studentName; }
            set
            {
                string name = value;

                while (name.Length > 50)
                {
                    if (name.Length > 50)
                    {
                        System.Console.Write("Name only have 50 character! Input again: ");
                        name = Console.ReadLine();
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
