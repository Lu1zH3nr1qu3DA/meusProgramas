namespace tempoDeVida._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime nascimento;
            int tempo;

            Console.Write("Insira sua data de nascimento: ");
            nascimento = Convert.ToDateTime(Console.ReadLine());

            tempo = Convert.ToInt16(DateTime.Now.Subtract(nascimento).Days);

            Console.WriteLine($"\nVocê viveu, aproximadamente, {tempo} dias.");

            Console.Write("\n\nPressione qualquer tecla para fechar. . . ");
            Console.ReadKey();
        }
    }
}