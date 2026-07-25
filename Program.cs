try
{
    Console.WriteLine("Ingrese primer número:");
    double n1 = double.Parse(Console.ReadLine() ?? "0");

    Console.WriteLine("Ingrese segundo número:");
    double n2 = double.Parse(Console.ReadLine() ?? "0");

    double division = n1 / n2;

    //Console.WriteLine("La división es: " + division);
    Console.WriteLine($"La división es: {division}"); // Interpolación
    Console.WriteLine();

    List<string> lista = new List<string>()
    {
        "Matemáticas",
        "Español",
        "Música"
    };

    lista.Add("Programación II");
    lista.Add("Ciencias Naturales");
    lista.Insert(0, "Historia de Honduras");
    lista.Add("Programación II");
    lista.Add("Programación II");
    lista.Add("Programación II");
    //lista.Remove("Programación II");
    //lista.RemoveAll(nombre => nombre.Contains("Programación II"));

    foreach (string item in lista)
    {
        Console.WriteLine(item);
    }
    //Console.WriteLine(lista[9]);


    Console.WriteLine();

    Dictionary<string, int> edades = new Dictionary<string, int>()
    {
        {"Juan Perez", 18},
        {"Carlos Perez", 25}
    };
    
    edades.Add("Sandra Perez", 30);
    edades.Add("juan perez", 19);

    foreach (var item in edades)
    {
        Console.WriteLine($"Key: {item.Key}, Valor: {item.Value}");
    }
    Console.WriteLine(edades["Juan Perez"]);
}
catch (FormatException fe)
{
    Console.WriteLine($"Error de tipo de formato: {fe.Message}");
}
catch (ArgumentOutOfRangeException fe)
{
    Console.WriteLine($"Error de índice incorrecto: {fe.Message}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}