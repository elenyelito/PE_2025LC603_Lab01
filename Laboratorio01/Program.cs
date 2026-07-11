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
        Console.WriteLine("     REGISTRO DE ESTUDIANTES");
        Console.WriteLine("========================================");

        Console.Write("Digite su nombre completo: ");
        nombre = Console.ReadLine()!;

        Console.Write("Digite su edad: ");
        edad = int.Parse(Console.ReadLine()!);

        Console.Write("Digite su carrera: ");
        carrera = Console.ReadLine()!;

        Console.Write("Digite su carné: ");
        carne = Console.ReadLine()!;

        Console.Write("Digte su correo electrónico: ");
        correo = Console.ReadLine()!;

        Console.Write("Digite su promedio: ");
        promedio = double.Parse(Console.ReadLine()!);

        Console.Write("Digite el número de materias inscritas: ");
        materias = int.Parse(Console.ReadLine()!);
        
        Console.WriteLine();
        Console.WriteLine("Captura de datos realizada correctamente...");
    }
}