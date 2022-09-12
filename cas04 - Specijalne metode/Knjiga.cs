
// Klasa knjiga koja je bila za domaci ima dva konstruktora i sve getere i setere
// Primer instanciranja je u Program.cs fajlu
class Knjiga{

    private string naslov;
    private int cena;

    public Knjiga(){}
    public Knjiga( string naslov, int cena){
        this.naslov = naslov;
        this.cena = cena;
    }
   
    public string getNaslov(){return naslov;}
    public int getCena(){return cena;}
    public void setNaslov( string naslov ){ this.naslov = naslov;}
    public void setCena(int cena){this.cena=cena;}

    
    // Novi koncept : override
    // OVERRIDE u bukvalno prevodu znaci pregaziti nesto ili pretabati, u ovom slucaju znaci da menjamo sta radi metoda toString() 
    // tako da nama odgovara - ispisuje naslov i cenu knjige. Ovo nam dozvljava C# zbog necega sto se zove nasledjivanje, a o cemu cemo pricati detlajnije
    // kasnije. Za sada je dovoljno da znamo da svaka klasa koju napravimo ima mogucnost da override-uje toString() metodu
    public override string toString(){
        return "Ovo je univerzalni ispis svakog objekta tipa Knjiga";
    }

    // Druga metoda koja je veoma interesantna jeste Equals() metoda. Direktnim poredjenjem objekata ( sa znacima jednoakosti )
    // dobijemo uvek da su u pitanju dva razlicita objekta jer ih on poredi po memorijskim lokacijama i to ni u jednom slucaju nece biti 
    // isto. Zato je neophodno da mi obucimo nasu klasu kako da poredi objekte i da kaze da su dva objekta ista ako su im sve atributi isti.
    public  bool Equals(Knjiga obj){
        
        if(this.cena == obj.cena && this.naslov == obj.naslov){
            return true;
        }   
        return false;
    }

}
