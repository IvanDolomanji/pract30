using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract30
{
    class DerivedClass : AClass
    {
        /// <summary>
        /// переопределенный виртуальный метод с именем Method2
        /// </summary>
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("Метод Method2 из класса AClass, реализованный в производный класс DerivedClass");
        }
        /// <summary>
        /// переопределенный виртуальный метод с именем Method3
        /// </summary>
        public override void Method3()
        {
            Console.WriteLine("Метод Method3 из класса AClass, реализованыый в производный класс DerivalClass");
        }
        /// <summary>
        /// переопределенный виртуальный метод с именем Method4
        /// </summary>
        public override void Method4()
        {
            Console.WriteLine("Метод Method4 из класса AClass, реализованыый в производный класс DerivalClass");
        }

    }
}

