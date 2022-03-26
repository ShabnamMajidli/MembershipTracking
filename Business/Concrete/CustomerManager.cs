using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add(Customer customer)
        {
            this._customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            this._customerDal.Delete(customer);
        }

        public void DeleteAll()
        {

            this._customerDal.DeleteAll();
        }

        public Customer Get(int id)
        {
            return this._customerDal.Get(m => m.Id == id);
        }

        public List<Customer> GetAll()
        {
            return this._customerDal.GetAll();
        }
        public int GetNextId()
        {

            return this._customerDal.GetNextId();
        }

        public void Update(Customer customer)
        {
            this._customerDal.Update(customer);
        }
    }
}
