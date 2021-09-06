using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  The constructor is protected---can not use new
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            //Test instances
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instances");
            }
            Console.WriteLine(Singleton.Message("Hello"));
            Console.WriteLine(Singleton.Message("Hello World"));
            Console.ReadLine();
        }
    }
   public class Singleton
    {
        static Singleton instance;
        //  Constructor is protected
        protected Singleton()
        {
            Console.WriteLine("Constructor invoked");
        }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
               
            }
            return instance;
        }
    
        public static string Message(string msg)
        {
            return msg;
        }
    }
}
