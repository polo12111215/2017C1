using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class MyData
    {
        private Double _high;
        private Double _kg;
        
        
        public Double  high
        {
            get { return _high; }
            set { _high = value; }
        }
        public Double  kg
        {
            get { return _kg; }
            set { _kg = value; }
        }

        public Double Bmi()
        {

            if (_high >= 100 && _kg > 1000)
            {
                return (_kg / 1000) / ((_high / 100) * (_high / 100));
            }
            else if (_high >= 100)
            {
                return _kg / ((_high / 100) * (_high / 100));
            }
            else if (_kg > 1000)
            {
                return (_kg / 1000) / (_high * _high);
            }
            
            return _kg  / (_high * _high);


        }
    }
}
