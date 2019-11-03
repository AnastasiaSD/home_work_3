namespace HomeWork3
{
    public interface IBaseEmailBuilder
    {
        IFinalEmailBuilder BuildBase(string recipient, string body);
    }
}