using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Library {
    static public class MathCollections {

        static public int factoFunc(int num) {

            if (num == 0) {
                return 1;
            }
            return num * factoFunc(num - 1);
        }

    }
}
