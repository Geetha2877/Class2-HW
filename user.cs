namespace Class2Hw
{
    class User: Contact
    {
       
        public User(){
            try{
                Console.WriteLine("Enter the Name");
                Name=Console.ReadLine();

                Console.WriteLine("Enter the Age");
                Age=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Mobile No.");
                MobileNo=long.Parse(Console.ReadLine());
            } 
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                System.Environment.Exit(0);  
            }

        }
        public override void View(){
            Console.WriteLine("Name : "+Convert.ToString(Name));

            Console.WriteLine("Age : "+ Convert.ToString(Age));

            Console.WriteLine("MobileNo: "+Convert.ToString(MobileNo));

        }
        public override void Update(){

            try{
            
                Console.WriteLine("Enter the Name");
                Name=Console.ReadLine();

                Console.WriteLine("Enter the Age");
                Age=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Mobile No.");
                MobileNo=long.Parse(Console.ReadLine());

                Console.WriteLine("Contact Updated Sucessfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                System.Environment.Exit(0);  
            }
        }
    }

}