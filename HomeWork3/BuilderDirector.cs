namespace HomeWork3
{
    public class BuilderDirector
    {
        private readonly IBaseEmailBuilder _classicBuilder;

        public BuilderDirector(IBaseEmailBuilder classicBuilder)
        {
            _classicBuilder = classicBuilder;
        }

        public IEmail Build()
        {
            return _classicBuilder.BuildBase("Mario", "The princess is not in this castle!!!")
                .AddRecipient("Luigi")
                .AddTopic("Get out!")
                .Build;
        }
    }
}