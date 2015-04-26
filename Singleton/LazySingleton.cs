
namespace Singleton
{
    /// <summary>
    /// Lazy Initialization.
    /// </summary>
    class LazySingleton
    {
        private LazySingleton(){}

        class SingletonCreator
        {
            static SingletonCreator() { }
            internal static readonly LazySingleton instance = new LazySingleton();
        }

        public static LazySingleton Instance
        {
            get { return SingletonCreator.instance; }
        }

        /**Insert all other stuff your class does**/
    }
}
