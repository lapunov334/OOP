    using System;
     
    namespace NewApp
    {
        class A
        {
            public float a;
            public float b;
            /*************KONSTRUCT***************/
            public  A(float a, float b)
            {
                this.a = a;
                this.b = b;
            }
            /****************************/
            public float c1
            {
                get { return a + b; }
            }
     
            public float c2
            {
                get { return a /= b; }
            }
        }
     
        class B : A
        {
            private float d;
     
     
            /**********KONSTRUCT****************/
            public B(float d, float a, float b):base(a, b)
            {
                this.d = d;
            }
     
            /**************************/
     
            public float Summ(int temp)
            {
                if (temp > 1)
                {
                    return a + b;
                }
                else if (temp < -1)
                {
                    return a + d;
                }
                else
                {
                    return b + d;
                }
            }
        }
     
        class Program
        {
            static void Main(string[] args)
            {
                //A classA = new A(10, 5);
                B classB = new B(10, 2, 8);
     
                //Console.WriteLine(classA.c1);
                //Console.WriteLine(classA.c2);
                Console.WriteLine(classB.Summ(0));
     
                Console.ReadKey();
            }
        }
    }
