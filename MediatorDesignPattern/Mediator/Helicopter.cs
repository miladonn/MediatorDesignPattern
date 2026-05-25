namespace MediatorDesignPattern;

public class Helicopter : Aircraft
{
    public Helicopter(string name, IAirTrafficMediator mediator)
        : base(name, mediator)
    {
    }
}