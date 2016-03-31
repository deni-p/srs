using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.DeskApp.Model
{
    public enum CurrentProcess{cpNone,cpTap,cpDialLedOn,cpDialLedOff,cpOpenGate}
    public enum ResultCurrentProcess{rpNone,rpDialLedError,rpDialLedOK,tapOK,tapError}
    public enum TimerProcess{tpNone,tpErrorTab,tpErrorGetValue}
    class InfoTimbangan
    {
        private int doc_entry;

        public int Doc_entry
        {
            get { return doc_entry; }
            set { doc_entry = value; }
        }
        private int base_entry;

        public int Base_entry
        {
            get { return base_entry; }
            set { base_entry = value; }
        }        
        //private string ip_address;
        private CurrentProcess cp;

        public CurrentProcess Cp
        {
            get { return cp; }
            set { cp = value; }
        }
        private ResultCurrentProcess cpr;

        public ResultCurrentProcess Cpr
        {
            get { return cpr; }
            set { cpr = value; }
        }
        private string errorMsg;

        public string ErrorMsg
        {
            get { return errorMsg; }
            set { errorMsg = value; }
        }
        private bool timeOn;

        public bool TimeOn
        {
            get { return timeOn; }
            set { timeOn = value; }
        }
        private int timerValue;

        public int TimerValue
        {
            get { return timerValue; }
            set { timerValue = value; }
        }
        private TimerProcess tp;

        public TimerProcess Tp
        {
            get { return tp; }
            set { tp = value; }
        }
        private string timerLabel;

        public string TimerLabel
        {
            get { return timerLabel; }
            set { timerLabel = value; }
        }
        private int timerCount;

        public int TimerCount
        {
            get { return timerCount; }
            set { timerCount = value; }
        }
        private Context.tbl_transit_timbangan tbl_timbangan;

        public Context.tbl_transit_timbangan Tbl_timbangan
        {
            get { return tbl_timbangan; }
            set { tbl_timbangan = value; }
        }
        private int stabilCount;

        public int StabilCount
        {
            get { return stabilCount; }
            set { stabilCount = value; }
        }
    }
}
