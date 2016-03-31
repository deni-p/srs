using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.DeskApp.Model
{
    public enum ErrorStatusTimbangan { stTapError,stOnLedError,stGetValueError}
    public enum StatusProsesTimbangan { stNone,stStartingGreenLed,stGreenLed}

    public class StatusTimbangan
    {
        private int doc_entry;
        private int base_entry;
        //private StatusProsesTimbangan statusProsesTimbangan;

    }
    
}
