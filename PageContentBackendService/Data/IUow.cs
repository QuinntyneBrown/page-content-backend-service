namespace PageContentBackendService.Data
{
    public interface IUow
    {
        IRepository<Models.App> Apps { get; }
        void SaveChanges();
    }
}
