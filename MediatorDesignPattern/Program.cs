namespace MediatorDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        AirportControlTower tower = new AirportControlTower();

        Plane plane1 = new Plane("Plane A", tower);
        Helicopter heli1 = new Helicopter("Helicopter H1", tower);
        Plane plane2 = new Plane("Plane B", tower);
        Helicopter heli2 = new Helicopter("Helicopter H2", tower);

        plane1.Send("Requesting landing");
        heli1.Send("Requesting takeoff");
        plane2.Send("Requesting takeoff");
        heli1.Send("Requesting landing");
        heli2.Send("Requesting takeoff");

        Console.ReadLine();
        
    }
}