using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svuonline.Medicinal.BussinessObjectLayer;

namespace Svuonline.Medicinal.DataAccessLayer
{
  public  interface IUserAccountsRepository
    {
        List<UserAccount> GetAll();
        UserAccount GetByID(int id);
        UserAccount Insert(UserAccount UserAccountObj);
         void Update(UserAccount UserAccountObj);
         void Delete(UserAccount UserAccountObj);
    }
}
