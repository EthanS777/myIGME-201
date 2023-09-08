using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    static internal partial class Program // PARTIAL: class expands several files 
    {

        static int MyAdder(int a, int b)
        {
            return 1;
        }
        static void Main(string[] args)
        {
            double doubleNum = 9999.999;
            float floatNum = 999.9F;
            decimal decimalNum = 1234.5678M;
            long longInt = -12345678; // Int64 (64-bit)
            ulong ulongInt = 123455678; // UInt64
            int intNum = -786; // Int32
            uint uintNum = 786; // UInt32 
            short shortInt = -789; // Int16
            ushort ushortInt = 456; // UInt16
            byte byteNum = 254; // 8-bit unsigned
            sbyte sbyteNum = -123; // 8-bit signed

            // implicit, you can set 16 bits into 64 and 8 bits into 32 
            longInt = shortInt;
            uintNum = byteNum;

            byteNum = shortInt; // CANNOT implicitly set data type more precise, like 16 into 8

            // explicit casting 
            byteNum = (byte)shortInt; // but can EXplicitly set 16 to 8, only copies lower 8 bits 

            try
            {
                byteNum = checked((byte)shortInt);
                byteNum = Convert.ToByte(shortInt);
            }
            catch
            {
                Console.WriteLine("Data was lost!");
            }

            // int / int = int 
            doubleNum = (double)longInt / shortInt; 

            shortInt = (short)3.94; // shortInt = 3

            MyAdder(shortInt, shortInt);
            myDivider(byteNum, intNum);
        }
    }
}
