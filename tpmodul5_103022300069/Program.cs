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

    class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData() 
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

    static void Main(string[] args)
    {
        HaloGeneric h = new HaloGeneric();
        h.SapaUser("Hapis");

        DataGeneric<String> d = new DataGeneric<string>("103022300069");
        d.PrintData();
    }
}