﻿using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public List<Notification> GetList()
        {
            return _notificationDal.GetListAll();
        }

        public void TAdd(Notification t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Notification t)
        {
            throw new NotImplementedException();
        }

        public Notification TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
