using System.IO;
using System.Text;
// See https://aka.ms/new-console-template for more information



string directory = Environment.GetEnvironmentVariable("DIRECTORY");
string fileName = Environment.GetEnvironmentVariable("FILENAME");

if (Directory.Exists(directory))
{

    StringBuilder builder = new StringBuilder();

    for (int i = 0; i < 10; i++)
    {
        builder.AppendLine($"Linea de prueba {i + 1}");
    }

    File.WriteAllText(Path.Combine(directory, fileName), builder.ToString());
}
else
{
    Console.WriteLine("Ya trono como cohete");
}



Console.WriteLine($"El directorio donde se almacenara es: {directory}");
Console.WriteLine($"El Nombre del archivo es: {fileName}");
System.Console.Read();