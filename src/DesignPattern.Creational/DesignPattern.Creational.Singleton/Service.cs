namespace DesignPattern.Creational.Singleton
{
    public class Service
    {
        private readonly ISingleton _singleton;

        public Service() : this(SingletonClass.Instance)
        {
        }

        public Service(ISingleton singleton)
        {
            _singleton = singleton;
        }
    }
}
