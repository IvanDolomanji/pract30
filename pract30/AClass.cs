using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract30
{
    /// <summary>
    /// 
    /// </summary>
    abstract class AClass
    {
        /// <summary>
        /// обычный метод
        /// </summary>
        public void Method1()=> Console.WriteLine("Обычный метод  Method1 из а.к. AClass");



        /// <summary>
        /// виртуальный метод
        /// </summary>
        public virtual void Method2() => Console.WriteLine("Виртуальный метод Method2 из а.к. AClass");



        /// <summary>
        /// абстрактный метод
        /// </summary>
        public abstract void Method3();



        /// <summary>
        /// абстрактный метод 2
        /// </summary>
        public abstract void Method4();




    }
}
