using BlazoriseOutlookClone.Models;

namespace BlazoriseOutlookClone.Data;

public class MailService
{
    private readonly List<MailInfo> mails = new();
    private readonly Random random = new();
    private readonly FolderService folderService;

    private readonly string[] sampleSubjects =
    {
        "Meeting Reminder",
        "Project Update",
        "Invoice Attached",
        "Your subscription is expiring",
        "Weekend Plans",
        "Flight Confirmation",
        "System Alert: Action Required",
        "Happy Birthday 🎉",
        "Newsletter - September Edition",
        "Password Reset Request"
    };

    private readonly string[] sampleBodies =
    {
        "Hi, just a quick reminder about our upcoming meeting.",
        "Please find the attached invoice for your recent purchase.",
        "Don't forget to submit your timesheet before Friday.",
        "Your subscription will expire in 7 days. Renew today!",
        "Looking forward to catching up this weekend.",
        "Thank you for your order. Your flight details are attached.",
        "System alert detected. Please check your dashboard.",
        "Happy Birthday! Wishing you a wonderful year ahead.",
        "Here's the latest company newsletter with updates.",
        "We received a request to reset your password."
    };

    private readonly string[] sampleNames =
    {
        "Alice Johnson",
        "Bob Smith",
        "Charlie Brown",
        "Diana Prince",
        "Ethan Hunt",
        "Fiona Gallagher",
        "George Martin",
        "Hannah Davis"
    };

    private readonly string[] sampleDomains =
    {
        "example.com",
        "mail.com",
        "corp.org",
        "test.net"
    };

    public MailService( FolderService folderService )
    {
        this.folderService = folderService;
        GenerateFakeMails( 30 );
    }

    private void GenerateFakeMails( int count )
    {
        var folders = folderService.GetAllFolders();

        for ( int i = 0; i < count; i++ )
        {
            var fromName = sampleNames[random.Next( sampleNames.Length )];
            var toName = sampleNames[random.Next( sampleNames.Length )];
            var subject = sampleSubjects[random.Next( sampleSubjects.Length )];
            var body = sampleBodies[random.Next( sampleBodies.Length )];
            var folder = folders[random.Next( folders.Count )];

            var mail = new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FolderKey = folder.Key,
                FromName = fromName,
                FromEmail = $"{fromName.Replace( " ", "." ).ToLowerInvariant()}@{sampleDomains[random.Next( sampleDomains.Length )]}",
                ToName = toName,
                ToEmail = $"{toName.Replace( " ", "." ).ToLowerInvariant()}@{sampleDomains[random.Next( sampleDomains.Length )]}",
                Subject = subject,
                Body = body,
                Date = DateTime.Now.AddMinutes( -random.Next( 0, 10000 ) ),
                IsRead = random.Next( 2 ) == 0,
                HasAttachment = random.Next( 5 ) == 0 // ~20% chance
            };

            mails.Add( mail );
        }
    }

    public IReadOnlyList<MailInfo> GetAllMails() => mails;

    public IReadOnlyList<MailInfo> GetMailsByFolder( string folderKey ) =>
        mails.Where( m => m.FolderKey == folderKey ).ToList();
}
