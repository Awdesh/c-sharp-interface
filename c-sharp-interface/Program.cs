using System;

namespace c_sharp_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tv Remote");
            Console.WriteLine("==========\n");
            Tv tv = new Tv();
            tv.AdjustVolume();
            tv.AdjustBrightness();
            Console.WriteLine();

            Console.WriteLine("Music Player Remote");
            Console.WriteLine("====================\n");
            MusicPlayer musicPlayer = new MusicPlayer();
            musicPlayer.AdjustVolume();

            Console.ReadLine();
        }
    }
}
