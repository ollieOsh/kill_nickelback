using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {

        static void Main(string[] args)
        {
            List<(string artist, string song)> goodSongs = new List<(string, string)>();

            HashSet<(string artist, string song)> allSongs = new HashSet<(string , string)>() {("Playboi Carti", "Magnolia"), ("XXXtentacion", "Look at Me"), ("Nickelback", "Photograph"), ("Nickelback", "shit"), ("Lil Pump", "Boss"), ("Astrid S", "Sushi"), ("Travis Scott", "Butterfly Effect")};
            
            foreach((string artist, string song) track in allSongs){
               if(track.artist != "Nickelback"){
                   goodSongs.Add((track.song, track.artist));
               }
            }
            
            foreach((string artist, string song) track in goodSongs){
                 Console.WriteLine("{0} by {1}", track.song, track.artist);
            }
        }
    }
}
