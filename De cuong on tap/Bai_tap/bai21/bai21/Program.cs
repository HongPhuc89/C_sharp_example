using System;
class VD1
{
    public string first;
}
class Tester
{
    public static void Main()
    {
    VD1 vd = new VD1();
    Console.Write("Nhap vao mot chuoi: ");
    vd.first = Console.ReadLine();
    Console.Write("Chuoi nhap vao: {0}", vd.first);
    }
}


