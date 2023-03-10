namespace InterfaceDemo1;

public class Car : Vehicle, IDestroyable
{
    public string DestructionSound { get; set; }
    public List<IDestroyable> DestroyablesNearby;

    public Car(float speed, string color)
    {
        this.Speed = speed;
        this.Color = color;
        DestructionSound = "CarExplosionSound.mp3";
        DestroyablesNearby = new List<IDestroyable>();
    }

    public void Destroy()
    {
        Console.WriteLine($"Playing destruction sound {DestructionSound}");
        Console.WriteLine("Create fire");

        foreach (IDestroyable destroyabe in DestroyablesNearby)
        {
            destroyabe.Destroy();
        }
    }
}