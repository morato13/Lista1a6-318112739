using System;

namespace Lista1a6LucasMorato
{
    class Program
    {
        /* Função número 3 */
        static bool PAR(int num) 
        {
            if (num % 2 == 0)
                return true;
            else
                return false;
        }



        static void Main(string[] args)
        {
            /* Questão 1 */

            int[] vetor = new int[4];

            int Numeros = 0;
            int PrimeiraTroca = 0;
            int SegundaTroca = 0;
            int PrimeiroNumero = 0;
            int SegundoNumero = 0;
            int TerceiroNumero = 0;
            int QuartoNumero = 0;

            Console.WriteLine("Digitar seu número de 4 digitos");
            Numeros = Convert.ToInt32(Console.ReadLine());

            PrimeiroNumero = Numeros / 1000;
            SegundoNumero = Numeros / 100 % 10;
            TerceiroNumero = Numeros / 10 % 10;
            QuartoNumero = Numeros % 10;

            PrimeiroNumero = (PrimeiroNumero + 7) / 10;
            SegundoNumero = (SegundoNumero + 7) / 10;
            TerceiroNumero = (TerceiroNumero + 7) / 10;
            QuartoNumero = (QuartoNumero + 7) / 10;

            vetor[0] = PrimeiroNumero;
            vetor[1] = SegundoNumero;
            vetor[2] = TerceiroNumero;
            vetor[3] = QuartoNumero;

            PrimeiraTroca = vetor[0];
            vetor[0] = vetor[2];
            vetor[2] = PrimeiraTroca;

            SegundaTroca = vetor[1];
            vetor[1] = vetor[3];
            vetor[3] = SegundaTroca;

            for (int j = 0; j < vetor.Length; j++)

            {
                Console.Write(vetor[j] + " ");

            }

            Console.WriteLine("  --> Criptografia");

            Console.ReadLine();
            Console.Clear();


            /* Questão 2 */

            int valor = 0;

            Console.WriteLine("Informar saldo: \n");
            valor = Convert.ToInt32(Console.ReadLine());

            Cliente cliente = new Cliente(valor, 200, 500, 450, 5000);
            Console.WriteLine("Novo: \n");
            Console.WriteLine(cliente.NovoValor());

            cliente.AtualizaSaldo();

            if (cliente.Limiteeltrapassado())
                Console.WriteLine("Limite ultrapassado !");
            else
                Console.WriteLine("Possui crédito disponivel.");

            Console.ReadKey();
            Console.Clear();

            /* Questão 3 */


            int num = 0;
            Console.WriteLine("\t\t\t\t (TRUE) PAR ----- (FALSE) IMPAR \n");

            while (num <= 10)
            {
                Console.WriteLine("Número : " + num + " " + PAR(num)); 
                num = num + 1;
            }

            Console.ReadKey();
            Console.Clear();


            /* Questão 4 */

            int numero1 = 0;
            int numero2 = 0;
            int numero3 = 0;

            Console.WriteLine("Digitar o primeiro valor do triângulo :");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digitar o Segundo valor do triângulo :");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digitar o Terceiro valor do triângulo :");
            numero3 = Convert.ToInt32(Console.ReadLine());

            if (numero1 == numero2 && numero2 == numero3)
                Console.WriteLine("Equilátero -> 3 lados iguais : 1° Lado = " + numero1 + " --> 2° Lado = " + numero2 + " --> 3º Lado = " + numero3);

            else if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
                Console.WriteLine("Escaleno -> 3 lados diferentes : 1° Lado = " + numero1 + " --> 2° Lado = " + numero2 + " --> 3º Lado = " + numero3);
            else
                Console.WriteLine("Isoceles -> 2 lados iguais : 1° Lado = " + numero1 + " --> 2° Lado = " + numero2 + " --> 3º Lado = " + numero3);

            Console.ReadKey();
            Console.Clear();


            /* Questão 5 */

            string A = "a";
            string E = "e";
            string I = "i";
            string O = "o";
            string U = "u";


            string InsiraLetra;


            Console.WriteLine("Digitar letra do alfabeto");
            InsiraLetra = Convert.ToString(Console.ReadLine());

            if (InsiraLetra.Length > A.Length || InsiraLetra.Length > E.Length || InsiraLetra.Length > I.Length || InsiraLetra.Length > O.Length || InsiraLetra.Length > U.Length)

                Console.WriteLine("Digitar somente 1 caractere");


            else if (InsiraLetra == A || InsiraLetra == E || InsiraLetra == I || InsiraLetra == O || InsiraLetra == U)
                Console.WriteLine(" A letra é uma Vogal");

            else
                Console.WriteLine(" A letra é uma Consoante");
            Console.ReadKey();
            Console.Clear();


            /* Questão 6 */

            int numero;
            int i;
            int soma = 0;
            Console.WriteLine("Numero inteiro positivo ===> ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= numero; i++) 

            {
                int aux = 0;


                aux = numero % i; 

                if (aux == 0)
                {
                    soma = soma + 1;
                }
            }

            if (soma == 2)
                Console.WriteLine("Número primo");
            else
                Console.WriteLine("Número não primo");

            Console.ReadKey();
            Console.Clear();

        }

    }
}