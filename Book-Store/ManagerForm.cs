using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Xml.Linq;
using Repository;
using Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;

namespace Book_Store {
    public partial class ManagerForm : Form {
        public static Registration _User = Form1.User;
        
        private BookStoreContext db = new BookStoreContext();
        
        public ManagerForm() {

            InitializeComponent();
            var Repo = new RepositoryBase<Book>();
            
        }

        public void SetDataInGridView1() {
            var AccountRepo = new RepositoryBase<Registration>();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = AccountRepo.GetAll().ToList();
        }

        public void SetDataInGridView2() {
            var BookRepo = new RepositoryBase<Book>();
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = BookRepo.GetAll().ToList();
        }

        //Search Users
        private void btnSearchUser_Click(object sender, EventArgs e) {
            var UserID = txtSearchUser.Text.ToString();

            var AccountRepo = new RepositoryBase<Registration>();
            var ListAccount = AccountRepo.GetAll().Where(p => p.Username.Contains(UserID)).ToList();
            dataGridView1.DataSource = ListAccount;
        }

        //Search Books
        private void btnSearchBook_Click(object sender, EventArgs e) {
            var ID = txtSearchBook.Text.ToString();

            var BookRepo = new RepositoryBase<Book>();
            var ListBook = BookRepo.GetAll().Where(p => p.Id.Contains(ID)).ToList();
            dataGridView2.DataSource = ListBook;
        }

        //Update User
        private void btnUpdate_Click(object sender, EventArgs e) {
            try {
                var regis = db.Registrations.Find(txtUser.Text);
                regis.Username = txtUser.Text;  //UserID must not be changed
                regis.Role = cbRole.Checked;
                regis.FullName = txtFullname.Text;
                regis.Password = txtPassword.Text;
                db.SaveChanges();
                MessageBox.Show("Done");
                dataGridView1.DataSource=db.Registrations.ToList();
            } catch {
                MessageBox.Show("Update User Failed");
            }
        }

        //don't touch this function
        private void btnDelete_Click(object sender, EventArgs e) {
            
            
        }

        //Delete User
        private void btnDeleteUser_Click(object sender, EventArgs e) {
            try {
                var result = MessageBox.Show("Are you sure?", "confirm",
                    MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes) {
                    var id = txtUser.Text.Trim();
                    var regis = db.Registrations.Find(id);
                    db.Registrations.Remove(regis);
                    db.SaveChanges();
                    dataGridView1.DataSource = db.Registrations.ToList();
                    MessageBox.Show("Done");

                    txtUser.Text = "";
                    txtFullname.Text = "";
                    txtPassword.Text = "";
                    cbRole.Checked = false;
                }
                
            } catch {
                MessageBox.Show("Delete User Failed!");
            }
        }

        private void ManagerForm_Load(object sender, EventArgs e) {
            dataGridView1.DataSource = db.Registrations.ToList();
            dataGridView2.DataSource = db.Books.ToList();
        }

        //Click Cells of dataGridView1
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            var user = db.Registrations.Find(id);
            txtUser.Text = user.Username;
            txtFullname.Text = user.FullName;
            txtPassword.Text = user.Password;
            cbRole.Checked = user.Role;
            this.btnUpdate.Enabled = true;
            this.btnDeleteUser.Enabled = true;
        }

        //Add Users
        private void btnAddUser_Click(object sender, EventArgs e) {
            try {
                var user = new Registration {
                    Username = txtUser.Text,
                    FullName = txtFullname.Text,
                    Password = txtPassword.Text,
                    Role = cbRole.Checked
                };
                db.Registrations.Add(user); 
                db.SaveChanges();
                dataGridView1.DataSource = db.Registrations.ToList();
                MessageBox.Show("Done");

                txtUser.Text = "";
                txtFullname.Text = "";
                txtPassword.Text = "";
                cbRole.Checked = false;
            } catch {
                MessageBox.Show("Add User Failed");
            }
        }

        //Click Cells of dataGridView2
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            var id = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            var book = db.Books.Find(id);
            txtID.Text = book.Id;
            txtName.Text = book.Name;
            txtAuthor.Text = book.Author;
            txtDescription.Text = book.Description;
            txtImage.Text = book.ImgUrl;
            nudPrice.Value = book.Price;

            this.btnUpdateBook.Enabled = true;
            this.btnDeleteBook.Enabled = true;
        }

        //Add Books
        private void btnAddBook_Click(object sender, EventArgs e) {
            try {

                var book = new Book {
                    Id = txtID.Text,
                    Name = txtName.Text,
                    Author = txtAuthor.Text,
                    Description = txtDescription.Text,
                    ImgUrl = txtImage.Text,
                    Price = (int)nudPrice.Value
                };
                db.Books.Add(book);
                db.SaveChanges();
                dataGridView2.DataSource = db.Books.ToList();
                MessageBox.Show("Done");

                txtID.Text = "";
                txtName.Text = "";
                txtAuthor.Text = "";
                txtDescription.Text = "";
                txtImage.Text = "";
                nudPrice.Value = 0;
            } catch {
                MessageBox.Show("Add Book Fail!");
            }
        }

        //Delete Books
        private void btnDeleteBook_Click(object sender, EventArgs e) {
            try {
                var result = MessageBox.Show("Are you sure?", "confirm",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) {
                    var id = txtID.Text;
                    var regis = db.Books.Find(id);
                    db.Books.Remove(regis);
                    db.SaveChanges();
                    dataGridView2.DataSource = db.Books.ToList();
                    MessageBox.Show("Done");

                    txtID.Text = "";
                    txtName.Text = "";
                    txtAuthor.Text = "";
                    txtDescription.Text = "";
                    txtImage.Text = "";
                    nudPrice.Value = 0;
                }

            } catch {
                MessageBox.Show("Delete Failed!");
            }
        }

        //Update Books
        private void btnUpdateBook_Click(object sender, EventArgs e) {
            try {
                var regis = db.Books.Find(txtID.Text);
                regis.Id = txtID.Text;
                regis.Name = txtName.Text;
                regis.Author = txtAuthor.Text;
                regis.Description = txtDescription.Text;
                regis.ImgUrl = txtImage.Text;
                regis.Price = (int)nudPrice.Value;
                db.SaveChanges();
                
                dataGridView2.DataSource = db.Books.ToList();
                MessageBox.Show("Done");
            } catch {
                MessageBox.Show("Update Book Failed");
            }
        }

        private void btnViewCart_Click(object sender, EventArgs e) {

            var Repo = new RepositoryBase<OrderDetail>();
            
            if (_User != null) {
                
                var newForm = new CartForm();
                newForm.Hide();
                newForm.ShowDialog();
            } else {
                MessageBox.Show("Your Cart is empty!", "Can not access", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddCart_Click(object sender, EventArgs e) {

        }
    }
}
