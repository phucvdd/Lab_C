using System;
// Khang
namespace Lab_C_
{
    abstract class Marks
    {
        private int _passLevel;
        public int PassLevel
        {
            get { return _passLevel; }
            set
            {
                int lv = value;
                while (lv < 40 || lv > 100)
                {
                    System.Console.WriteLine("Pass level is in range [4;100]!");
                    System.Console.Write("Input again: ");
                    lv = Int32.Parse(Console.ReadLine());
                }
                _passLevel = lv;
            }
        }


        private int _mark;
        public int Mark
        {
            get { return _mark; }
            set
            {
                int mark = value;
                while (mark < 0 || mark > 100)
                {
                    System.Console.WriteLine("Mark value is in range [0;100]!");
                    System.Console.Write("Input again: ");
                    mark = Int32.Parse(Console.ReadLine());
                }
                _mark = mark;
            }
        }
        public bool checkPass()
        {
            if (_mark < _passLevel) return false;
            else return true;
        }
        public abstract bool getBonus();
    }
}