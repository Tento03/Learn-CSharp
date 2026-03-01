interface IPayment
{
    void Process();
}



public class TransferBank:IPayment
{
    public void Process()
    {
        Console.WriteLine("Transfer bank is processing");
    }
}

public class EWallet : IPayment
{
    public void Process()
    {
        Console.WriteLine("E wallet is processing");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        IPayment payment1 = new TransferBank();
        IPayment payment2 = new EWallet();

        payment1.Process();
        payment2.Process();
    }
}