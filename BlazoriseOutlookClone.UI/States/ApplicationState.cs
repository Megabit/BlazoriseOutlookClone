using System;

namespace BlazoriseOutlookClone.States;

public record ApplicationState
{
    public bool SidebarVisible { get; set; } = true;

    public string Title { get; set; }

    public string UserName { get; set; }

    public string UserEmail { get; set; }

    public string UserAvatar { get; set; }

    public string CurrentPage { get; set; }

    public string CurrentFolder { get; set; }

    public void ChangePage( string page ) => CurrentPage = page;

    public event Action<bool> SidebarVisibilityChanged;

    public void ToggleSidebar()
    {
        SidebarVisible = !SidebarVisible;

        SidebarVisibilityChanged?.Invoke( SidebarVisible );
    }
}
