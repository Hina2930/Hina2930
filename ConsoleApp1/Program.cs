using System;
namespace ConstStaticReadOnly
{
    public class StaticReadOnly
    {
        public readonly int iReadOnly = 2;
        public static readonly int istaticReadOnly;
        public StaticReadOnly()
        {
            iReadOnly = 10;
            //istaticReadOnly = 20; //compile time error as static variable value cannot be assigned in instance construtor  
        }
        static StaticReadOnly()
        {
            istaticReadOnly = 20;
            //iReadOnly = 20; //compile time error as instance variable value cannot be assigned in static construtor, only static value should be assigned  
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StaticReadOnly stReadObj = new StaticReadOnly();
            Console.WriteLine(String.Format("ReadOnly Value : {0}", stReadObj.iReadOnly));
            Console.WriteLine(String.Format("Static ReadOnly Value : {0}", StaticReadOnly.istaticReadOnly));
        }
    }
}