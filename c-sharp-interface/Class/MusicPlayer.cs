using System;

namespace c_sharp_interface
{
    class MusicPlayer : IRemote, ITuner
    {
        public int MaxVolume => 100;

        public void AdjustVolume()
        {
            Console.WriteLine("---> Adjusting Volume using voice commands.\n");
        }

        public void EnableAudioTuner()
        {
            Console.WriteLine("---> Audio tuner Enabled.\n");
        }
    }
}
