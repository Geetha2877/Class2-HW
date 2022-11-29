namespace Class2Hw
{
    class User: Contact
    {
        private string Name{get;set;}
        private int Age{get;set;}
        private int MobileNo{get;set;}
        public User(){

            Console.WriteLine("Enter the Name");
            Name=Console.ReadLine();
            Console.WriteLine("Enter the Age");
            Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Mobile No.");
            MobileNo=Convert.ToInt32(Console.ReadLine());

        }
        public override void View(){
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(MobileNo);

        }
        public override void Update(){
            Console.WriteLine("Enter the Name");
            string Name=Console.ReadLine();
            Console.WriteLine("Enter the Age");
            int Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Mobile No.");
            int MobileNo=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Contact Updated Sucessfully");
        }
    }

}