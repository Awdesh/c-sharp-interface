using System;

namespace c_sharp_interface
{
    class Program
    {
        private static void ChangeVolume(IRemote remote)
        {
            // Check Type of the object using Reflection
            Console.WriteLine(remote.GetType());
            remote.AdjustVolume();

        }

        static void Main(string[] args)
        {
            ChangeVolume(new Tv());
            ChangeVolume(new MusicPlayer());
            ChangeVolume(new PremiumMusicPlayer());

            Console.ReadLine();
        }

    }
}

















//Console.WriteLine("Tv Remote");
//            Console.WriteLine("==========\n");
//            Tv tv = new Tv();
//tv.AdjustVolume();
//            tv.AdjustBrightness();

//            Console.WriteLine();

//            Console.WriteLine("Music Player Remote");
//            Console.WriteLine("====================\n");
//            MusicPlayer musicPlayer = new MusicPlayer();
//musicPlayer.AdjustVolume();
