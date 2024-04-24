﻿int qtdlinhas = 3, qtdcolunas = 3;

int[,] matriz1 = new int[qtdlinhas, qtdcolunas];
int[,] matriz2 = new int[qtdlinhas, qtdcolunas];
int [,] matriz3 = new int[qtdlinhas, qtdcolunas];

//criacao da matriz 1

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(0, 10);
    }
}

for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz1[linha, coluna] + " ");
    }
}

//criacao da matriz 2

for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz2[linha, coluna] = new Random().Next(1, 10);
    }
}

Console.ReadLine();

for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz2[linha, coluna] + " ");
    }
}
//soma
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
    }
}
Console.ReadLine();
Console.WriteLine("\nSoma");
for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }
}


//subtração
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
    }
}

Console.ReadLine();
Console.WriteLine("\nSubtração");
for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }
}

//multiplicação
for (int linha = 0; linha < qtdlinhas; linha++)
{
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
    }
}
Console.ReadLine();
Console.WriteLine("\nMultiplicação");
for (int linha = 0; linha < qtdlinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdcolunas; coluna++)
    {
        Console.Write(matriz3[linha, coluna] + " ");
    }
}

//divisão
/*
if (matriz3[qtdlinhas, qtdcolunas == 0])
{
    Console.WriteLine("Não existe divisão por zero!");
}
else*/
{
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            matriz3[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
        }
    }
    Console.ReadLine();
    Console.WriteLine("\nDivisão");
    for (int linha = 0; linha < qtdlinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdcolunas; coluna++)
        {
            Console.Write(matriz3[linha, coluna] + " ");
        }
    }
}
