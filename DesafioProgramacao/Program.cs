﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DesafioProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //HoHoHo();

            //DividirXY();

            //Esfera();

            //Xenlonguinho();

            //PedroBentoMundoOz();
        }

        static void HoHoHo()
        {
            //DESCRIÇÃO DO DESAFIO:

            // Papai Noel está brincando com seus duendes para entretê - los durante a véspera do Natal.
            // A brincadeira consiste nos elfos escreverem números em pedaços de papel e colocarem no gorro do Papai Noel.
            // Após todos terminarem de colocar os números Noel sorteia um papel e aquele número representa quantos "Ho" o Noel deve falar.
            // Seu trabalho é ajudar o Papai Noel montando um problema que mostre todos os "Ho" que ele deve falar dado o número sorteado.

            // ENTRADA:

            // A entrada é composta por um único inteiro N (0 < N ≤ 106) representando quantos "Ho" serão falados por Noel.

            // SAÍDA:

            // A saída é composta por todos "Ho" que Papai Noel deve falar separados por um espaço.
            // Após o último "Ho" deve ser apresentado um "!" encerrando o programa.

            //SOLUÇÃO:

            Console.WriteLine("----------------- Desafio HO HO HO -----------------\n");

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++) {
                if (i != N - 1) {
                    Console.Write("Ho ");
                }
                else{
                    Console.WriteLine("Ho!");
                }
            }

            Console.WriteLine("\n------------------------------------------------------------------\n");
        }

        static void DividirXY()
        {
            //DESCRIÇÃO DO DESAFIO:

            // Você terá o desafio de escrever um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo.
            // Caso não for possível, mostre a mensagem “divisao impossivel” para os valores em questão.

            // ENTRADA:

            // A entrada contém um número inteiro N.
            // Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

            // SAÍDA:

            // Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo

            //SOLUÇÃO:

            Console.WriteLine("----------------- Desafio Dividindo X por Y -----------------\n");

            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++) 
            {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                if (Y != 0) {
                    System.Console.WriteLine((X/Y).ToString("0.0"));

                } else {
                    System.Console.WriteLine("divisao impossivel");
                }
            }

            Console.WriteLine("\n------------------------------------------------------------------\n");
        }

        static void Esfera()
        {
            //DESCRIÇAÕ DO DESAFIO:

            // Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R).
            // A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.
            // Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++),
            // assumem que o resultado da divisão entre dois inteiros é outro inteiro.

            // ENTRADA:

            // O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

            //SAÍDA:

            // A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes e um espaço depois da igualdade.
            // O valor deverá ser apresentado com 3 casas após o ponto.
            // R = 3  -> VOLUME = 113.097

            //SOLUÇÃO:

            Console.WriteLine("----------------- Desafio Esfera -----------------\n");

            double pi, raio, volume;
            pi = 3.14159;

            raio = double.Parse(Console.ReadLine());

            volume = (4.00 * pi * (Math.Pow(raio, 3.00))) / 3;

            System.Console.WriteLine("VOLUME = " + volume.ToString("0.000"));

            Console.WriteLine("\n------------------------------------------------------------------\n");
        }

        static void Xenlonguinho()
        {
            // DESCRIÇÃO DO DESAFIO:

            // Kogu está buscando as esferas do dragão para invocar Xenlonguinho e pedir para ele reviver seu amigo Kuriri,
            // que infelizmente morreu na última batalha dos guerreiros Zê.
            // Porém Kogu está tendo muita dificuldade para encontrar as esferas, por isso Xenlonguinho que é seu conhecido há muito tempo,
            // decidiu abrir uma exceção e aceitou ser invocado caso Kogu encontre todas as esferas cujo o número de divisores da quantidade de estrelas da esfera sejam par.
            // Por exemplo se existem sete esferas, Kogu não precisaria encontrar as esferas de uma e quatro estrelas,
            // pois elas tem uma quantidade ímpar de divisores, então ele só precisa pegar 5 esferas para invocar Xenlonguinho.
            // Como Kogu não é muito bom em contas, ele pediu para você escrever um programa que dado o total de esferas existentes,
            // mostre a quantidade mínima de esferas que ele precisa procurar.

            // ENTRADA:

            // A primeira linha consiste de um inteiro C que representa a quantidade de casos de teste.
            // As linhas subsequentes contém um inteiro N (2 ≤ N ≤ 1000) que representa a quantidade de esferas necessárias para invocar Xenlonguinho.

            // SAÍDA:

            // Seu programa deve exibir a quantidade mínima de esferas que Kogu tem que procurar.

            // SOLUÇÃO:

            Console.WriteLine("----------------- Desafio Xenlonguinho -----------------\n");

            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                int val = Int32.Parse(Console.ReadLine());
                Console.WriteLine(val - Math.Floor(Math.Sqrt(val)));
            }

            Console.WriteLine("\n------------------------------------------------------------------\n");
        }

        static void PedroBentoMundoOz()
        {
            // DESCRIÇÃO DO DESAFIO:

            // No jogo, O Mundo de Oz, Pedro Bento é o líder do Tribunal, por causa disso ele é uma das pessoas mais importantes do mundo, no jogo.
            // Além disso, Pedro Bento possui um grande tesouro, o qual possui diversos tipos de jóias.
            // Pedro Bento está muito curioso para saber quantos tipos de jóias diferentes seu tesouro possui.
            // Sabendo que você é o melhor programador do mundo, Pedro Bento te contratou para verificar quantos tipos de jóias distintas ele tem em seu tesouro.

            // ENTRADA:

            // A entrada consiste de várias linhas e cada uma contém uma string que descreve uma das jóias de Pedro Bento.
            // Essa string é composta apenas dos caracteres '(' e ')', a soma do tamanho de todas as string não excede 106.

            // SAÍDA:

            // Imprima quantos tipos de jóias distintas Pedro Bento possui.

            // SOLUÇÃO:

            Console.WriteLine("----------------- Desafio Pedro Bento e o Mundo de OZ -----------------\n");

            List<string> joias = new List<string>();
            int joiasDistintas = 0;
            for(int i = 0; i < 106; i++)
            {
                string joia = Console.ReadLine();
                if (!string.IsNullOrEmpty(joia))
                {
                    joias.Add(joia);
                }
                else
                {
                    break;
                }
            }

            joiasDistintas = joias.Distinct().Count();
            System.Console.WriteLine(joiasDistintas);

            Console.WriteLine("\n------------------------------------------------------------------\n");
        }
    }
}
