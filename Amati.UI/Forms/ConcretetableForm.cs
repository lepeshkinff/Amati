using Amati.Engine.Services;

namespace Amati.UI.Forms
{
    public class ConcretetableForm<T> : TableViewForm
    {
        public ConcretetableForm(IDataSource<T>? palinsDataSource) 
            : base(palinsDataSource)
        {
        }
    }
}
