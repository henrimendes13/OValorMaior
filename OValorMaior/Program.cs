/*Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido 
 da mensagem “é o maior”.*/

int a, b, c, maior;

a=int.Parse(Console.ReadLine());
b=int.Parse(Console.ReadLine());
c=int.Parse(Console.ReadLine());

maior = Math.Max(a,Math.Max(b,c));

Console.WriteLine(maior+" É o maior.");