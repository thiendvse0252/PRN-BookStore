using Repository;
using Repository.Models;

namespace Book_Store {
    public partial class Form1 : Form {

        public static Registration User = new Registration();
        public Form1() {
            var a = DataConnect.GetConnectionString();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            var _Username = txtUsername.Text.ToString();
            var _Password = txtPassword.Text.ToString();

            var Repo = new RepositoryBase<Registration>();
            var _User = Repo.GetAll().Where(o => o.Username.Equals(_Username) && o.Password.Equals(_Password)).FirstOrDefault();
            if (_User != null) {
                User = (Registration)_User;
                var newForm = new ManagerForm();
                newForm.Hide();
                newForm.ShowDialog();
            } else {
                MessageBox.Show("You are not allowed to access this function", "Login fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        
    }
}