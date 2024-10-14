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
            students = new List<string>() { "Samet Ta�", "Yunus Eren Tonkal", "Serdar Do�an" };
            foreach (string student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // bo�lukta bir karakterlik yer kaplad��� i�in b�yle bir�ey yapt�k
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
                MessageBox.Show("��renci ismi en az 2 karakterli olmal�d�r");
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
