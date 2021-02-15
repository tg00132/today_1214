using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car0208
{
    class Car
    {
        private string model;
        private string company;
        private string price;
        private string color;

        //클래스 상수 변수 
         const string agency = "동대구 영업소";

        public void setModel(string model)
        {
            this.model = model;
        }
        public string getModel()
        {
            return model;
        }
        public void setCompany(string company)
        {
            this.company = company;
        }
        public string getCompany()
        {
            return company;
        }
        public void setPrice(string price)
        {
            this.price = price;
        }
        public string getPrice()
        {
            return price;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public string getColor()
        {
            return color;
        }

        public void showCarInfo()
        {
            Console.WriteLine("대리점 영업소: " + Car.agency);
            Console.WriteLine("모델명: " + model);
            Console.WriteLine("가격: " + price);
            Console.WriteLine("색상: " + color);
            Console.WriteLine("제조사: " + company);
        }

    }
}
