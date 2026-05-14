namespace MediatorDesignPattern;

public class Plane : Aircraft
{
    public Plane(string name, IAirTrafficMediator mediator)
        : base(name, mediator)
    {
    }
}