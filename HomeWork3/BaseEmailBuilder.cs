using System.Collections.Generic;

namespace HomeWork3
{
    public class BaseEmailBuilder : IBaseEmailBuilder
    {
        public IFinalEmailBuilder BuildBase(string recipient, string body)
        {
            return new FinalEmailBuilder(recipient, body);
        }

        private class FinalEmailBuilder : IFinalEmailBuilder
        {
            private readonly Email _email = new Email();

            public FinalEmailBuilder(string recipient, string body)
            {
                _email.Recipients = new List<string>() {recipient};
                _email.Body = body;
            }

            public IFinalEmailBuilder AddTopic(string topic)
            {
                _email.Topic = topic;
                return this;
            }

            public IFinalEmailBuilder AddRecipient(string recipient)
            {
                _email.Recipients.Add(recipient);
                return this;
            }

            public IEmail Build => _email;
        }

        private class Email : IEmail
        {
            public List<string> Recipients { get; set; }
            public string Topic { get; set; }
            public string Body { get; set; }

            public override string ToString() => $"Получатели: {string.Join(", ", Recipients)}\n" +
                                                 $"Тема: {Topic}\nСообщение: {Body}";
        }
    }
}