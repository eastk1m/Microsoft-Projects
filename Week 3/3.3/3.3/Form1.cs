using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentRecordsApp
{
    public partial class MainForm : Form
    {
        private List<Student> studentList = new List<Student>();
        private object dataGridViewStudents;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initialize sample data (you can load from a database or other sources)
            studentList.Add(new Student(1, "John", "Doe", "123 Main St", MonthOfAdmission.September, 'A'));
            studentList.Add(new Student(2, "Jane", "Smith", "456 Elm St", MonthOfAdmission.January, 'B'));

            // Bind the studentList to DataGridView (assuming you have a DataGridView named dataGridViewStudents)
            dataGridViewStudents = studentList;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Capture input and add a new student
            int studid = int.Parse(textBoxStudId.Text);
            string firstname = textBoxFirstName.Text;
            string lastname = textBoxLastName.Text;
            string address = textBoxAddress.Text;
            MonthOfAdmission month = (MonthOfAdmission)comboBoxMonth.SelectedIndex;
            char grade = textBoxGrade.Text[0]; // Assuming single character grade

            studentList.Add(new Student(studid, firstname, lastname, address, month, grade));
            dataGridViewStudents.Refresh(); // Refresh the DataGridView
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Remove the selected student
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewStudents.SelectedRows[0].Index;
                studentList.RemoveAt(selectedIndex);
                dataGridViewStudents.Refresh();
            }
        }
    }

    // Student structure
    public struct Student
    {
        public int studid;
        public string firstname;
        public string lastname;
        public string address;
        public MonthOfAdmission monthofadmission;
        public char grade;

        public Student(int id, string first, string last, string addr, MonthOfAdmission month, char grd)
        {
            studid = id;
            firstname = first;
            lastname = last;
            address = addr;
            monthofadmission = month;
            grade = grd;
        }
    }

    // Enum for month of admission
    public enum MonthOfAdmission
    {
        January, February, March, April, May, June,
        July, August, September, October, November, December
    }
}
