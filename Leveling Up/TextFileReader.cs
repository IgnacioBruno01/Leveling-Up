using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SFML.System;

namespace Leveling_Up
{
    public static class TextFileReader
    {
        public static void ReadPlayerFromFile(string path, Player player)
        {
            
            string[] lines = File.ReadAllLines(path);

            player.name = lines[0];
            player.level = Convert.ToInt32(lines[1]);
            player.maxHP = Convert.ToInt32(lines[2]);
            player.HP = player.maxHP;
            player.maxMana = Convert.ToInt32(lines[3]);
            player.mana = player.maxMana;
            player.speed = Convert.ToInt32(lines[4]);
            player.ataque = Convert.ToInt32(lines[5]);
            player.ataquemagico = Convert.ToInt32(lines[6]);
            player.defensa = Convert.ToInt32(lines[7]);
            player.defensaMagica = Convert.ToInt32(lines[8]);
            player.xpActual = Convert.ToInt32(lines[9]);
            player.xpProximoNivel = Convert.ToInt32(lines[10]);
            player.gold = Convert.ToInt32(lines[11]);

        }

        public static void ReadEnemyFromFile(string path, Enemy enemy)
        {
            
            string[] lines = File.ReadAllLines(path);

            enemy.name = lines[0];
           // switch (e.name)
           // {
           //     case "Goblin":
           //         Goblin goblin = new Goblin(path);
           //         return goblin;
           //
           //     case "Goblin Warrior":
           //         GoblinWarrior goblinWarrior = new GoblinWarrior(path);
           //         return goblinWarrior;
           //
           //     case "Hobgoblin":
           //         Hobgoblin Hobgoblin = new Hobgoblin(path);
           //         return Hobgoblin;
           //     case "Spider":
           //         Spider spider = new Spider(path);
           //         return spider;
           //     case "Wolf":
           //         Wolf wolf = new Wolf(path);
           //         return wolf;
           //     case "Orc":
           //         Orc orc = new Orc(path);
           //         return orc;
           //     case "Orc Warrior":
           //         OrcWarrior orcWarrior = new OrcWarrior(path);
           //         return orcWarrior;
           //     case "Orc King":
           //         OrcKing orcKing = new OrcKing(path);
           //         return orcKing;
           //     case "Skeleton":
           //         Skeleton skeleton = new Skeleton(path);
           //         return skeleton;
           //
           //     default:
           //         break;
           // }
            enemy.level = Convert.ToInt32(lines[1]);
            enemy.maxHP = Convert.ToInt32(lines[2]);
            enemy.HP = Convert.ToInt32(lines[3]);
            enemy.maxMana = Convert.ToInt32(lines[4]);
            enemy.mana = Convert.ToInt32(lines[5]);
            enemy.speed = Convert.ToInt32(lines[6]);
            enemy.ataque = Convert.ToInt32(lines[7]);
            enemy.ataquemagico = Convert.ToInt32(lines[8]);
            enemy.defensa = Convert.ToInt32(lines[9]);
            enemy.defensaMagica = Convert.ToInt32(lines[10]);
            enemy.xpDropeada = Convert.ToInt32(lines[11]);

        }
    }
}