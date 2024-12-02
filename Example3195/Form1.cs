using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Example3195
{
    public partial class Form1 : Form
    {
        private double V0;
        private double A = 0;
        private double time = 0;
        private double angle = 0f;

        public char[] charArray;
        public char selChar = '0';
        private string sel;
        private List<string> selBaraban;

        private Bitmap bitmap;

        private int score;
        private bool isRotate;

        const string STRING_PRIZ = "приз";
        const string STRING_NONE = "None";
        const string STRING_ROTATE = "Крутить";
        const string STRING_SELECT = "Выбрать букву";

        public int R1 { get; set; }
        public int R2 { get; set; }
        public int Time { get; set; }
        private Random Random;

        public Form1()
        {
            InitializeComponent();
            isRotate = false;
            score = 0;
            R1 = 372;
            R2 = 498;
            Time = 5;
            Random = new Random((int)ConvertToUnixTimestamp(DateTime.Now));
            selBaraban = new List<string>()
            {
                "x5", // Элемент на котором стоит стрелка должен быть первым
                "0",
                STRING_PRIZ,
                "500",
                "300",
                "200",
                "x3",
                "700",
                STRING_NONE,
                "100",
                "900",
                "x2",
                "600",
                "800",
                "+1",
                "400",
            };
            sel = selBaraban[0];
            bitmap = Properties.Resources.baraban_finel;
            imageBox.Image = bitmap;
            // TO DO сделать угадывание всего слова и есть ли буква в слове если да открывать все ее вхождения
            string[] words = new string[]{
                "монстры",
                "франкенштейн",
                "конфеты",
                "тыква"
            };
            charArray = words[Random.Next(0, words.Length)].ToCharArray();
            dataGridView1.ColumnCount = charArray.Length;
            dataGridView1.RowCount = 1;


            actionButton.Text = STRING_ROTATE;
        }



        private double RaschetStart(double v0, double constTime)
        {

            double velocity = 0;
            double velocity0 = v0;
            double time = constTime;
            double a = (-1 * velocity0) / (double)time;
            velocity = velocity0 + a * time;
            velocity0 = velocity - a * time;
            labelA.Text = a.ToString();
            labelTime.Text = time.ToString();
            labelV0.Text = velocity0.ToString();
            physLabel.Text = velocity.ToString();

            return a;
        }

        /// <summary>
        /// Функция расчета угла поворота от указанного времени(вызывается каждый тик)
        /// </summary>
        /// <param name="v0">начальная скорость</param>
        /// <param name="t"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        private double RaschetAngle(double v0, double t, double a)
        {
            double ph;
            double ph0 = 0;

            double velocity0 = v0;


            ph = ph0 + velocity0 * t + (a * t * t) / 2d;
            labelph.Text = Math.Round(ph).ToString();

            return ph;
        }






        private string selectedSector()
        {
            int c = 0;
            int countRot = (int)angle / 360;
            double clearAngle = angle - (countRot * 360);
            
            for (float i = 0; i <= 360; i += 22.5f)
            {
                if (clearAngle >= i && clearAngle < i + 22.5f)
                {
                    try
                    {
                        Debug.WriteLine("SEL+" + selBaraban[c + 1]);
                        Debug.WriteLine("SEL-" + selBaraban[c - 1]);
                    }
                    catch (Exception)
                    {

                    }
                    return selBaraban[c];

                }
                c++;
            }

            return selBaraban[0];


        }





        /// <summary>
        /// Главная функция отвечающая за событие происходящее каждый интервал таймера, в нашем случае вращение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            time += timer1.Interval;

            double velocity = V0 + A * (time / 1000d);

            double ph = RaschetAngle(V0, time / 1000d, A);
            Rotate(angle + ph);


            Debug.WriteLine(time / 1000d + " " + velocity);
            if (velocity <= 0)
            {
                timer1.Stop();
                isRotate = true;
                this.angle += ph;
                sel = selectedSector();
                currentSel.Text = sel;
                if (sel == "+1")
                {
                    isRotate = false;
                    Start();
                    timer1.Start();
                    return;
                }
                else if (sel == STRING_PRIZ)
                {


                    if (Random.Next(0, 2) == 1)
                    {
                        score += 1000;
                        MessageBox.Show("Выигрыш");

                    }
                    else
                    {
                        MessageBox.Show("Не повезло");
                    }
                    isRotate = false;
                    actionButton.Text = STRING_ROTATE;
                }
                else if (sel == STRING_NONE)
                {
                    score = 0;
                    isRotate = false;

                    actionButton.Text = STRING_ROTATE;
                }
                else
                {
                    actionButton.Text = STRING_SELECT;

                }
                actionButton.Enabled = true;
                if (checkBox1.Checked)
                {
                    actionButton.PerformClick();
                }

            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isRotate)
            {
                if (dataGridView1.Rows[0].Cells[e.ColumnIndex].Value == null)
                {
                    new selectKey(this, e.ColumnIndex).ShowDialog();

                    if (selChar != '0')
                    {
                        if (selChar == charArray[e.ColumnIndex])
                        {
                            Result(sel);
                            dataGridView1.Rows[0].Cells[e.ColumnIndex].Value = charArray[e.ColumnIndex];
                        }
                    }

                    selChar = '0';
                }
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void Start()
        {
            time = 0;
            V0 = Random.Next(R1, R2);
            A = RaschetStart(V0, Time);
            double maxAngle = RaschetAngle(V0, 5 / 1000d, A);
        }

        private void Result(string resBaraban)
        {
            if (int.TryParse(resBaraban, out int sc))
            {
                score += sc;
            }
            else
            {
                if (resBaraban[0] == 'x')
                {
                    score *= int.Parse(resBaraban[1].ToString());
                }
            }

            label2.Text = score.ToString();
        }

        public void Rotate(double angle)
        {
            System.Drawing.Image image = RotateImage(imageBox.Image, angle);
            imageBox.Image = null;
            imageBox.Invalidate();
            imageBox.Image = image;
            imageBox.SizeMode = PictureBoxSizeMode.Zoom;
            imageBox.Invalidate();
        }





        public System.Drawing.Image RotateImage(System.Drawing.Image img, double angle)
        {

            Graphics g1 = Graphics.FromImage(bitmap);
            g1.Clear(Color.Transparent);
            bitmap = Properties.Resources.baraban_finel;
            GC.Collect();
            Graphics g = Graphics.FromImage(bitmap);
            g.TranslateTransform(bitmap.Height / 2, bitmap.Width / 2);  //Put the rotation point in the center of the image
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.RotateTransform((float)angle);  //rotate the image
            g.TranslateTransform(-bitmap.Height / 2, -bitmap.Width / 2);
            g.DrawImage(bitmap, new PointF(0, 0));  //draw passed in image onto graphics object     
            return bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return origin.AddSeconds(timestamp);
        }

        public static long ConvertToUnixTimestamp(DateTime date)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Convert.ToInt64(Math.Floor(diff.TotalSeconds));
        }

        private void actionButton_Click(object sender, EventArgs e)
        {


            if (!isRotate)
            {
                if (timer1.Enabled)
                {
                    // timer1.Stop(); // Чтобы барабан нельзя было остановить
                }
                else
                {
                    Start();
                    timer1.Start();
                    actionButton.Enabled = false;
                }
            }
            else
            {
                new selectKey(this, 0).ShowDialog();
                bool uspeh = false;
                if (selChar != '0')
                {
                    for (int i = 0; i < charArray.Length; i++)
                    {
                        if (charArray[i] == selChar)
                        {
                            dataGridView1.Rows[0].Cells[i].Value = charArray[i];
                            uspeh = true;
                        }
                    }
                }
                if (uspeh)
                {
                    Result(sel);
                }
                selChar = '0';
                isRotate = false;
                actionButton.Text = STRING_ROTATE;




                //
                if (checkBox1.Checked)
                {
                    actionButton.PerformClick();
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void показатьубратьОтладкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            debugBox.Visible = !debugBox.Visible;
        }

        private void настройкаЦветовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selColor selColor = new selColor();
            selColor.ShowDialog();
        }

        private void настройкаСкоростиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting setting = new setting(this);
            setting.ShowDialog();

        }
    }
}
