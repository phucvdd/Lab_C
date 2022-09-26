//trinh nè 
namespace Lab_C
{
    class Subject
    {
        private string _subjectCode;
        public string SubjectCode
        {
            get { return _subjectCode; }
            set { 
                string sc = value;
                while (sc.Length != 6)
                {
                    System.Console.WriteLine("Subject code must have 6 characters!");
                    System.Console.Write("Enter again: ");
                    sc = System.Console.ReadLine();
                }
                 _subjectCode = sc;
             }
        }

        private string _subjectName;
        public string SubjectName
        {
            get { return _subjectName; }
            set { 
                string sn = value;
                while (sn.Length > 50)
                {
                    System.Console.WriteLine("Subject name has most 50 characters!");
                    System.Console.Write("Enter again: ");
                    sn = System.Console.ReadLine();
                }
                value = _subjectName;
            }
        }

        private int _theory;
        public int Theory
        {
            get { return _theory; }
            set {
                int numberOfTheory = value; 
                if (numberOfTheory <= 0 || numberOfTheory>=100)
                while (numberOfTheory <= 0 || numberOfTheory>=100)
                {
                    System.Console.WriteLine("Number of theory lessons 0<=Theory <=100");
                    System.Console.Write("Enter again: ");
                    numberOfTheory = int.Parse(System.Console.ReadLine());
                }
                _theory = value; 
                }
        }
        
        private int _practice;
        public int Practice
        {
            get { return _practice; }
            set {
                int numberofPractice = value;
                while (numberofPractice <= 0 || numberofPractice>=100)
                {
                    System.Console.WriteLine("Number of theory lessons 0<=Theory <=100");
                    System.Console.Write("Enter again: ");
                    numberofPractice = int.Parse(System.Console.ReadLine());
                }
                _practice = value; 
                }
        }

        public void getTotalLessons(){
            int total;
            total = _theory + _practice;
        }

        public override string ToString()
        {
            Subject subject = new Subject();
            string s = "Subject Code: " + subject._subjectCode + "Subject Name: " + subject._subjectName + "Number of theory: " + subject._theory + "Number of practice: " + subject._practice;
            return s;
        }

        public void inputSubject(){
            System.Console.WriteLine("Enter subject code: ");
            _subjectCode = System.Console.ReadLine();
            System.Console.WriteLine("Enter subject name: ");
            _subjectName = System.Console.ReadLine();
            System.Console.WriteLine("Enter number of theory: ");
            _theory = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter number of theory: ");
            _practice = int.Parse(System.Console.ReadLine());
        }

        public void printInfo(){
            System.Console.WriteLine("Information about subject: ");
            System.Console.WriteLine("Subject code: " + _subjectCode);
            System.Console.WriteLine("Subject name: " + _subjectName);
            System.Console.WriteLine("Number of theory: " + _theory);
            System.Console.WriteLine("Number of practice: " + _practice);
        }
    }
}

    
