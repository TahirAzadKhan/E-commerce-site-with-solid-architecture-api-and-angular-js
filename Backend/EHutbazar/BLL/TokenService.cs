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
    class TokenService
    {
        public static List<TokenModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Token, TokenModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.TokenDataAccess();
            var data = mapper.Map<List<TokenModel>>(da.GetAll());
            return data;
        }

        public static TokenModel Get(string accessToken)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Token, TokenModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.TokenDataAccess();
            var data = mapper.Map<TokenModel>(da.Get(accessToken));
            return data;
        }

        public static void Insert(TokenModel token)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Token, TokenModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.TokenDataAccess();
            var upload = mapper.Map<TokenModel, Token>(token);
            da.Insert(upload);

        }

        public static void Upadte(TokenModel token)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Token, TokenModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.TokenDataAccess();
            var upload = mapper.Map<TokenModel, Token>(token);
            da.Update(upload);
        }
        public static void Delete(string accessToken)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Token, TokenModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.TokenDataAccess();
            da.Delete(accessToken);
        }
    }
}
