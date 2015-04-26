
namespace Singleton
{
    /// <summary>
    /// Eager Initialization.
    /// Thread Safe
    /// </summary>
    class EagerSingleton
    {
        private static readonly EagerSingleton instance = new EagerSingleton();

        static EagerSingleton() { }

        public static EagerSingleton Instance
        {
            get { return instance; }
        }

        /**Insert all other stuff your class does**/
    }
}
