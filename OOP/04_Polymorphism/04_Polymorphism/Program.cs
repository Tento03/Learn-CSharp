public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("The Animals have different sound based on their kind");
    }
}

public class Dog:Animal
{
    public override void Sound()
    {
        Console.WriteLine("guk guk guk");
    }
}

public class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Meow meow meow");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Animal animal1 = new Dog();
        Animal animal2 = new Cat();

        animal1.Sound();
        animal2.Sound();
    }
}