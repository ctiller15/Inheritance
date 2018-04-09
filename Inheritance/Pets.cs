using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface IPet
    {
        string OwnersName { get; set; }
        string Name { get; set; }

        void NameSelf();
    }
}
