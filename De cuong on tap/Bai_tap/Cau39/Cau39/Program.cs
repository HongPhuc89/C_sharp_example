using System;
class TheStruct
{
    public int x;
    public TheStruct()
    {
        x = 10;
    }
}
class TestClass
{
    public static void structtaker(TheStruct s)
    {
        s.x = 5;
    }
    public static void Main()
    {
        TheStruct a = new TheStruct();
        a.x = 1;
        structtaker(a);
        Console.WriteLine("a.x = {0}", a.x);
    }
}
