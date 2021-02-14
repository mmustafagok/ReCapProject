using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICarService
    {

        IDataResult<List<Car>> GetAllByBrandId(int id);

        IDataResult<List<Car>> GetAllByColorId(int id);

        IDataResult<List<Car>> GetByDailyPrice(int minPrice, int maxPrice);

        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);


    }
}
