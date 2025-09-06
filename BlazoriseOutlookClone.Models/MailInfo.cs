namespace BlazoriseOutlookClone.Models;

public class MailInfo
{
    public string Key { get; set; }
    public string FolderKey { get; set; }
    public string FromName { get; set; }
    public string FromEmail { get; set; }
    public string ToName { get; set; }
    public string ToEmail { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public DateTime Date { get; set; }
    public bool IsRead { get; set; }
    public bool HasAttachment { get; set; }
}
