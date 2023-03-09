using SecretMessagesNet.Models;

namespace SecretMessagesNet.Services;

public static class MessageService
{
    static List<Message> Messages { get; }

    static MessageService()
    {
        Messages = new List<Message>
        {
            new Message { Id = 1, Content = "firs message", Key = "secret1" },
            new Message { Id = 2, Content = "second message", Key = "secret2" }
        };
    }

    public static List<Message> GetAll() => Messages;

    public static Message? Get(int id) => Messages.FirstOrDefault(p => p.Id == id);

    public static void Add(Message message)
    {
        message.Id = 3;
        Messages.Add(message);
    }

    public static void Update(Message message)
    {
        var index = Messages.FindIndex(p => p.Id == message.Id);
        if (index == -1)
            return;

        Messages[index] = message;
    }

    public static void Delete(int id)
    {
        var message = Get(id);
        if (message is null)
            return;

        Messages.Remove(message);
    }
}
