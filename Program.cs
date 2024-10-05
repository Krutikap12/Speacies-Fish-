namespace Speacies__Fish_
{
    public class Fish
    {
        public string Species { get; set; }
        public double PricePerFish { get; set; }
    }
    public class FishUtility : Fish
    {
        public void AddFish(string species, double pricePerFish)
        {
            Species = species;
            PricePerFish = pricePerFish;
        }
        public bool BuyFish()
        {
            if( Species == "ClownFish" || Species == "GoldFish")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Double CalculatePrice(int numberOfFishes)
        {
            double additionalCharges=0 ;
         
            if (Species == "ClownFish")
            {
                additionalCharges = 100;
            }
            if (Species == "GoldFish")
            {
                additionalCharges = 150;
            }    
            return ((numberOfFishes * PricePerFish)+additionalCharges);
        }
    }

        
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Species to buy");
            string species = Console.ReadLine();
            Console.WriteLine("Enter the Price Per Fish");
            double pricePerFish = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the no of Fishes you need to buy");
            int numberOfFishes = Convert.ToInt32(Console.ReadLine());
            
            FishUtility fish = new FishUtility();
    
            fish.AddFish(species, pricePerFish);
            
             if(fish.BuyFish())
             {
                double totalPrice = fish.CalculatePrice(numberOfFishes);
                Console.WriteLine($"Total cost is {totalPrice}");
                
             }
            else
            {
                Console.WriteLine("Fish not found");
                
            }
          

           
        }
    }
}
