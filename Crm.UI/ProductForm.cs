using System;
using System.Windows.Forms;
using Crm.BL.Model;

namespace Crm.UI
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product) : this()
        {
            Product = product;
            inp_name.Text = Product.Name;
            num_price.Value = Product.Price;
            num_count.Value = Product.Count;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Product = Product ?? new Product();

            Product.Name = inp_name.Text;
            Product.Price = num_price.Value;
            Product.Count = (int)num_count.Value;

            Close();
        }
    }
}
