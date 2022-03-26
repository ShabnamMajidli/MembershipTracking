using Business.Abstract;
using DataAccess.Abstract;
using DattaAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class MeetingManager : IMeetingService
    {
        private readonly IMeetingDal _meetingDal;
        public MeetingManager(IMeetingDal meetingDal)
        {
            _meetingDal = meetingDal;
        }
        public void Add(Meeting meeting)
        {
            this._meetingDal.Add(meeting);
        }

        public void Delete(Meeting meeting)
        {
            this._meetingDal.Delete(meeting);
        }

        public void DeleteAll()
        {

            this._meetingDal.DeleteAll();
        }

        public Meeting Get(int id)
        {
            return this._meetingDal.Get(m => m.Id == id);
        }

        public List<Meeting> GetAll()
        {
            return this._meetingDal.GetAll();
        }
        public int GetNextId()
        {

            return this._meetingDal.GetNextId();
        }

        public void Update(Meeting meeting)
        {
            this._meetingDal.Update(meeting);
        }

       
    }
}
