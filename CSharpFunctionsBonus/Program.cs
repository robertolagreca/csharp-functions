// See https://aka.ms/new-console-template for more information
using System;


Console.WriteLine();
int[] arrayInteri;
int numeroPosizioniArray, somma = 0;

Console.WriteLine("Quanti numeri vorresti inserire nell'array?");
numeroPosizioniArray = int.Parse(Console.ReadLine());
arrayInteri = new int[numeroPosizioniArray];

setNumeriArray(numeroPosizioniArray, arrayInteri);


Console.WriteLine("Esercizio 1: stampa dell'array dato");
Console.WriteLine();
StampaArrayInteri(arrayInteri);
Console.WriteLine();
Console.WriteLine("---------------------------------------------------------------------");


Console.WriteLine("Esercizio 2: stampa dell'array dato al quadato");
Console.WriteLine();
arrayQuadrato(arrayInteri);
Console.WriteLine();

Console.WriteLine("Esercizio 2: verifica che l'array di partenza è invariato");
Console.WriteLine();
StampaArrayInteri(arrayInteri);
Console.WriteLine();
Console.WriteLine("---------------------------------------------------------------------");


Console.WriteLine("Esercizio 3: stampa la somma dei numeri presenti nell'array dato");
Console.WriteLine();

StampaArrayInteri(arrayInteri);
Console.WriteLine();

somma = getSommaArray(arrayInteri);
Console.WriteLine("La somma dei numeri dell'array è " + somma);




//FUNZIONI

//0 - Funzione che permette di inserire numeri nell'array.
int[] setNumeriArray (int numPosizioni, int[] array)
{
    Console.WriteLine("Inserisci numeri interi nell'array");
    for(int i = 0; i < numPosizioni; i++)
    {   
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
//1 - Funzione che stampa array di interi
void StampaArrayInteri(int[] array)
{
    //Console.WriteLine("Stampa di un array di interi");
    //Console.WriteLine();
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);


        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}


//2 - Funzione che restituisca il quadrato del numero passato come parametro
int getQuadrato(int numero)
{
    int quadrato;

    quadrato = (int)Math.Pow(numero, 2);

    return quadrato;
}

//3 - Funzione che restituisca un nuovo array al quadrato.

void arrayQuadrato(int[] array)
{
    //Console.WriteLine("Array in entrata");
    //StampaArrayInteri(array);
    //Console.WriteLine();

    int[] arrayIntF = (int[])array.Clone();

    for (int i = 0; i < array.Length; i++)
    {
        arrayIntF[i] = getQuadrato(arrayIntF[i]);
    }
    //Console.WriteLine("Array in uscita al quadrato");
    StampaArrayInteri(arrayIntF);
    //Console.WriteLine();
}

//4 - funzione che preso un array di interi restitusce la somma

int getSommaArray(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    return sum;
}
