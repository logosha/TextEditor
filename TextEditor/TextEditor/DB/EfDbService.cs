using System.Data.Entity;
using System.Reflection;
using System.Data.Entity.Core.Common;
using System.Data.SQLite;
using System.Data.SQLite.EF6;
using Unity;
using Unity.Resolution;
using System.Threading.Tasks;

namespace Core.DBService
{
    public class SQLiteConfiguration : DbConfiguration
    {
        public SQLiteConfiguration()
        {
            SetProviderFactory("System.Data.SQLite", SQLiteFactory.Instance);
            SetProviderFactory("System.Data.SQLite.EF6", SQLiteProviderFactory.Instance);
            SetProviderServices("System.Data.SQLite", (DbProviderServices)SQLiteProviderFactory.Instance.GetService(typeof(DbProviderServices)));
        }
    }

    public class EfDbService : DbContext, IDbService
    {
        static EfDbService()
        {
            DbConfiguration.SetConfiguration(new SQLiteConfiguration());
        }

        IUnityContainer _container;
        public EfDbService(IUnityContainer container)
        {
            _container = container;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(GetType()));
            base.OnModelCreating(modelBuilder);
        }

        public IRepo<TEntity> Repo<TEntity>() where TEntity : class
        {
            return _container.Resolve<IRepo<TEntity>>(new ResolverOverride[]
            {
                new ParameterOverride("dbContext", this)
            });
        }

        public override Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        public new void Dispose()
        {
            base.Dispose();
        }
    }
}
