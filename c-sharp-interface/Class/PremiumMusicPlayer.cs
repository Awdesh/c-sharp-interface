using System;

namespace c_sharp_interface
{
    class PremiumMusicPlayer : MusicPlayer
    {
        public PremiumMusicPlayer(string device) : base(device) { }

        public override void AdjustVolume()
        {
            Console.WriteLine($"=> Max limit is {MaxVolume}. You can adjust volume using Mobile App.\n");
        }
    }
}
