using Model.DomainModels;
namespace View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Person> people = new List<Person>
            {
                new Person { Id = 1, FirstName = "Ati", LastName = "hashemi" },
                new Person { Id = 2, FirstName = "Ali", LastName = "Tehrani" },
            };

            dataGridView1.DataSource = people;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
