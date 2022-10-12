class Motor
{
    // Doradi klasu tako da konstruktor prebrojava
    // instance motora u Main-u i ispisuje ih posle svake promene.
    public float Kubikaza { get; set; }
    public string TipGoriva { get; set; }
    public Boolean daLiJeBrz { get; set; }
    public static int brSvihMotora = 0;
    // Dodati i brojac za dizelase
    public static int brDizelasi = 0;
    public Motor() {
        brSvihMotora++;
        Console.WriteLine("Ima " + brSvihMotora + " motora");           

    }
    public Motor(string tipGoriva) : this(){
        
        if (tipGoriva == "Dizel")
        {
            brDizelasi++;
            Console.WriteLine("Ima " + brDizelasi + " instanciranih dizelasa");
        }
    }
}
