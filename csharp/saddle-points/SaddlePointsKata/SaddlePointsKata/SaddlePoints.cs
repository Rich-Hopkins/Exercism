using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace SaddlePointsKata
{
    public class SaddlePoints
    {
        private int[,] values;

        public SaddlePoints(int[,] values)
        {
            this.values = values;
        }


        public ActualValueDelegate<object> Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
