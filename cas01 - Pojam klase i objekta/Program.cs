// ---------------------------- UVOD U OBJEKTNO ORIJENTISANO PROGRAMIRANJE U C# - Pojam klase i objekta -----------------------------------

// 1.  Klasa predstavlja oredjenu jedinicu od znacaja.
//     Klasom pravimo novi tip podataka.
//     Klasa ima svoje atribute( svojstva ili polja ) i metode relevantne za nas problem.
//     Ako bi pravili informacioni sistem za skolu, sigurno necemo traziti da nas Ucenik ima broj cipela u klasi, vec atribute vezane za 
//     nas domen problema. Recimo da pravimo klasu Ucenik za novi eDnevnik.
class Ucenik{

    string ime;
    string prezime;
}

// 2.   Kada se kaze da je programski jezik objektno orijentisan, to znaci da je sve u njemu objekat tj. da sve potice od neke klasa.
//      Osnovna klasa za pogretanje naseg projekta je ona klasa koja sadrzi Main() metodu. U njoj cemo da napravimo novog ucenika.
//      Ime fajla uglavnom predstavlja i ime klase koju definise.
class Program{


    public static void Main(){
        // Objekat tipa Ucenik koji se zove prvi_ucenik
        Ucenik prvi_ucenik = new Ucenik();
        // Objekat tipa Ucenik koji se zove drugi_ucenik
        Ucenik drugi_ucenik = new Ucenik();        

    }
}