using System;

namespace c_sharp_interface
{
    class MusicPlayer : IRemote
    {
        public int MaxVolume => 100;

        public void AdjustVolume()
        {
            Console.WriteLine("---> Adjusting Volume using voice commands.\n");
        }
    }
}
