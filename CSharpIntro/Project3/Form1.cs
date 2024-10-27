namespace Project3
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //Buraya yazma sebebimiz customermanager iki farkl� blokta new lenirse farkl� bir cutomer manager
        //olarak alg�lanacakt�r ve btnAdd i�indeki customer null de�erine sahip olacakt�r. 
        CustomerManager customerManager = new CustomerManager() ;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //DataGridWiev �n veri kayna�� bu projedir  demektir
            dgrwCustomers.DataSource = customerManager.GetAll();
            //Kolonlar� sayfa b�y�kl��� de�i�irse orant�l� olarak de�i�tir =
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
            // yeni veri i�in �nce eski verileri ��kart�r�z ve tekrarda GetAll methodnu �a��r�r�z
            dgrwCustomers.DataSource = null;
            dgrwCustomers.DataSource = customerManager.GetAll();
            MessageBox.Show("Ba�ar�yla eklendi");
        }

        private void gbxAdd_Enter(object sender, EventArgs e)
        {
            //��erdi�i her�eyin boyutunu toplu olarak d�zenlemeye yarar
        }
    }
}
