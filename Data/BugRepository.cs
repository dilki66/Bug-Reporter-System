using BugReporterApp.Models;

namespace BugReporterApp.Data;

public static class BugRepository
{
    private static List<Bug> _bugs = new List<Bug>();
    public static List<Bug> GetAll()
    {
        return _bugs;
    }

    public static Bug GetById(int id)
    {
        return _bugs.FirstOrDefault(b => b.Id == id);
    }
}