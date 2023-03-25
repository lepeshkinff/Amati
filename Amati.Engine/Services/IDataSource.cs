namespace Amati.Engine.Services;

public interface IDataSource
{
    object GetPage(int page, int pageSize, string? dataPropertyName, bool orderAsc, string search);
    int GetPagesCount(int pageSize);
}

public interface IDataSource<T> : IDataSource
{
    new ICollection<T> GetPage(int page, int pageSize, string? dataPropertyName, bool orderAsc, string search);
}
