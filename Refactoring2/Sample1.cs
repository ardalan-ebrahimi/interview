public interface IWorker
{
    void Work();
    void Eat();
    void Sleep();
}

public class Worker : IWorker
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Working...");
    }

    public void Eat()
    {
        throw new Exception("I don't eat");
    }

    public void Sleep()
    {
        throw new Exception("I don't sleep.");
    }
}

class Program_Example1
{
    static void Main()
    {
        IWorker worker = new Worker();
        IWorker robot = new Robot();

        worker.Work();
        worker.Eat();
        worker.Sleep();

        robot.Work();
        robot.Eat();
        robot.Sleep();
    }
}
