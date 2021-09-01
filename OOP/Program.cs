using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //when you have to return muliple data you can use tuple for it simplify.
            //it can return multiple data like you have to return a integer data and string data you can go for it i mean tuple


            // tuple new syle
            var Person = GetAgeAndName(23,"Mridul");
            Console.WriteLine("Person Name - " + Person.Item2);
            Console.WriteLine("Person Age - " + Person.Item1);

            

            // tuple old style
            var Person2 = GetAgeAndName2();
            Console.WriteLine("Person Name - " + Person2.Item2);
            Console.WriteLine("Person Age - " + Person2.Item1);



            // you can use this like that
            var (age,name) = GetAgeAndName(27,"tanvir");
            Console.WriteLine("person Name - "+ name);
            Console.WriteLine("person Name - " + age);

        }


        // in c# 7 Tuple update like this or you can say tuple new style
        public static Tuple<int,string> GetAgeAndName(int age,string name)
        {
            return Tuple.Create(age,name);
        }


        // before c# 7 tuple use like this or you can say tuple old style
        public static (int,string) GetAgeAndName2()
        {
            int age = 28;
            string name = "Zakaria";
            return(age, name);
        }

    }
}


