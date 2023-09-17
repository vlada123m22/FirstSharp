class Car
{
    private string color;
    private int speed;
    private string model;
    private string manufacturer;

    public string Color { get => color; set => color = value; }
    public int Speed { get => speed; set => speed = value; }
    public string Model { get => model; set => model = value; }
    public string Manufacturer { get => manufacturer; set => manufacturer = value; }

    public bool IsMooving(int speed)
    {
        if (speed > 0) return true; else return false;
    }


}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Color = "white";
        Console.WriteLine(car.Color);
        Console.Write("Introduce speed");
        car.Speed = int.Parse(Console.ReadLine());
        if (car.IsMooving(car.Speed)){ Console.WriteLine("Is mooving"); } else { Console.WriteLine("Is not mooving"); }       
    }
}