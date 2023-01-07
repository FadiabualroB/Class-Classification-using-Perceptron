using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq.Expressions;
using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ANN
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        Point cursor;
        List<double[]> trainingData = new List<double[]>();
        List<double[]> initialWeights = new List<double[]>();
        double[] initialWeight = new double[2];
        List<double> yd_REd = new List<double>();
        List<double> yd_Green = new List<double>();
        List<double> yd_Blue = new List<double>();
        List<double> yd_Black = new List<double>();
        List<List<double>> All_yd_Values = new List<List<double>>();
        List<double[]> TestingData = new List<double[]>();
        List<double> Error = new List<double>();
        List<Point> points = new List<Point>();
        int Maximum_Iterations;
        double thresholdsign;
        double colorIndex;
        double bigXValue, w1, w2, thresholValue, ya_Value;
        double error, delta_W1, delta_W2;
        double learning_rate = 0.2;
        double new_X1, new_X2;
        public static double getRange(double minRange, double maxRange)
        {
            var random = new Random();
            var rDouble = random.NextDouble();
            return rDouble * (maxRange - minRange) + minRange;
        }
        double getThreshold()
        {
            double getthresholValue = getRange(-0.5, 0.5);
            thresholValue = getthresholValue;
            return thresholValue;
        }
        double[] getinitialWeight()
        {
            w1 = getRange(-0.5, 0.5);
            w2 = getRange(-0.5, 0.5);
            initialWeight = new double[] { w1, w2 };

            initialWeights.Add(new double[] { w1, w2 });
            return initialWeight;
        }
        double bigX(double W1, double W2, double x1, double x2, double threValue, double threSign)
        {
            bigXValue = (x1 * W1) + (x2 * W2) + (threValue * threSign);
            return bigXValue;
        }
        double getdelta_W(double err, double Xi)
        {
            double delta_Wvalue = learning_rate * err * Xi;
            return delta_Wvalue;
        }
        double getError(double yd, double ya)
        {
            error = yd - ya;
            return error;
        }
        double getya_Value(string type, double bigX)
        {
            double exp = 2.178;

            if (type == "Tanh")
            {
                return ((2 / (1 + Math.Pow(exp, -2 * bigX))) - 1);
            }
            else if (type == "Sigmoid")
            {
                return 1 / (1 + Math.Pow(exp, -1 * bigX));
            }
            else if (type == "Step")
            {
                if (bigX >= 0)
                    return 1;
                else
                    return 0;
            }
            else
            {
                return -1;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = txt_Itteration.Text;
            if (s == "")
                Maximum_Iterations = 10000;
            else
                Maximum_Iterations = int.Parse(s);
        }
        private void DL_ColorSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void rd_binery_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_binery.Checked)
            {
                DL_ColorSelector.Items.Clear();
                DL_ColorSelector.Items.Add("Red");
                DL_ColorSelector.Items.Add("Blue");
            }
        }
        private void rd_multi_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_multi.Checked)
            {
                DL_ColorSelector.Items.Clear();
                DL_ColorSelector.Items.Add("Red");
                DL_ColorSelector.Items.Add("Blue");
                DL_ColorSelector.Items.Add("Green");
                DL_ColorSelector.Items.Add("Black");
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            rd_binery.Checked = true;
        }
        private void TB_learningRate_Scroll(object sender, EventArgs e)
        {
            learning_rate = TB_learningRate.Value;
            learning_rate = learning_rate / 10;
            textBox1.Text = learning_rate.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            TB_learningRate.Value = 0;
            textBox1.Text = "0.2";
            txt_Itteration.Text = "10000";
            txtThreashold.Text = "-1";
            trainingData.Clear();
            initialWeights.Clear();
            initialWeight.Clone();
            yd_REd.Clear();
            yd_Blue.Clear();
            yd_Green.Clear();
            yd_Black.Clear();
            All_yd_Values.Clear();
            Error.Clear();
            TestingData.Clear();
            points.Clear();
            panel1.CreateGraphics().Clear(Color.White);
            label1.Text = "Run Time";

        }

        void setyd(List<double> ydd, string tagetColor, string inputcolor)
        {
            if (tagetColor == inputcolor)
            {
                ydd.Add(1);
            }
            else
            {
                ydd.Add(0);
            }
        }
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }
        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (DL_ColorSelector.SelectedItem.ToString() == "Red")
            {
                p = new Pen(Color.Red, 5);
                g.DrawEllipse(p, cursor.X - 5, cursor.Y - 5, 5, 5);
                colorIndex = 1;
            }
            else if (DL_ColorSelector.SelectedItem.ToString() == "Blue")
            {
                p = new Pen(Color.Blue, 5);
                g.DrawEllipse(p, cursor.X - 5, cursor.Y - 5, 5, 5);
                colorIndex = 2;
            }
            else if (DL_ColorSelector.SelectedItem.ToString() == "Green")
            {
                p = new Pen(Color.Green, 5);
                g.DrawEllipse(p, cursor.X - 5, cursor.Y - 5, 5, 5);
                colorIndex = 3;
            }
            else
            {
                p = new Pen(Color.Black, 5);
                g.DrawEllipse(p, cursor.X - 5, cursor.Y - 5, 5, 5);
                colorIndex = 4;
            }
            double x1 = cursor.X;
            double x2 = cursor.Y;

            trainingData.Add(new double[] { x1, x2, colorIndex });

            setyd(yd_REd, DL_ColorSelector.Text, "Red");
            All_yd_Values.Add(yd_REd);
            setyd(yd_Blue, DL_ColorSelector.Text, "Blue");
            All_yd_Values.Add(yd_Blue);
            setyd(yd_Green, DL_ColorSelector.Text, "Green");
            All_yd_Values.Add(yd_Green);
            setyd(yd_Black, DL_ColorSelector.Text, "Black");
            All_yd_Values.Add(yd_Black);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            cursor = panel1.PointToClient(Cursor.Position);
            MousePosition.Text = "X: " + cursor.X + "Y: " + cursor.Y;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics().Clear(Color.White);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Stopwatch myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();

            if (txtThreashold.Text == "-1")
            {
                thresholdsign = -1;
            }
            else if (txtThreashold.Text == "1")
            {
                thresholdsign = 1;
            }
            else
            {
                MessageBox.Show("Threshold Value should be -1 or 1 !");
            }

            thresholValue = getThreshold();
            getinitialWeight();

            if (rd_binery.Checked)
            {
                for (int j = 0; j < Maximum_Iterations; j++)
                {
                    Error.Clear();
                    for (int i = 0; i < trainingData.Count(); i++)
                    {
                        double x1 = trainingData[i][0];
                        double x2 = trainingData[i][1];

                        bigXValue = bigX(w1, w2, x1, x2, thresholValue, thresholdsign);

                        ya_Value = getya_Value(DL_ActivationFunction.Text, bigXValue);

                        error = getError(yd_REd[i], ya_Value);
                        Error.Add(error);

                        delta_W1 = getdelta_W(error, x1);
                        delta_W2 = getdelta_W(error, x2);
                        w1 = delta_W1 + w1;
                        w2 = delta_W2 + w2;

                        initialWeights.Add(new double[] { w1, w2 });
                    }
                }
                for (int i = 0; i < trainingData.Count; i++)
                {
                    new_X1 = trainingData[i][0];
                    new_X2 = (-w1 * new_X1 / w2) + (thresholValue / w2);
                    TestingData.Add(new double[] { new_X1, new_X2 });
                    points.Add(new Point((int)new_X1, (int)new_X2));
                }
                panel1.CreateGraphics().DrawLines(Pens.Red, points.ToArray());
            }
            if (rd_multi.Checked)
            {
                for (int k = 0; k < All_yd_Values.Count(); k++)
                {
                    for (int j = 0; j < Maximum_Iterations; j++)
                    {
                        Error.Clear();
                        for (int i = 0; i < trainingData.Count(); i++)
                        {
                            double x1 = trainingData[i][0];
                            double x2 = trainingData[i][1];

                            bigXValue = bigX(w1, w2, x1, x2, thresholValue, thresholdsign);

                            ya_Value = getya_Value(DL_ActivationFunction.Text, bigXValue);

                            error = getError(All_yd_Values[k][i], ya_Value);
                            Error.Add(error);

                            delta_W1 = getdelta_W(error, x1);
                            delta_W2 = getdelta_W(error, x2);

                            w1 = delta_W1 + w1;
                            w2 = delta_W2 + w2;
                            initialWeights.Add(new double[] { w1, w2 });

                        }
                    }
                    for (int i = 0; i < trainingData.Count; i++)
                    {
                        new_X1 = trainingData[i][0];
                        new_X2 = (-w1 * new_X1 / w2) + (thresholValue / w2);

                        TestingData.Add(new double[] { new_X1, new_X2 });
                        points.Add(new Point((int)new_X1, (int)new_X2));
                    }
                    if (k == 0)
                    {
                        panel1.CreateGraphics().DrawLines(Pens.Red, points.ToArray());
                    }
                    if (k == 1)
                    {
                        panel1.CreateGraphics().DrawLines(Pens.Blue, points.ToArray());
                    }
                    if (k == 2)
                    {
                        panel1.CreateGraphics().DrawLines(Pens.Green, points.ToArray());
                    }
                    if (k == 3)
                    {
                        panel1.CreateGraphics().DrawLines(Pens.Black, points.ToArray());
                    }

                    TestingData.Clear();
                    points.Clear();
                }
            }

            myStopwatch.Stop();
            TimeSpan ts = myStopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
            label1.Text = "Run Time: " + elapsedTime;
        }
    }
}