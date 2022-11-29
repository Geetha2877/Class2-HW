namespace Class2Hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
        User me = new User();
       

        Console.WriteLine("Choose 1 to View data or 2 to Update data and 0 to exit");
        int option=Convert.ToInt32(Console.ReadLine());
        if(option==1){
                 me.View();
               
                Console.WriteLine("Choose 1 to View data or 2 to Update data and 0 to exit");
                option=Convert.ToInt32(Console.ReadLine());
                
        }
        else if(option==2){
                me.Update();  
                me.View();
                Console.WriteLine("Choose 1 to View data or 2 to Update data and 0 to exit");
                option=Convert.ToInt32(Console.ReadLine());
                   
        }
        else if(option==0){
            System.Environment.Exit(0);  
        }
        else {
        Console.WriteLine("Choose 1 to View data or 2 to Update data and 0 to exit");
        }
        
  
      
        }
    }
}