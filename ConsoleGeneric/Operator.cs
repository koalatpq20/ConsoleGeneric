using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGeneric
{
    public  class Operator<T>
    {
        public void Display(T value)
        { 
            Console.WriteLine($"Giá trị nhập {value} - Kiểu dữ liệu: {typeof(T)}");
        }
    }
}
