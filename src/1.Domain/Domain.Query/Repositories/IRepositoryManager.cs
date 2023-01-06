namespace Domain.Query.Repositories
{
    public interface IRepositoryManager<EntityClass> where EntityClass : class
    {
        Task<IQueryable<EntityClass>> GetAllAsync();
        Task<EntityClass> GetById(int id);
    }
}
