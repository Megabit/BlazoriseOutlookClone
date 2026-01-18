using BlazoriseOutlookClone.Models;

namespace BlazoriseOutlookClone.Data;

public class ContactService
{
    private readonly List<ContactInfo> contacts = new()
    {
        new ContactInfo
        {
            Key = Guid.NewGuid().ToString(),
            FirstName = "Alice",
            LastName = "Johnson",
            Email = "alice.johnson@example.com",
            Phone = "+1 (555) 123-4567",
            Address = "123 Maple Street",
            City = "Springfield",
            State = "IL",
            Company = "TechCorp"
        },
        new ContactInfo
        {
            Key = Guid.NewGuid().ToString(),
            FirstName = "Bob",
            LastName = "Smith",
            Email = "bob.smith@example.com",
            Phone = "+1 (555) 987-6543",
            Address = "456 Oak Avenue",
            City = "Madison",
            State = "WI",
            Company = "FinServe"
        },
        new ContactInfo
        {
            Key = Guid.NewGuid().ToString(),
            FirstName = "Charlie",
            LastName = "Brown",
            Email = "charlie.brown@example.com",
            Phone = "+1 (555) 321-7890",
            Address = "789 Pine Road",
            City = "Denver",
            State = "CO",
            Company = "HealthPlus"
        },
        new ContactInfo
        {
            Key = Guid.NewGuid().ToString(),
            FirstName = "Diana",
            LastName = "Miller",
            Email = "diana.miller@example.com",
            Phone = "+1 (555) 654-3210",
            Address = "321 Birch Lane",
            City = "Austin",
            State = "TX",
            Company = "EduSmart"
        },
        new ContactInfo
        {
            Key = Guid.NewGuid().ToString(),
            FirstName = "Ethan",
            LastName = "Clark",
            Email = "ethan.clark@example.com",
            Phone = "+1 (555) 111-2222",
            Address = "987 Cedar Court",
            City = "Seattle",
            State = "WA",
            Company = "CloudWorks"
        },
        new ContactInfo
        {
            Key = Guid.NewGuid().ToString(),
            FirstName = "Fiona",
            LastName = "Davis",
            Email = "fiona.davis@example.com",
            Phone = "+1 (555) 333-4444",
            Address = "654 Willow Street",
            City = "Portland",
            State = "OR",
            Company = "GreenTech"
        },
        new ContactInfo
        {
            Key = Guid.NewGuid().ToString(),
            FirstName = "George",
            LastName = "Evans",
            Email = "george.evans@example.com",
            Phone = "+1 (555) 777-8888",
            Address = "222 Aspen Drive",
            City = "Boston",
            State = "MA",
            Company = "MedSys"
        },
        new ContactInfo
        {
            Key = Guid.NewGuid().ToString(),
            FirstName = "Hannah",
            LastName = "White",
            Email = "hannah.white@example.com",
            Phone = "+1 (555) 999-0000",
            Address = "111 Cherry Blvd",
            City = "Miami",
            State = "FL",
            Company = "Sunrise Media"
        },
        new ContactInfo
        {
            Key = Guid.NewGuid().ToString(),
            FirstName = "Ian",
            LastName = "Green",
            Email = "ian.green@example.com",
            Phone = "+1 (555) 444-5555",
            Address = "555 Spruce Terrace",
            City = "Chicago",
            State = "IL",
            Company = "BuildRight"
        },
        new ContactInfo
        {
            Key = Guid.NewGuid().ToString(),
            FirstName = "Julia",
            LastName = "Adams",
            Email = "julia.adams@example.com",
            Phone = "+1 (555) 666-7777",
            Address = "888 Magnolia Way",
            City = "San Francisco",
            State = "CA",
            Company = "InnoSoft"
        }
    };

    public IReadOnlyList<ContactInfo> GetAllContacts() => contacts;
}
