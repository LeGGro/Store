using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.View
{
    internal class UIFacade
    {
        UserInterface UI;

        public UIFacade()
        {
            UI = new UserInterface();
        }

        public void ShowOnScreen(object obj)
        {
            if (obj.GetType() == typeof(string))
            {
                UI.ShowString((string)obj);
            
            }
            else if (obj.GetType() == typeof(List<string>))
            {
                UI.ShowList((List<string>)obj);

            }
            else if (obj.GetType() == typeof(List<int>))
            {
                UI.ShowList((List<int>)obj);

            }
            
        }
        public string WaitAnswer()
        { 
            return UI.UserAnswer();
        }
    }
}
