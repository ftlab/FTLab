namespace FTCli
{
    public interface ICli
    {
        void UseFormaterr(IFormatter formatter);

        void WriteLine(object value);
    }
}
