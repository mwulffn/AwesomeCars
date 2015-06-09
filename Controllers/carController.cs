using AwesomeCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AwesomeCars.Controllers
{
    public class CarController : ApiController
    {
        private static List<Car> _cars;

        static CarController()
        {
            _cars = new List<Car>();

            _cars.Add(new Car()
            {
                Id = 1,
                Make = "Tesla",
                Model = "Model S",
                Year = "2012",
                Price = 635000,
                BHP = 385,
                Pictures = new string[] { "http://www.blogcdn.com/www.autoblog.com/media/2012/09/03-2012-tesla-model-s-fd-1347336750.jpg", "http://image.motortrend.com/f/oftheyear/car/1301_2013_motor_trend_car_of_the_year_tesla_model_s/41007800/2013-tesla-model-s-front-three-quarter-1.jpg" }
            });

            _cars.Add(new Car()
            {
                Id = 2,
                Make = "Nissan",
                Model = "Leaf",
                Year = "2010",
                Price = 221100,
                BHP = 109,
                Pictures = new string[] { "http://www.extremetech.com/wp-content/uploads/2012/01/Nissan_Leaf.jpg", "http://www.nissanusa.com/vlp-assets/media/vehicles/2015/leaf/features/performance-details/bg.jpg" }
            });

            _cars.Add(new Car()
            {
                Id = 3,
                Make = "BMW",
                Model = "i3",
                Year = "2014",
                Price = 286000,
                BHP = 170,
                Pictures = new string[] { "http://surlegreen.blog-idrac.com/wp-content/uploads/sites/66/2014/01/S1-Video-BMW-i3-Caradisiac-etait-a-la-presentation-officielle-a-Londres-de-la-premiere-citadine-premium-electrique-2995511.jpg", "http://images-2.drive.com.au/2013/10/10/4818403/bmw-i3_600c-620x414.jpg" }
            });

            _cars.Add(new Car()
            {
                Id = 4,
                Make = "Renault",
                Model = "Zoe",
                Year = "2012",
                Price = 174900,
                BHP = 87,
                Pictures = new string[] { "http://myrenaultzoe.com/wp-content/uploads/2012/11/5038816404-4e0041562b_Zoe_PreviewParis2010_RenaultOnFlickr_c.jpg", "https://www.cdn.renault.com/content/dam/Renault/master/vehicules/zoe-b10e-ph1/decouverte/renault-zoe-b10ph1-overview-design.jpg.ximg.l_full_m.smart.jpg" }
            });

        }


        // GET: api/car
        public IEnumerable<Car> Get()
        {
            return _cars;
        }

        // GET: api/car/5
        public Car Get(int id)
        {
            var car = _cars.SingleOrDefault(a => a.Id == id);

            return car;
        }

        // POST: api/car
        public void Post([FromBody]Car value)
        {
            if (value.Id == 0)
                value.Id = _cars.Max(a => a.Id) + 1;

            _cars.Add(value);


        }

        // PUT: api/car/5
        public void Put(int id, [FromBody]Car value)
        {
            var car = _cars.SingleOrDefault(a => a.Id == id);

            if (car == null)
                Post(value);
            else
            {
                _cars.Remove(car);
                _cars.Add(value);
            }
        }

        // DELETE: api/car/5
        public void Delete(int id)
        {
            var car = _cars.SingleOrDefault(a => a.Id == id);

            if (car != null)
                _cars.Remove(car);
        }
    }
}
