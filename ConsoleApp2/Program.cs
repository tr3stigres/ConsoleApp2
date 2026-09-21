using System;
using System.Text;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.Http;

class Program
{
    public static async Task Main()
    {
        HelloWorld();
        //CompararFechas();
    }

    static void HelloWorld()
    {

        string nombre = DemanarNom();
        int anioNacimiento = DemanarAny();
        int edadAproximada = CalculEdat(anioNacimiento);
        decimal precio = DemanarPreu();        
        decimal precioFinal = CalculPreuFinal(precio);
        MostarResultat(nombre, edadAproximada, precioFinal);        
    }


    static string DemanarNom() 
    {
        string nombre = "";
        Console.Write("Com et dius? ");
        string? resposta = Console.ReadLine() ?? "";
        if (resposta != null)
            nombre = resposta;

        return nombre;

    }

    static int DemanarAny()
    {

        int anio = 0;

        do
        {
            Console.Write("Any de naixament: ");
            string? resposta = Console.ReadLine();
            if (!int.TryParse(resposta, out anio))
            {
                Console.WriteLine("La resposta ha de ser un número sencer");
                continue;
            }

            break;

        } while (true);

        return anio;
    }

    static decimal DemanarPreu()
    {        
        Console.Write("Preu del producte: ");
        return decimal.Parse(Console.ReadLine() ?? "");        
    }

    static int CalculEdat(int anioNacimiento)
    {
        return DateTime.Now.Year - anioNacimiento;
    }

    static decimal CalculPreuFinal(decimal precio)
    {
        return precio * 0.90m;  //calculo del 10%
    }

    static void MostarResultat(string nombre, int edadAproximada, decimal precioFinal)
    {
        Console.WriteLine($"{nombre}: edad aprox. {edadAproximada} años");
        Console.WriteLine($"Precio: {precioFinal:F2}");
    }

    static void CompararFechas()
    {
        //afegim un comentari

        //bla bla bla
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



