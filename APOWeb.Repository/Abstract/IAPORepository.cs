using APOWeb.Core.Pattern;
using APOWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOWeb.Repository.Abstract
{
    public partial interface IAPORepository : IGenericRepository<APO>
    {
        IList<APO> FindAll();
        APO SearchById(int id);
    }
}
