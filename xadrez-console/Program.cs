using tabuleiro;
using xadrez_console;
using xadrez;

namespace XadrezConole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}