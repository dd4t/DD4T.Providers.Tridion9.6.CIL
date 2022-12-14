using DD4T.ContentModel.Querying;
using Tridion.ContentDelivery.DynamicContent.Query;

namespace DD4T.Providers.Tridion95.CIL
{
    public interface ITridionQueryWrapper : IQuery
    {
        Query ToTridionQuery();
    }
}
