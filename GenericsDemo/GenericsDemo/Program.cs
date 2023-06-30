namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generics<int> generics = new Generics<int>(25);
            Generics<string> genericsString = new Generics<string>("Amit");
            Generics<double> genericsDouble = new Generics<double>(0.19);
            Generics<char> genericsChar = new Generics<char>('a');
            Generics<bool> genericsBool = new Generics<bool>(true);
            Generics<float> genericsFloat = new Generics<float>(1.2f);
            Generics<long> genericsLong = new Generics<long>(5);
            Console.WriteLine("=========================================================");
            generics.GenericMethod(9);
            genericsString.GenericMethod("Nayak");
            genericsDouble.GenericMethod(1.59);
            genericsChar.GenericMethod('m');
            genericsBool.GenericMethod(false);
            Console.WriteLine("==========================================================");
            GenericMethod obj = new GenericMethod();
            obj.Generic<int>(30);
            obj.Generic<string>("Kumar");

        }
    }
}