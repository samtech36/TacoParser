namespace LoggingKata;

// TODO: Create a TacoBell class
// that conforms to ITrackable
// TODO: Create an instance of the TacoBell class
// TODO: Set the values of the class correctly (Name and Location)
// TODO: Then, return the instance of your TacoBell class


public class TacoBell : ITrackable
{
    public string Name { get; set; }
    public Point Location { get; set; }
}