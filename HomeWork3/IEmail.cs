using System.Collections.Generic;

namespace HomeWork3
{
    public interface IEmail
    {
        List<string> Recipients { get; }
        string Topic { get; }
        string Body { get; }
    }
}