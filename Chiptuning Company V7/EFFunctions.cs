using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chiptuning_Company_V7
{
    class EFFunctions
    {
        static private CompanyDbEntities context = new CompanyDbEntities();

        static public void Select(DataGridView _dataGridView, string _make)
        {
            List<Car> objCars = context.Cars.Where(c => c.Make == _make).OrderBy(input => input.Vin).Skip(0).Take(1000).ToList<Car>();
            _dataGridView.DataSource = objCars;
        }
        
        static public void Insert(string _vin, string _make, string _model, string _year, string _displacement, string _fuel, string _power)
        {
            Car newCar = new Car();

            newCar.Vin = _vin;
            newCar.Make = _make;
            newCar.Model = _model;
            newCar.Year = _year;
            newCar.Displacement = _displacement;
            newCar.Fuel = _fuel;
            newCar.Power = _power;

            context.Cars.Add(newCar);
            context.SaveChanges();

        }

        static public void Update(string _vin, string _make, string _model, string _year, string _displacement, string _fuel, string _power)
        {
            Car updateCar = context.Cars.Where(c => c.Vin == _vin).FirstOrDefault();

            updateCar.Make = _make;
            updateCar.Model = _model;
            updateCar.Year = _year;
            updateCar.Displacement = _displacement;
            updateCar.Fuel = _fuel;
            updateCar.Power = _power;

            context.SaveChanges();
        }

        static public void Delete(string _vin)
        {
            var car = new Car { Vin = _vin };
            context.Cars.Attach(car);
            context.Cars.Remove(car);
            context.SaveChanges();
        }
    }
}
