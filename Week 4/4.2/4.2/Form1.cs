namespace _4._2


{
    public partial class Form1 : Form

    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Logonbutton_Click(object sender, EventArgs e)

        {
            Form2 studentForm = new Form2();
            studentForm.Show();
        }
    }
}
