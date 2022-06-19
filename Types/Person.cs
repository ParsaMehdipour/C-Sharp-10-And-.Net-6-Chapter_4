using static System.Console;

namespace Types;
public class Person
{
    // read-only fields
    public readonly string HomePlanet;
    public const string Species = "Homo Sapien";
    public string FirstName;
    public DateTime BirthDate;
    public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorldFlag FavoriteAncientWonderFlag;
    public readonly DateTime Instantiated;

    // constructors
    public Person()
    {
        // set default values for fields
        // including read-only fields
        FirstName = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string homePlanet)
    {
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        FirstName = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{FirstName} was born on a {BirthDate:dddd}.");
    }

    public string GetOrigin()
    {
        return $"{FirstName} was born on {HomePlanet}.";
    }


}