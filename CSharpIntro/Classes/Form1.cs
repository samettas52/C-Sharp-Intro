namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string name = "Samet";
            int age = 22;

            // verileri tek tek girmek yerine ;

            List<string> Names = new List<string>() {"Samet" , "Serdar" , "Ya��z" };
            List<int> Ages  = new List<int>() { 22 , 21 ,21 };
            List<string> Mails = new List<string>() { "Samet@...", "Serdar@...", "Ya��z@..." };

            for (int i = 0; i < Names.Count; i++)
            {
                //MessageBox.Show(Names[i] + " " + Ages[i] + " " + Mails[i] + " ");
            }
            //tabi buda istedi�imiz verimi bize vermeyecektir ve devreye classlar girecek
       
            //class yap�s�:
            Student ogrenci1 = new Student();
            ogrenci1.Name = "Samet";
            ogrenci1.Age = 22;
            ogrenci1.Mail = "Samet@...";

            Student ogrenci2 = new Student();
            ogrenci2.Name = "Serdar";
            ogrenci2.Age = 21;
            ogrenci2.Mail = "Serdar@...";

            Student ogrenci3 = new Student();
            ogrenci3.Name = "Ya��z";
            ogrenci3.Age = 21;
            ogrenci3.Mail = "Ya��z@...";

            List<Student> students = new List<Student>() {ogrenci1,ogrenci2,ogrenci3 };

            foreach (var student in students )
            {
                //MessageBox.Show(student.Name + " " + student.Age + " " + student.Mail);
                lbxStudents.Items.Add(student.Name);
            }

            //toolboxtan alaca��m�z DataGridWiev toolu ile sistem veriyi excelldeki gibi i�ler
            //tool a yazd�rd���m�z kod ise budur:
            dgrwStudents.DataSource = students;
        }
    }
}
