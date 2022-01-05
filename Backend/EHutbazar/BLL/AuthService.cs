using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using DAL;
using AutoMapper;

namespace BLL
{
    public class AuthService
    {
        public static TokenModel Authenticate(AdminModel admin)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Admin, AdminModel>();
                c.CreateMap<AdminModel, Admin>();

            });
            var mapper = new Mapper(config);
            var da = DataAccess.AuthDataAccess();
            var data = mapper.Map<AdminModel, Admin>(admin);
            var result = da.Authenticate(data);
            //var token = Mapper.Map<TokenModel, Token>(result);
            var token = new TokenModel();
            if (result != null)
            {
                token.Id = result.Id;
                token.User_Id = result.User_Id;
                token.AccessToken = result.AccessToken;
                token.UserType = result.UserType;
            }
            return token;
        }
        public static TokenModel AuthenticateShopOwner(ShopOwnerModel shopOwner)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShopOwner, ShopOwnerModel>();
                c.CreateMap<ShopOwnerModel, ShopOwner>();

            });
            var mapper = new Mapper(config);
            var da = DataAccess.AuthShopOwnerDataAccess();
            var data = mapper.Map<ShopOwnerModel, ShopOwner>(shopOwner);
            var result = da.Authenticate(data);
            //var token = Mapper.Map<TokenModel, Token>(result);
            var token = new TokenModel();
            if (result != null)
            {
                token.Id = result.Id;
                token.User_Id = result.User_Id;
                token.AccessToken = result.AccessToken;
                token.UserType = result.UserType;
            }
            return token;
        }
        public static bool IsAuthenticated(string token)
        {
            var rs = DataAccess.AuthDataAccess().IsAuthenticated(token);
            return rs;

        }
        public static bool Logout(string token)
        {
            return DataAccess.AuthDataAccess().Logout(token);
        }
    }
}
