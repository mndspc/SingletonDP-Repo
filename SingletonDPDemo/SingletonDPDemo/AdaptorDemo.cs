using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDPDemo
{
    class AdaptorDemo
    {
        static void Main()
        {
            Target target1 = new Target();
            target1.Request();

            Target target = new Adapter();
            target.Request();
            Console.ReadLine();
        }
    }

    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();
        public override void Request()
        {
            // Possibly do some other work
            // and then call SpecificRequest
            adaptee.SpecificRequest();
        }
    }
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}
