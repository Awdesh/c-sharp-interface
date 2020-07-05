namespace c_sharp_interface
{
    public interface IRemote
    {
        int MaxVolume { get; }
        string Device { get; }
        void AdjustVolume();
        void PowerOn();
        void PowerOff();
    }
}
