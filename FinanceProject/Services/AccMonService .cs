using DataActivity;
using DataActivity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceProject.Services
{
    public class AccMonService : IService
    {
        AccMonRepository accMonRepository = new AccMonRepository();
        public int Delete(int id)
        {
           return accMonRepository.Delete(id);
        }

        public int Save(object accMon)
        {
            return accMonRepository.Save(accMon);
        }

        public object SelectAll()
        {
            return accMonRepository.SelectAll();
        }

        public int SelectByField(List<object> Fields)
        {
            return accMonRepository.SelectByField(Fields);
        }

        public int SelectById(int id)
        {
            return accMonRepository.SelectById(id);
        }

        public int Update(int id)
        {
            return accMonRepository.Update(id);
        }
    }
}
