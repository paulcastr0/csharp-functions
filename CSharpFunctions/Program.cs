// See https://aka.ms/new-console-template for more information

// ------------------  PROGRAMMA PRINCIPALE ---------------------------

int[] arrayDiNumeri = { 5, 2, 3, 8, 10 };
StampaArrayInteri(arrayDiNumeri);


int Quadrato = 0;
int[] ElevaArrayAlQuadrato = { };
int sommaElementiArray = 0;















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
