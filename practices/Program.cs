using System;

namespace practices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region record
            //Myclass myclass = new Myclass()
            //{
            //    name = "emre",
            //    age = 20
            //};


            //Myrecord myrecord = new Myrecord()
            //{
            //    MyProperty = 10,
            //    MyProperty2 = 20,
            //};

            //Myrecord myrecord1 = myrecord with { MyProperty2 = 35 };

            //#endregion


            //#region constructor

            ////MyClass2 myclass2 = new(3, 5);







            //#endregion


            //Real real = new Real() { x = 1,y=2,z=3 };
            //var(x,y,z) = real;
            //Console.WriteLine($"{x} {y} {z}");
            //GC.Collect();
            //Console.ReadLine();


            //B b=new B();
            //b.write();
            B.writeStatic();

            




            










        }
    }



    public class Myclass
    {
        public int age { get; set; }
        public string name { get; init; }



    }
    public record Myrecord
    {
        public int MyProperty { get; init; }
        public int MyProperty2 { get; init; }
    }

    public class MyClass2
    {
        private int MyProperty;
        private int MyProperty2; 
        public MyClass2(int a)
        {
            MyProperty=a;
            Console.WriteLine(MyProperty+"myproperty");
        }
        public MyClass2(int b,int c):this(b)
        {
            
            MyProperty2 = c;
            Console.WriteLine(MyProperty2+"myproperty2");
        }
    }

    public class Real
    {
        public Real()
        {

            Console.WriteLine("nesne oluştu");
                
                
                
        }

        ~Real()
        {
            Console.WriteLine("nesne yıkıldı");
        }

        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }




        public void Deconstruct(out int x,out int y,out int z)
        {
            x =this.x;
            y = this.y;
            z = this.z;
        }
    }
    
    public class B
    {
        public B()
        {
            Console.WriteLine("constructer method runned");
        }
        static B()
        {
            Console.WriteLine("static constructer method runned");
        }

        public static void writeStatic()
        {
            Console.WriteLine("hello world static");
           
        }
        public  void write()
        {
            Console.WriteLine("hello world non static");
            
        }
    }

   

}
