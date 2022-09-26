namespace Lab_C
{
    public class People
    {
        private int _idCard;
        public int IdCard
        {
            get { return _idCard; }
            set {
                int id = value;
                while (id != 9)
                {
                    System.Console.WriteLine("ID Card must be a number and has 9 digits!");
                    System.Console.WriteLine("Enter again: ");
                    id = int.Parse(System.Console.ReadLine());
                } 
                _idCard = value; 
                }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { 
                string name = value;
                while (name.Length >50)
                {
                    System.Console.WriteLine("Fullname most 50 character!");
                    System.Console.WriteLine("Enter again: ");
                    name = System.Console.ReadLine();
                }
                _name = value; 
                }
        }

       
        
        
        
    }
}