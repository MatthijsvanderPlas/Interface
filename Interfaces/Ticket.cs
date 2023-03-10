namespace Interfaces;

public class Ticket : IEquatable<Ticket>
{
    public int DurationHours { get; set; }

    public Ticket(int durationHours)
    {
        DurationHours = durationHours;
    }

    public bool Equals(Ticket? other)
    {
        if (other == null) throw new ArgumentNullException(nameof(other));
        return this.DurationHours == other.DurationHours;
    }
}   