using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    //Generic means General form 
    //It dose not Specify a perticular Data type
    //We are using <> (Angular barket) with type name.
    //TypeName <T> T is your type parameater
    //Generic Allow us to a single class or method that can be used in a different Datatype.
    // Advantage - We can reuse the code.
    public class Generics<T>
    {
        //public string name;
        public T data;
        public Generics(T data)
        {
            this.data = data;
            Console.WriteLine(this.data);
        }
        public void GenericMethod(T num)
        {
            Console.WriteLine(num);
        }
       
    }
    public class GenericMethod
    {
        public void Generic<T>(T num)
        {
            Console.WriteLine(num);
        }
        public void GenericMethodOne<T>(T num)
        {
            Console.WriteLine(num);
        }
    }
}
