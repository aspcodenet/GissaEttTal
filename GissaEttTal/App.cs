public class App
{
    public void Run()
    {
        var random = new Random();
        Console.WriteLine("Gissa ett tal mellan 1 och 100.");
        int secretNumber = random.Next(0,100);
        Console.WriteLine(secretNumber);
        while (true)
        {
            int tal = Convert.ToInt32(Console.ReadLine());
            if (tal == secretNumber)
                break;
        }
    }
}



