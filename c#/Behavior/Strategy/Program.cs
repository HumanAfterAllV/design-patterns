using Context;
using Model;
using Strategy;

class Program
{
    static void Main(string[] args)
    {
        // Crea ubicaciones
        var origin = new Location(19.4326, -99.1332);        // CDMX
        var destination = new Location(20.6597, -103.3496);  // Guadalajara

        // Crea un delivery
        var delivery = new Delivery(origin, destination, 250); // 250kg

        // Selecciona una estrategia (por carretera con velocidad 80 km/h)
        var roadRoute = new RoadRute(80);

        // Usa el contexto
        var context = new DeliveryContext(roadRoute);

        // Obtén el tiempo estimado
        double estimatedTime = context.GetEstimatedTime(delivery);

        // Output
        Console.WriteLine(delivery);
        Console.WriteLine($"Tiempo de entrega estimado: {estimatedTime:F2} horas");
    }
}
