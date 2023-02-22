namespace ToDoNotify
{
    public partial class Form1 : Form
    {
        ViewModel viewModel = new ViewModel();
        public Form1()
        {
            InitializeComponent();

        }

        private void ToDoNotify_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            DateTime time = dateTimePicker2.Value;

            Objective newObjective = new Objective(
                new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second), 
                textBox1.Text
                );
            viewModel.objectives.Add(newObjective);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}