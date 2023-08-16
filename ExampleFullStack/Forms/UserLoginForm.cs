using System.Data;
using System.Data.SqlClient;

namespace ExampleFullStack
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //NotesForm form1 = new NotesForm();
            ////form1.ShowDialog();
            ////Thread.Sleep(1000);

            ////login form kapanıp form1 açılması sağlanır.

            //form1.Show();
            //this.Hide();

            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text)) ;
            {

                var userFullName = GetUserFullName(txtUserName.Text, txtPassword.Text);

                if (!string.IsNullOrEmpty(userFullName))
                {
                    ProductsForm form = new ProductsForm(userFullName);
                    form.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Kulannıcı adı veya şifre hatalı.");
                }

            }
            //else {
            //    MessageBox.Show("Alanları doldurunuz.");
            //} 

        }

        ///<summary>
        ///Parametre olaraka girilen username ve pasword karşılık, userin full name'ini döner. 
        ///<summary>

        private string GetUserFullName(string username, string password)
        {

            //sqlConnection
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database = LearnDb; integrated security = true;");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Users where Username=@username and Password=@password";


            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();
            var reader = command.ExecuteReader();

            string fullname = "";

            while (reader.Read())
            {
                //var username = Convert.ToString(reader[1]);
                fullname = Convert.ToString(reader[3]);
            }
            reader.Close();
            connection.Close();

            return fullname;


        }
    }
}
