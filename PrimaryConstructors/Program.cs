using PrimaryConstructors;

var car = new Car("Telsa", "Model 3", new List<Trip>
{
    new(50),
    new(23),
    new(12),
    new(321)
});

Console.WriteLine(
    $"{car.MakeModel} traveled {car.DistanceTraveled} km."
);