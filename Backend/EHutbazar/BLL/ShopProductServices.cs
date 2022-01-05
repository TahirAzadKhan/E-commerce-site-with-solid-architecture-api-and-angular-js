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
    public class ShopProductServices
    {
        public static List<ShopProductModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Shop_Product, ShopProductModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.ShopProductDataAccess();
            var data = mapper.Map<List<ShopProductModel>>(da.GetAll());
            return data;
        }

        public static ShopProductModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Shop_Product, ShopProductModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.ShopProductDataAccess();
            var data = mapper.Map<ShopProductModel>(da.Get(id));
            return data;
        }

        public static void Insert(ShopProductModel shopProduct)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Shop_Product, ShopProductModel>();
                c.CreateMap<ShopProductModel, Shop_Product>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.ShopProductDataAccess();
            var upload = mapper.Map<ShopProductModel, Shop_Product>(shopProduct);
            da.Insert(upload);

        }

        public static void Upadte(ShopProductModel shopProduct)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Shop_Product, ShopProductModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.ShopProductDataAccess();
            var upload = mapper.Map<ShopProductModel, Shop_Product>(shopProduct);
            da.Update(upload);
        }
        public static void Delete(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Shop_Product, ShopProductModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.ShopProductDataAccess();
            da.Delete(id);
        }
    
}
}
