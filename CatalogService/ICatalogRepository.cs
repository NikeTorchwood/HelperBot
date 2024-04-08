namespace CatalogService;

public interface ICatalogRepository
{
    Task SaveChanges();
    IEnumerable<Item> GetAllItems();
    Item GetItemByGuid(Guid guid);
    void CreateItem(Item item);
}