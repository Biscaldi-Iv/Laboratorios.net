using System;

/*Numericos_simples:
    Bisiesto
    Mes
    Pares
    Suma

//Numericos_comp:
    Primos
    Llama_fib
    Romanos

//Cadenas:
    Claves
    Piramide

*/
namespace LabSintaxis04
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            string key1,key2;
            do
            {
                Console.Clear();
                op = Menu();
                switch (op)
                {
                    case 1:
                        Numericos_simples.Suma();
                        break;
                    case 2:
                        Numericos_simples.Bisiesto();
                        break;
                    case 3:
                        Numericos_comp.Llama_fib();
                        break;
                    case 4:
                        Numericos_simples.Pares();
                        break;
                    case 5:
                        Numericos_simples.Mes();
                        break;
                    case 6:
                        Numericos_comp.Romanos();
                        break;
                    case 7:
                        Numericos_comp.Primos();
                        break;
                    case 8:
                        do
                        {
                            Console.Write("\n\tRegistrar contraseña: ");
                            key1 = Cadenas.LectorClaves();
                            Console.Write("Confirmar:");
                            key2 = Cadenas.LectorClaves();
                        } while (key1 != key2);
                        Cadenas.Claves(key1);
                        break;
                    case 9:
                        Cadenas.Piramides();
                        break;
                }
            } while (op != 0);
        }
        private static int Menu()
        {
            Console.Clear();
            int opc;
            Console.Write("Menu:\n" +
                          "\t1-Suma\n" +
                          "\t2-Años bisiestos\n" +
                          "\t3-Serie de fibonacci\n" +
                          "\t4-Pares\n" +
                          "\t5-Meses\n" +
                          "\t6-Numeros romanos\n" +
                          "\t7-Numeros primos\n" +
                          "\t8-Contraseña\n" +
                          "\t9-Piramides\n\n" +
                          "0-Salir\n\n");
            do
            {
                Console.Write("Seleccionar: ");
                opc=int.Parse(Console.ReadLine());
                if (0<=opc && opc<=9)
                {
                    return opc;
                }
            } while (true);
            
        }
        

        
    }
}
