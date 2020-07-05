using System;

namespace c_sharp_interface
{
    class Tv : ITvRemote
    {
        public int MaxVolume => 60;
        public string Device { get; }

        public Tv(string device)
        {
            Device = device;
        }

        public void AdjustBrightness()
        {
            Console.WriteLine("=> Adjusting Brightness using a button.\n");
        }

        public void AdjustVolume()
        {
            Console.WriteLine($"=> Max limit is {MaxVolume}. You can adjust volume using volume button.\n");
        }

        public void PowerOn()
        {
            Console.WriteLine($"{Device}");
            Console.WriteLine("-----------------");
            Console.WriteLine($"=> Turned on {Device}\n");
        }

        public void PowerOff()
        {
            Console.WriteLine($"=> Turned off {Device}\n");
            Console.WriteLine();
        }
    }
}
