using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
    public class Enemy : Character
    {
        public int xpDropeada;
        
        public Enemy(string path, Vector2f position, string name) : base(path, position)
        {
            TextFileReader.ReadEnemyFromFile("Monstruos/" +name+ " Stat.txt", this);
        }
        public bool muerteEnemy()
        {
            return HP <= 0;
        }
    }

    //public sealed class Goblin : Enemy
    //{
    //    public Goblin(string path, Vector2f position, string name) : base(path, position, name)
    //    {
    //        this = TextFileReader.ReadEnemyFromFile("Monstruos/Stage1/Goblin Stat.txt");
    //    }
    //}
    //public sealed class GoblinWarrior : Enemy
    //{
    //    public GoblinWarrior(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage1/Goblin Warrior Stat.txt");
    //    }
    //}
    //public sealed class Hobgoblin : Enemy
    //{
    //    public Hobgoblin(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage1/Hoboblin Stat.txt");
    //    }
    //}
    //public sealed class Spider : Enemy
    //{
    //    public Spider(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage1/Spider Stat.txt");
    //    }
    //}
    //public sealed class Wolf : Enemy
    //{
    //    public Wolf(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage1/Wolf Stattxt");
    //    }
    //}
    //public sealed class Orc : Enemy
    //{
    //    public Orc(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage2/Orc Stat.txt");
    //    }
    //}
    //public sealed class OrcWarrior : Enemy
    //{
    //    public OrcWarrior(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage2/Orc Warrior Stat.txt");
    //    }
    //}
    //public sealed class OrcKing : Enemy
    //{
    //    public OrcKing(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage2/Orc King Stat.txt");
    //    }
    //}
    //public sealed class Skeleton : Enemy
    //{
    //    public Skeleton(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage3/Skeleton Stat.txt");
    //    }
    //}
    //public sealed class SkeletonWarrior : Enemy
    //{
    //    public SkeletonWarrior(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage3/Skeleton Warrior Stat.txt");
    //    }
    //}
    //public sealed class SkeletonArcher : Enemy
    //{
    //    public SkeletonArcher(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage3/Skeleton Archer Stat.txt");
    //    }
    //}
    //public sealed class SkeletonMaze : Enemy
    //{
    //    public SkeletonMaze(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage3/Skeleton Maze Stat.txt");
    //    }
    //}
    //public sealed class Ghost : Enemy
    //{
    //    public Ghost(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage3/Ghost Stat.txt");
    //    }
    //}
    //public sealed class Dullahan : Enemy
    //{
    //    public Dullahan(string path, Vector2f position, string type, string name, int level, int maxHP, int HP, int maxMana, int mana,
    //        int speed, int ataque, int ataquemagico, int defensa, int defensaMagica) : base(path, position, type, name, level, maxHP, HP, maxMana, mana,
    //         speed, ataque, ataquemagico, defensa, defensaMagica)
    //    {
    //        TextFileReader.ReadEnemyFromFile("Monstruos/Stage3/Dullahan Stat.txt");
    //    }
    //}
}   //