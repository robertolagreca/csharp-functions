// See https://aka.ms/new-console-template for more information

//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:

//1
//void StampaArrayInteri(int[] array): che preso un array di numeri interi, stampa
//a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”.

//2
//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

//3
//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca
//un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della
//funzione!

//int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma
//totale di tutti gli elementi dell’array.

//Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9]
//già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
//Stampare l’array di numeri fornito a video
//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
//(Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e
//verificare che sia rimasto [2, 6, 7, 5, 3, 9])
//Stampare la somma di tutti i numeri
//Stampare la somma di tutti i numeri elevati al quadrati


//1 - Funzione che stampa array di interi
Console.WriteLine("Esercizio 1");
Console.WriteLine();
int[] arrayInteri = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


StampaArrayInteri(arrayInteri);

void StampaArrayInteri(int[] array)
{
    Console.WriteLine("Stampa di un array di interi");
    Console.WriteLine();
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
Console.WriteLine("Esercizio 2");
int numeroUtente, quadratoNumeroUtente;

Console.WriteLine();
Console.WriteLine("Inserisci un numero e ti verrà restituito il quadrato");
numeroUtente = int.Parse(Console.ReadLine());
Console.WriteLine();

quadratoNumeroUtente = getQuadrato(numeroUtente);

Console.WriteLine("Il quadrato del numero " + numeroUtente + " è " + quadratoNumeroUtente);
Console.WriteLine();

int getQuadrato(int numero)
{
    int quadrato;

    quadrato = (int)Math.Pow(numero, 2);
  
    return quadrato;
}

//3 - Funzione che restituisca un nuovo array al quadrato.
Console.WriteLine();
Console.WriteLine("Esercizio 3");
Console.WriteLine();

int[] arrayInt = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

arrayQuadrato(arrayInt);
void arrayQuadrato(int[] array)
{
    Console.WriteLine("Array in entrata");
    StampaArrayInteri(array);
    Console.WriteLine();

    int[] arrayIntF = (int[])array.Clone();
    
    for (int i = 0; i < array.Length; i++)
    {
        arrayIntF[i] = getQuadrato(arrayIntF[i]);
    }
    Console.WriteLine("Array in uscita al quadrato");
    StampaArrayInteri(arrayIntF);
    Console.WriteLine();
}