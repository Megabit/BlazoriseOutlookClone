namespace BlazoriseOutlookClone.Models;

public class MailInfo
{
    public string Key { get; set; } = string.Empty;
    public string FolderKey { get; set; } = string.Empty;
    public string FromName { get; set; } = string.Empty;
    public string FromEmail { get; set; } = string.Empty;
    public string ToName { get; set; } = string.Empty;
    public string ToEmail { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public bool IsRead { get; set; }
    public bool HasAttachment { get; set; }
}
