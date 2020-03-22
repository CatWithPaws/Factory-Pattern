using System;
using System.Collections.Generic;
using System.Text;
using Factory.EnemyGenerator;
namespace Factory
{
    class LevelGenerator
    {
        public IEnemyGenerator EnemyGenerator { get; set; }


        public LevelGenerator(IEnemyGenerator enemyGenerator)
        {
            EnemyGenerator = enemyGenerator;
        }
        private void GenerateDecorations()
        {
            Console.WriteLine("Decoration was spawned");
        }

        public void GenerateLevel()
        {
            GenerateDecorations();
            EnemyGenerator.GenerateEnemies();
            Console.WriteLine("Done!\n");
        }

    }
}
