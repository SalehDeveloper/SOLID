using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.Before
{
    public interface IPrinterTasks
    {
        void Print(string PrintContent);
        void PrintDuplex(string PrintDuplexContent);
        void Scan(string ScanContent);
        void Fax(string FaxContent);
        
    }
}
