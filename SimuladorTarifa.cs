public class SimuladorTarifa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==============================================");
        Console.WriteLine("         InDrive - Simulador de Tarifa        ");
        Console.WriteLine("==============================================");

        Console.WriteLine("Nombre del Pasajero: ");
        string nombre = Console.ReadLine();

        Console.WriteLine("Distancia del viaje (en KM): ");
        double distancia = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Hora de Salida (0 - 23 hrs): ");
        int horas = int.Parse(Console.ReadLine());

        Console.WriteLine("\nTipo de Vehiculo: ");
        Console.WriteLine("1. Economico ");
        Console.WriteLine("2. Confort: ");
        Console.WriteLine("3. Premium: ");
        Console.WriteLine("4. Moto: ");
        Console.WriteLine("Ingrese una opcion: ");
        int tipo = int.Parse(Console.ReadLine());
        
        
    }
}