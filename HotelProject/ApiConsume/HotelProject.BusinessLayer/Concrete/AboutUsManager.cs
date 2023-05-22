using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public AboutUs GetAboutUs()
        {
            return _aboutUsDal.AboutUsGet();
        }

        public void TDelete(AboutUs t)
        {
           _aboutUsDal.Delete(t);
        }

        public AboutUs TGetById(int id)
        {
            return _aboutUsDal.GetById(id);
        }

        public List<AboutUs> TGetList()
        {
            return _aboutUsDal.GetList();
        }

        public void TInsert(AboutUs t)
        {
            _aboutUsDal.Insert(t);
        }

        public void TUpdate(AboutUs t)
        {
            _aboutUsDal.Update(t);
        }
    }
}
