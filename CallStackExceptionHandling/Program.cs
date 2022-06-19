using CallStackExceptionHandlingLib;
using static System.Console;


WriteLine("In Main");
Alpha();

static void Alpha()
{
    try
    {
        WriteLine("In Alpha");
        Beta();
    }
    catch (Exception e)
    {
        WriteLine("Caught In Alpha");
        WriteLine(e.Message);
        throw;
    }
}

static void Beta()
{
    WriteLine("In Beta");
    Calculator.Gamma();
}