
    class Program
    {
        static void Main(string[] args)
        {
            Trka t = new Trka("Kup Vojvodine", new DateTime());
            Trka t1 = new Trka("Kup Srbije" , new DateTime());
            Trka t2 = new Trka("Nacionalno prvenstvo", new DateTime());

            Mesto m = new Mesto("Novi Sad", "", 0);
            m.sve_trke_u_mestu.Add(t);
            m.sve_trke_u_mestu.Add(t1);
            m.sve_trke_u_mestu.Add(t2);

            Console.WriteLine("U mestu " + m.Grad + " se odrzavaju trke:");
            foreach (Trka x in m.sve_trke_u_mestu) {
                Console.WriteLine(x);
            }

        }
    }

    