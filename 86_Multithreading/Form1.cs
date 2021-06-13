using System;
using System.Threading;
using System.Windows.Forms;

namespace _86_Multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            // making them non-clickable
            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            Thread workerThread = new Thread(DoTimeConsumingWork);
            workerThread.Start();
            // wait for 5 sec
            //DoTimeConsumingWork();

            // making them clickable
            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        private void DoTimeConsumingWork()
        {
            Thread.Sleep(5000);
        }
        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                listBoxNumbers.Items.Add(i);
            }
        }
    }
}
