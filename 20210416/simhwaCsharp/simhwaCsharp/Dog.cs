using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhwaCsharp
{
    class Dog : Animal
    {
        public override void Eat()
        {
            System.Windows.Forms.MessageBox.Show("멍멍");
            //throw new NotImplementedException();
        }
    }
}
