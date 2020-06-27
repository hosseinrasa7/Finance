using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceProject.Services
{
    public interface IService
    {
        int Save(object model);
        int Delete(int id);
        int Update(int id);
        int SelectById(int id);
        int SelectByField(List<object> Fields);
        object SelectAll();
    }
}
