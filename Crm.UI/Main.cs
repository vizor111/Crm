using Crm.BL.EF;
using System;
using System.Windows.Forms;
using Crm.BL.Model;

namespace Crm.UI
{
    public partial class Main : Form
    {
        CrmContext _db;

        public Main()
        {
            InitializeComponent();

            _db = new CrmContext();
        }


        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerCatalog = new Catalog<Seller>(_db.Sellers);
            customerCatalog.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productCatalog = new Catalog<Product>(_db.Products);

            productCatalog.Show();
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sellerCatalog = new Catalog<Seller>(_db.Sellers);
            sellerCatalog.Show();
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkCatalog = new Catalog<Seller>(_db.Sellers);
            checkCatalog.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();

            customerForm.ShowDialog();


            if (customerForm.DialogResult == DialogResult.OK)
            {
                _db.Customers.Add(customerForm.Customer);

                _db.SaveChanges();
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sellerForm = new SellerForm();

            sellerForm.ShowDialog();

            if (sellerForm.DialogResult == DialogResult.OK)
            {
                _db.Sellers.Add(sellerForm.Seller);

                _db.SaveChanges();
            }
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var productForm = new ProductForm();

            productForm.ShowDialog();

            if (productForm.DialogResult == DialogResult.OK)
            {
                _db.Products.Add(productForm.Product);

                _db.SaveChanges();
            }
        }
    }
}
