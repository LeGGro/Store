using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.View
{
    internal class UserInterface
    {
        public void ShowString(string text)
        {
            Console.WriteLine(text);
        }
        public void ShowList(List<string> list)
        {
            //вывод листа
        }
        public void ShowList(List<int> list)
        {
            //вывод листа
        }
        public string UserAnswer()
        {
            return Console.ReadLine();
        }
    }
}
