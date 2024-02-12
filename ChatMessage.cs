
using System.Diagnostics.Contracts;

public class ChatMessage {

    public int MessageId;
    public string ? Content;
    public DateTime Timestamp; 
    public int SourceId;

    public ChatMessage(string content)
    {
        Random randgen = new Random();

        MessageId = randgen.Next();
        SourceId = randgen.Next();
        Content = content;
        Timestamp = DateTime.Now;
    }

    public override string ToString()
    {
        return $@"
            MessageId:  {MessageId}
            Content:    {Content}
            Timestamp:  {Timestamp}
            SourceId:   {SourceId}
        ";
    }

}