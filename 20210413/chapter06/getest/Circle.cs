using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getest
{
    class Circle
    {
        private int r;
        public int R { get { return  this.r; }
            set { this.r = value; } }

        public int radius { get; set; }
        //{get; set;}없어도 잘만써왓지만 그리드뷰할때는 필요하니
        //public 변수 만들땐 {get; set;}을 써라

       public int radi
        {
            get { return  this.r; }
            set
            {
                if (value < 0)
                    this.r = 0;
                else
                {
                    this.r = value;
                }
            } 
        }
    }
}
