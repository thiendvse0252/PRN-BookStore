using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Repository.Models;

namespace Book_Store {
    public partial class CartForm : Form {
        private BookStoreContext db = new BookStoreContext();
        public CartForm() {
            InitializeComponent();
        }

        private void btnCheckOut_Click(object sender, EventArgs e) {
            try {

                MessageBox.Show("Done!");
            }catch {
                MessageBox.Show("CheckOut Fail!");
            }
        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var id = dataGridViewCart.Rows[e.RowIndex].Cells[0].Value.ToString();
            var order = db.Ordereds.Find(id);
            tbID.Text = order.OrderId;
            tbName.Text = order.Username;

            nudQuantityCart.Value = order.TotalPayment;

            this.btnDeleteCart.Enabled = true;
            this.btnCheckOut.Enabled = true;
        }

        private void btnDeleteCart_Click(object sender, EventArgs e) {
            try {

                MessageBox.Show("Done");
            } catch {
                MessageBox.Show("Delete Item Fail!");
            }
        }
    }
}
