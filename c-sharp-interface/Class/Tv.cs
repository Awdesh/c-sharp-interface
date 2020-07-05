using System;

namespace c_sharp_interface
{
    class Tv : ITvRemote
    {
        public int MaxVolume => 60;

        public void AdjustBrightness()
        {
            Console.WriteLine("---> Adjusting Brightness using a button.\n");
        }

        public void AdjustVolume()
        {
            Console.WriteLine("---> Adjusting Volume using volume button.\n");
        }
    }
}
