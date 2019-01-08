using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ThiCK
{
    class ClsTriangle : ClsHinh
    {
        public ClsDiem begin = new ClsDiem();
        public ClsDiem end = new ClsDiem();
        public ClsTriangle()
        {
            
        }
        public ClsTriangle(ClsDiem A, ClsDiem B)
        {
            begin = A;
            end = B;
        }
      
        
    }
   
}
