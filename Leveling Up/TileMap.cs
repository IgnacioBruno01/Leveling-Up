using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Leveling_Up
{
    class TileMap
    {
        private List<Tile> tiles;
        public TileMap(string tileMapPathTexture, string tileMapPathCSV, int tileWidht, int tileHeight, int tilesPerRow, Vector2f tileMapScale)
        {
            tiles = new List<Tile>();
            List<List<int>> tileMapIndexes = new List<List<int>>();
            string csvRawData = File.ReadAllText(tileMapPathCSV);
            csvRawData = csvRawData.Replace("\r", "");
            string[] rows = csvRawData.Split('\n');

            for (int i = 0; i < rows.Length - 1; i++)
            {
                tileMapIndexes.Add(new List<int>());
                string[] indexes = rows[i].Split(',');
                for (int j = 0; j < indexes.Length; j++)
                {
                    tileMapIndexes[i].Add(Convert.ToInt32(indexes[j]));
                }
            }

            for (int i = 0; i < tileMapIndexes.Count; i++)
            {
                for (int j = 0; j < tileMapIndexes[i].Count; j++)
                {
                    if (tileMapIndexes[i][j] != -1)
                    {
                        IntRect tileArea = new IntRect();
                        tileArea.Height = tileHeight;
                        tileArea.Width = tileWidht;
                        tileArea.Top = (tileMapIndexes[i][j] / tilesPerRow) * tileHeight;
                        tileArea.Left = (tileMapIndexes[i][j] % tilesPerRow) * tileWidht;
                        tiles.Add(new Tile(new Texture(tileMapPathTexture, tileArea), new Vector2f(tileHeight * j, tileWidht * i), tileMapScale));
                    }

                }
            }


        }
        public void Draw(RenderWindow window)
        {
            for (int i = 0; i < tiles.Count; i++)
            {
                tiles[i].Draw(window);
            }
        }
    }
}
