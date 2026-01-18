namespace BlazoriseOutlookClone.Models;

public class FolderInfo
{
    public string Key { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int UnreadCount { get; set; }
    public bool Favorite { get; set; }
    public object IconName { get; set; } = default!;
}
