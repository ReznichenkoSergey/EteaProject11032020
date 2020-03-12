using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEAProject11032020.Interfaces
{
    interface ITemp
    {
        void GetValues();
        bool IsActive { get; set; }
    }
}
