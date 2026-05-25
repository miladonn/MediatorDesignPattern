namespace MediatorDesignPattern;

public interface IAirTrafficMediator
{
    void SendMessage(string message, Aircraft sender);
}