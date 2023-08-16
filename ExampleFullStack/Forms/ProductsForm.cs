using ExampleFullStack.Entity;
using System.Data;
using System.Data.SqlClient;

namespace ExampleFullStack
{
    public partial class ProductsForm : Form
    {
        string userFullName;
        Product selectedProduct;
        /// <summary>
        /// Bu form ancak ve ancak sadece userFullName ile örneklenir.
        /// </summary>

        public ProductsForm(string userFullName)
        {
            InitializeComponent();

            //lblUser.Text = username;
            this.userFullName = userFullName;
            Reload();

        }
        public void Reload()
        {
            var notes = ListProduct();
            listNote.DataSource = null;
            listNote.DataSource = notes;
            listNote.DisplayMember = "Name";
            listNote.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void NotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            //Uygulama kapandýðýnda tamamen program sonlanýyor.

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            var item = listNote.SelectedItem as Product;

            label1.Text = item.Stock.ToString();
            lblUser.Text = userFullName;
        }

        //bu metotda 1 iþ yapýyor
        //veritabaný kayýtlarýnýn çekilmesi de bir iþtir.

        private List<Product> ListProduct()
        {
            var productList = new List<Product>();
            SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=LearnDb; integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
            command.CommandText = "Select * from Products";

            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var product = new Product();

                product.Id = Convert.ToInt32(reader[0]);
                product.Name = Convert.ToString(reader[1]);
                product.Stock = Convert.ToInt32(reader[2]);

                productList.Add(product);
            }
            reader.Close();
            connection.Close();
            return productList;

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
        }

        private void listNote_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectedProduct = listNote.SelectedItem as Product;
            txtStock.Text = selectedProduct.Stock + "";
            TxtNote.Text = selectedProduct.Name;
            label1.Text = selectedProduct.Stock.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtStock.Text) && !string.IsNullOrEmpty(TxtNote.Text))
            {
                UpdateProduct(new Product
                { Name = TxtNote.Text, Stock = int.Parse(txtStock.Text), Id = selectedProduct.Id });
                Reload();

            }

        }

        private int UpdateProduct(Product updatedProduct)
        {
            SqlConnection connection = new SqlConnection("Server=.\\SQLExpress; database=LearnDb; integrated security=true;");

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update Products set Name = @name, Stock=@stock where Id=@id";

            command.Parameters.AddWithValue("@name", updatedProduct.Name);
            command.Parameters.AddWithValue("@stock", updatedProduct.Stock);
            command.Parameters.AddWithValue("@id", updatedProduct.Id);

            connection.Open();
            int effectedRows = command.ExecuteNonQuery();
            connection.Close();
            return effectedRows;


        }
    }
}