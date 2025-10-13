namespace ADMIN.Service.IService
{
    public interface IService
    {
        Task<T?> GetAsync<T>(string url);
        Task<T?> GetbyId<T, Tkey>(Tkey tkey, string url);
        Task<TResponse?> PostAsync<TRequest, TResponse>(string url, TRequest data);
        Task<bool> PutAsync<TRequest>(string url, TRequest data);
        Task<bool> DeleteAsync<Tkey>(string url, Tkey tkey);
    }
}
