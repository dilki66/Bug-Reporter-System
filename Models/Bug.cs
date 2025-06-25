
namespace BugReporterApp.Models;

public class Bug
{
    public int Id { get; set; }
    public string Title { get; set; } 
    public string Description { get; set; } 
    public DateTime CreatedAt { get; set; } // when the bug was reported
    public string Status { get; set; }  //bug status (e.g., Open, In Progress, Resolved)
}