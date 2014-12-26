using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace customerQDQUi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        serial aComplain = new serial();

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            complain newComplain =new complain();
            newComplain.serial = aComplain.lastserial;
            newComplain.name = nameEntextBox.Text;
            newComplain.cuscomplain = complainEntextBox.Text;
            aComplain.Add(newComplain);
            en_listview();
            cleartext();

        }

        public void cleartext()
        {
            nameEntextBox.Text = "";
            complainEntextBox.Text = "";
        }

        public void en_listview()
        {
            complainlistView.Items.Clear();

            foreach (complain cComplain in aComplain.queCom)
            {
                ListViewItem newListViewItem =new ListViewItem();
                newListViewItem.Text = cComplain.serial.ToString();
                newListViewItem.SubItems.Add(cComplain.name);
                newListViewItem.SubItems.Add(cComplain.cuscomplain);
                complainlistView.Items.Add(newListViewItem);
            }

           
        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (aComplain.queCom.Count > 0)
            {
                slNotextBox.Text = aComplain.queCom.First().serial.ToString();
                nameDetextBox.Text = aComplain.queCom.First().name.ToString();
                complainDetextBox.Text = aComplain.queCom.First().serial.ToString();
                aComplain.queCom.Dequeue();
                en_listview();
            }
            else
            {
                MessageBox.Show("No more entry");
            }
        }
    }
    
}
