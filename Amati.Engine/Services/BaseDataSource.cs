namespace Amati.Engine.Services;

public abstract class BaseDataSource<T> : IDataSource<T>
{
    protected List<T> _plainList = new();

    public BaseDataSource()
    {
    }

    public ICollection<T> GetPage(int page, int pageSize, string? dataPropertyName, bool orderAsc)
        => GetPageInternal(page, pageSize, dataPropertyName, orderAsc);

    public int GetPagesCount(int pageSize)
    {
        var pages = _plainList.Count % pageSize == 0
            ? _plainList.Count / pageSize
            : _plainList.Count / pageSize + 1;

        return pages;
    }

    object IDataSource.GetPage(int page, int pageSize, string? dataPropertyName, bool orderAsc)
        => GetPageInternal(page, pageSize, dataPropertyName, orderAsc);

    private ICollection<T> GetPageInternal(
        int page,
        int pageSize,
        string? dataPropertyName,
        bool orderAsc)
    {
        return (
                orderAsc
                    ? _plainList.OrderBy(x => OrderValue(x, dataPropertyName))
                    : _plainList.OrderByDescending(x => OrderValue(x, dataPropertyName))
                )
            .Skip(page * pageSize)
            .Take(pageSize)
            .ToList();

        
    }

    protected virtual object? OrderValue(T x, string dataPropertyName) =>
         typeof(T).GetProperty(dataPropertyName)?.GetValue(x, null);
}
