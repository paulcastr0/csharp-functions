// See https://aka.ms/new-console-template for more information

// ------------------  PROGRAMMA PRINCIPALE ---------------------------



int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArrayInteri(arrayDiNumeri);

int Quadrato = 2;
Console.WriteLine("Il numero originale è: " + Quadrato);
raddoppiaNumeroRef(ref Quadrato);
Console.WriteLine("Il numero raddoppiato è: " + Quadrato);

Console.WriteLine("Array di numeri originale: ");
StampaArrayInteri(arrayDiNumeri);

int[] arrayDiNumeriIncrementato = incrementoArrayNumeri(arrayDiNumeri);

Console.WriteLine("Array di numeri originale: ");
StampaArrayInteri(arrayDiNumeri);

Console.WriteLine("Array di numeri incrementato originale: ");
StampaArrayInteri(arrayDiNumeriIncrementato);

int somma = SommaNumeri(arrayDiNumeri);
Console.Write("La somma dei numeri originali è: " + somma);

int somma2 = SommaNumeriQuadrato(arrayDiNumeriIncrementato);
Console.Write("La somma dei numeri al quadrato è: " + somma2);



// --------------- DICHIARAZIONE DELLE FUNZIONI ------------------------

// Creo una funzione che stampa in console un array di interi
void StampaArrayInteri(int[] arrayInteri)
{
    Console.Write("[");

    for (int i = 0; i < arrayInteri.Length; i++)
    {
        if (i == arrayInteri.Length - 1)
        {
            Console.Write(arrayInteri[i]);
        }
        else
        {
            Console.Write(arrayInteri[i] + ", ");
        }

    }

    Console.WriteLine("]");
}

    int raddoppiaNumero(int n)
{
    n = n * 2;
    return n;
}
void raddoppiaNumeroRef(ref int n)
{
    n = n * 2;
}

// IMPORTANTE: qualunque tipo di array (quindi anche array di int, float, double, bool, ecc ecc) sono SEMPRE
// passati come referenza. Dunque qualunque modifica sull'array fatta al parametro della funzione si 
// ripercuote sull'array originale passato dal programma principale!
int[] incrementoArrayNumeriSenzaCopia(int[] arrayNumeri)
{
    for (int i = 0; i < arrayNumeri.Length; i++)
    {
        arrayNumeri[i] = arrayNumeri[i] * 2;
    }

    return arrayNumeri;
}

// Per evitare di sovrascrivere l'array originale passato dal programma principale, dovete voi occuparvi
// quando create la funzione di copiare l'array originale in una nuova VARIABILE LOCALE!!!
int[] incrementoArrayNumeri(int[] arrayNumeri)
{
    // Per copiare un array si utilizza questo metodo .Clone() sull'array originale.
    // Ricordatevi di fare il corretto cast di tipo (int[])
    int[] copiaArray = (int[])arrayNumeri.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * 2;
    }

    return copiaArray;
}


int SommaNumeri(int[] arrayNumeri) 
{
    int sum = 0;
    for (int i = 0; i < arrayDiNumeri.Length; i++)
    {
        sum += arrayDiNumeri[i];
    }
    return sum;
}



int SommaNumeriQuadrato(int[] arrayDiNumeriIncrementato)
{
    int sum1 = 0;
    for (int i = 0; i < arrayDiNumeriIncrementato.Length; i++)
    {
        sum1 += arrayDiNumeriIncrementato[i];
    }
    return sum1;
}
