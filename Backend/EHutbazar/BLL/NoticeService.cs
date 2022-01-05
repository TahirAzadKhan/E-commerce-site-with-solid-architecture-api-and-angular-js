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
    public class NoticeService
    {
        public static List<NoticeModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeModel>();
                c.CreateMap<NoticeModel, Notice>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.NoticeDataAccess();
            var data = mapper.Map<List<NoticeModel>>(da.GetAll());
            return data;
        }

        public static NoticeModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeModel>();
                c.CreateMap<NoticeModel, Notice>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.NoticeDataAccess();
            var data = mapper.Map<NoticeModel>(da.Get(id));
            return data;
        }

        public static void Insert(NoticeModel notice)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeModel>();
                c.CreateMap<NoticeModel, Notice>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.NoticeDataAccess();
            var upload = mapper.Map<NoticeModel, Notice>(notice);
            da.Insert(upload);

        }

        public static void Upadte(NoticeModel notice)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeModel>();
                c.CreateMap<NoticeModel, Notice>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.NoticeDataAccess();
            var upload = mapper.Map<NoticeModel, Notice>(notice);
            da.Update(upload);
        }
        public static void Delete(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Notice, NoticeModel>();
                c.CreateMap<NoticeModel, Notice>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.NoticeDataAccess();
            da.Delete(id);
        }
    }
}
