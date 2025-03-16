using System;

class Program
{
    class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine("Halo user " + user);
        }
    }

    static void Main(string[] args)
    {
        HaloGeneric h = new HaloGeneric();
        h.SapaUser("Hapis");
    }
}