using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Digite sua idade para saber se voce pode doar sangue: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 17 || idade <= 68)
            {
                Console.WriteLine("Voce pode ser doador de sangue");
            }
            else 
            {
                Console.WriteLine("Voce nao pode ser doador de sangue");
            }
        }
    }
}
