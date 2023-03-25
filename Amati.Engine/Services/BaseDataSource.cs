namespace Amati.Engine.Services;

public class BaseDataSource<T> : IDataSource<T>
{
    protected List<T> _plainList = new();

    public BaseDataSource()
    {
        if(typeof(T) == typeof(Plain))
        {
            _plainList = Enumerable.Range(0, 10)
                .Select(x => new Plain(x, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString()))
                .Cast<T>()
                .ToList();
        }

        if (typeof(T) == typeof(User))
        {
            _plainList = Enumerable.Range(0, 10)
                .Select(x => new User(x, Guid.NewGuid().ToString(), Guid.NewGuid().ToString()))
                .Cast<T>()
                .ToList();
        }

        if (typeof(T) == typeof(Some))
        {
            _plainList = Enumerable.Range(0, 10)
                .Select(x => new Some(x, Guid.NewGuid().ToString(), Guid.NewGuid().ToString()))
                .Cast<T>()
                .ToList();
        }

    }

    public ICollection<T> GetPage(int page, int pageSize, string? dataPropertyName, bool orderAsc,
        string search)
        => GetPageInternal(page, pageSize, dataPropertyName, orderAsc, search);

    public int GetPagesCount(int pageSize)
    {
        var pages = _plainList.Count % pageSize == 0
            ? _plainList.Count / pageSize
            : _plainList.Count / pageSize + 1;

        return pages;
    }

    object IDataSource.GetPage(int page, int pageSize, string? dataPropertyName, bool orderAsc,
        string search)
        => GetPageInternal(page, pageSize, dataPropertyName, orderAsc, search);

    private ICollection<T> GetPageInternal(
        int page,
        int pageSize,
        string? dataPropertyName,
        bool orderAsc,
        string search)
    {
        var property = typeof(T) == typeof(Plain)
            ? typeof(Plain).GetProperty("Name")
            : typeof(T) == typeof(User)
                ? typeof(User).GetProperty("Name")
                : typeof(T) == typeof(Some)
                    ? typeof(Some).GetProperty("Name")
                    : throw null;

        var data = string.IsNullOrWhiteSpace(search)
            ? _plainList
            : _plainList.Where(x => ((string)property!.GetValue(x, null)).Contains(search));
        return (
                orderAsc
                    ? data.OrderBy(x => OrderValue(x, dataPropertyName))
                    : data.OrderByDescending(x => OrderValue(x, dataPropertyName))
                )
            .Skip(page * pageSize)
            .Take(pageSize)
            .ToList();

        
    }

    protected virtual object? OrderValue(T x, string dataPropertyName) =>
        string.IsNullOrEmpty(dataPropertyName) 
        ? typeof(T).GetProperty("Id")?.GetValue(x, null)
        : typeof(T).GetProperty(dataPropertyName)?.GetValue(x, null);
}
