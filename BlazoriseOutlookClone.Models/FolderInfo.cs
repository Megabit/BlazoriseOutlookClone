using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazoriseOutlookClone.Models;

public class FolderInfo
{
    public string Key { get; set; }
    public string Name { get; set; }
    public int UnreadCount { get; set; }
    public bool Favorite { get; set; }
    public object IconName { get; set; }
}
