using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Interfaces
{
    public interface IScreenImage
    {
        double Xsize { get; set; }
        double Ysize { get; set; }

        bool Iscolored { get; set; }
    }
}
