using CQRS.Data.context;
using CQRS.Data.Models;

namespace CQRS.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _dbContext;

        public ItemRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int AddItem(Item item)
        {

            _dbContext.Items.Add(item);
            _dbContext.SaveChanges();
            return item.Id;
        }

        public int DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAllItems() => _dbContext.Items.ToList();

        public Item GetById(int id)
        {
            var result = _dbContext.Items.Find(id);
            if (result == null) 
                return new Item();

            return result;
        }

        public int UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
