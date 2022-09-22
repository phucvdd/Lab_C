namespace Lab_C
{
    public class Subject
    {
        private string _subjectCode;
        public string SubjectCode
        {
            get { return _subjectCode; }
            set { 
                string sc = value;
                if (sc.Length != 6)
                {
                    System.Console.WriteLine("Subject code must have 6 characters!");
                    System.Console.Write("Enter again: ");
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
                if (sn.Length > 50)
                {
                    System.Console.WriteLine("Subject name has most 50 characters!");
                    System.Console.Write("Enter again: ");
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
                {
                    System.Console.WriteLine("Number of theory lessons 0<=Theory <=100");
                    System.Console.Write("Enter again: ");
                    
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
                if (numberofPractice <= 0 || numberofPractice>=100)
                {
                    System.Console.WriteLine("Number of theory lessons 0<=Theory <=100");
                    System.Console.Write("Enter again: ");
                } 
                _practice = value; 
                }
        } 
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Subject sb = new Subject();
            
            sb.SubjectCode = "";
            
            
        }
    }
}