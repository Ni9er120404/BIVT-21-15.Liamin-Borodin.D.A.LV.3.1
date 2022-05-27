namespace BIVT_21_15_Liamin_Borodin.D.A._LV_3_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void RichTextBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Person_Of_The_Year person_Of_The_Year = new();
            richTextBox2.Text = person_Of_The_Year.PersonOfTheYear(richTextBox1.Text);
        }
    }
    class Person_Of_The_Year
    {
        public string PersonOfTheYear(string name)
        {
            string console = "";
            List<int> list = new();
            int count = 0;
            string[] a = name.Split(' ');
            HashSet<string> universal = new(a);
            string[] myUniqueArray = universal.ToArray();
            for (int i = 0; i < myUniqueArray.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == myUniqueArray[i])
                    {
                        count++;
                    }
                }
                list.Add(count);
                count = 0;
            }
            for (int i = 0; i < 5; i++)
            {
                console += myUniqueArray[i] + "\t" + list[i].ToString() + "\n";
            }
            return console;
        }
    }
}