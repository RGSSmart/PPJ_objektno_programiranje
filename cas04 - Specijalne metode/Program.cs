
class Program{
    public static void Main(string[] args){
        Knjiga prva = new Knjiga();
        prva.setCena(400);
        prva.setNaslov("Mali princ");
        Knjiga druga = new Knjiga("Ana karenjina", 500);

        Console.WriteLine(" Prva knjiga se zove " + prva.getNaslov() + " i kosta "+ prva.getCena() + "din");
        Console.WriteLine(" Druga knjiga se zove " + druga.getNaslov() + " i kosta " + druga.getCena() + "din");
    }
}