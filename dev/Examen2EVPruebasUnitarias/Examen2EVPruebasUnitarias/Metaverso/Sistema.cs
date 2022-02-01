using System;

namespace Metaverso
{
    public class Sistema
    {
        public string Saludo(string nombre) => $"Saludos {numero}!";

        
        public int numero { get; }
        public string Metaverso(int numero)
        {
            var sistema = new Sistema();

            if (numero % 5 == 0 && numero % 3 == 0 )
            {
                return "metaverso";
            }
            else if (numero % 5 == 0)
            {
                return "meta";
            }
            else if (numero % 3 == 0)
            {
                return "verso";
            }
            else{
                return $"{numero}";
            }
        }
        public string Metaverso2 (int[]array){
            string cadena="";
            for(int i=0;i<array.Length;i++){
                cadena = cadena + Metaverso(array[i]);
            }
            return cadena;
        }
    }
}
