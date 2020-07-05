using System;

namespace c_sharp_interface
{
    class MusicPlayer : IRemote, ITuner
    {
        public int MaxVolume => 100;
        public string Device { get; }

        public MusicPlayer(string device)
        {
            Device = device;
            Console.WriteLine($"{Device}");
            Console.WriteLine("-----------------");
        }

        public virtual void AdjustVolume()
        {
            Console.WriteLine($"=> Max limit is {MaxVolume}. You can adjust volume using voice commands.\n");
        }

        public void EnableAudioTuner()
        {
            Console.WriteLine("=> Audio tuner Enabled.\n");
        }

        public void PowerOn()
        {
            Console.WriteLine($"=> Turned on {Device}\n");
        }

        public void PowerOff()
        {
            Console.WriteLine($"=> Turned off {Device}\n");
            Console.WriteLine();
        }
    }
}
