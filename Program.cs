using System;
using System.Collections;
namespace Lista_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int opcao = -1;

            while(opcao != 0) {
                Console.WriteLine("Selecione a questão:");
                Console.WriteLine("[1] - ArrayList");
                Console.WriteLine("[2] - Queue");
                Console.WriteLine("[3] - Stack");
                Console.WriteLine("[4] - Erro");
                Console.WriteLine("[5] - Questão 5 com foreach");
                Console.WriteLine("[0] - Sair");
                Console.Write("=> ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao) {
                    case 1:
                        Questao1();
                        break;
                    case 2:
                        Questao2();
                        break;
                    case 3:
                        Questao3();
                        break;
                    case 4:
                        Questao4();
                        break;
                    case 5:
                        Questao5Foreach();
                        break;
                    default:
                        Console.Write("Cabo");
                        break;
                }
            }
            

            Console.ReadKey();
        }

        public static void Questao1() {
            /*1 – Faça um programa que leia n números inteiros e os   armazene em um ArrayList. 
            Calcule a soma e a média 	aritmética (use o comando FOR e depois o FOREACH).*/
            Console.Clear();

            ArrayList AL = new ArrayList();  
            double soma = 0;
            int num  = 0;

            Console.WriteLine("QUESTÃO 1");
            Console.Write("Quantos números inteiros deseja inserir? \n=> ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira os números:");
            
            for(int i = 0; i < num; i++) 
            {
                Console.Write("=> ");
                AL.Add(int.Parse(Console.ReadLine()));
            }
            AL.TrimToSize();
            foreach(int n in AL){
                soma += n;
            }

            Console.WriteLine("Soma = {0}", soma);
            Console.WriteLine("Média = {0}", soma/AL.Count);
            
            Console.WriteLine("Tecle qualquer coisa para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Questao2 () {
            /*2 – Faça um programa que leia n números inteiros e os armazene em um Queue. 
            Calcule a soma e a média aritmética 
            (use o comando FOREACH para iterar sobre os elementos)*/
            Console.Clear();
            Console.WriteLine("QUESTÃO 2");

            Queue queue = new Queue();
            int num, qnt, soma = 0;
            double media;

            Console.Write("Quantos números inteiros deseja inserir? \n=> ");
            qnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira os números:");
            
            for(int i = 0; i < qnt; i++) {
                Console.Write("=> ");
                num = int.Parse(Console.ReadLine());

                queue.Enqueue(num);
            }

            foreach(int numero in queue) {
                soma += numero;
            }
            media = soma/qnt;
            Console.WriteLine($"A soma foi: {soma} e a média foi de: {media} ");

            Console.Write("Tecle qualquer coisa para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Questao3() {
            /*3 – Faça um programa que leia n números inteiros e os armazene em um Stack. 
            Calcule a soma e a média aritmética 
            (use o comando FOREACH para iterar sobre os elementos).	*/
            Console.Clear();
            Console.WriteLine("QUESTÃO 3");

            Stack stack = new Stack();
            int num, qnt, soma = 0;
            double media;
            
            Console.Write("Quantos números deseja inserir? \n=> ");
            qnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira os números:");

            for(int i = 0; i < qnt; i++) {
                Console.Write("=> ");
                num = int.Parse(Console.ReadLine());

                stack.Push(num);
            }

            foreach(int numero in stack) {
                soma += numero;
            }
            media = soma/qnt;
            Console.WriteLine($"A soma foi: {soma} e a média foi de: {media} ");
                
            Console.Write("Tecle qualquer coisa para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
	    }

        public static void Questao4() {
            /*4 – Faça um programa que preencha um ArrayList com elementos de diferentes 
            tipos (int, double, float, boolean, String). 
            Tente calcular a soma dos elementos. 
            Evidentemente, isso irá provocar uma mensagem de erro. 
            Que mensagem o Visual Studio retorna?*/
            Console.Clear();
            Console.WriteLine("QUESTÃO 4");

            int soma = 0;

            ArrayList al = new ArrayList() { 1, 2, 1.2, 3.10, "C#", "teste",false, true };
            try{
                foreach(int posicao in al) 
                soma += posicao;
            }
            catch(Exception ex){
                Console.WriteLine("Erro Gerado: {0}", ex);
            }
            
            Console.Write("Tecle qualquer coisa para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Questao5Foreach() {
            /*5 – Faça um programa que preencha um ArrayList com os números entre 1 e 25. Pede-se:
                • Imprima todos os elementos
                • Imprima todos os elementos em ordem invertida
                • Imprima todos os elementos em posições ímpares (o elemento da posição 1, 3, 5, ...)
                • Imprima todos os elementos ímpares
                • Imprima apenas os elementos da primeira metade do vetor (posição 0 a 12).*/

            ArrayList numeros = new ArrayList();
            for(int i = 1; i<=25; i++) {
                numeros.Add(i);
            }
            
            //imprimindo todos os elementos
            Console.WriteLine("Imprimindo todos os elementos");
            foreach(int num in numeros)
                Console.Write($"{num}, ");
            Console.WriteLine();

            //imprimindo ordem invertida
            numeros.Reverse();
            Console.WriteLine("Imprimindo todos os elementos em ordem invertida");
            foreach(int num in numeros)
                Console.Write($"{num}, ");
            Console.WriteLine();

            //imprime em posições impares

            Console.WriteLine("Tecle qualquer coisa para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}