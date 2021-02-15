using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car0208
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.setModel("K7");
            car.setPrice("사천만원");
            car.setColor("블랙");
            car.setCompany("기아");
            car.showCarInfo();

            

        }
    }
}
