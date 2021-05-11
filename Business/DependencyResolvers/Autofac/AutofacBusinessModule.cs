using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
   public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<CarManager>().As<ICarService>().SingleInstance();// Biri senden Iproduct service isterse
            //Productmaneger ver
            builder.RegisterType<EFCarDAl>().As<ICarDal>().SingleInstance();
            builder.RegisterType<RentalMenager>().As<IRentalService>().SingleInstance();
            builder.RegisterType<EFRentalDal>().As<IRentalDal>().SingleInstance();
            builder.RegisterType<CarImageManager>().As<ICarImageService>().SingleInstance();
            builder.RegisterType<EFCarImageDal>().As<ICarImageDal>().SingleInstance();
        }
    }
}
