
    class Trka
    {
        public string  Naziv { get; set; }
        public DateTime Datum { get; set; }
        public Trka() {
            
        }
        public Trka(string naziv, DateTime datum) {
            this.Naziv = naziv;
            this.Datum = datum;
        }
        public override string ToString()
        {
            return Naziv;
        }

