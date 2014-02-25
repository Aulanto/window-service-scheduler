using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsServiceDemo {

    class Scheduler {

       public static void Record() {

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("E:\\log.txt", true)) {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "));
            }
        
        }

    }
}
