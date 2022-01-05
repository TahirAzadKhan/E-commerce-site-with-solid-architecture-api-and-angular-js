using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using AutoMapper;
using BEL;

namespace BLL
{
    public class ShopOwnerService
    {
        public static List<ShopOwnerModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShopOwner, ShopOwnerModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.ShopOwnerDataAccess();
            var data = mapper.Map<List<ShopOwnerModel>>(da.GetAll());
            return data;
        }

        public static ShopOwnerModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShopOwner, ShopOwnerModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.ShopOwnerDataAccess();
            var data = mapper.Map<ShopOwnerModel>(da.Get(id));
            return data;
        }

        public static void Insert(ShopOwnerModel ShopOwner)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShopOwner, ShopOwnerModel>();
                c.CreateMap<ShopOwnerModel, ShopOwner>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.ShopOwnerDataAccess();
            var upload = mapper.Map<ShopOwnerModel, ShopOwner>(ShopOwner);
            da.Insert(upload);

        }

        public static void Upadte(ShopOwnerModel ShopOwner)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShopOwner, ShopOwnerModel>();
                c.CreateMap<ShopOwnerModel, ShopOwner>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.ShopOwnerDataAccess();
            var upload = mapper.Map<ShopOwnerModel, ShopOwner>(ShopOwner);
            da.Update(upload);
        }
        public static void Delete(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ShopOwner, ShopOwnerModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.ShopOwnerDataAccess();
            da.Delete(id);
        }

    }
    
}
