namespace CatalogService;

public class CatalogRepository : ICatalogRepository
{
    private readonly CatalogDbContext _context;

    public CatalogRepository(CatalogDbContext context)
    {
        _context = context;
    }
    public async Task SaveChanges()
    {
        await _context.SaveChangesAsync();
    }

    public IEnumerable<Item> GetAllItems()
    {
        return _context.Items.ToList();
    }

    public Item GetItemByGuid(Guid guid)
    {
        return _context.Items.FirstOrDefault(item => item.Id == guid);
    }

    public void CreateItem(Item item)
    {
        if (item != null)
        {
            _context.Items.Add(item);
        }
    }
}