using System.ComponentModel.DataAnnotations;

public class SimuladorTarifa
{
    public static void Main(string[] args)
    {
        string nombre, nombreVehiculo;
        double distancia, tarifaBase = 0.0, costoKm = 0.0, subtotal = 0.0, descuento = 0.0, total = 0.0;
        int horas, tipoVehiculo;
        bool esHoraPico;

        Console.WriteLine("==============================================");
        Console.WriteLine("         InDrive - Simulador de Tarifa        ");
        Console.WriteLine("==============================================");

        Console.WriteLine("Nombre del Pasajero: ");
        nombre = Console.ReadLine();

        Console.WriteLine("Distancia del viaje (en KM): ");
        distancia = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Hora de Salida (0 - 23 hrs): ");
        horas = int.Parse(Console.ReadLine());

        Console.WriteLine("\nTipo de Vehiculo: ");
        Console.WriteLine("1. Economico ");
        Console.WriteLine("2. Confort: ");
        Console.WriteLine("3. Premium: ");
        Console.WriteLine("4. Moto: ");
        Console.WriteLine("Ingrese una opcion: ");
        tipoVehiculo = int.Parse(Console.ReadLine());
        

        switch(tipoVehiculo)
        {
            case 1:
                nombreVehiculo = "Economico";
                tarifaBase = 2.0;
                costoKm = 1.5;

                break;
            case 2:
                nombreVehiculo = "Confort";
                tarifaBase = 3.0;
                costoKm = 2.0;

                break;
            case 3:
                nombreVehiculo = "Premium";
                tarifaBase = 5.0;
                costoKm = 3.0;

                break;
            case 4:
                nombreVehiculo = "Moto";
                tarifaBase = 1.5;
                costoKm = 1.0;

                break;
            default:
                Console.WriteLine("Opcion no valida. Fin del programa");
                return;
        }
        
        subtotal = tarifaBase + (costoKm * distancia);

        if ((horas >= 7 && horas <= 9) || (horas >=17 && horas <= 20))
        {
            esHoraPico = true;
            subtotal = subtotal * 1.30;
        }

        if (distancia > 15)
        {
            descuento = subtotal * 0.05;
            subtotal = subtotal - descuento;
        }

        total = Math.Round(Math.Max(subtotal, 5.00), 2);

        Console.WriteLine("==============================================");
        Console.WriteLine("              RESUMEN DEL VIAJE               ");
        Console.WriteLine("==============================================");
        Console.WriteLine("Pasajero: " + nombre);
        Console.WriteLine("Vehiculo: " + nombreVehiculo);
        Console.WriteLine("Distancia: " + distancia + " km.");
        Console.WriteLine("Hora Pico: " + (esHoraPico?"Si (+30%)":"No")); //inline if --> condicional? es verdad : es falso;
        if (descuento > 0)
        {
            Console.WriteLine("Descuento: S/." + Math.Round(descuento,2));    
        }
        Console.WriteLine("==============================================");
        Console.WriteLine("La tarifa final es: S/." + total);
        Console.WriteLine("==============================================");
    }
}