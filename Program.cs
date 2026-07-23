try
{
    Console.WriteLine("Ingrese primer número:");
    double n1 = double.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Ingrese segundo número:");
    double n2 = double.Parse(Console.ReadLine() ?? "0");

    double division = n1 / n2;

    //Console.WriteLine("La división es: " + division);
    Console.WriteLine($"La división es: {division}"); // Interpolación
}
catch (FormatException fe)
{
    Console.WriteLine($"Error de tipo de formato: {fe.Message}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}