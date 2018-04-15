using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstVS2015
{
    public static class @switch
    {
        enum dgos { lassie, snoopy, yeller}

        public static void switcharoo()
        {
            var t = dgos.lassie;

            switch (t)
            {
                case dgos.lassie:
                    break;
                case dgos.snoopy:
                    Console.WriteLine("Hi lassie");
                    break;
                case dgos.yeller:
                    break;
                default:
                    break;
            }



        }
    }
}
