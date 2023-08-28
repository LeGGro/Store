using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Controllers
{
    internal interface IController
    {
        void SendToScreen(object obj);
        void SendToModel(string text);
    }
}
