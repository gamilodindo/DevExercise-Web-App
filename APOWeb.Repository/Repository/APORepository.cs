using APOWeb.Core.Pattern;
using APOWeb.Data;
using APOWeb.Data.Entities;
using APOWeb.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOWeb.Repository.Repository
{
    public class APORepository :
        GenericRepository<APOWebDbContext, APO>, IAPORepository
    {
        public APO SearchById(int id)
        {
            return this.Context.APOs.Find(id);
        }

        public IList<APO> FindAll()
        {
            var afposContext = this.Context.APOs.AsQueryable();
            var query = from users in afposContext
                        select users;
            return query.ToList();

        }
    }
}
