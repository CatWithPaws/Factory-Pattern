using System;
using Factory.EnemyGenerator;
namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            LevelGenerator levelGenerator = new LevelGenerator(new HardEnemyGenerator());
            levelGenerator.GenerateLevel();

            levelGenerator.EnemyGenerator = new EasyEnemyGenerator();
            levelGenerator.GenerateLevel();

            levelGenerator.EnemyGenerator = new AverageEnemyGenerator();
            levelGenerator.GenerateLevel();
        }
    }
}
