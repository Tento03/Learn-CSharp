int myInt = 10;
double myDouble = 10.5;
string myString = "Tento";
bool myBool = true;

Console.WriteLine("Int:" + myInt);
Console.WriteLine("Double:" + myDouble);

Console.WriteLine("Doube to Int:" + Convert.ToInt64(myDouble));
Console.WriteLine("Bool to String:" + Convert.ToString(myBool));