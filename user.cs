namespace Class2Hw
{
    class User: Contact
    {
       
        public User(){

            Console.WriteLine("Enter the Name");
            Name=Console.ReadLine();
            Console.WriteLine("Enter the Age");
            Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Mobile No.");
            MobileNo=long.Parse(Console.ReadLine());

        }
        public override void View(){
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(MobileNo);

        }
        public override void Update(){
            Console.WriteLine("Enter the Name");
            Name=Console.ReadLine();
            Console.WriteLine("Enter the Age");
            Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Mobile No.");
            MobileNo=long.Parse(Console.ReadLine());
             Console.WriteLine("Contact Updated Sucessfully");
        }
    }

}