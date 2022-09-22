
class Trka
{
    public string  Naziv { get; set; }
    public DateTime Datum { get; set; }
    public Mesto Mesto { get; set; }
    public Trka() { }
    public Trka(string naziv, DateTime datum, Mesto mesto) {
        this.Naziv = naziv;
        this.Datum = datum;
        // Ovde se poziva copy construkotr
        this.Mesto = new Mesto(mesto);
        

    }


}
