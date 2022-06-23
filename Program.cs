using System;

namespace calculadora
{
    class Program
    {
        static void Main(string []args)
        {
         
            
            menu();
        }
        static void menu()
        {
            Console.WriteLine("Digite qual opção deseja realizar sua operação matematica.");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");

            Console.WriteLine("----------------------------------");
            short capMenu = short.Parse (Console.ReadLine());

            switch(capMenu)
            {
                case 1 : soma(); break;
                case 2 : subtracao();break;
                case 3 : multiplicacao();break;
                case 4 : divisao(); break;
                case 0 : System.Environment.Exit(0);break;
                default: menu(); break;
            }



        }

        static void soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float valor1 = float.Parse(Console.ReadLine());
                        
            Console.WriteLine("Segundo Valor:");
            float valor2 = float.Parse(Console.ReadLine());
            

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resulado da soma é:{resultado}");
            menu();


        }

        static void subtracao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float valor1 = float.Parse(Console.ReadLine());
                        
            Console.WriteLine("Segundo Valor:");
            float valor2 = float.Parse(Console.ReadLine());
            

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resulado da subtração é:{resultado}");
            menu();

        }

        static void multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float valor1 = float.Parse(Console.ReadLine());
                        
            Console.WriteLine("Segundo Valor:");
            float valor2 = float.Parse(Console.ReadLine());
            

            float resultado = valor1 * valor2;
            Console.WriteLine($"O resulado da multiplicação é:{resultado}");
            menu();

        
        }
        static void divisao()
                {

            Console.Clear();
            Console.WriteLine("Primeiro Valor:");
            float valor1 = float.Parse(Console.ReadLine());
                        
            Console.WriteLine("Segundo Valor:");
            float valor2 = float.Parse(Console.ReadLine());
            menu();
            

            float resultado = valor1 / valor2;
            Console.WriteLine($"O resulado da divisão é:{resultado}");

        }
    }   
}
