using LazyPinger.Base.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LazyPinger.Base.Entities
{
    public class LazyPingerEntityVm<DbContext, TEntity> : ViewModelBase where DbContext : LazyPingerDbContext where TEntity : class
    {
        public TEntity Entity { get; }

        public LazyPingerEntityVm(TEntity dbEntity) { Entity = dbEntity; }


        public Func<DbContext, IQueryable<TEntity>> entityTable;

        public Func<DbContext, IQueryable<TEntity>> EntityTable
        {
            get => this.entityTable ??= context => context.Set<TEntity>();
            protected set => this.entityTable = value;
        }

        public int entityID;

        public int EntityID
        {
            get => entityID;
            protected init => this.entityID = value;
        }
    }
}
