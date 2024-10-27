namespace Project3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //Buraya yazma sebebimiz customermanager iki farklý blokta new lenirse farklý bir cutomer manager
        //olarak algýlanacaktýr ve btnAdd içindeki customer null deðerine sahip olacaktýr. 
        CustomerManager customerManager = new CustomerManager() ;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //DataGridWiev ýn veri kaynaðý bu projedir  demektir
            dgrwCustomers.DataSource = customerManager.GetAll();
            //Kolonlarý sayfa büyüklüðü deðiþirse orantýlý olarak deðiþtir =
            dgrwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {         
            Customer customer = new Customer();
            customer.ID = Convert.ToInt32(tbxId.Text);
            customer.FirstName = tbxFirstName.Text;
            customer.LastName = tbxLastName.Text;
            customer.Email = tbxEmail.Text;
            customer.City = tbxCity.Text;
            customerManager.Add(customer);
            // yeni veri için önce eski verileri çýkartýrýz ve tekrarda GetAll methodnu çaðýrýrýz
            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = customerManager.GetAll();
            MessageBox.Show("Baþarýyla eklendi");
        }

        private void gbxAdd_Enter(object sender, EventArgs e)
        {
            //Ýçerdiði herþeyin boyutunu toplu olarak düzenlemeye yarar
        }
    }
}
