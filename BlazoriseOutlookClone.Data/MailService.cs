using BlazoriseOutlookClone.Models;

namespace BlazoriseOutlookClone.Data;

public class MailService
{
    List<MailInfo> mails = new List<MailInfo>
        {
           new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "Alice Johnson",
                FromEmail = "alice.johnson@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Meeting Reminder",
                Body = @"Hi Bob,

I just wanted to remind you about our meeting scheduled for tomorrow at 10 AM in the conference room. We’ll go over the quarterly results and discuss the roadmap for the next sprint. Please make sure you bring your updated project notes, as we’ll need to align tasks and deadlines.

If you have any blockers or issues that might prevent us from reaching our milestones, this would be the best time to raise them. I’ve attached the presentation draft for your review.

See you tomorrow,
Alice",
                Date = DateTime.Now.AddDays(-1),
                IsRead = true,
                HasAttachment = false
            },
            new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "HR Department",
                FromEmail = "hr@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Policy Update",
                Body = @"Dear Bob,

We have recently updated our company policies regarding remote work and annual leave. The key changes include new guidelines for hybrid schedules, expanded options for health benefits, and improved parental leave provisions. Please review the attached policy document carefully.

It is mandatory for all employees to acknowledge receipt of this update. You may reply to this email once you’ve read the attachment to confirm. If you have any questions, don’t hesitate to reach out to HR directly.

Best regards,
HR Team",
                Date = DateTime.Now.AddDays(-2),
                IsRead = false,
                HasAttachment = true
            },
            new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "Charlie Brown",
                FromEmail = "charlie.brown@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Lunch Invitation",
                Body = @"Hey Bob,

It’s been a while since we caught up outside of work. How about we grab lunch tomorrow at noon? I was thinking about that new Italian place near the office. Their menu looks great and I’ve heard good things about their pasta.

If you’re busy, we can always reschedule, but it would be great to take a break from the office and chat about non-work stuff for once. Let me know if you’re in.

Cheers,
Charlie",
                Date = DateTime.Now.AddDays(-3),
                IsRead = true,
                HasAttachment = false
            },
            new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "Project Manager",
                FromEmail = "pm@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Weekly Report",
                Body = @"Bob,

Please find attached the weekly project report. We’ve made significant progress on the backend integration, but we’re still behind on the UI tasks. I’d like you to review the pending items in your area and provide an estimate on when they will be completed.

Additionally, QA has raised several tickets regarding stability issues in the last build. Make sure to coordinate with them to ensure these are resolved before the next release candidate.

Regards,
Project Manager",
                Date = DateTime.Now.AddDays(-4),
                IsRead = false,
                HasAttachment = true
            },
            new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "Support Team",
                FromEmail = "support@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Ticket Resolved",
                Body = @"Hello Bob,

We are pleased to inform you that your support ticket #12345 has been resolved. The root cause of the issue was identified as a configuration mismatch on the server, which has now been corrected. You should no longer experience any disruptions.

If you continue to encounter issues, please reply to this email or open a new support request. Your satisfaction is important to us.

Best regards,
Support Team",
                Date = DateTime.Now.AddDays(-5),
                IsRead = true,
                HasAttachment = false
            },
            new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "Marketing",
                FromEmail = "marketing@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Special Offer!",
                Body = @"Hi Bob,

We’re excited to let you know about our limited-time special offer! For the next seven days, you can enjoy up to 50% off selected products and services. This is a great opportunity to upgrade your current plan or explore new features we’ve recently released.

Full details can be found in the attached brochure. Don’t miss out—this deal ends at midnight on Friday.

Cheers,
The Marketing Team",
                Date = DateTime.Now.AddDays(-6),
                IsRead = false,
                HasAttachment = true
            },
            new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "Jane Doe",
                FromEmail = "jane.doe@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Conference Call",
                Body = @"Hi Bob,

Are you available for a conference call at 3 PM today? The client has some urgent questions about the implementation details, and I’d like both of us to be on the call to provide technical insights.

Please confirm your availability as soon as possible. If you’re tied up, I’ll handle the call but would prefer to have you there for support.

Thanks,
Jane",
                Date = DateTime.Now.AddHours(-6),
                IsRead = false,
                HasAttachment = false
            },
            new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "Finance Department",
                FromEmail = "finance@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Invoice Attached",
                Body = @"Dear Bob,

Please find attached invoice #98765 for your review. This invoice covers the subscription renewal for the upcoming year, as well as additional service charges incurred during the last quarter.

Kindly review the document and confirm once the payment has been processed. If you require any clarifications, please contact our accounts team directly.

Thank you,
Finance Department",
                Date = DateTime.Now.AddDays(-7),
                IsRead = true,
                HasAttachment = true
            },
            new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "System Admin",
                FromEmail = "admin@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Password Expiry Notice",
                Body = @"Dear Bob,

This is a reminder that your system password will expire in 5 days. For security reasons, please ensure that you update your password before the expiry date to avoid losing access.

You can change your password through the company portal or by contacting IT support. Please use a strong password and avoid reusing old ones.

Regards,
System Administration",
                Date = DateTime.Now.AddDays(-8),
                IsRead = true,
                HasAttachment = false
            },
            new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "Emily Clark",
                FromEmail = "emily.clark@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Project Feedback",
                Body = @"Hi Bob,

I’ve gone through the recent deliverables and wanted to share my feedback. Overall, the work is on the right track, but there are several areas that could be improved. Specifically, I think we need more detailed documentation for the API methods and additional unit tests to cover edge cases.

Let’s schedule a quick call later this week to go over the points in detail.

Thanks,
Emily",
                Date = DateTime.Now.AddDays(-9),
                IsRead = false,
                HasAttachment = false
            },
            new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "IT Helpdesk",
                FromEmail = "ithelp@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Scheduled Maintenance",
                Body = @"Dear Bob,

Please note that scheduled system maintenance will take place this weekend from Saturday 10 PM to Sunday 6 AM. During this time, access to internal tools and email may be unavailable.

We apologize for any inconvenience this may cause and appreciate your understanding.

Best regards,
IT Helpdesk",
                Date = DateTime.Now.AddDays(-10),
                IsRead = true,
                HasAttachment = false
            },
            new MailInfo
            {
                Key = Guid.NewGuid().ToString(),
                FromName = "Recruiter",
                FromEmail = "jobs@example.com",
                ToName = "Bob Smith",
                ToEmail = "bob.smith@example.com",
                Subject = "Job Opportunity",
                Body = @"Hi Bob,

I hope this message finds you well. I came across your profile and thought you might be a great fit for an open position at one of our client companies. They are looking for someone with strong experience in .NET and cloud platforms, and based on your background, I believe you’d be an excellent candidate.

Please see the attached job description. If you’re interested, reply with your updated resume and availability for a quick introductory call.

Best regards,
Recruiter",
                Date = DateTime.Now.AddDays(-11),
                IsRead = false,
                HasAttachment = true
            }
        };

    public List<MailInfo> GetAllMails()
    {
        return mails;
    }
}
