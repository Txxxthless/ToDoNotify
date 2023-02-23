using System.Runtime.Serialization.Formatters.Binary;

namespace ToDoNotify
{
    public partial class Form1 : Form
    {
        public delegate void DeleteObjective(int index);
        public DeleteObjective DeleteFromListBox;
        public ListBox listBox1 = new ListBox() { Location = new Point(12,44), Size = new Size(245,199)};
        ViewModel viewModel = new ViewModel();

        public Form1()
        {
            InitializeComponent();
            Controls.Add(listBox1);
            viewModel.mainForm = this;

            DeleteFromListBox = (int index) =>
            {
                listBox1.Items.RemoveAt(index);
                MessageBox.Show(viewModel.objectives[index].objectiveDescription);
            };

            Task.Run(() => viewModel.DoChecking());
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

            listBox1.Items.Add(newObjective.TimeAndDescription);
        }

        private void ToDoNotify_Load(object sender, EventArgs e)
        {
            using FileStream fs = new FileStream("user_config.s", FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                viewModel.objectives = (List<Objective>)bf.Deserialize(fs);

                if (viewModel.objectives.Count != 0)
                {
                    foreach (var o in viewModel.objectives) listBox1.Items.Add(o.TimeAndDescription);
                }
            } catch (Exception ex) { Console.WriteLine(ex.StackTrace); }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            using FileStream fs = new FileStream("user_config.s", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, viewModel.objectives);
        }
















        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
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