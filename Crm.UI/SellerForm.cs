using System;
using System.Windows.Forms;
using Crm.BL.Model;

namespace Crm.UI
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }

        public SellerForm()
        {
            InitializeComponent();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seller = new Seller
            {
                Name = inp_name.Text
            };

            Close();
        }
    }
}
