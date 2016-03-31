using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SRS.DeskApp.DAO;
using SRS.DeskApp.Context;
using SRS.DeskApp.Model;
using System.Diagnostics;

namespace SRS.DeskApp.Model
{
    class ThreadTimbangan
    {
        private string ip;

        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }
        
        private BackgroundWorker worker;

        public BackgroundWorker Worker
        {
            get { return worker; }
            set { worker = value; }
        }
        private MetroTextBox txtDriver;

        public MetroTextBox TxtDriver
        {
            get { return txtDriver; }
            set { txtDriver = value; }
        }
        private MetroTextBox txtCarID;

        public MetroTextBox TxtCarID
        {
            get { return txtCarID; }
            set { txtCarID = value; }
        }
        private MetroTextBox txtUkuran;

        public MetroTextBox TxtUkuran
        {
            get { return txtUkuran; }
            set { txtUkuran = value; }
        }
        private MetroButton btnSubmit;

        public MetroButton BtnSubmit
        {
            get { return btnSubmit; }
            set { btnSubmit = value; }
        }
        private MetroLabel lblNo;

        public MetroLabel LblNo
        {
            get { return lblNo; }
            set { lblNo = value; }
        }
        private MetroLabel lblTimer;

        public MetroLabel LblTimer
        {
            get { return lblTimer; }
            set { lblTimer = value; }
        }
        private System.Windows.Forms.Label lblID;

        public System.Windows.Forms.Label LblID
        {
            get { return lblID; }
            set { lblID = value; }
        }

        public ThreadTimbangan()
        {
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            while (true)
            {

                System.Threading.Thread.Sleep(1000);
            }
            //throw new System.NotImplementedException();
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new System.NotImplementedException();
        }
        public bool start()
        {
            return true;
        }
        
    }
}
