using DataActivity;
using DataActivity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceProject.Services
{
    public class AccGroupService : IService
    {
        AccGroupRepository accGroupRepository = new AccGroupRepository();
        public int Delete(int id)
        {
           return accGroupRepository.Delete(id);
        }

        public int Save(object accGrpup)
        {
            return accGroupRepository.Save(accGrpup);
        }

        public object SelectAll()
        {
            return accGroupRepository.SelectAll();
        }

        public int SelectByField(List<object> Fields)
        {
            return accGroupRepository.SelectByField(Fields);
        }

        public int SelectById(int id)
        {
            return accGroupRepository.SelectById(id);
        }

        public int Update(int id)
        {
            return accGroupRepository.Update(id);
        }
    }
}
