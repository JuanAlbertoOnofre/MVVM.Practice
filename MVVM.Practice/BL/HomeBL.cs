using MVVM.Practice.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Practice.BL
{
    public class HomeBL
    {

        public async Task<string> GetString()
        {
            HomeSarvice homeSarvice = new HomeSarvice();
            var s = await homeSarvice.GetProductAsync();
            return s;
        }

    }
}
