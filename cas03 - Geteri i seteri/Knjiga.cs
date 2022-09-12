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
    // Geteri sluze za vracanje atributa
    public string getNaslov(){return naslov;}
    public int getCena(){return cena;}
    // Seteri sluze za dodelu vrednosti atributima
    public void setNaslov( string naslov ){ this.naslov = naslov;}
    public void setCena(int cena){this.cena=cena;}
    // Ovako napisana klasa se pridrzava principu ENKAPSULACIJE

}
