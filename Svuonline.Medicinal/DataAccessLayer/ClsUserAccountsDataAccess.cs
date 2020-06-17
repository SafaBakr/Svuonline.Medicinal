using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Svuonline.Medicinal.BussinessObjectLayer;

namespace Svuonline.Medicinal.DataAccessLayer
{
    public class ClsUserAccountsDataAccess : IUserAccountsRepository
    {
        public void Delete(UserAccount UserAccountObj)
        {
            using (covid19Entities CoVID19db = new covid19Entities())
            {
                CoVID19db.UserAccounts.Attach(UserAccountObj);
                CoVID19db.UserAccounts.Remove(UserAccountObj);
                CoVID19db.SaveChanges();
            }
        }
        public List<UserAccount> GetAll()
        {
            using (covid19Entities CoVID19db = new covid19Entities())
            {
                return CoVID19db.UserAccounts.ToList();
            }
        }
        public UserAccount GetByID(int id)
        {
            using (covid19Entities CoVID19db = new covid19Entities())
            {
                return CoVID19db.UserAccounts.Find(id);
            }

        }
        public UserAccount Insert(UserAccount UserAccountObj)
        {
            using (covid19Entities CoVID19db = new covid19Entities())
            {
                CoVID19db.UserAccounts.Add(UserAccountObj);
                CoVID19db.SaveChanges();
                return UserAccountObj;
            }

        }
        public void Update(UserAccount UserAccountObj)
        {
            using (covid19Entities CoVID19db = new covid19Entities())
            {
                CoVID19db.UserAccounts.Attach(UserAccountObj);
                CoVID19db.Entry(UserAccountObj).State = System.Data.Entity.EntityState.Modified;
                CoVID19db.SaveChanges();
            }
        }
    }
}