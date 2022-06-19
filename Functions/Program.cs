//HelloClass helloClass = new HelloClass();

HelloClass.SayHello("Parsa");

Console.WriteLine("{0},{1}",
    arg0: "Parsa",
    arg1: "Amir");

static int FibImperative(int term)
{
    if (term == 1)
    {
        return 0;
    }
    else if (term == 2)
    {
        return 1;
    }
    else
    {
        return FibImperative(term - 1) + FibImperative(term - 2);
    }
}
static int FibFunctional_declarative(int term) =>
    term switch
    {
        1 => 0,
        2 => 1,
        _ => FibFunctional_declarative(term - 1) + FibFunctional_declarative(term - 2)
    };
public static class HelloClass
{
    /// <summary>
    /// Says Hello To Given Name
    /// </summary>
    /// <param name="name">
    /// Says Hello To This Parameter
    /// </param>
    public static void SayHello(string name)
    {
        Console.WriteLine($"Hello {name}");
    }
}
