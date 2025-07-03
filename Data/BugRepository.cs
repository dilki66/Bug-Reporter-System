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

    public static void Add(Bug bug)
    {
        bug.Id = _bugs.Count > 0 ? _bugs.Max(b => b.Id) + 1 : 1;
        bug.CreatedAt = DateTime.Now;
        _bugs.Add(bug);
    }
}