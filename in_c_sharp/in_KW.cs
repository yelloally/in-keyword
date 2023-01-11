using System;
using System.Diagnostics;
using System.Threading;
using System.Text;

class Program {
    struct MyStruct
    {
        public decimal a;
        public decimal b;
        public decimal c;
        public decimal d;
        public decimal e;
    }

    //create a method without modifier
    static void Foo(MyStruct value)
    {

    }
    //create a method with 'IN' modifier
    static void Bar(in MyStruct value)
    {

    }

    static void Main(string[] args)
    {
       
        //calling our structure
        MyStruct a = new MyStruct();

        //creating a variable with timer
        var sw = new Stopwatch();
        sw.Start();

        //creating a condition for timer
        for (int i = 0; i < int.MaxValue; i++)
        {
            Foo(a);
        }

        sw.Stop();
        var elapsed = sw.ElapsedMilliseconds;

        //output the result 
        Console.WriteLine($"Foo {sw.ElapsedMilliseconds}");

        sw.Restart();

        for (int i = 0; i < int.MaxValue; i++)
        {
            Bar(a);
        }

        sw.Stop();

        Console.WriteLine($"Bar {sw.ElapsedMilliseconds}");

        //output
        //Foo 21233
        //Bar 5793
    }

}
