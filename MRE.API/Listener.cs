using System;

namespace MRE.API
{
    public class Listener : IDisposable
    {
        public Listener(Repo.Repo repo)
        {
            Console.WriteLine("Listener created");
        }

        public void StartHub()
        {
            // starting hub here
        }

        public void Dispose()
        {
            Console.WriteLine("Listener disposed");
        }
    }
}