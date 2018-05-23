using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Observers;

namespace WindowsFormsApp1.Subjects
{
    public class WeatherData : iSubject
    {
        List<iObserver> observers;
        private int temperature;
        private int pressure;
        private int humidity;
        public GroupBox groupBox1 { get; set; }
        public Label label1 { get; set; }
        public Label label2 { get; set; }
        public Label label3 { get; set; }
        public ProgressBar progressBar { get; set; }
        public WeatherData()
        {
            observers = new List<iObserver>();
        }
        public void notifyObserver()
        {
            foreach (iObserver obs in observers)
            {
                obs.update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(iObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(iObserver o)
        {
            observers.Remove(o);
        }

        public void messurementsChanges()
        {
            notifyObserver();
        }

        public void setMeasurments(int temp, int _humidity, int _pressure, GroupBox groupBox1, Label label1, Label label2, Label label3, ProgressBar progressBar)
        {
            temperature = temp;
            humidity = _humidity;
            pressure = _pressure;
            this.groupBox1 = groupBox1;
            this.label1 = label1;
            this.label2 = label2;
            this.label3 = label3;
            this.progressBar = progressBar;
            messurementsChanges();

        }
    }
}
