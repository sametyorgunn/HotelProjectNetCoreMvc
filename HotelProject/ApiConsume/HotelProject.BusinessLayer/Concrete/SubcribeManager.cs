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
	public class SubcribeManager : ISubcribeService
	{
		private readonly ISubcribeDal _subcribeDal;

		public SubcribeManager(ISubcribeDal subcribeDal)
		{
			_subcribeDal = subcribeDal;
		}

		public void TDelete(Subscribe t)
		{
			_subcribeDal.Delete(t);
		}

		public Subscribe TGetById(int id)
		{
			return _subcribeDal.GetById(id);
		}

		public List<Subscribe> TGetList()
		{
			return _subcribeDal.GetList();
		}

		public void TInsert(Subscribe t)
		{
			_subcribeDal.Insert(t);
		}

		public void TUpdate(Subscribe t)
		{
			_subcribeDal.Update(t);
		}
	}
}
