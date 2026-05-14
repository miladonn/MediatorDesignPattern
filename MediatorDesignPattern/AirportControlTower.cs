namespace MediatorDesignPattern;

public class AirportControlTower : IAirTrafficMediator
{
    public void SendMessage(string message, Aircraft sender)
    {
        Console.WriteLine($"\n[Control Tower received]: {message}");

        if (message.Contains("landing"))
        {
            Console.WriteLine($"Control Tower: {sender.Name}, you are cleared to land.");
        }
        else if (message.Contains("takeoff"))
        {
            Console.WriteLine($"Control Tower: {sender.Name}, you are cleared for takeoff.");
        }
    }
}