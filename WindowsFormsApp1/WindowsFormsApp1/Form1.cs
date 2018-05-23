using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Observers;
using WindowsFormsApp1.Subjects;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        Timer timer = null;
        WeatherData weatherData = null;
        CurrentCondition currentCondition = null;
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            progressBar1.Minimum = 1;
            progressBar1.Maximum = 255;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            weatherData = new WeatherData();
            currentCondition = new CurrentCondition(weatherData);


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            weatherData.setMeasurments(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255), groupBox1, label4,label5,label6,progressBar1);
        }
    }
}
