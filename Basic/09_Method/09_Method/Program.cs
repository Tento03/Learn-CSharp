public class Program
{
    //Without Parameter
    static void Hello()
    {
        Console.WriteLine("Hello");
    }
    
    //With Parameter
    static void myProfile(string name,int age)
    {
        Console.WriteLine("My name is " + name + " and my age is " + age);
    }

    //Return value
    static int sumMyNum(int x,int y)
    {
        return x + y;
    }

    //override method
    static double sumMyNum(double x,double y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        Hello();
        myProfile("Tento", 21);

        int resultSumInt = sumMyNum(2, 3);
        Console.WriteLine("The result of sum my num method is: "+resultSumInt);

        double resultSumDouble = sumMyNum(2.5, 3.5);
        Console.WriteLine("The result of sum my num method is: " + resultSumDouble);
    }
}