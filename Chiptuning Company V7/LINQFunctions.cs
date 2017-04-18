using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chiptuning_Company_V7
{
    class LINQFunctions
    {
        static private CompanyDbEntities context = new CompanyDbEntities();

        static public void Join(DataGridView _dataGridView)
        {
            
            var query = from car in context.Cars
                        join customer in context.Customers on car.Owner equals customer.Id
                        select new { Vin = car.Vin, Make = car.Make, Model = car.Model, Year = car.Year,
                            Displacement = car.Displacement, Fuel = car.Fuel, Power = car.Power,
                            Name = customer.Name, Surname = customer.Surname, Email = customer.Email };

            _dataGridView.DataSource = query.ToList();
        }        
    }
}
