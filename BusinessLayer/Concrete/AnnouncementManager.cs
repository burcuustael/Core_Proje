﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void TAdd(Announcement t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Announcement t)
        {
            throw new NotImplementedException();
        }

        public Announcement TGetByID(int id)
        {
           return _announcementDal.GetByID(id);
        }

        public List<Announcement> TGetList()
        {
           return _announcementDal.GetList();
        }

        public List<Announcement> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            throw new NotImplementedException();
        }
    }
}
