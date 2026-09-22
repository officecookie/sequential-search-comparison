namespace lb2_Burkeev_Dmitry
{
    public partial class Form1 : Form
    {
        const int N = 500000000;
        int[] mas1 = new int[N + 1];

        int[] mas2 = new int[N + 1];
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < N; i++) mas1[i] = rnd.Next(1, N);




            Random rnd2 = new Random();
            //это я сделал чтобы не с какогото там 23542 начинался, а именно с 1 и т.д. Но если хотите можно и убрать!
            mas2[0] = 1;


            for (int i = 1; i < N; i++)
            {
                mas2[i] = mas2[i - 1] + rnd2.Next(1, 6);
            }
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
            int key = (int)numericUpDown1.Value;


            bool f = false;
            // Устанавливаем барьер
            mas2[N] = key;

            int Samuilow = 0;

            int StartTime2 = Environment.TickCount;
            while (mas2[Samuilow] != key) Samuilow++;
            //end time
            int ResultTime2 = Environment.TickCount - StartTime2;
            if (Samuilow < N) f = true;

            if (f)
            {
                textBox2.Text = Samuilow.ToString();
                textBox1.Text = ResultTime2.ToString();
            }
            else
            {
                textBox2.Text = "Его нет";
                textBox1.Text = ResultTime2.ToString();
            }



            f = false;
            

            int Gurianow = 0;


            int StartTime3 = Environment.TickCount;
            while (mas2[Gurianow] < key)
            {
                Gurianow++;
            }
            //END TIME
            int ResultTime3 = Environment.TickCount - StartTime3;

            if (Gurianow < N && mas2[Gurianow] == key) f = true;

            if (f)
            {
                textBox7.Text = Gurianow.ToString();
                textBox5.Text = ResultTime3.ToString();
            }
            else
            {
                textBox7.Text = "Его нет";
                textBox5.Text = ResultTime3.ToString();
            }
        }
    }
}