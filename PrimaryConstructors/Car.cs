using System.Security.AccessControl;

namespace PrimaryConstructors;

public class Trip(decimal distance)
{
    public decimal Distance => distance;
}

public class Car(string make, string model, IEnumerable<Trip> trips)
{
    public string MakeModel => $"{make} {model}";
    public decimal DistanceTraveled => trips.Sum(t => t.Distance);
}