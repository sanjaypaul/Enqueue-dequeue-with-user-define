using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerQDQUi
{
   public class complain
   {
       public int serial;
       public string name;
       public string cuscomplain;
   }

    class serial
    {
        public int lastserial = 1;
        public  Queue<complain> queCom = new Queue<complain>();

        public void Add(complain secComplain)
        {
            lastserial ++;
            queCom.Enqueue(secComplain);
        }
    }
    
}


