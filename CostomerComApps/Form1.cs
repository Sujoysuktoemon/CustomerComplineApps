using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostomerComApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<Costomer> customeQueue = new Queue<Costomer>();
        private int customerIdIndex = 1;
        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            Costomer aCustomer = new Costomer();
            aCustomer.customerName = txtCustomerEnqueueName.Text;
            aCustomer.customerCompline = txtCustomerEnqueueCompline.Text;
            aCustomer.customerId = customerIdIndex.ToString();
            customeQueue.Enqueue(aCustomer);
            customerIdIndex ++;
            ListViewItem item=new ListViewItem();
            item.Text = aCustomer.customerId;
            item.SubItems.Add(aCustomer.customerName);
            item.SubItems.Add(aCustomer.customerCompline);
            listView1.Items.Add(item);
            MessageBox.Show("your Compline Number Is" + " " + aCustomer.customerId);
            txtCustomerEnqueueName.Text = "";
            txtCustomerEnqueueCompline.Text = "";



        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            Costomer aCustomer = new Costomer();
            aCustomer= customeQueue.Dequeue();
            txtCustomerDequeueId.Text = aCustomer.customerId;
            txtCustomerDequeueName.Text = aCustomer.customerName;
            txtCustomerDequeueCompline.Text = aCustomer.customerCompline;
            listView1.Items[0].Remove();
        }
    }
}
