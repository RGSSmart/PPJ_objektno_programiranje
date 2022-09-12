    // -----------> Nova terminologija : KREIRANJE ~ KONSTRUISANJE ~ INSTANCIRANJE objekta su sve validni i isti nazivi <---------
class Ucenik{
    public  string ime;
    public  string prezime;
    // 3.   Konstuktor je specijalan metoda koja NEMA POVREATNI TIP i mora da se zove isto kao i klasa koju konstruise.
    //  Ovde je dat primer konstuktora bez parametara ( defult construtor )
    public Ucenik(){

    }
    // 4. Konstruktor bez parametara nam nece resiti problem momentalne dodele vrednosti ime i prezime, ali konstuktor sa parametrima hoce.
    // Pa kaze...
    public Ucenik( string ime, string prezime){
        // 5.   this je kljucna rec koja drzi referencu na trenutnu klasu. U ovom slucaju this operator razlikuje parametar ime od istoimenog atributa
        //      ime u klasi Ucenik. Da se parametar i polje klase drugacije zovu, this operator ne bi bio neophodan. Praksa je da se i parametar i polje
        //      klase isto zovu i da se sa razlikuju pomocu this-a.
        this.ime = ime ;
        this.prezime = prezime;        
    }
    // 6. Metode se pisu isto kao i pre
    public void dobar_dan(){
        Console.WriteLine("Ucenik kaze dobar dan");
    }
    // 7.   Jedina novina jeste kljucna rec this. Ona predstavlja referencu na 
    //      objekat koji je poziva. To nam omogucava da "personalizujemo" metode
    //      i na taj nacin sebi skratimo kod.
    public void ko_sam_ja(){
        Console.WriteLine("Dobar dan: " + this.ime + " " + this.prezime);
    }

}