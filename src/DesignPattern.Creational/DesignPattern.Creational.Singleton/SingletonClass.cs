namespace DesignPattern.Creational.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ISingleton
    {
    }

    public class SingletonClass : ISingleton
    {
        protected SingletonClass()
        {
        }

        private static SingletonClass _instance;
        public static SingletonClass Instance =>
            _instance = _instance ?? new SingletonClass();
    }
}