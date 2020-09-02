using Microsoft.VisualBasic;
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
                Console.WriteLine("[1] Questão 1: ArrayList");
                Console.WriteLine("[2] Questão 2 Queue");
                Console.WriteLine("[3] Questão 3: Stack");
                Console.WriteLine("[4] Questão 4: Erro");
                Console.WriteLine("[5] Questão 5: For");
                Console.WriteLine("[6] Questão 5: Foreach");
                Console.WriteLine("[7] Questão 6: ArrayList");
                Console.WriteLine("[8] Questão 6: Queue");
                Console.WriteLine("[9] Questão 6: Stack");
                Console.WriteLine("[10] Questão 7: Demonstração da questão 7 que inverte um arraylist");
                Console.WriteLine("[11] Questão 8: Função de retornar soma (Stack)");
                Console.WriteLine("[12] Questão 9: Positivos");
                Console.WriteLine("[13] Questão 10: Ocorrências");
                Console.WriteLine("[0] - Sair");
                Console.Write("=> ");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao) {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Aperte enter");
                        break;
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
                        Questao5For();
                        break;
                    case 6:
                        Questao5Foreach();
                        break;
                    case 7:
                        Questao6ArrayList();
                        break;
                    case 8: 
                         Questao6Queue();
                        break;
                    case 9: 
                         Questao6Stack();
                        break;
                    case 10:
                        testaQuestao7();
                        break;
                    case 11:
                        Questao8Stack();
                        break;
                    case 12:
                        Questao9();
                        break;
                    case 13:
                        Questao10();
                        break;
                    default:
                        Console.Write("Cabo");
                        Console.Clear();
                        Console.WriteLine("---x--- Opção inválida! ---x---");
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
            
            Console.Write("Tecle qualquer coisa para voltar ao menu...");
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

        public static void Questao5For() {
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
            for(int num = 0; num < numeros.Count; num++)
                Console.Write($"{numeros[num]}, ");
            Console.WriteLine();
 
            //imprimindo ordem invertida
            numeros.Reverse();
            Console.WriteLine("Imprimindo todos os elementos em ordem invertida");
            for(int num = 0; num < numeros.Count; num++)
                Console.Write($"{numeros[num]}, ");
            Console.WriteLine();
            numeros.Reverse();
 
            //imprime em posições impares
            Console.WriteLine("Imprimindo todos os elementos em posições impares");
            for(int num = 0; num < numeros.Count; num++)
                if(num % 2 != 0)
                    Console.Write($"{numeros[num]}, ");
            Console.WriteLine();
 
            //Imprima todos os elementos ímpares
            Console.WriteLine("Imprimindo todos os elementos ímpares");
            for(int num = 0; num < numeros.Count; num++)
                if((int)numeros[num] % 2 != 0)
                    Console.Write($"{numeros[num]}, ");
            Console.WriteLine();
 
            //Imprima apenas os elementos da primeira metade do vetor (posição 0 a 12).
            Console.WriteLine("Imprimindo todos os elementos da primeira metade do vetor");
            for(int num = 0; num < numeros.Count/2; num++)  
                Console.Write($"{numeros[num]}, ");
            Console.WriteLine();
 
            Console.WriteLine("Tecle qualquer coisa para voltar ao menu...");
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
            numeros.Reverse();
 
            //imprime em posições impares
            Console.WriteLine("Imprimindo todos os elementos em posições impares");
            int qnt  = numeros.Count - 1;
            foreach(int num in numeros) {
                if(qnt % 2 != 0)
                    Console.Write($"{num}, ");
                qnt--;
            }
            Console.WriteLine();
 
            //Imprima todos os elementos ímpares
            Console.WriteLine("Imprimindo todos os elementos ímpares");
            foreach(int num in numeros)
                if(num % 2 != 0)
                    Console.Write($"{num}, ");
            Console.WriteLine();
 
            //Imprima apenas os elementos da primeira metade do vetor (posição 0 a 12).
            Console.WriteLine("Imprimindo todos os elementos da primeira metade do vetor");
            qnt  = numeros.Count/2;
            foreach(int num in numeros) {
                if(qnt >= 0)
                    Console.Write($"{num}, ");
                qnt--;
            }
                
            Console.WriteLine();
 
            Console.WriteLine("Tecle qualquer coisa para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Questao6ArrayList() {
            /*6 - Faça um programa que gere uma coleção com n números inteiros aleatórios (o valor de n deve ser
            informado pelo usuário no início da execução do programa. Imprima os elementos da coleção.*/
            int n;
            Random random = new Random();
            Console.WriteLine("Questão 6");
            Console.Write("Quantos números deseja gerar? \n=> ");
            n = int.Parse(Console.ReadLine());

            ArrayList colecao = new ArrayList();
            for(int i = 0; i < n; i++)
            {
                colecao.Add(random.Next(0,200));
            }
            foreach(int i in colecao)
            {
                Console.WriteLine(i);
            }
        }
        public static ArrayList Questao7(ArrayList colecao) {
            Stack stack = new Stack();


            foreach(int i in colecao) {
                stack.Push(i);
            }

            colecao.Clear();
            foreach(int i in stack) {
                colecao.Add(i);
            }
            return colecao;
        }
         public static void Questao6Queue() {
            /*6 - Faça um programa que gere uma coleção com n números inteiros aleatórios (o valor de n deve ser
            informado pelo usuário no início da execução do programa. Imprima os elementos da coleção.*/
            int n;
            Random random = new Random();
            Console.WriteLine("Questão 6");
            Console.Write("Quantos números deseja gerar? \n=> ");
            n = int.Parse(Console.ReadLine());

            Queue colecao = new Queue();
            for(int i = 0; i < n; i++)
            {
                colecao.Enqueue(random.Next(0,200));
            }
            foreach(int i in colecao)
            {
                Console.WriteLine(i);
            }
        }
         public static void Questao6Stack() {
            /*6 - Faça um programa que gere uma coleção com n números inteiros aleatórios (o valor de n deve ser
            informado pelo usuário no início da execução do programa. Imprima os elementos da coleção.*/
            int n;
            Random random = new Random();
            Console.WriteLine("Questão 6");
            Console.Write("Quantos números deseja gerar? \n=> ");
            n = int.Parse(Console.ReadLine());

            Stack colecao = new Stack();
            for(int i = 0; i < n; i++)
            {
                colecao.Push(random.Next(0,200));
            }
            foreach(int i in colecao)
            {
                Console.WriteLine(i);
            }
        }
       


        public static void testaQuestao7() {
            ArrayList al = new ArrayList() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine("ArrayList original");
            foreach(int i in al)
                Console.Write($"{i} -");
            Questao7(al);
            Console.WriteLine();

            Console.WriteLine("ArrayList invertido");
            foreach(int i in al)
                Console.Write($"{i} -");
            Console.WriteLine();

            Console.Write("Tecle qualquer coisa para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }

        public static int SomaQuestao8(Stack st) {
            int soma = 0;

            foreach (int num in st)
            {
                soma += num;
            }

            return soma;
        }

        public static void Questao8Stack() {
            /*8 - Crie uma função que receba a coleção como parâmetro e retorne a soma de seus elementos.
            OBS: considere que todos seus dados são do tipo int.*/
            Console.Clear();
            Console.WriteLine("Questão 8 - Stack");

            int qtd;
            Stack st = new Stack();

            Console.Write("Quantos números deseja somar? \n=> ");
            qtd = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira os números:");
            for (int i = 0; i < qtd; i++)
            {
                Console.Write("=> ");
                st.Push(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Soma dos elementos da Stack = " + SomaQuestao8(st));

            Console.Write("Tecle qualquer coisa para voltar ao menu...");
            
            
            
            Console.ReadKey();
            Console.Clear();
        }
        
        public static int Questao9ElPositivos(ArrayList Al)
        {
            //9 – Crie uma função que calcule o número de elementos positivos
            //    de uma coleção passada como parâmetro.
            int num = 0;
            foreach (int i in Al)
                if (i > 0)
                    num++;
            return num;

        }

        public static void Questao9(){
            
            Console.Clear();
            ArrayList A = new ArrayList();
            A.Add(5);
            A.Add(10);
            A.Add(15);
            A.Add(15);
            A.Add(-3);

            Console.WriteLine("\nO número de elementos positivos é {0}", Questao9ElPositivos(A));
            Console.Write("Tecle qualquer coisa para voltar ao menu...");            
            Console.ReadKey();
            Console.Clear();
            
        }

        public static int Questao10Ocorrencias(ArrayList Al, int n)
        {
            //10 – Crie uma função que calcule o número de ocorrências
            //     em uma coleção de um elemento passado como parâmetro.
            int elm = 0;

            foreach (int i in Al)
                if (i == n)
                    elm++;
            return elm;
        }

        public static void Questao10(){
            
            Console.Clear();
            ArrayList A = new ArrayList() {5,10,15,15,-3};

            Console.WriteLine("O número de ocorrências é {0}", Questao10Ocorrencias(A, 15));

            Console.Write("Tecle qualquer coisa para voltar ao menu...");
            Console.ReadKey();
            Console.Clear();
        }
}
}