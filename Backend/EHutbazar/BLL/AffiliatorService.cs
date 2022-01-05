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
    public class AffiliatorService
    {
        public static List<AffiliatorModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Affiliator, AffiliatorModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.AffiliatorDataAccess();
            var data = mapper.Map<List<AffiliatorModel>>(da.GetAll());
            return data;
        }

        public static AffiliatorModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Affiliator, AffiliatorModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.AffiliatorDataAccess();
            var data = mapper.Map<AffiliatorModel>(da.Get(id));
            return data;
        }

        public static void Insert(AffiliatorModel affiliator)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Affiliator, AffiliatorModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.AffiliatorDataAccess();
            var upload = mapper.Map<AffiliatorModel, Affiliator>(affiliator);
            da.Insert(upload);

        }

        public static void Upadte(AffiliatorModel affiliator)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Affiliator, AffiliatorModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.AffiliatorDataAccess();
            var upload = mapper.Map<AffiliatorModel, Affiliator>(affiliator);
            da.Update(upload);
        }
        public static void Delete(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Affiliator, AffiliatorModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.AffiliatorDataAccess();
            da.Delete(id);
        }
    }
}
