using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.EnemyGenerator
{
    public class AverageEnemyGenerator : IEnemyGenerator
    {
        public void GenerateEnemies()
        {
            Console.WriteLine("More Average and Less Easy enemies were spawned");
        }
    }
}
