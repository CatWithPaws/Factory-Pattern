using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.EnemyGenerator
{
    public class EasyEnemyGenerator : IEnemyGenerator
    {
        public void GenerateEnemies()
        {
            Console.WriteLine("Easy and average enemies was spawned");
        }
    }
}
