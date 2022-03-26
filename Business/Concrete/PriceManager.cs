using Business.Abstract;
using DataAccess.Abstract;
using DattaAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class PriceManager : IPriceService
    {
        private readonly IPriceDal _priceDal;
        public PriceManager(IPriceDal priceDal)
        {
            _priceDal = priceDal;
        }
        public void Add(Price price)
        {
            this._priceDal.Add(price);
        }

        public void Delete(Price price)
        {
            this._priceDal.Delete(price);
        }

        public void DeleteAll()
        {

            this._priceDal.DeleteAll();
        }

        public Price Get(int id)
        {
            return this._priceDal.Get(m => m.Id == id);
        }

        public List<Price> GetAll()
        {
            return this._priceDal.GetAll();
        }
        public int GetNextId()
        {

            return this._priceDal.GetNextId();
        }

        public void Update(Price price)
        {
            this._priceDal.Update(price);
        }


    }
}

