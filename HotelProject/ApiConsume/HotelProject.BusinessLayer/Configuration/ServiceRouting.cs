using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Configuration
{
	public static class ServiceRouting
	{
		public static void ServiceRoutingSetting(this IServiceCollection services)
		{
			services.AddScoped<IRoomService, RoomManager>();
			services.AddScoped<IRoomDal, EfRoomDal>();

			services.AddScoped<IStaffService, StaffManager>();
			services.AddScoped<IStaffDal, EfStaffDal>();

			services.AddScoped<ISubcribeService, SubcribeManager>();
			services.AddScoped<ISubcribeDal, EfSubcribeDal>();

			services.AddScoped<IServiceService, ServiceManager>();
			services.AddScoped<IServiceDal, EfServiceDal>();

			services.AddScoped<ITestimonialService, TestimonialManager>();
			services.AddScoped<ITestimonialDal, EfTestimonialDal>();

            services.AddScoped<IAboutUsService, AboutUsManager>();
            services.AddScoped<IAboutUsDal, EfAboutUsDal>();

            services.AddScoped<IBookingService, BookingManager>();
            services.AddScoped<IBookingDal, EfBookingDal>();
        }
	}
}
