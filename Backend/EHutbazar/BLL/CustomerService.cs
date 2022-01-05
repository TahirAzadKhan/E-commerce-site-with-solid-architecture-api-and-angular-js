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
    public class CustomerService
    {
        public static List<CustomerModel> GetAll()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.CustomerDataAccess();
            var data = mapper.Map<List<CustomerModel>>(da.GetAll());
            return data;
        }

        public static CustomerModel Get(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.CustomerDataAccess();
            var data = mapper.Map<CustomerModel>(da.Get(id));
            return data;
        }

        public static void Insert(CustomerModel customer)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerModel>();
                c.CreateMap<CustomerModel, Customer>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.CustomerDataAccess();
            var upload = mapper.Map<CustomerModel, Customer>(customer);
            da.Insert(upload);

        }

        public static void Upadte(CustomerModel customer)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerModel>();
                c.CreateMap<CustomerModel, Customer>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.CustomerDataAccess();
            var upload = mapper.Map<CustomerModel, Customer>(customer);
            da.Update(upload);
        }
        public static void Delete(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Customer, CustomerModel>();

            });
            var mapper = new Mapper(config);
            var da = DataAccess.CustomerDataAccess();
            da.Delete(id);
        }
    }
}
