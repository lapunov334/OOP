using System;

namespace NewApp
{
    class A
    {
        private float a = 9;
        private float b = 3;
 
        public float c1
        {
            get { return a/b; }
        }
        
        public float c2 
        {
            get { return a-b; }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A();
            
            Console.WriteLine(classA.c1);
            Console.WriteLine(classA.c2);
            Console.ReadKey();
        }
    }
}
