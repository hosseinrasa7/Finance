using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataActivity.Repositories
{
    public interface IRepository
    {
        int Save(object model);
        int Delete(int id);
        int Update(int id);
        int SelectById(int id);
        int SelectByField(List<object> Fields);
        object SelectAll();
        string TableName { get; }
        
    }
}
