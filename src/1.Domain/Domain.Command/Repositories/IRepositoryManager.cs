namespace Domain.Command.Repositories
{
    public interface IRepositoryManager<EntityClass> where EntityClass : class
    {
        Task Create(EntityClass entity);
        Task Update(EntityClass entity);
        Task<bool> SaveEntityChanges();
    }
}
