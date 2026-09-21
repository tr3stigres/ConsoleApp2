class Program
{
    public static async Task Main()
    {
        HelloWorld();
        CompararFechas();
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

    static void CompararFechas()
    {

        DateTime data1 = IntroduirData("Introdueix la primera data:");
        DateTime data2 = IntroduirData("Introdueix la segona data:");
        int comparacio = CompararDatas(data1, data2);
        MostrarResposta(comparacio, data1, data2);
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

    static DateTime IntroduirData(string pregunta)
    {
        DateTime resultat = DateTime.Now;

        do
        {
            Console.Write($"{pregunta} ");
            string? resposta = Console.ReadLine();
            if (!DateTime.TryParse(resposta, out resultat))
            {
                Console.WriteLine("La resposta ha de ser una data");
                continue;
            }
           
            break;

        } while (true);

        return resultat;

    }

    static int CompararDatas (DateTime data1, DateTime data2)
    {
        int anyData1 = data1.Year;
        int anyData2 = data2.Year;

        if (anyData1 < anyData2)
        {

            return 2;
        }
        else
        {
            if (anyData1 > anyData2)
            {

                return 1;
            }
            else
            {
                int mesData1 = data1.Month;
                int mesData2 = data2.Month;

                if (mesData1 < mesData2)
                {

                    return 2;
                }
                else
                {
                    if (mesData1 > mesData2)
                    {

                        return 1;
                    }
                    else
                    {
                        int diaData1 = data1.Day;
                        int diaData2 = data2.Day;

                        if (diaData1 < diaData2)
                        {

                            return 2;
                        }
                        else
                        {
                            if (diaData1 > diaData2)
                            {

                                return 1;
                            }
                            else
                            {
                                return 0;
                            }
                        }
                    }
                }
            }
        }
    }

    static void MostrarResposta(int comparacio, DateTime data1, DateTime data2)
    {
        string resposta = comparacio switch
        {
            0 => "Les dates son idètiques",
            1 => $"{data1} es posterior a {data2}",
            2 => $"{data1} es anterior a {data2}",
            _ => "No hi ha solució"
        };

        Console.Write(resposta);
    }

}



