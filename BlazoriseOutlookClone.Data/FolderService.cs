using BlazoriseOutlookClone.Models;

namespace BlazoriseOutlookClone.Data;

public class FolderService
{
    List<FolderInfo> folders = new List<FolderInfo>
    {
        new FolderInfo { Key = Guid.NewGuid().ToString(), Name = "Inbox", UnreadCount = 17, IconName = Blazorise.Icons.FluentUI.FluentUIIcons.MailInbox, Favorite = true },
        new FolderInfo { Key = Guid.NewGuid().ToString(), Name = "Sent Items" ,  IconName = Blazorise.Icons.FluentUI.FluentUIIcons.Send, Favorite = true},
        new FolderInfo { Key = Guid.NewGuid().ToString(), Name = "Drafts",  IconName = Blazorise.Icons.FluentUI.FluentUIIcons.Drafts, Favorite = true },
        new FolderInfo { Key = Guid.NewGuid().ToString(), Name = "Deleted Items", IconName = Blazorise.Icons.FluentUI.FluentUIIcons.Delete, UnreadCount = 6 },
        new FolderInfo { Key = Guid.NewGuid().ToString(), Name = "Junk Email", IconName = Blazorise.Icons.FluentUI.FluentUIIcons.MailProhibited, },
        new FolderInfo { Key = Guid.NewGuid().ToString(), Name = "Notes" , IconName = Blazorise.Icons.FluentUI.FluentUIIcons.Note,},
        new FolderInfo { Key = Guid.NewGuid().ToString(), Name = "Archive" , IconName = Blazorise.Icons.FluentUI.FluentUIIcons.Archive,},
        new FolderInfo { Key = Guid.NewGuid().ToString(), Name = "Conversation History" , IconName = Blazorise.Icons.FluentUI.FluentUIIcons.Folder,},
        new FolderInfo { Key = Guid.NewGuid().ToString(), Name = "Search Folders" , IconName = Blazorise.Icons.FluentUI.FluentUIIcons.FolderSearch,},
    };

    public List<FolderInfo> GetAllFolders()
    {
        return folders;
    }
}
