using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiCK
{
    class ClsHinh
    {
        public List<ClsDiem> save = new List<ClsDiem>();
        public ClsHinh()
        { }
        public void LoadData(Dictionary<string, List<ClsDiem>> input, string input_Name)
        {
            foreach (var item in input)
            {
                if (item.Key == input_Name)
                {
                    save = item.Value;
                }
            }
        }
        public List<ClsDiem> SaveData()
        {
            List<ClsDiem> temp = new List<ClsDiem>();
            temp = save;
            return temp;
        }
    }
}
