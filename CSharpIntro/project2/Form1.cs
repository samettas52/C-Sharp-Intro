namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> students;
        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() { "Samet Taþ", "Yunus Eren Tonkal", "Serdar Doðan" };
            foreach (string student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // boþlukta bir karakterlik yer kapladýðý için böyle birþey yaptýk
            if (tbxStudentName.Text.Length >= 2)
            {
                students.Add(tbxStudentName.Text);
                lbxStudentList.Items.Clear();
                foreach (string student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("Öðrenci ismi en az 2 karakterli olmalýdýr");
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lbxStudentList.SelectedItem != null)
            {
                students.Remove(lbxStudentList.SelectedItem.ToString());
                lbxStudentList.Items.Clear();
                foreach (string student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }
        }
    }
}
