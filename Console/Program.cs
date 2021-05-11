using Business.Concrete;

using DataAccess.Concrate.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
         
        {

          
         
            CarManager carManager = new CarManager(new EFCarDAl());
           
            //  foreach (var i in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(i.BrandName+"/"+ i.ColorName+"/"+i.Decription+"/"+i.DailyPrice);
            //}

            
        }
        
    }
}
