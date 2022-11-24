// See https://aka.ms/new-console-template for more information

// ------------------  PROGRAMMA PRINCIPALE ---------------------------



int[] arrayDiNumeri = { 5, 2, 3, 8, 10 };
StampaArrayInteri(arrayDiNumeri);

int number = 2;
Console.WriteLine("Il numero originale è: " + number);
raddoppiaNumeroRef(ref number);
Console.WriteLine("Il numero raddoppiato è: " + number);




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



/*

// --------------------------------------------------ESEMPIO---------------------------------------------------------------

// ------------------  PROGRAMMA PRINCIPALE ---------------------------

int[] arrayDiNumeri = { 5, 2, 3, 8, 10 };
StampaArrayInteri(arrayDiNumeri);


// ESEMPIO PASSAGGIO PER RIFERIMENTO
int numero = 10;
Console.WriteLine("Il numero originale è: " + numero);
raddoppiaNumeroRef(ref numero);
Console.WriteLine("Il numero raddoppiato è: " + numero);



Console.WriteLine("Array di numeri originale: ");
StampaArrayInteri(arrayDiNumeri);

int[] arrayDiNumeriIncrementato = incrementoArrayNumeri(arrayDiNumeri);

Console.WriteLine("Array di numeri originale: ");
StampaArrayInteri(arrayDiNumeri);

Console.WriteLine("Array di numeri incrementato originale: ");
StampaArrayInteri(arrayDiNumeriIncrementato);




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
// Ho creato una funzione il cui valore del parametro n viene passato come una copia dal programma principale.
// Quindi modifiche al parametro n non si ripercuotono sulla variabile originale passata da fuori
// Fate riferimento alle slide sul TYPE SYSTEM per vedere tutti i tipi valore il cui comportamente è il medesimo!
// Es: [char, byte, bool, double, float, ...]
int raddoppiaNumero(int n)
{
    n = n * 2;
    return n;
}


// ATTENZIONE QUESTA FUNZIONE MODIFICA IL COMPORTAMENTO DI DEFAULT DI UNA VARIABILE DI TIPO VALORE
// PASSATA NORMALMENTE COME VALORE (COPIA)
// In questo caso non viene passata come una copia, ma come referenza della variabile originale che 
// il programma principale passa!
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
        arrayNumeri[i] = arrayNumeri[i] + 1;
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
        copiaArray[i] = copiaArray[i] + 1;
    }

    return copiaArray;
}


int SommaNumeri(int addendo1, int addendo2)
{
    int risultato = addendo1 + addendo2;
    return risultato;
}

*/