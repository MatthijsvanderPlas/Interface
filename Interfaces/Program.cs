namespace Interfaces;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        Ticket t1 = new Ticket(10);
        Ticket t2 = new Ticket(15);

        Console.WriteLine(t1.Equals(t2));
    }
}