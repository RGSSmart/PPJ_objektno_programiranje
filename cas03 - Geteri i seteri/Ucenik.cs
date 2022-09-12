// Dodavanje getera i setera na klasu Ucenik
class Ucenik{

    // Atributi klase se uvek pise da su PRIVATNI clanovi klase
    private string ime;
    private string prezime;

    // Metode se uvek pisu da su JAVNI clanovi klase ( osim ako je bas privatna metoda )
    public Ucenik() { }
    public Ucenik(string naslov, int cena)
    {
        this.naslov = naslov;
        this.cena = cena;
    }
    public string javi_se(){
        return "Cao, ja sam " +this.ime + " " + this.prezime;
    }
    // Geteri sluze za vracanje atributa
    public string getIme() { return ime; }
    public int getPrezime() { return prezime; }
    // Seteri sluze za dodelu vrednosti atributima
    public void setIme(string ime) { this.ime = ime; }
    public void setPrezime(int prezime) { this.prezime = prezime; }

    // Ovako napisana klasa se pridrzava principu ENKAPSULACIJE

}
