using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS.DeskApp
{
    class DataNIROnline
    {
        private int base_entry;

        public int Base_entry
        {
            get { return base_entry; }
            set { base_entry = value; }
        }
        private string house;

        public string House
        {
            get { return house; }
            set { house = value; }
        }
        private Decimal pol;
        public Decimal Pol
        {
            get { return pol; }
            set { pol = value; }
        }
        private Decimal brix;
        public Decimal Brix
        {
            get { return brix; }
            set { brix = value; }
        }
        private bool success;

        public bool Success
        {
            get { return success; }
            set { success = value; }
        }
        private string barcode;

        public string Barcode
        {
            get { return barcode; }
            set { barcode = value; }
        }
    }
}
