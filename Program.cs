Console.WriteLine("=================================");
Console.WriteLine("   SOPORTE ACADÉMICO");
Console.WriteLine("=================================");

string codigo;
string nombre;
string tipoConsulta;
string descripcion;

Console.WriteLine("Ingrese el código del estudiante:");
codigo = Console.ReadLine();

Console.WriteLine("Ingrese el nombre del estudiante:");
nombre = Console.ReadLine();

Console.WriteLine("Ingrese el tipo de consulta:");
tipoConsulta = Console.ReadLine();

Console.WriteLine("Ingrese una descripción:");
descripcion = Console.ReadLine();

Console.WriteLine("\nSOLICITUD REGISTRADA");
Console.WriteLine("Código: " + codigo);
Console.WriteLine("Nombre: " + nombre);
Console.WriteLine("Tipo de consulta: " + tipoConsulta);
Console.WriteLine("Descripción: " + descripcion);