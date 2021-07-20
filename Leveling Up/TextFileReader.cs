using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Leveling_Up
{
    public static class TextFileReader
    {
        public static Player ReadPlayerFromFile(string path)
        {
            Player p = new Player();
            string[] lines = File.ReadAllLines(path);

            p.type = lines[0];
            p.name = lines[1];
            p.level = Convert.ToInt32(lines[2]);
            p.maxHP = Convert.ToInt32(lines[3]);
            p.HP = Convert.ToInt32(lines[4]);
            p.maxMana = Convert.ToInt32(lines[5]);
            p.mana = Convert.ToInt32(lines[6]);
            p.speed = Convert.ToInt32(lines[7]);
            p.ataque = Convert.ToInt32(lines[8]);
            p.ataquemagico = Convert.ToInt32(lines[9]);
            p.defensa = Convert.ToInt32(lines[10]);
            p.defensaMagica = Convert.ToInt32(lines[11]);
            p.xpActual = Convert.ToInt32(lines[12]);
            p.xpProximoNivel = Convert.ToInt32(lines[13]);
            p.gold = Convert.ToInt32(lines[14]);

            return p;
        }

        public static Enemy ReadEnemyFromFile(string path)
        {
            Enemy e = new Enemy();
            string[] lines = File.ReadAllLines(path);

            e.type = lines[0];
            switch (e.type)
            {
                case "Goblin":
                    Goblin goblin = new Goblin(path);
                    return goblin;

                case "Goblin Warrior":
                    GoblinWarrior goblinWarrior = new GoblinWarrior(path);
                    return goblinWarrior;

                case "Hobgoblin":
                    Hobgoblin Hobgoblin = new Hobgoblin(path);
                    return Hobgoblin;
                case "Spider":
                    Spider spider = new Spider(path);
                    return spider;
                case "Wolf":
                    Wolf wolf = new Wolf(path);
                    return wolf;
                case "Orc":
                    Orc orc = new Orc(path);
                    return orc;
                case "Orc Warrior":
                    OrcWarrior orcWarrior = new OrcWarrior(path);
                    return orcWarrior;
                case "Orc King":
                    OrcKing orcKing = new OrcKing(path);
                    return orcKing;
                case "Skeleton":
                    Skeleton skeleton = new Skeleton(path);
                    return skeleton;

                default:
                    break;
            }
            e.name = lines[1];
            e.level = Convert.ToInt32(lines[2]);
            e.maxHP = Convert.ToInt32(lines[3]);
            e.HP = Convert.ToInt32(lines[4]);
            e.maxMana = Convert.ToInt32(lines[5]);
            e.mana = Convert.ToInt32(lines[6]);
            e.speed = Convert.ToInt32(lines[7]);
            e.ataque = Convert.ToInt32(lines[8]);
            e.ataquemagico = Convert.ToInt32(lines[9]);
            e.defensa = Convert.ToInt32(lines[10]);
            e.defensaMagica = Convert.ToInt32(lines[11]);
            e.xpDropeada = Convert.ToInt32(lines[12]);
            e.botin = lines[13];

            return e;
        }
    }
}