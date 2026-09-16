using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main()
    {
        //HelloWorld();
        CompararFechas();
    }

    static void HelloWorld()
    {
        //nombre
        Console.WriteLine("¿Cómo te llamas?");
        string nombre = Console.ReadLine() ?? "";
        Console.WriteLine($"Hola, {nombre}");

        //año de nacimiento
        Console.WriteLine("Año de nacimiento:");
        int anioNacimiento = int.Parse(Console.ReadLine() ?? "");

        // insertar pecio
        Console.WriteLine("Precio del producto:");
        decimal precio = decimal.Parse(Console.ReadLine() ?? "");

        int anioActual = DateTime.Now.Year;
        int edadAproximada = anioActual - anioNacimiento;
        decimal precioFinal = precio * 0.90m;  //calculo del 10%

        // respuesta
        Console.WriteLine($"{nombre}: edad aprox. {edadAproximada} años");
        Console.WriteLine($"Precio: {precioFinal:F2}");
    }

    static void CompararFechas()
    {
        //afegim un comentari

        //blab bla
        Console.Write("Introdueix la primera data: ");
        DateTime data1 = DateTime.Parse(Console.ReadLine() ?? "");

        Console.Write("Introdueix la segona data: ");
        DateTime data2 = DateTime.Parse(Console.ReadLine() ?? "");

        int anyData1 = data1.Year;
        int anyData2 = data2.Year;

        if (anyData1 < anyData2)
        {

            Console.WriteLine($"{data1} es anterior a {data2}");
        }
        else
        {
            if (anyData1 > anyData2)
            {

                Console.WriteLine($"{data1} es posterior a {data2}");
            }
            else
            {
                int mesData1 = data1.Month;
                int mesData2 = data2.Month;
                
                if (mesData1 < mesData2)
                {

                    Console.WriteLine($"{data1} es anterior a {data2}");
                }
                else
                {
                    if (mesData1 > mesData2)
                    {

                        Console.WriteLine($"{data1} es posterior a {data2}");
                    }
                    else
                    {
                        int diaData1 = data1.Day;
                        int diaData2 = data2.Day;

                        if (diaData1 < diaData2)
                        {

                            Console.WriteLine($"{data1} es anterior a {data2}");
                        }
                        else
                        {
                            if (diaData1 > diaData2)
                            {

                                Console.WriteLine($"{data1} es posterior a {data2}");
                            }
                            else
                            {
                                Console.WriteLine("Les dates son idètiques");
                            }
                        }
                    }
                }
            }
        }
    }

}


