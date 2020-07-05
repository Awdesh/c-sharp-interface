﻿namespace c_sharp_interface
{
    public interface IRemote
    {
        int MaxVolume { get; }

        // Function to raise volume
        void AdjustVolume();
    }

    public interface ITvRemote: IRemote
    {
        void AdjustBrightness();
    }

}