namespace GMToolset.Data.Repositories
{
    public class RepositoryBase
    {
        protected readonly AppDbContext _appDbContext;

        public RepositoryBase(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
    }
}
