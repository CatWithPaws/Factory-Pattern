using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.EnemyGenerator
{
    class HardEnemyGenerator : IEnemyGenerator
    {
        public void GenerateEnemies()
        {
            Console.WriteLine("ONLY HARDCORE!!!!!");
        }
    }
}
