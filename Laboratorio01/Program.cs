using System;

class Program
{
    static void Main(string[] args)
    {
        const int max_materias = 6;
        string nombre;
        int edad;
        string carrera;
        string carne;
        string correo;
        string telefono;
        double promedio;
        int materias;

        Console.WriteLine("========================================");
        Console.WriteLine("        REGISTRO DE ESTUDIANTE         ");
        Console.WriteLine("========================================");

        Console.Write("Digite su nombre completo: ");
        nombre = Console.ReadLine()!;

        Console.Write("Digite su edad: ");
        edad = int.Parse(Console.ReadLine()!);

        Console.Write("Digite su carrera: ");
        carrera = Console.ReadLine()!;

        Console.Write("Digite su carné: ");
        carne = Console.ReadLine()!;

        Console.Write("Digite su correo electrónico: ");
        correo = Console.ReadLine()!;

        Console.Write("Digite su número de teléfono: ");
        telefono = Console.ReadLine()!;

        Console.Write("Digite su promedio: ");
        promedio = double.Parse(Console.ReadLine()!);

        Console.Write("Digite el número de materias inscritas: ");
        materias = int.Parse(Console.ReadLine()!);

        int edadFutura = edad + 5;
        bool puedeInscribir = materias < max_materias;

        Console.Clear();
        Console.WriteLine("========================================");
        Console.WriteLine("        REGISTRO DE ESTUDIANTE         ");
        Console.WriteLine("========================================");
        Console.WriteLine($"Bienvenido(a), {nombre}");
        Console.WriteLine();
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Edad dentro de 5 años: {edadFutura} años");
        Console.WriteLine();
        Console.WriteLine($"Carrera: {carrera}");
        Console.WriteLine($"Carné: {carne}");
        Console.WriteLine($"Correo: {correo}");
        Console.WriteLine($"Teléfono: {telefono}");
        Console.WriteLine();
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Materias inscritas: {materias}");
        Console.WriteLine($"Máximo permitido: {max_materias}");
        Console.WriteLine();
        Console.WriteLine($"Puede inscribir más materias: {(puedeInscribir ? "Sí" : "No")}");
        Console.WriteLine();
        Console.WriteLine("==============================================");
        Console.WriteLine("Gracias por utilizar el sistema.");
        Console.WriteLine("==============================================");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
