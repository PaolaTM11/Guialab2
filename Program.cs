class PRogram 
{
    static void Main()
    {
     MostrarMenu();
     Console.WriteLine("=================================");
     Console.WriteLine("   SOPORTE ACADÉMICO");
     Console.WriteLine("=================================");

     string codigo;
     string nombre;
     string tipoConsulta;
     string descripcion;

     Console.WriteLine("Ingrese el código del estudiante:");
     codigo = Console.ReadLine();
     while (codigo == "" || codigo.Length < 5)

    {
       Console.WriteLine("Código inválido.");
       Console.WriteLine("Debe tener al menos 5 caracteres.");
      Console.WriteLine("Ingrese nuevamente el código:");

       codigo = Console.ReadLine();
    }

   Console.WriteLine("Ingrese el nombre del estudiante:");
   nombre = Console.ReadLine();
   while (ValidarTexto(nombre) == false)
    {
    Console.WriteLine("Nombre inválido. No debe estar vacío ni contener números.");
    Console.WriteLine("Ingrese nuevamente el nombre:");
    nombre = Console.ReadLine();
    }

   Console.WriteLine("Ingrese el tipo de consulta:");
   tipoConsulta = Console.ReadLine();
   string[] tipos = { "matricula", "pagos", "constancia", "plataforma", "otro" };

    bool valido = false;

    while (valido == false)
    {
      for (int i = 0; i < tipos.Length; i++)
      {
        if (tipoConsulta == tipos[i])
        {
            valido = true;
        }
      }

      if (valido == false)
      {
        Console.WriteLine("Tipo de consulta incorrecto.");
        Console.WriteLine("Las opciones son: matricula, pagos, constancia, plataforma u otro.");
        Console.WriteLine("Ingrese nuevamente el tipo de consulta:");

        tipoConsulta = Console.ReadLine();
      }
    }

    Console.WriteLine("Ingrese una descripción:");
    descripcion = Console.ReadLine();
    string prioridad = AsignarPrioridad(tipoConsulta);

    Console.WriteLine("\nSOLICITUD REGISTRADA");
     
    Console.WriteLine("Código: " + codigo);
    Console.WriteLine("Nombre: " + nombre);
    Console.WriteLine("Tipo de consulta: " + tipoConsulta);
    Console.WriteLine("Descripción: " + descripcion);
    Console.WriteLine("Prioridad:"+prioridad);
    }


  static void MostrarMenu()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("       SOPORTE ACADÉMICO");
        Console.WriteLine("=================================");
        Console.WriteLine("1. Registrar solicitud");
        Console.WriteLine("2. Mostrar solicitudes");
        Console.WriteLine("3. Salir");
     }    

   static string AsignarPrioridad(string tipoConsulta)
   {
     if (tipoConsulta == "matricula")
     {
        return "Alta";
     }
     else if (tipoConsulta == "pagos")
     {
        return "Alta";
    }
     else if (tipoConsulta == "plataforma")
     {
        return "Alta";
     }
     else if (tipoConsulta == "constancia")
     {
        return "Media";
     }
     else
     {
        return "Baja";
     }
    }
    static bool ValidarTexto(string texto)
    {
        if (texto == "")
        {
            return false;
        }
        for (int i = 0;i<texto.Length;i++)
        {
            if (char.IsDigit(texto[i]))
            {
                return false;
            }
        }
        return true;
    }


}