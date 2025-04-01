
{
    static void Main()
    {
        Console.Title = "Repetidor do Cebolinha";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Cebolinha: Eae! Fala alguma coisa que eu vou lepetil com a minha fala especial! *lisos*");
        
        while (true) 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nVocê: ");
            string inputUsuario = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(inputUsuario))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Cebolinha: Nããão fala nada? Tá bêm... Tchau!");
                break;
            }
            
            string falaCebolinha = TransformarEmFalaDoCebolinha(inputUsuario);
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Cebolinha: {falaCebolinha} *lisos*");
            
           
            if (inputUsuario.Equals("tchau", StringComparison.OrdinalIgnoreCase) || 
                inputUsuario.Equals("adeus", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Cebolinha: Ah, tá bom então... Flw flw! Até mais, viu?");
                break;
            }
        }
        
        Console.ReadKey();
    }

    static string TransformarEmFalaDoCebolinha(string frase)
    {
       
        string texto = frase.Replace("rr", "l")
                           .Replace("RR", "L")
                           .Replace("rR", "l")
                           .Replace("Rr", "L");
        
        
        texto = texto.Replace('r', 'l')
                    .Replace('R', 'L');
        
        
        texto = texto.Replace("ml", "mr") 
                    .Replace("Ml", "Mr");
        
        return texto;
    }
}