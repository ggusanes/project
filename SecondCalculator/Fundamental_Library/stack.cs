using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_Library
{
    public class stack {
        //Stack?
        private List<string> list;

        public stack() {
            list = new List<string>();
        }

        public bool IsEmpty() {

            bool result = false;

            if (list.Count() == 0) {
                result = true;
            } else {
                result = false;
            }
            return result;
        }

        public void stackInsert(string data) {

            list.Add(data);
        }

        public string putOut() {

            int howMany = list.Count();
            string lastNum = "";

            if (howMany != 0) {
                lastNum = list[howMany - 1];
                list.RemoveAt(howMany - 1);
            }
            return lastNum;
        }

        public string check() {

            int howMany = list.Count();
            string lastNum = "";

            if (howMany != 0) {
                lastNum = list[howMany - 1];
                //list.RemoveAt(howMany - 1);
            }
            return lastNum;
        }
    }
}
