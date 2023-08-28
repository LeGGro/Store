using Store.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Controllers.UI
{
    internal class UIController
    {
        private UIFacade UI;
        public UIController()
        {
            UI = new UIFacade();
        }

        public string WaitAnswer()
        {
            return UI.WaitAnswer();
        }
        public void SendToScreen(object obj)
        {
            UI.ShowOnScreen(obj);
        }

    }
}
