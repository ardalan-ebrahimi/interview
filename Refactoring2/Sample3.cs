public class FileManager
{
    public void WriteToFile(string content)
    {
        File.WriteAllText("output.txt", content);
    }

    public void LogError(string errorMessage)
    {
        File.WriteAllText("error.log", $"Error: {errorMessage}");
    }

    public void SendEmail(string recipient, string subject, string message)
    {
        // Code to send an email
    }
}

class Program_Example3
{
    static void Main()
    {
        var manager = new FileManager();

        manager.WriteToFile("This is some data.");
        manager.LogError("An error occurred.");
        manager.SendEmail("recipient@example.com", "Subject", "This is an email.");
    }
}
