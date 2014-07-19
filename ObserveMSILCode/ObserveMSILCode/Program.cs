using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ObserveMSILCode
{
    class Program
    {
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint="Beep")]
        static extern Boolean Beep1(UInt32 frequency, UInt32 duration);

        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "Beep")]
        static extern Boolean Beep2(UInt32 frequency, UInt32 duration);

        static void Main(string[] args)
        {
            int value1 = 34;
            Console.WriteLine(value1);
            Beep1(554, 1000);
            //Beep1(554, 1000);
            //Main2();
            //Beep1(554, 1000);
            Console.WriteLine(value1);
            //Beep1(2960, 1000);
            //Console.ReadLine();
        }

        static void Main2()
        {
            //Beep1(554, 1000);
        }
    }
}
