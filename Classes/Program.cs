using Classes;

namespace CarConsole
{
    public class Program
    {
       static void Main(string[] args)
       {
            Car theCar = new Car();
            theCar.Make = "Ford";
            theCar.Model = "F150";
            theCar.Year = "2022";
            
            Console.WriteLine(theCar.Year);
            Console.WriteLine(theCar.Make);
            Console.WriteLine(theCar.Model);    
            
            
            Console.ReadLine();
                

       }
    }
}
