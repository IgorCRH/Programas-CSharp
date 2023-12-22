using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

public class Forca
{
    public static string PalavraValida(List<string> palavrasForca)
    {
        Random random = new Random();
        string palavra = palavrasForca[random.Next(palavrasForca.Count)];

        while (palavra.Contains('-') || palavra.Contains(' '))
        {
            palavra = palavrasForca[random.Next(palavrasForca.Count)];
        }

        return palavra.ToUpper();
    }

    public static void JogoForca()
    {
        List<string> palavrasForca = PalavrasForca.PalavrasForcaList.ToList();
        string palavra = PalavraValida(palavrasForca);
        HashSet<char> letrasPalavra = new HashSet<char>(palavra); 
        HashSet<char> alfabeto = new HashSet<char>(Enumerable.Range('A', 26).Select(c => (char)c));
        HashSet<char> letrasUsadas = new HashSet<char>(); 

        int vidas = 5;

        // A palavra que está sendo adivinhada pelo usuário atualmente
        List<char> letrasPalavraUsadas = palavra.Select(letra => letrasUsadas.Contains(letra) ? letra : '-').ToList();
        Console.WriteLine($"Palavra: {string.Join(" ", letrasPalavraUsadas)}");

        while (letrasPalavra.Count > 0 && vidas > 0)
        {
            Console.WriteLine(VisualDaForca.VisualDasVidas[vidas]);
            Console.WriteLine($"Você tem {vidas} vidas restantes e já usou estas letras: {string.Join(" ", letrasUsadas)}");
            Console.Write("Entre com um caractere: ");
            string entradaUsuario = Console.ReadLine().ToUpper();

            if (alfabeto.Contains(entradaUsuario[0]) && !letrasUsadas.Contains(entradaUsuario[0]))
            {
                letrasUsadas.Add(entradaUsuario[0]);
                if (letrasPalavra.Contains(entradaUsuario[0]))
                {
                    letrasPalavra.Remove(entradaUsuario[0]);
                }
                else
                {
                    vidas--; // Tira uma vida se a letra não estiver na palavra
                }
            }
            else if (letrasUsadas.Contains(entradaUsuario[0]))
            {
                Console.WriteLine("Você já usou essa letra");
            }
            else
            {
                Console.WriteLine("Caractere inválido. Por favor, entre com um válido.");
            }

            // Atualiza a lista de letras da palavra que foram usadas
            letrasPalavraUsadas = palavra.Select(letra => letrasUsadas.Contains(letra) ? letra : '-').ToList();
            Console.WriteLine($"Palavra: {string.Join(" ", letrasPalavraUsadas)}");
        }

        if (vidas == 0)
        {
            Console.WriteLine(VisualDaForca.VisualDasVidas[vidas]);
            Console.WriteLine($"Você morreu. A palavra era {palavra}");
        }
        else
        {
            Console.WriteLine("Você adivinhou a palavra e salvou a pessoa!");
        }
    }

    public static void Main()
    {
        JogoForca();
    }
}
