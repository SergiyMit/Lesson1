using System;
using System.Reflection;
using Nix1;
namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly asm = Assembly.LoadFrom(@"D:\Мітряєв\Nix\Lecture1\Lecture1\Lecture1Library.dll");
            Console.WriteLine(asm.FullName);

            Type[] types = asm.GetTypes();

            foreach(Type t1 in types)
            {
                Console.WriteLine($"Name: {t1.Name} || Assembly: {t1.Assembly} || Typeinfo: {t1.GetTypeInfo()}");
            }
            Type t = asm.GetType("Lecture1Library.Diver", true, true);
            object obj = Activator.CreateInstance(t);


            MethodInfo method = t.GetMethod("Calculate");
            object result = method.Invoke(obj, new object[] { 2, 2 });
            Console.WriteLine(result);

            Type type2 = typeof(User);
            Console.WriteLine($"Name: {type2.Name}");
            User user = new User("Sergiy", 20);
            Console.ReadKey();

        }
    }
}
