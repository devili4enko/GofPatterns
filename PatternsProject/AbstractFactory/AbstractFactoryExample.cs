using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory
{
    public class AbstractFactoryExample
    {
        public static void Run()
        {
            //тут не много денег у нас и мы строим нашу фатрику в Китае
            IToyFactory factory = new ChinaToyFactory();

            //запускаем производство
            Bear _bear = factory.GetBear();
            Cat _cat = factory.GetCat();

            //проверяем что получилось
            _bear.Talk();
            _cat.Talk();

            //внезапно появляются деньги и мы переносим нашу фабрику
            //в Германию чтобы производить более качественные продукты
            factory = new GermanToyFactory();

            //опять запускаем производство
            Bear _germanBear = factory.GetBear();
            Cat _germanCat = factory.GetCat();

            //проверка качества
            _germanBear.Talk();
            _germanCat.Talk();

            /* если мы захотим еще кудато перенести нашу фабрику
             * тогда нам все что надо сделать это:
             * 1. создать ее 
             * 2. пронаследоваться от интерфейса
             * 3. создать продукты и пронаследоваться от абстрактных класов проуктов и победа
             */

        }
    }
}
