using Types;
using static System.Console;

Person bob = new("Earth");

bob.FirstName = "Bob Smith";
bob.BirthDate = new DateTime(1965, 12, 22); // C# 1.0 or later
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.
StatueOfZeusAtOlympia;

Person alice = new(homePlanet: "Mars")
{
    FirstName = "Alice Jones",
    BirthDate = new(1998, 3, 7) // C# 9.0 or later
};

Person Sam = new(initialName: "Parsa", homePlanet: "Mars");

WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy} and his home planet is {2}",
arg0: bob.FirstName,
arg1: bob.BirthDate,
arg2: bob.HomePlanet);

WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy} and her human planet is {2}",
arg0: alice.FirstName,
arg1: alice.BirthDate,
arg2: alice.HomePlanet);

bob.WriteToConsole();

Console.WriteLine(bob.GetOrigin());

alice.WriteToConsole();

Console.WriteLine(alice.GetOrigin());

WriteLine(
format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
arg0: bob.FirstName,
arg1: bob.FavoriteAncientWonder,
arg2: (int)bob.FavoriteAncientWonder);

BankAccount jonesAccount = new(); // C# 9.0 and later
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine(format: "{0} earned {1:C} interest.",
arg0: jonesAccount.AccountName,
arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98;

WriteLine(format: "{0} earned {1:C} interest.",
arg0: gerrierAccount.AccountName,
arg1: gerrierAccount.Balance * BankAccount.InterestRate);

Console.WriteLine(OptionalParameters());
Console.WriteLine(OptionalParameters(command: "Hello", number: 10, active: true));

int d = 10;
int e = 20;

WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");

// simplified C# 7.0 or later syntax for the out parameter

PassingParameters(d, ref e, out int f);
WriteLine($"After: d = {d}, e = {e}, f = {f}");


string OptionalParameters(
string command = "Run!",
double number = 0.0,
bool active = true)
{
    return string.Format(
    format: "command is {0}, number is {1}, active is {2}",
    arg0: command,
    arg1: number,
    arg2: active);
}

void PassingParameters(int x, ref int y, out int z)
{
    // out parameters cannot have a default
    // AND must be initialized inside the method
    z = 99;

    // increment each parameter
    x++;
    y++;
    z++;
}