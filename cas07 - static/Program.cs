
class Program
{
    static void Main(string[] args) {

        Motor m = new Motor();
        m.TipGoriva = "Dizel";
        Motor m1 = new Motor();
        Motor m2 = new Motor("Dizel");
        Motor m3 = new Motor();
    }
}

