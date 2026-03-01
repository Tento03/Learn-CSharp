public class Car
{
    //Properties
    public string name;
    public int ccTank;

    public void Profile()
    {
        Console.WriteLine("The car name is: " + name);
        Console.WriteLine("The cc tank is: " + ccTank);
    }

    public void Producer(string boss)
    {
        Console.WriteLine("My Producer is:" + boss);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        //Making a new object
        Car car = new Car();

        car.name = "avanza";
        car.ccTank = 200;
        car.Profile();
        car.Producer("toyota");

        Console.WriteLine("=============================");

        car.name = "ferrari";
        car.ccTank = 500;
        car.Profile();
        car.Producer("mitsubishi");
    }
}