using System;
using System.Collections.Generic;
using System.IO;

namespace Music
{

    public class MusicAlbum
    {
        public string Artist { get; set; }
        public string Album { get; set; }
        public int SongsNumber { get; set; }
        public int Year { get; set; }
        public int DownloadNumber { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<MusicAlbum> albums = LoadAlbumsFromFile(@"C:\Users\niewi\Downloads\Desktop-Apps-2024-2025\Music\Data.txt");
            DisplayAlbums(albums);
        }

        static List<MusicAlbum> LoadAlbumsFromFile(string path)
        {
            List<MusicAlbum> albums = new List<MusicAlbum>();

            try
            {
                string[] lines = File.ReadAllLines(path);
                MusicAlbum currentAlbum = null;

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        if (currentAlbum != null)
                        {
                            albums.Add(currentAlbum);
                            currentAlbum = null;
                        }
                        continue;
                    }

                    if (currentAlbum == null)
                    {
                        currentAlbum = new MusicAlbum();
                        currentAlbum.Artist = line.Trim();
                    }
                    else if (currentAlbum.Album == null)
                    {
                        currentAlbum.Album = line.Trim('"', ' ', '\t');
                    }
                    else if (currentAlbum.SongsNumber == 0)
                    {
                        currentAlbum.SongsNumber = int.Parse(line.Trim());
                    }
                    else if (currentAlbum.Year == 0)
                    {
                        currentAlbum.Year = int.Parse(line.Trim());
                    }
                    else if (currentAlbum.DownloadNumber == 0)
                    {
                        currentAlbum.DownloadNumber = int.Parse(line.Trim());
                    }
                }

                if (currentAlbum != null)
                {
                    albums.Add(currentAlbum);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return albums;
        }

        static void DisplayAlbums(List<MusicAlbum> albums)
        {

            foreach (MusicAlbum album in albums)
            {
                Console.WriteLine($"{album.Artist}");
                Console.WriteLine($"{album.Album}");
                Console.WriteLine($"{album.SongsNumber}");
                Console.WriteLine($"{album.Year}");
                Console.WriteLine($"{album.DownloadNumber}");
                Console.WriteLine();
            }
        }
    }
}
