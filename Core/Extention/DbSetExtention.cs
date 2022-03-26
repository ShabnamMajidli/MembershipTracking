using Core.Entities.Abstract;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extentions
{
    public static class DbSetExtension
    {
        public static void Clear<T>(this DbSet<T> dbSet) where T : class, IEntity, new()
        {
            dbSet.RemoveRange(dbSet);
        }
    }

}
