namespace AuthApi.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetTAll();
        Task<T> GetById(int id);
        Task<int> Add(T entity);

        Task Update(T entity);

        Task Delete(int id);
    }
}
