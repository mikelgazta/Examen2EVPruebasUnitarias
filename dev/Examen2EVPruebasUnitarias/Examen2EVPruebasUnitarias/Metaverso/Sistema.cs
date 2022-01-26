using System;

namespace Metaverso
{
    public class Sistema
    {
        public string Saludo(string nombre) => $"Saludos {numero}!";

        public int numero { get; }
        static void Metaverso()
        {
            var sistema = new Sistema();

            if (sistema.numero % 5 == 0 & sistema.numero % 3 == 0 )
            {
                Console.WriteLine("Metaverso");
            }
            else if (sistema.numero % 5 == 0)
            {
                Console.WriteLine("Meta");
            }
            else if (sistema.numero % 3 == 0)
            {
                Console.WriteLine("Verso");
            }
            else{
                Console.WriteLine($"{sistema.numero}");
            }
        }
    }
}
