// 1.   Praksa u programiranju jeste da u jednom fajlu bude jedna samo klasa. Sa tim na umu, klasu Ucenik premestamo u novi fajl i
//       referenciramo ga pomocu klauzule using:
using Ucenik;
class Program{
    public static void Main(string[] args){
        Ucenik prvi_ucenik = new Ucenik();
        Ucenik drugi_ucenik = new Ucenik();
        prvi_ucenik.ime = "Pera";
        prvi_ucenik.prezime = "Peric";
        // 2. A sta ako zelimo da odmah prilikom kreiranja objekta dodelimo vrednosti za ime i prezime?
        // Da bi to uradili, moramo da koristimo jednu specijalnu metodu zvanu KONSTRUKTOR. ( pogledaj Ucenik.cs )

        // 6. Primer kreiranja treceg ucenika sa pocetnim imenom i prezimenom
        Ucenik treci_ucenik = new Ucenik("Mika", "Mikic");

    }
}