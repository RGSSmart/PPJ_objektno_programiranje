
class Program{
    public static void Main(string[] args){
        Ucenik prvi = new ucenik();
        prvi.setIme("Jovan");
        prvi.setPrezime("Popovic");
        Ucenik drugi = new ucenik("Pera", "Peric");

      prvi.javi_se();
      drugi.javi_se();
    }
}