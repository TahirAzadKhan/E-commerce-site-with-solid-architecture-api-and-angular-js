using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        static EhutBazardbEntities db;
        static DataAccess()
        {
            db = new EhutBazardbEntities();

        }

        public static IRepository<Admin,int> AdminDataAccess()
        {
            return new AdminRepo(db);
        }
        
        public static IRepository<ShopOwner, int> ShopOwnerDataAccess()
        {
            return new ShopOwnerRepo(db);
        }
        public static IRepository<Shop_Product, int> ShopProductDataAccess()
        {
            return new ShopProductRepo(db);
        }
        public static IRepository<Affiliator, int> AffiliatorDataAccess()
        {
            return new AffiliatorRepo(db);
        }
        public static IRepository<Customer, int> CustomerDataAccess()
        {
            return new CustomerRepo(db);
        }
        public static IRepository<Notice, int> NoticeDataAccess()
        {
            return new NoticeRepo(db);
        }
        public static IRepository<Token, string> TokenDataAccess()
        {
            return new TokenRepo(db);
        }
        public static IAuth<Admin, string> AuthDataAccess()
        {
            return new AdminRepo(db);
        }
        public static IAuth<ShopOwner, string> AuthShopOwnerDataAccess()
        {
            return new ShopOwnerRepo(db);
        }
    }
}
