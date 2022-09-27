using System;
using System.Windows.Forms;
using CrmBl.Model;

namespace CrmUi
{
    public partial class Main : Form
    {
        CrmContext db;

        public Main()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogProduct = new Catalog<Product>(db.Products,db);
            CatalogProduct.Show();
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogSeller = new Catalog<Seller>(db.Sellers, db);
            CatalogSeller.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogCustomer = new Catalog<Customer>(db.Customers, db);
            CatalogCustomer.Show();
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogCheck = new Catalog<Check>(db.Checks, db);
            CatalogCheck.Show();
        }

        private void sellerAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        private void goodsAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new GoodsForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }

        private void customerAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void modelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModelForm form = new ModelForm();
            form.Show();
        }
    }
}
