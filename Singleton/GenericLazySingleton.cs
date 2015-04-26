using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Generic Lazy Static Initialization
    /// </summary>
    /// <typeparam name="T">Type you want to create.</typeparam>
    public sealed class Singleton<T> 
        where T : class /*reference type only*/, 
                  new() /*parameter-less constructor: closest thing we got to a private constructor*/
    {
        class SingletonCreator
        {
            static SingletonCreator() { }
            internal static readonly T instance = new T();
        }

        public static T Instance
        {
            get { return SingletonCreator.instance; }
        }
    }
}
