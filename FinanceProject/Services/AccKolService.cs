using DataActivity;
using DataActivity.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceProject.Services
{
    public class AccKolService : IService
    {
        AccKolRepository accKolRepository = new AccKolRepository();
        public int Delete(int id)
        {
           return accKolRepository.Delete(id);
        }

        public int Save(object accKol)
        {
            return accKolRepository.Save(accKol);
        }

        public object SelectAll()
        {
            return accKolRepository.SelectAll();
        }

        public int SelectByField(List<object> Fields)
        {
            return accKolRepository.SelectByField(Fields);
        }

        public int SelectById(int id)
        {
            return accKolRepository.SelectById(id);
        }

        public int Update(int id)
        {
            return accKolRepository.Update(id);
        }
    }
}
