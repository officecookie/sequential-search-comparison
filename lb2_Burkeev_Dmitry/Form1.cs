namespace lb2_Burkeev_Dmitry
{
    public partial class Form1 : Form
    {
        const int N = 500000000;
        int[] mas1 = new int[N + 1];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < N; i++) mas1[i] = rnd.Next(1, N);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int key = (int)numericUpDown2.Value;
            
            

            //lab2
            bool f = false;
            int StartTime = Environment.TickCount;
                for (int j = 0; j < N; j++)
                {
                    if (mas1[j] == key)
                    {
                        int ResultTime1 = Environment.TickCount - StartTime;
                        textBox3.Text = ResultTime1.ToString();
                        textBox4.Text = j.ToString();
                        f = true;
                        break;
                    }
                }
                
                if (!f)
                {
                    int ResultTime1 = Environment.TickCount - StartTime;
                    textBox3.Text = ResultTime1.ToString();
                    textBox4.Text = "Его нет"; 
                }

            //lab 3
            f = false;
            // Устанавливаем барьер
            mas1[N] = key;

            int masha = 0;
            int StartTime2 = Environment.TickCount;
            while (mas1[masha] != key) masha++;
            //end time
            int ResultTime2 = Environment.TickCount - StartTime2;
            if (masha < N) f = true;

            if (f)
            {
                textBox8.Text = masha.ToString();
                textBox6.Text = ResultTime2.ToString();
            }
            else
            {
                textBox8.Text = "Его нет";
                textBox6.Text = ResultTime2.ToString();
            }
        }
        private void Close_Click(object sender, EventArgs e)
        { Close(); }

        private void button1_Click(object sender, EventArgs e)
        {
            //для 4 лабы в будущем
        }
    }
}