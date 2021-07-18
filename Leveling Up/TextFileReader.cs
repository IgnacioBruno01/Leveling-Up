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

            p.name = lines[0];
            p.level = Convert.ToInt32(lines[1]);
            p.maxHP = Convert.ToInt32(lines[2]);
            p.HP = Convert.ToInt32(lines[3]);
            p.maxMana = Convert.ToInt32(lines[4]);
            p.mana = Convert.ToInt32(lines[5]);
            p.speed = Convert.ToInt32(lines[6]);
            p.ataque = Convert.ToInt32(lines[7]);
            p.ataquemagico = Convert.ToInt32(lines[8]);
            p.defensa = Convert.ToInt32(lines[9]);
            p.defensaMagica = Convert.ToInt32(lines[10]);
            p.xpActual = Convert.ToInt32(lines[11]);
            p.xpProximoNivel = Convert.ToInt32(lines[12]);

            return p;
        }

        public static Enemy ReadEnemyFromFile(string path)
        {
            Enemy e = new Goblin();
            string[] lines = File.ReadAllLines(path);

            e.name = lines[0];
            e.level = Convert.ToInt32(lines[1]);
            e.maxHP = Convert.ToInt32(lines[2]);
            e.HP = Convert.ToInt32(lines[3]);
            e.maxMana = Convert.ToInt32(lines[4]);
            e.mana = Convert.ToInt32(lines[5]);
            e.speed = Convert.ToInt32(lines[6]);
            e.ataque = Convert.ToInt32(lines[7]);
            e.ataquemagico = Convert.ToInt32(lines[8]);
            e.defensa = Convert.ToInt32(lines[9]);
            e.defensaMagica = Convert.ToInt32(lines[10]);
            e.xpDropeada = Convert.ToInt32(lines[11]);
            e.botin =lines[12];

            return e;
        }
    }
}
