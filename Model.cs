namespace EfCoreMigrationIssue;

public class Model
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public IReadOnlyCollection<string> Uids => _uids.ToList();
    private List<string> _uids = [];
    
    public void AddUids(IEnumerable<string> uids)
    {
        _uids.AddRange(uids);
    }
    
    public void RemoveUids(IEnumerable<string> uids)
    {
        foreach (var uid in uids)
        {
            _uids.Remove(uid);
        }
    }
}