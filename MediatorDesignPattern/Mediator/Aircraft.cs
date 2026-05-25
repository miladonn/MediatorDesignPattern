namespace MediatorDesignPattern;

public abstract class Aircraft
{
    protected IAirTrafficMediator mediator;

    public string Name { get; set; }

    public Aircraft(string name, IAirTrafficMediator mediator)
    {
        Name = name;
        this.mediator = mediator;
    }

    public void Send(string message)
    {
        Console.WriteLine($"\n{Name}: {message}");
        mediator.SendMessage(message, this);
    }
}