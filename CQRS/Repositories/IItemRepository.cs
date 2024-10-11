using CQRS.Data.Models;

namespace CQRS.Repositories
{
    public interface IItemRepository
    {
        public List<Item> GetAllItems();
        public Item GetById(int id);
        public int AddItem(Item item);
        public int UpdateItem(Item item);
        public int DeleteItem(int id);
    }
}
