using System;

namespace Lab_C
{
    public class Teacher
    {

        private string _teacherCode;
        public string TeacherCode
        {
            get { return _teacherCode; }
            set
            {
                String code = value;
                while (true)
                {
                    if (code.Length != 5)
                    {
                        System.Console.WriteLine("Teacher code is have 5 characters!");
                        System.Console.Write("Input again:");
                        code = Console.ReadLine();
                        continue;
                    }
                    if (!code.StartsWith("A") && !code.StartsWith("B"))
                    {
                        System.Console.WriteLine("Teacher code is not valid");
                        System.Console.Write("Input again:");
                        code = Console.ReadLine();
                        continue;
                    }
                    for (int i = 1; i < 5; i++)
                    {
                        if (code[i] > '9' || code[i] < '0')
                        {
                            System.Console.WriteLine("Teacher code is not valid");
                            System.Console.Write("Input again:");
                            code = Console.ReadLine();
                            continue;
                        }
                    }
                    int vl = int.Parse(code);
                    if (vl == 0)
                    {
                        System.Console.WriteLine("Teacher code is not valid");
                        System.Console.Write("Input again:");
                        code = Console.ReadLine();
                        continue;
                    }
                    break;
                }
                _teacherCode = code;
            }
        }
        private string _joinDate;
        public string JoinDate
        {
            get { return _joinDate; }
            set
            {
                bool IsDate(string tempDate)
                {
                    DateTime fromDateValue;
                    var formats = new[] { "dd/MM/yyyy" };
                    if (DateTime.TryParseExact(tempDate, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out fromDateValue))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                string date = value;
                while (true)
                {
                    if (!IsDate(date))
                    {
                        System.Console.WriteLine("Date is not valid");
                        System.Console.Write("Input again: ");
                        date = Console.ReadLine();
                        continue;
                    }
                    DateTime dt =  DateTime.ParseExact(date, "dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);
                    DateTime crr = DateTime.Now;
                    int compare = DateTime.Compare(dt, crr);
                    // dt > crr
                    if(compare > 0) {
                        System.Console.WriteLine("Date is not valid");
                        System.Console.Write("Input again: ");
                        date = Console.ReadLine();
                        continue;
                    }
                    break;
                }

                _joinDate = date;
            }
        }
        public int getWorkedYear()
        {
            int joinY = int.Parse(this._joinDate.Substring(6, 4));
            DateTime today = DateTime.Now;
            int crr = today.Year;
            return crr - joinY;
        }
    }
}