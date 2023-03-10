namespace InterfaceDemo1;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        Chair officeChair = new Chair("Brown", "Plastic");
        Chair gamingChair = new Chair("Red", "Wood");

        Car damagedCar = new Car(80f, "Blue");
        
        damagedCar.DestroyablesNearby.Add(officeChair);
        damagedCar.DestroyablesNearby.Add(gamingChair);
        
        damagedCar.Destroy();
    }
}