namespace HomeWork3
{
    public interface IFinalEmailBuilder
    {
        IFinalEmailBuilder AddTopic(string topic);
        IFinalEmailBuilder AddRecipient(string recipient);
        IEmail Build { get; }
    }
}