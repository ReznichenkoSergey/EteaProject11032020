using FProjectEtea1.Classes;
using FProjectEtea1.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EteaProject11032020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = a++;
            int c = ++a;
            int d = b++;
            this.listBox1.Items.Add($"Values: a={a}, b={b}, c={c}, d={d}");
            this.listBox1.Items.Add(string.Empty);

            Temp temp = new Temp("1", 0, "Один");
            temp.Count += 10;
            //
            Temp temp1 = new Temp("2", 0, "Два");
            //
            Temp2 tempV = temp;
            //
            //this.textBox1.Text = Temp.SetStatVar();
            //this.textBox1.Text = tempV.Method2();
            //this.textBox1.Text = tempV.Method1().ToString();
            //this.textBox1.Text = temp.Method1().ToString();
            //this.textBox1.Text = temp1.GetDate();
            //
            this.listBox1.Items.Add($"Object Equals = {temp.Equals(temp1)}");
            this.listBox1.Items.Add(string.Empty);
            //
            ((ITemp)temp).GetValues();
            this.listBox1.Items.Add($"Interface Method Result= {temp.Count}");
            this.listBox1.Items.Add(string.Empty);
            //
            temp.GetValues();
            this.listBox1.Items.Add($"Class Method Result = {temp.Count}");
            this.listBox1.Items.Add(string.Empty);
            //
            try
            {
                MyException ex = new MyException("My exception!!!");
                throw ex;
            }
            catch(MyException ex)
            {
                this.listBox1.Items.Add($"Exception: {ex.Message}");
                this.listBox1.Items.Add(string.Empty);
            }
            this.listBox1.Items.Add($"Day (Number) = {(int)DayOfWeek.Friday}");
            this.listBox1.Items.Add(string.Empty);
            //
            this.listBox1.Items.Add($"Day (Name) = {DayOfWeek.Friday}");
            //this.textBox1.Text = DayOfWeek.Friday.ToString();
            this.listBox1.Items.Add(string.Empty);
        }
    }
}
