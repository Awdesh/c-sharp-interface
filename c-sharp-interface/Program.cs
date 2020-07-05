using System;

namespace c_sharp_interface
{
    class Program
    {
        private static void ExecuteCalls(IRemote remote)
        {
            remote.PowerOn();
            remote.AdjustVolume();
            remote.PowerOff();
        }

        static void Main(string[] args)
        {
            ExecuteCalls(new Tv("TV"));
            ExecuteCalls(new MusicPlayer("Music Player"));
            ExecuteCalls(new PremiumMusicPlayer("Premium Music Player"));

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
