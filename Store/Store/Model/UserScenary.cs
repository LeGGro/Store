using Store.Controllers.Auth;
using Store.Controllers.UI;
using Store.Model.Auth;
using Store.Model.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Model
{
    internal class UserScenary
    {
        private UIController UIController;
        private RolesHelper RolesHelper;
        private DBHelper DBHelper;
        public UserScenary()
        {
            UIController = new UIController();
            RolesHelper = new RolesHelper();
            DBHelper = new DBHelper();
        }



        public void StartDialog()
        {
            string choise;
            UIController.SendToScreen("Enter AuthCode");
            choise = UIController.WaitAnswer();

            while (RolesHelper.SetRole(System.Convert.ToInt32(choise)) != 1)
            {
                UIController.SendToScreen("Wrong, Enter AuthCode");
                choise = UIController.WaitAnswer();
            }

            UIController.SendToScreen("You can:");
            UIController.SendToScreen(RolesHelper.GivePermits());

            while (choise.ToLower() != "e")
            {
                choise = UIController.WaitAnswer();
                switch (choise.ToLower())
                {
                    case "c":
                        UIController.SendToScreen(DBHelper.CreateNewInfo(RolesHelper.role));
                        break;
                    case "r":
                        UIController.SendToScreen(DBHelper.ReadInfo(RolesHelper.role));
                        break;
                    case "u":
                        UIController.SendToScreen(DBHelper.UpdateInfo(RolesHelper.role));
                        break;
                    case "d":
                        UIController.SendToScreen(DBHelper.DeleteInfo(RolesHelper.role));
                        break;
                    default:
                        UIController.SendToScreen("c-r-u-d-e");
                        break;

                }
            }
        }

    }
}
