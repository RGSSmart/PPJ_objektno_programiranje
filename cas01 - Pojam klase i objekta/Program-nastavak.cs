// ---------------------------- UVOD U OBJEKTNO ORIJENTISANO PROGRAMIRANJE U C# - Pojam klase i objekta -----------------------------------
class Ucenik{

    // 4. Da bi mogli da pristupimo varijabli ime u klasi Ucenik, moramo dodati modifikator public ispred definicije. Isto vazi i za prezime.
    public string ime;
    public string prezime;
}

class Program{

    public static void Main(){
        
        Ucenik prvi_ucenik = new Ucenik();        
        Ucenik drugi_ucenik = new Ucenik();
        // 3. Ovako kreirani objekti ne dozvoljavaju da im pristupimo atributima jer im nismo dodelili kljucnu rec PUBLIC.
        //    Public, private, protected, internal su MODIFIKATORI PRISTUPA. Oni sluze da ogranice pristup atributima i metodama.
        //    Ako je nesto private to znaci da niko van klase ne moze da im pristupi.
        //    Ako je nesto public to znaci da im svako moze pristupiti.
        //    Protected i internal necemo trenutno razmatrati.

        // 5. Sada mozemo da ispisemo ime prvog ucenika
        Console.WriteLine("Ime prvog ucenika je :" + prvi_ucenik.ime);
        ConsoleWriteLine(",a prezime je :" + prvi_ucenik.prezime);

        // 6. Zasto nisu ime i prezime ispisani? Prvo moramo da im dodelimo vrednost. Pristup atributima u objektu se radi pomocu sledece sintakse:
        // SINTAKSA: objekat - tacka - atribut
        prvi_ucenik.ime = "Pera";  
        prvi_ucenik.prezime = "Peric";

        // * Da se podsetimo i formatiranog stringa za ispis *
        Console.Write("Nosi ispis imena i prezimena prvog ucenika je {0} {1}", prvi_ucenik.ime , prvi_ucenik.prezime);

        

    }
}