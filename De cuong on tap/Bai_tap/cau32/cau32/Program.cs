using System;
abstract public class Animal
{
    public Animal(string name)
    {
        this.name = name;
    }
    // phương thức trừu tượng minh họa việc
    // đưa tên của đối tượng
    abstract public void Who();
    // biến thành viên protected
    protected string name;
}

// lớp Dog dẫn xuất từ lớp Animal
public class Dog : Animal
{
    // hàm khởi dựng lấy hai tham số
    public Dog(string name, string color) : base(name)
    {
        this.color = color;
    }
    // phủ quyết phương thức trừu tượng Who()
    public override void Who( )
    {
        Console.WriteLine("Gu gu! Toi la {0} co mau long {1}", name, color);
    }
    // biến private của lớp
    private string color;
}

public class Cat : Animal
{
    // hàm khởi dựng lấy hai tham số
    public Cat(string name, int weight) : base(name)
    {
        this.weight = weight;
    }
    // phủ quyết phương thức trừu tượng Who()
    public override void Who( )
    {
        Console.WriteLine("Meo meo! Toi la {0} can nang {1}", name, weight);
    }
    // biến private của lớp
    private int weight;
}
public class Tester
{
    static void Main()
    {
        Animal[] Arr = new Animal[3];
        Arr[0] = new Dog("Lu Lu", "Vang");
        Arr[1] = new Cat("Mun", 5);
        Arr[2] = new Cat("MiuLe", 7);
        //Arr[2] = new Animal("Noname");
        for( int i=0; i <3 ; i++)
        {
            Arr[i].Who();
        }
    }
}
