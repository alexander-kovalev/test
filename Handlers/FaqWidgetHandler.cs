using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.JiraExtension.Models;

namespace Orchard.JiraExtension.Handlers
{
    public class FaqWidgetHandler : ContentHandler
    {
        public FaqWidgetHandler(IRepository<FaqWidgetPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}