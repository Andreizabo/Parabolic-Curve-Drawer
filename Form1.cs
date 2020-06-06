/// Type: dewsen.Form1
/// Assembly: dewsen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null, Configuration=x86, .Net Framework=4.5.2
/// MVID: 2643EC53-56EA-439A-A5FC-99806218DD4A

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace dewsen
{
  public class Form1 : Form
  {
    public int size = 1000;
    public int prec = 10;
    public int a = 10;
    public int b = 10;
    public int opt = 1;
    public int rd = 0;
    private Random rnd = new Random();
    public int cgd = 0;
    private IContainer components = (IContainer) null;
    private Button button2;
    public ColorDialog colorDialog1;
    private Button button3;
    public TextBox textBox2;
    public Button button1;
    private Button button4;
    public TextBox textBox3;
    private Button button5;
    private TableLayoutPanel tableLayoutPanel1;
    private Button button7;
    private Button button6;
    private TextBox textBox1;
    private TextBox textBox4;
    private Button button8;
    private TextBox textBox5;
    private Button button9;
    private TextBox textBox6;
    private Button button10;
    private TextBox textBox7;
    private Button button11;
    private TextBox textBox8;
    private Button button12;
    private TextBox textBox9;
    private Button button13;
    private Button button14;
    private Button button15;
    private Button button16;
    private Button button17;
    private TextBox textBox10;
    private TextBox textBox11;
    private Button button18;
    private Button button19;
    private TextBox textBox12;
    private ToolTip toolTip1;
    private Button button20;
    private TextBox textBox13;
    private Button button27;
    private Button button26;
    private Button button25;
    private Button button24;
    private Button button23;
    private Button button22;
    private Button button21;
    private Button button28;
    private Button button29;
    private Button button36;
    private Button button37;
    private Button button33;
    private Button button34;
    private Button button35;
    private Button button31;
    private Button button32;
    private CheckBox checkBox1;
    private SaveFileDialog saveFileDialog1;
    private RadioButton tr;
    private RadioButton pt;
    private GroupBox groupBox1;
    private GroupBox savebox;
    private Button button30;
    private TextBox textBox15;
    private TextBox textBox14;
    private TextBox textBox16;
    private Button button38;
    private Timer timer1;

    public Form1()
    {
      this.InitializeComponent();
    }

    public void button2_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBox2.BackColor = this.colorDialog1.Color;
    }

    public void button1_Click(object sender, EventArgs e)
    {
      this.cgd = 1;
      if (this.pt.Checked)
      {
        if (this.opt == 1)
        {
          this.size = 1000;
          if (this.prec <= 1)
            this.prec = 2;
          Graphics graphics = this.CreateGraphics();
          Brush brush1 = (Brush) new SolidBrush(this.BackColor);
          Pen pen1 = new Pen(brush1, 1f);
          graphics.FillRectangle(brush1, new Rectangle(this.a, this.b, 1010, 1010));
          Brush brush2 = (Brush) new SolidBrush(this.textBox3.BackColor);
          pen1 = new Pen(brush2, 1f);
          graphics.FillRectangle(brush2, new Rectangle(this.a, this.b, this.size, this.size));
          if (this.rd == 0)
          {
            Pen pen2 = new Pen((Brush) new SolidBrush(this.textBox1.BackColor), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + index, this.b);
              graphics.DrawLine(pen2, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Pen pen3 = new Pen((Brush) new SolidBrush(this.textBox4.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 85; index += this.prec / 2)
            {
              int num = 85;
              graphics.DrawLine(pen3, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen3, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Pen pen4 = new Pen((Brush) new SolidBrush(this.textBox5.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 160; index += this.prec / 2)
            {
              int num = 172;
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Pen pen5 = new Pen((Brush) new SolidBrush(this.textBox6.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 360; index += this.prec / 2)
            {
              int num = 142;
              graphics.DrawLine(pen5, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Pen pen6 = new Pen((Brush) new SolidBrush(this.textBox7.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 380; index += this.prec / 2)
            {
              int num = 60;
              graphics.DrawLine(pen6, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen6, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen6, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen6, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Pen pen7 = new Pen((Brush) new SolidBrush(this.textBox8.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 450; index += this.prec / 2)
            {
              int num = 50;
              graphics.DrawLine(pen7, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen7, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen7, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen7, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Pen pen8 = new Pen((Brush) new SolidBrush(this.textBox9.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 460; index += this.prec / 2)
            {
              int num = 20;
              graphics.DrawLine(pen8, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen8, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen8, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen8, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
          else
          {
            if (this.rd != 1)
              return;
            Color color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color1 == Color.Transparent)
              color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color1), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size, this.b + index, this.a + index, this.b);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Color color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color6 == Color.Transparent)
              color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color6), 1f);
            for (int index = 0; index <= this.size / 2 - 85; index += this.prec / 2)
            {
              int num = 85;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Color color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color7 == Color.Transparent)
              color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color7), 1f);
            for (int index = 0; index <= this.size / 2 - 160; index += this.prec / 2)
            {
              int num = 172;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Color color8 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color8 == Color.Transparent)
              color8 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color8), 1f);
            for (int index = 0; index <= this.size / 2 - 360; index += this.prec / 2)
            {
              int num = 142;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Color color9 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color9 == Color.Transparent)
              color9 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color9), 1f);
            for (int index = 0; index <= this.size / 2 - 380; index += this.prec / 2)
            {
              int num = 60;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Color color10 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color10 == Color.Transparent)
              color10 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color10), 1f);
            for (int index = 0; index <= this.size / 2 - 450; index += this.prec / 2)
            {
              int num = 50;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Color color11 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color11 == Color.Transparent)
              color11 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color11), 1f);
            for (int index = 0; index <= this.size / 2 - 460; index += this.prec / 2)
            {
              int num = 20;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
        }
        else if (this.opt == 2)
        {
          this.size = 750;
          if (this.prec <= 1)
            this.prec = 2;
          Graphics graphics = this.CreateGraphics();
          Brush brush1 = (Brush) new SolidBrush(this.BackColor);
          Pen pen1 = new Pen(brush1, 1f);
          graphics.FillRectangle(brush1, new Rectangle(this.a, this.b, 1010, 1010));
          Brush brush2 = (Brush) new SolidBrush(this.textBox3.BackColor);
          pen1 = new Pen(brush2, 1f);
          graphics.FillRectangle(brush2, new Rectangle(this.a, this.b, this.size, this.size));
          if (this.rd == 0)
          {
            Pen pen2 = new Pen((Brush) new SolidBrush(this.textBox1.BackColor), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + index, this.b);
              graphics.DrawLine(pen2, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Pen pen3 = new Pen((Brush) new SolidBrush(this.textBox4.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 65; index += this.prec / 2)
            {
              int num = 65;
              graphics.DrawLine(pen3, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen3, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Pen pen4 = new Pen((Brush) new SolidBrush(this.textBox5.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 120; index += this.prec / 2)
            {
              int num = 130;
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Pen pen5 = new Pen((Brush) new SolidBrush(this.textBox6.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 270; index += this.prec / 2 + 1)
            {
              int num = 107;
              graphics.DrawLine(pen5, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Pen pen6 = new Pen((Brush) new SolidBrush(this.textBox7.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 290; index += this.prec / 2)
            {
              int num = 44;
              graphics.DrawLine(pen6, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen6, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen6, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen6, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
          else
          {
            if (this.rd != 1)
              return;
            Color color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color1 == Color.Transparent)
              color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color1), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size, this.b + index, this.a + index, this.b);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Color color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color6 == Color.Transparent)
              color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color6), 1f);
            for (int index = 0; index <= this.size / 2 - 65; index += this.prec / 2)
            {
              int num = 65;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Color color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color7 == Color.Transparent)
              color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color7), 1f);
            for (int index = 0; index <= this.size / 2 - 120; index += this.prec / 2)
            {
              int num = 130;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Color color8 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color8 == Color.Transparent)
              color8 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color8), 1f);
            for (int index = 0; index <= this.size / 2 - 270; index += this.prec / 2 + 1)
            {
              int num = 107;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Color color9 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color9 == Color.Transparent)
              color9 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color9), 1f);
            for (int index = 0; index <= this.size / 2 - 290; index += this.prec / 2)
            {
              int num = 44;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
        }
        else if (this.opt == 3)
        {
          this.size = 500;
          if (this.prec <= 1)
            this.prec = 2;
          Graphics graphics = this.CreateGraphics();
          Brush brush1 = (Brush) new SolidBrush(this.BackColor);
          Pen pen1 = new Pen(brush1, 1f);
          graphics.FillRectangle(brush1, new Rectangle(this.a, this.b, 1010, 1010));
          Brush brush2 = (Brush) new SolidBrush(this.textBox3.BackColor);
          pen1 = new Pen(brush2, 1f);
          graphics.FillRectangle(brush2, new Rectangle(this.a, this.b, this.size, this.size));
          if (this.rd == 0)
          {
            Pen pen2 = new Pen((Brush) new SolidBrush(this.textBox1.BackColor), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + index, this.b);
              graphics.DrawLine(pen2, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Pen pen3 = new Pen((Brush) new SolidBrush(this.textBox4.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 45; index += this.prec / 2)
            {
              int num = 44;
              graphics.DrawLine(pen3, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen3, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Pen pen4 = new Pen((Brush) new SolidBrush(this.textBox5.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 85; index += this.prec / 2)
            {
              int num = 85;
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
          else
          {
            if (this.rd != 1)
              return;
            Color color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color1 == Color.Transparent)
              color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color1), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size, this.b + index, this.a + index, this.b);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Color color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color6 == Color.Transparent)
              color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color6), 1f);
            for (int index = 0; index <= this.size / 2 - 45; index += this.prec / 2)
            {
              int num = 44;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Color color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color7 == Color.Transparent)
              color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color7), 1f);
            for (int index = 0; index <= this.size / 2 - 85; index += this.prec / 2)
            {
              int num = 85;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
        }
        else
        {
          if (this.opt != 4)
            return;
          this.size = 100;
          Graphics graphics = this.CreateGraphics();
          Brush brush1 = (Brush) new SolidBrush(this.BackColor);
          Pen pen1 = new Pen(brush1, 1f);
          graphics.FillRectangle(brush1, new Rectangle(this.a, this.b, 1010, 1010));
          Brush brush2 = (Brush) new SolidBrush(this.textBox3.BackColor);
          pen1 = new Pen(brush2, 1f);
          graphics.FillRectangle(brush2, new Rectangle(this.a, this.b, this.size, this.size));
          if (this.rd == 0)
          {
            Pen pen2 = new Pen((Brush) new SolidBrush(this.textBox1.BackColor), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + index, this.b);
              graphics.DrawLine(pen2, this.a, this.b + this.size - index, this.a + index, this.b);
            }
          }
          else if (this.rd == 1)
          {
            Color color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color1 == Color.Transparent)
              color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color1), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size, this.b + index, this.a + index, this.b);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a, this.b + this.size - index, this.a + index, this.b);
            }
          }
        }
      }
      else
      {
        if (!this.tr.Checked)
          return;
        float num1 = (float) Math.Sqrt((double) (this.size * this.size - this.size / 2 * (this.size / 2)));
        float num2 = (float) (Math.Sqrt(3.0) / 2.0);
        Graphics graphics = this.CreateGraphics();
        Brush brush1 = (Brush) new SolidBrush(this.BackColor);
        Pen pen1 = new Pen(brush1, 1f);
        graphics.FillRectangle(brush1, new Rectangle(this.a, this.b, 1010, 1010));
        Brush brush2 = (Brush) new SolidBrush(this.textBox3.BackColor);
        pen1 = new Pen(brush2, 1f);
        graphics.FillRectangle(brush2, new Rectangle(this.a, this.b, this.size, this.size));
        if (this.rd == 0)
        {
          Pen pen2 = new Pen((Brush) new SolidBrush(this.textBox1.BackColor), 1f);
          for (int index = 0; index <= this.size; index += this.prec)
          {
            graphics.DrawLine(pen2, (float) (this.a + index), (float) this.b + num1, (float) (this.a + this.size - index / 2), (float) ((double) this.b + (double) num1 - (double) num2 * (double) index));
            graphics.DrawLine(pen2, (float) (this.a + this.size / 2 - index / 2), (float) this.b + num2 * (float) index, (float) (this.a + this.size - index / 2), (float) ((double) this.b + (double) num1 - (double) num2 * (double) index));
            graphics.DrawLine(pen2, (float) (this.a + this.size / 2 - index / 2), (float) this.b + num2 * (float) index, (float) (this.a + index), (float) this.b + num1);
          }
          if (this.opt < 3)
          {
            Pen pen3 = new Pen((Brush) new SolidBrush(this.textBox4.BackColor), 1f);
            for (int index = 0; index <= this.size / 3; index += this.prec)
            {
              graphics.DrawLine(pen3, (float) (this.a + this.size / 2 - this.size / 6 + index), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0), (float) (this.a + this.size / 2 - index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2));
              graphics.DrawLine(pen3, (float) (this.a + this.size / 2 + index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2), (float) (this.a + this.size / 2 + this.size / 6 - index), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0));
              graphics.DrawLine(pen3, (float) (this.a + this.size / 2 - this.size / 6 + index / 2), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0 + (double) index * (double) num2), (float) (this.a + this.size / 2 + index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2));
            }
          }
        }
        else if (this.rd == 1)
        {
          Color color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
          while (color1 == Color.Transparent)
            color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
          pen1 = new Pen((Brush) new SolidBrush(color1), 1f);
          for (int index = 0; index <= this.size; index += this.prec)
          {
            Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color2 == Color.Transparent)
              color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
            graphics.DrawLine(pen2, (float) (this.a + index), (float) this.b + num1, (float) (this.a + this.size - index / 2), (float) ((double) this.b + (double) num1 - (double) num2 * (double) index));
            Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color3 == Color.Transparent)
              color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
            graphics.DrawLine(pen3, (float) (this.a + this.size / 2 - index / 2), (float) this.b + num2 * (float) index, (float) (this.a + this.size - index / 2), (float) ((double) this.b + (double) num1 - (double) num2 * (double) index));
            Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color4 == Color.Transparent)
              color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
            graphics.DrawLine(pen4, (float) (this.a + this.size / 2 - index / 2), (float) this.b + num2 * (float) index, (float) (this.a + index), (float) this.b + num1);
          }
          if (this.opt < 3)
          {
            pen1 = new Pen((Brush) new SolidBrush(this.textBox4.BackColor), 1f);
            Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color2 == Color.Transparent)
              color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color2), 1f);
            for (int index = 0; index <= this.size / 3; index += this.prec)
            {
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen2, (float) (this.a + this.size / 2 - this.size / 6 + index), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0), (float) (this.a + this.size / 2 - index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2));
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen3, (float) (this.a + this.size / 2 + index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2), (float) (this.a + this.size / 2 + this.size / 6 - index), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0));
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen4, (float) (this.a + this.size / 2 - this.size / 6 + index / 2), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0 + (double) index * (double) num2), (float) (this.a + this.size / 2 + index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2));
            }
          }
        }
      }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    public void textBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.cgd = 0;
      Graphics graphics = this.CreateGraphics();
      Brush brush = (Brush) new SolidBrush(this.BackColor);
      Pen pen = new Pen(brush, 1f);
      graphics.FillRectangle(brush, new Rectangle(this.a, this.b, 1010, 1010));
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBox3.BackColor = this.colorDialog1.Color;
    }

    private void button13_Click(object sender, EventArgs e)
    {
      this.tableLayoutPanel1.Visible = false;
      this.button14.Visible = false;
      this.button15.Visible = false;
      this.button16.Visible = false;
      this.button17.Visible = false;
      this.textBox10.Visible = false;
      this.textBox11.Visible = false;
      this.button18.Visible = false;
      this.checkBox1.Visible = false;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      this.tableLayoutPanel1.Visible = true;
      this.button14.Visible = true;
      this.button15.Visible = true;
      this.button16.Visible = true;
      this.button17.Visible = true;
      this.textBox10.Visible = true;
      this.textBox11.Visible = true;
      this.button18.Visible = true;
      this.checkBox1.Visible = true;
    }

    private void button6_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBox1.BackColor = this.colorDialog1.Color;
    }

    private void button7_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBox4.BackColor = this.colorDialog1.Color;
    }

    private void button8_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBox5.BackColor = this.colorDialog1.Color;
    }

    private void button9_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBox6.BackColor = this.colorDialog1.Color;
    }

    private void button10_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBox7.BackColor = this.colorDialog1.Color;
    }

    private void button11_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBox8.BackColor = this.colorDialog1.Color;
    }

    private void button12_Click(object sender, EventArgs e)
    {
      if (this.colorDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.textBox9.BackColor = this.colorDialog1.Color;
    }

    private void button14_Click(object sender, EventArgs e)
    {
      this.cgd = 0;
      this.opt = 1;
      this.size = 1000;
      this.prec = 10;
      if (this.pt.Checked)
      {
        this.button12.Visible = true;
        this.button11.Visible = true;
        this.button10.Visible = true;
        this.button9.Visible = true;
        this.button8.Visible = true;
        this.button7.Visible = true;
        this.button6.Visible = true;
        this.textBox9.Visible = true;
        this.textBox8.Visible = true;
        this.textBox7.Visible = true;
        this.textBox6.Visible = true;
        this.textBox5.Visible = true;
        this.textBox4.Visible = true;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = true;
        this.button23.Visible = true;
        this.button24.Visible = true;
        this.button25.Visible = true;
        this.button26.Visible = true;
        this.button27.Visible = true;
        this.button31.Visible = true;
        this.button32.Visible = true;
        this.button35.Visible = true;
        this.button34.Visible = true;
        this.button33.Visible = true;
        this.button37.Visible = true;
        this.button36.Visible = true;
      }
      else if (this.tr.Checked)
      {
        this.button7.Visible = true;
        this.button6.Visible = true;
        this.textBox4.Visible = true;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = true;
        this.button31.Visible = true;
        this.button32.Visible = true;
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = false;
        this.button9.Visible = false;
        this.button8.Visible = false;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = false;
        this.textBox6.Visible = false;
        this.textBox5.Visible = false;
        this.button23.Visible = false;
        this.button24.Visible = false;
        this.button25.Visible = false;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button35.Visible = false;
        this.button34.Visible = false;
        this.button33.Visible = false;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
      if (this.prec > 1)
        return;
      this.prec = 2;
    }

    private void button15_Click(object sender, EventArgs e)
    {
      this.cgd = 0;
      this.opt = 2;
      this.size = 750;
      this.prec = 8;
      if (this.pt.Checked)
      {
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = true;
        this.button9.Visible = true;
        this.button8.Visible = true;
        this.button7.Visible = true;
        this.button6.Visible = true;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = true;
        this.textBox6.Visible = true;
        this.textBox5.Visible = true;
        this.textBox4.Visible = true;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = true;
        this.button23.Visible = true;
        this.button24.Visible = true;
        this.button25.Visible = true;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button31.Visible = true;
        this.button32.Visible = true;
        this.button35.Visible = true;
        this.button34.Visible = true;
        this.button33.Visible = true;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
      else if (this.tr.Checked)
      {
        this.button7.Visible = true;
        this.button6.Visible = true;
        this.textBox4.Visible = true;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = true;
        this.button31.Visible = true;
        this.button32.Visible = true;
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = false;
        this.button9.Visible = false;
        this.button8.Visible = false;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = false;
        this.textBox6.Visible = false;
        this.textBox5.Visible = false;
        this.button23.Visible = false;
        this.button24.Visible = false;
        this.button25.Visible = false;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button35.Visible = false;
        this.button34.Visible = false;
        this.button33.Visible = false;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
      if (this.prec > 1)
        return;
      this.prec = 2;
    }

    private void button16_Click(object sender, EventArgs e)
    {
      this.cgd = 0;
      this.opt = 3;
      this.size = 500;
      this.prec = 7;
      if (this.pt.Checked)
      {
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = false;
        this.button9.Visible = false;
        this.button8.Visible = true;
        this.button7.Visible = true;
        this.button6.Visible = true;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = false;
        this.textBox6.Visible = false;
        this.textBox5.Visible = true;
        this.textBox4.Visible = true;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = true;
        this.button23.Visible = true;
        this.button24.Visible = false;
        this.button25.Visible = false;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button31.Visible = true;
        this.button32.Visible = true;
        this.button35.Visible = true;
        this.button34.Visible = false;
        this.button33.Visible = false;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
      else if (this.tr.Checked)
      {
        this.button7.Visible = false;
        this.button6.Visible = true;
        this.textBox4.Visible = false;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = false;
        this.button31.Visible = true;
        this.button32.Visible = false;
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = false;
        this.button9.Visible = false;
        this.button8.Visible = false;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = false;
        this.textBox6.Visible = false;
        this.textBox5.Visible = false;
        this.button23.Visible = false;
        this.button24.Visible = false;
        this.button25.Visible = false;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button35.Visible = false;
        this.button34.Visible = false;
        this.button33.Visible = false;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
      if (this.prec > 1)
        return;
      this.prec = 2;
    }

    private void button17_Click(object sender, EventArgs e)
    {
      this.cgd = 0;
      this.opt = 4;
      this.size = 100;
      this.prec = 5;
      if (this.pt.Checked)
      {
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = false;
        this.button9.Visible = false;
        this.button8.Visible = false;
        this.button7.Visible = false;
        this.button6.Visible = true;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = false;
        this.textBox6.Visible = false;
        this.textBox5.Visible = false;
        this.textBox4.Visible = false;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = false;
        this.button23.Visible = false;
        this.button24.Visible = false;
        this.button25.Visible = false;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button31.Visible = true;
        this.button32.Visible = false;
        this.button35.Visible = false;
        this.button34.Visible = false;
        this.button33.Visible = false;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
      else
      {
        if (!this.tr.Checked)
          return;
        this.button7.Visible = false;
        this.button6.Visible = true;
        this.textBox4.Visible = false;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = false;
        this.button31.Visible = true;
        this.button32.Visible = false;
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = false;
        this.button9.Visible = false;
        this.button8.Visible = false;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = false;
        this.textBox6.Visible = false;
        this.textBox5.Visible = false;
        this.button23.Visible = false;
        this.button24.Visible = false;
        this.button25.Visible = false;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button35.Visible = false;
        this.button34.Visible = false;
        this.button33.Visible = false;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
    }

    private void button18_Click(object sender, EventArgs e)
    {
      if (this.textBox11.Text == "")
      {
        int num = (int) MessageBox.Show("Introdu la precizie un numar mai mare ca 1");
        this.textBox11.BackColor = Color.Red;
      }
      else
      {
        try
        {
          this.prec = Convert.ToInt32(this.textBox11.Text);
          this.cgd = 0;
          this.textBox11.BackColor = Color.White;
        }
        catch
        {
          int num = (int) MessageBox.Show("EROARE");
          this.textBox11.BackColor = Color.Red;
        }
      }
    }

    private void button19_Click(object sender, EventArgs e)
    {
      this.cgd = 0;
      this.prec = 10;
      this.size = 1000;
      this.opt = 1;
      this.textBox11.BackColor = Color.White;
      this.button31.Visible = true;
      this.button32.Visible = true;
      this.button35.Visible = true;
      this.button34.Visible = true;
      this.button33.Visible = true;
      this.button37.Visible = true;
      this.button36.Visible = true;
      this.button24.Visible = true;
      this.button25.Visible = true;
      this.button26.Visible = true;
      this.button27.Visible = true;
      this.button12.Visible = true;
      this.button11.Visible = true;
      this.button10.Visible = true;
      this.checkBox1.Visible = false;
      this.button9.Visible = true;
      this.button8.Visible = true;
      this.button7.Visible = true;
      this.button6.Visible = true;
      this.textBox9.Visible = true;
      this.textBox8.Visible = true;
      this.textBox7.Visible = true;
      this.textBox6.Visible = true;
      this.textBox5.Visible = true;
      this.textBox4.Visible = true;
      this.textBox1.Visible = true;
      this.tableLayoutPanel1.Visible = false;
      this.button14.Visible = false;
      this.button15.Visible = false;
      this.button16.Visible = false;
      this.button17.Visible = false;
      this.textBox10.Visible = false;
      this.textBox11.Visible = false;
      this.button18.Visible = false;
      Graphics graphics = this.CreateGraphics();
      Brush brush = (Brush) new SolidBrush(this.BackColor);
      Pen pen = new Pen(brush, 1f);
      graphics.FillRectangle(brush, new Rectangle(this.a, this.b, 1010, 1010));
      this.textBox1.BackColor = Color.Red;
      this.textBox2.BackColor = Color.Red;
      this.textBox4.BackColor = Color.Red;
      this.textBox5.BackColor = Color.Red;
      this.textBox6.BackColor = Color.Red;
      this.textBox7.BackColor = Color.Red;
      this.textBox8.BackColor = Color.Red;
      this.textBox9.BackColor = Color.Red;
      this.textBox3.BackColor = this.BackColor;
      if (this.checkBox1.Checked)
        this.checkBox1.Checked = false;
      this.tr.Checked = false;
      this.pt.Checked = true;
    }

    private void button14_MouseHover(object sender, EventArgs e)
    {
    }

    private void toolTip1_Popup(object sender, PopupEventArgs e)
    {
    }

    private void button20_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show(" Deseneaza- deseneaza figura \n Sterge- sterge figura \n Colare linii- stabileste culoare liniilor \n Colare fundal- stabileste culoare fundalului \n In setarile avansate poti seta o culoare pentru fiecare subfigura in parte, poti seta una dintre cele 4 marimi sau poti modifica precizia \n Precizia se refera la cat de multe linii sunt, cu cat mai mica cu atat mai multe linii \n Preciziile sub 5 pot face programul sa mearga greu \n Preciziile prea mari nu sunt recomandate \n Reset- reseteaza marimea la 1000x1000, precizia la 10, culoarea liniilor la rosu si fundalul la cel initlal");
    }

    private void button21_Click(object sender, EventArgs e)
    {
      this.textBox1.BackColor = this.textBox3.BackColor;
    }

    private void button22_Click(object sender, EventArgs e)
    {
      this.textBox4.BackColor = this.textBox3.BackColor;
    }

    private void button23_Click(object sender, EventArgs e)
    {
      this.textBox5.BackColor = this.textBox3.BackColor;
    }

    private void button24_Click(object sender, EventArgs e)
    {
      this.textBox6.BackColor = this.textBox3.BackColor;
    }

    private void button25_Click(object sender, EventArgs e)
    {
      this.textBox7.BackColor = this.textBox3.BackColor;
    }

    private void button26_Click(object sender, EventArgs e)
    {
      this.textBox8.BackColor = this.textBox3.BackColor;
    }

    private void button27_Click(object sender, EventArgs e)
    {
      this.textBox9.BackColor = this.textBox3.BackColor;
    }

    private void button28_Click(object sender, EventArgs e)
    {
      Color color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      while (color == Color.Transparent)
        color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      this.textBox2.BackColor = color;
    }

    private void button29_Click(object sender, EventArgs e)
    {
      Color color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      while (color == Color.Transparent)
        color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      this.textBox3.BackColor = color;
    }

    private void textBox2_BackColorChanged(object sender, EventArgs e)
    {
      this.cgd = 0;
      this.textBox1.BackColor = this.textBox2.BackColor;
      this.textBox4.BackColor = this.textBox2.BackColor;
      this.textBox5.BackColor = this.textBox2.BackColor;
      this.textBox6.BackColor = this.textBox2.BackColor;
      this.textBox7.BackColor = this.textBox2.BackColor;
      this.textBox8.BackColor = this.textBox2.BackColor;
      this.textBox9.BackColor = this.textBox2.BackColor;
    }

    private void button31_Click(object sender, EventArgs e)
    {
      Color color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      while (color == Color.Transparent)
        color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      this.textBox1.BackColor = color;
    }

    private void button32_Click(object sender, EventArgs e)
    {
      Color color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      while (color == Color.Transparent)
        color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      this.textBox4.BackColor = color;
    }

    private void button35_Click(object sender, EventArgs e)
    {
      Color color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      while (color == Color.Transparent)
        color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      this.textBox5.BackColor = color;
    }

    private void button34_Click(object sender, EventArgs e)
    {
      Color color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      while (color == Color.Transparent)
        color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      this.textBox6.BackColor = color;
    }

    private void button33_Click(object sender, EventArgs e)
    {
      Color color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      while (color == Color.Transparent)
        color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      this.textBox7.BackColor = color;
    }

    private void button37_Click(object sender, EventArgs e)
    {
      Color color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      while (color == Color.Transparent)
        color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      this.textBox8.BackColor = color;
    }

    private void button36_Click(object sender, EventArgs e)
    {
      Color color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      while (color == Color.Transparent)
        color = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
      this.textBox9.BackColor = color;
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (this.rd == 0)
      {
        ++this.rd;
        this.textBox3.BackColor = this.BackColor;
        this.textBox2.BackColor = this.BackColor;
      }
      else
      {
        --this.rd;
        this.textBox2.BackColor = Color.Red;
        this.textBox3.BackColor = this.BackColor;
      }
    }

    private void button30_Click(object sender, EventArgs e)
    {
    }

    private void button30_Click_1(object sender, EventArgs e)
    {
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
      this.cgd = 0;
      if (!this.pt.Checked)
        return;
      if (this.opt == 1)
      {
        this.button12.Visible = true;
        this.button11.Visible = true;
        this.button10.Visible = true;
        this.button9.Visible = true;
        this.button8.Visible = true;
        this.button7.Visible = true;
        this.button6.Visible = true;
        this.textBox9.Visible = true;
        this.textBox8.Visible = true;
        this.textBox7.Visible = true;
        this.textBox6.Visible = true;
        this.textBox5.Visible = true;
        this.textBox4.Visible = true;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = true;
        this.button23.Visible = true;
        this.button24.Visible = true;
        this.button25.Visible = true;
        this.button26.Visible = true;
        this.button27.Visible = true;
        this.button31.Visible = true;
        this.button32.Visible = true;
        this.button35.Visible = true;
        this.button34.Visible = true;
        this.button33.Visible = true;
        this.button37.Visible = true;
        this.button36.Visible = true;
      }
      else if (this.opt == 2)
      {
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = true;
        this.button9.Visible = true;
        this.button8.Visible = true;
        this.button7.Visible = true;
        this.button6.Visible = true;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = true;
        this.textBox6.Visible = true;
        this.textBox5.Visible = true;
        this.textBox4.Visible = true;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = true;
        this.button23.Visible = true;
        this.button24.Visible = true;
        this.button25.Visible = true;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button31.Visible = true;
        this.button32.Visible = true;
        this.button35.Visible = true;
        this.button34.Visible = true;
        this.button33.Visible = true;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
      else if (this.opt == 3)
      {
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = false;
        this.button9.Visible = false;
        this.button8.Visible = true;
        this.button7.Visible = true;
        this.button6.Visible = true;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = false;
        this.textBox6.Visible = false;
        this.textBox5.Visible = true;
        this.textBox4.Visible = true;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = true;
        this.button23.Visible = true;
        this.button24.Visible = false;
        this.button25.Visible = false;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button31.Visible = true;
        this.button32.Visible = true;
        this.button35.Visible = true;
        this.button34.Visible = false;
        this.button33.Visible = false;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
      else if (this.opt == 4)
      {
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = false;
        this.button9.Visible = false;
        this.button8.Visible = false;
        this.button7.Visible = false;
        this.button6.Visible = true;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = false;
        this.textBox6.Visible = false;
        this.textBox5.Visible = false;
        this.textBox4.Visible = false;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = false;
        this.button23.Visible = false;
        this.button24.Visible = false;
        this.button25.Visible = false;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button31.Visible = true;
        this.button32.Visible = false;
        this.button35.Visible = false;
        this.button34.Visible = false;
        this.button33.Visible = false;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
      this.cgd = 0;
      if (!this.tr.Checked)
        return;
      if (this.opt < 3)
      {
        this.button7.Visible = true;
        this.button6.Visible = true;
        this.textBox4.Visible = true;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = true;
        this.button31.Visible = true;
        this.button32.Visible = true;
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = false;
        this.button9.Visible = false;
        this.button8.Visible = false;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = false;
        this.textBox6.Visible = false;
        this.textBox5.Visible = false;
        this.button23.Visible = false;
        this.button24.Visible = false;
        this.button25.Visible = false;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button35.Visible = false;
        this.button34.Visible = false;
        this.button33.Visible = false;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
      else if (this.opt > 2)
      {
        this.button7.Visible = false;
        this.button6.Visible = true;
        this.textBox4.Visible = false;
        this.textBox1.Visible = true;
        this.button21.Visible = true;
        this.button22.Visible = false;
        this.button31.Visible = true;
        this.button32.Visible = false;
        this.button12.Visible = false;
        this.button11.Visible = false;
        this.button10.Visible = false;
        this.button9.Visible = false;
        this.button8.Visible = false;
        this.textBox9.Visible = false;
        this.textBox8.Visible = false;
        this.textBox7.Visible = false;
        this.textBox6.Visible = false;
        this.textBox5.Visible = false;
        this.button23.Visible = false;
        this.button24.Visible = false;
        this.button25.Visible = false;
        this.button26.Visible = false;
        this.button27.Visible = false;
        this.button35.Visible = false;
        this.button34.Visible = false;
        this.button33.Visible = false;
        this.button37.Visible = false;
        this.button36.Visible = false;
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void button30_Click_2(object sender, EventArgs e)
    {
      if (this.cgd == 0)
      {
        this.button1.PerformClick();
        this.cgd = 1;
      }
      if (this.pt.Checked)
      {
        if (this.opt == 1)
        {
          this.size = 1000;
          if (this.prec <= 1)
            this.prec = 2;
          Bitmap bitmap = new Bitmap(this.a + this.size, this.b + this.size);
          Graphics graphics = Graphics.FromImage((Image) bitmap);
          try
          {
            bitmap.Save(this.textBox15.Text + ".jpg");
            this.textBox15.BackColor = this.BackColor;
          }
          catch
          {
            int num = (int) MessageBox.Show("Numele nu este bun, incearca alt nume. \n Nu folosi caractere speciale.");
            this.textBox15.BackColor = Color.Red;
            return;
          }
          Brush brush1 = (Brush) new SolidBrush(this.BackColor);
          Pen pen1 = new Pen(brush1, 1f);
          graphics.FillRectangle(brush1, new Rectangle(this.a, this.b, 1010, 1010));
          Brush brush2 = (Brush) new SolidBrush(this.textBox3.BackColor);
          pen1 = new Pen(brush2, 1f);
          graphics.FillRectangle(brush2, new Rectangle(this.a, this.b, this.size, this.size));
          if (this.rd == 0)
          {
            Pen pen2 = new Pen((Brush) new SolidBrush(this.textBox1.BackColor), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + index, this.b);
              graphics.DrawLine(pen2, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Pen pen3 = new Pen((Brush) new SolidBrush(this.textBox4.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 85; index += this.prec / 2)
            {
              int num = 85;
              graphics.DrawLine(pen3, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen3, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Pen pen4 = new Pen((Brush) new SolidBrush(this.textBox5.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 160; index += this.prec / 2)
            {
              int num = 172;
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Pen pen5 = new Pen((Brush) new SolidBrush(this.textBox6.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 360; index += this.prec / 2)
            {
              int num = 142;
              graphics.DrawLine(pen5, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Pen pen6 = new Pen((Brush) new SolidBrush(this.textBox7.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 380; index += this.prec / 2)
            {
              int num = 60;
              graphics.DrawLine(pen6, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen6, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen6, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen6, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Pen pen7 = new Pen((Brush) new SolidBrush(this.textBox8.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 450; index += this.prec / 2)
            {
              int num = 50;
              graphics.DrawLine(pen7, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen7, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen7, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen7, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Pen pen8 = new Pen((Brush) new SolidBrush(this.textBox9.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 460; index += this.prec / 2)
            {
              int num = 20;
              graphics.DrawLine(pen8, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen8, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen8, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen8, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
          else if (this.rd == 1)
          {
            Color color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color1 == Color.Transparent)
              color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color1), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size, this.b + index, this.a + index, this.b);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Color color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color6 == Color.Transparent)
              color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color6), 1f);
            for (int index = 0; index <= this.size / 2 - 85; index += this.prec / 2)
            {
              int num = 85;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Color color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color7 == Color.Transparent)
              color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color7), 1f);
            for (int index = 0; index <= this.size / 2 - 160; index += this.prec / 2)
            {
              int num = 172;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Color color8 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color8 == Color.Transparent)
              color8 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color8), 1f);
            for (int index = 0; index <= this.size / 2 - 360; index += this.prec / 2)
            {
              int num = 142;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Color color9 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color9 == Color.Transparent)
              color9 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color9), 1f);
            for (int index = 0; index <= this.size / 2 - 380; index += this.prec / 2)
            {
              int num = 60;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Color color10 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color10 == Color.Transparent)
              color10 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color10), 1f);
            for (int index = 0; index <= this.size / 2 - 450; index += this.prec / 2)
            {
              int num = 50;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Color color11 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color11 == Color.Transparent)
              color11 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color11), 1f);
            for (int index = 0; index <= this.size / 2 - 460; index += this.prec / 2)
            {
              int num = 20;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
          try
          {
            bitmap.Save(this.textBox15.Text + ".jpg");
            int num = (int) MessageBox.Show("Succes");
            this.textBox15.BackColor = this.BackColor;
          }
          catch
          {
            int num = (int) MessageBox.Show("Salvare esuata, incearca alt nume. \n Nu folosi caractere speciale.");
            this.textBox15.BackColor = Color.Red;
          }
        }
        else if (this.opt == 2)
        {
          this.size = 750;
          if (this.prec <= 1)
            this.prec = 2;
          Bitmap bitmap = new Bitmap(this.a + this.size, this.b + this.size);
          Graphics graphics = Graphics.FromImage((Image) bitmap);
          try
          {
            bitmap.Save(this.textBox15.Text + ".jpg");
            this.textBox15.BackColor = this.BackColor;
          }
          catch
          {
            int num = (int) MessageBox.Show("Numele nu este bun, incearca alt nume. \n Nu folosi caractere speciale.");
            this.textBox15.BackColor = Color.Red;
            return;
          }
          Brush brush1 = (Brush) new SolidBrush(this.BackColor);
          Pen pen1 = new Pen(brush1, 1f);
          graphics.FillRectangle(brush1, new Rectangle(this.a, this.b, 1010, 1010));
          Brush brush2 = (Brush) new SolidBrush(this.textBox3.BackColor);
          pen1 = new Pen(brush2, 1f);
          graphics.FillRectangle(brush2, new Rectangle(this.a, this.b, this.size, this.size));
          if (this.rd == 0)
          {
            Pen pen2 = new Pen((Brush) new SolidBrush(this.textBox1.BackColor), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + index, this.b);
              graphics.DrawLine(pen2, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Pen pen3 = new Pen((Brush) new SolidBrush(this.textBox4.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 65; index += this.prec / 2)
            {
              int num = 65;
              graphics.DrawLine(pen3, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen3, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Pen pen4 = new Pen((Brush) new SolidBrush(this.textBox5.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 120; index += this.prec / 2)
            {
              int num = 130;
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Pen pen5 = new Pen((Brush) new SolidBrush(this.textBox6.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 270; index += this.prec / 2 + 1)
            {
              int num = 107;
              graphics.DrawLine(pen5, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Pen pen6 = new Pen((Brush) new SolidBrush(this.textBox7.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 290; index += this.prec / 2)
            {
              int num = 44;
              graphics.DrawLine(pen6, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen6, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen6, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen6, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
          else if (this.rd == 1)
          {
            Color color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color1 == Color.Transparent)
              color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color1), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size, this.b + index, this.a + index, this.b);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Color color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color6 == Color.Transparent)
              color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color6), 1f);
            for (int index = 0; index <= this.size / 2 - 65; index += this.prec / 2)
            {
              int num = 65;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Color color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color7 == Color.Transparent)
              color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color7), 1f);
            for (int index = 0; index <= this.size / 2 - 120; index += this.prec / 2)
            {
              int num = 130;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
            Color color8 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color8 == Color.Transparent)
              color8 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color8), 1f);
            for (int index = 0; index <= this.size / 2 - 270; index += this.prec / 2 + 1)
            {
              int num = 107;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + this.size / 2 - num + index, this.a + this.size / 2 - num + index, this.b + this.size / 2 + index);
            }
            Color color9 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color9 == Color.Transparent)
              color9 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color9), 1f);
            for (int index = 0; index <= this.size / 2 - 290; index += this.prec / 2)
            {
              int num = 44;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
          try
          {
            bitmap.Save(this.textBox15.Text + ".jpg");
            int num = (int) MessageBox.Show("Succes");
            this.textBox15.BackColor = this.BackColor;
          }
          catch
          {
            int num = (int) MessageBox.Show("Salvare esuata, incearca alt nume. \n Nu folosi caractere speciale.");
            this.textBox15.BackColor = Color.Red;
          }
        }
        else if (this.opt == 3)
        {
          this.size = 500;
          if (this.prec <= 1)
            this.prec = 2;
          Bitmap bitmap = new Bitmap(this.a + this.size, this.b + this.size);
          Graphics graphics = Graphics.FromImage((Image) bitmap);
          try
          {
            bitmap.Save(this.textBox15.Text + ".jpg");
            this.textBox15.BackColor = this.BackColor;
          }
          catch
          {
            int num = (int) MessageBox.Show("Numele nu este bun, incearca alt nume. \n Nu folosi caractere speciale.");
            this.textBox15.BackColor = Color.Red;
            return;
          }
          Brush brush1 = (Brush) new SolidBrush(this.BackColor);
          Pen pen1 = new Pen(brush1, 1f);
          graphics.FillRectangle(brush1, new Rectangle(this.a, this.b, 1010, 1010));
          Brush brush2 = (Brush) new SolidBrush(this.textBox3.BackColor);
          pen1 = new Pen(brush2, 1f);
          graphics.FillRectangle(brush2, new Rectangle(this.a, this.b, this.size, this.size));
          if (this.rd == 0)
          {
            Pen pen2 = new Pen((Brush) new SolidBrush(this.textBox1.BackColor), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + index, this.b);
              graphics.DrawLine(pen2, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Pen pen3 = new Pen((Brush) new SolidBrush(this.textBox4.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 45; index += this.prec / 2)
            {
              int num = 44;
              graphics.DrawLine(pen3, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              graphics.DrawLine(pen3, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Pen pen4 = new Pen((Brush) new SolidBrush(this.textBox5.BackColor), 1f);
            for (int index = 0; index <= this.size / 2 - 85; index += this.prec / 2)
            {
              int num = 85;
              graphics.DrawLine(pen4, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              graphics.DrawLine(pen4, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
          else if (this.rd == 1)
          {
            Color color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color1 == Color.Transparent)
              color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color1), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size, this.b + index, this.a + index, this.b);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a, this.b + this.size - index, this.a + index, this.b);
            }
            Color color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color6 == Color.Transparent)
              color6 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color6), 1f);
            for (int index = 0; index <= this.size / 2 - 45; index += this.prec / 2)
            {
              int num = 44;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 + index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 - index, this.b + num + index, this.a + this.size - num - index, this.b + this.size / 2 - index);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + num + index, this.b + this.size / 2 + index, this.a + this.size / 2 + index, this.b + this.size - num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - index, this.b + num + index, this.a + num + index, this.b + this.size / 2 + index);
            }
            Color color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color7 == Color.Transparent)
              color7 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color7), 1f);
            for (int index = 0; index <= this.size / 2 - 85; index += this.prec / 2)
            {
              int num = 85;
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size / 2 + num, this.b + this.size / 2 - num + index, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size / 2 + num - index, this.b + this.size / 2 + num, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a + this.size / 2 - num, this.b + this.size / 2 + num - index, this.a + this.size / 2 - num + index, this.b + this.size / 2 - num);
            }
          }
          try
          {
            bitmap.Save(this.textBox15.Text + ".jpg");
            int num = (int) MessageBox.Show("Succes");
            this.textBox15.BackColor = this.BackColor;
          }
          catch
          {
            int num = (int) MessageBox.Show("Salvare esuata, incearca alt nume. \n Nu folosi caractere speciale.");
            this.textBox15.BackColor = Color.Red;
          }
        }
        else
        {
          if (this.opt != 4)
            return;
          this.size = 100;
          Bitmap bitmap = new Bitmap(this.a + this.size, this.b + this.size);
          Graphics graphics = Graphics.FromImage((Image) bitmap);
          try
          {
            bitmap.Save(this.textBox15.Text + ".jpg");
            this.textBox15.BackColor = this.BackColor;
          }
          catch
          {
            int num = (int) MessageBox.Show("Numele nu este bun, incearca alt nume. \n Nu folosi caractere speciale.");
            this.textBox15.BackColor = Color.Red;
            return;
          }
          Brush brush1 = (Brush) new SolidBrush(this.BackColor);
          Pen pen1 = new Pen(brush1, 1f);
          graphics.FillRectangle(brush1, new Rectangle(this.a, this.b, 1010, 1010));
          Brush brush2 = (Brush) new SolidBrush(this.textBox3.BackColor);
          pen1 = new Pen(brush2, 1f);
          graphics.FillRectangle(brush2, new Rectangle(this.a, this.b, this.size, this.size));
          if (this.rd == 0)
          {
            Pen pen2 = new Pen((Brush) new SolidBrush(this.textBox1.BackColor), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              graphics.DrawLine(pen2, this.a + this.size, this.b + index, this.a + index, this.b);
              graphics.DrawLine(pen2, this.a, this.b + this.size - index, this.a + index, this.b);
            }
          }
          else if (this.rd == 1)
          {
            Color color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color1 == Color.Transparent)
              color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color1), 1f);
            for (int index = 0; index <= this.size; index += this.prec)
            {
              Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color2 == Color.Transparent)
                color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
              graphics.DrawLine(pen2, this.a, this.b + index, this.a + index, this.b + this.size);
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen3, this.a + this.size, this.b + index, this.a + this.size - index, this.b + this.size);
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen4, this.a + this.size, this.b + index, this.a + index, this.b);
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen5 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen5, this.a, this.b + this.size - index, this.a + index, this.b);
            }
          }
          try
          {
            bitmap.Save(this.textBox15.Text + ".jpg");
            int num = (int) MessageBox.Show("Succes");
            this.textBox15.BackColor = this.BackColor;
          }
          catch
          {
            int num = (int) MessageBox.Show("Salvare esuata, incearca alt nume. \n Nu folosi caractere speciale.");
            this.textBox15.BackColor = Color.Red;
          }
        }
      }
      else
      {
        if (!this.tr.Checked)
          return;
        float num1 = (float) Math.Sqrt((double) (this.size * this.size - this.size / 2 * (this.size / 2)));
        float num2 = (float) (Math.Sqrt(3.0) / 2.0);
        Bitmap bitmap = new Bitmap(this.a + this.size, this.b + this.size);
        try
        {
          bitmap.Save(this.textBox15.Text + ".jpg");
          this.textBox15.BackColor = this.BackColor;
        }
        catch
        {
          int num3 = (int) MessageBox.Show("Numele nu este bun, incearca alt nume. \n Nu folosi caractere speciale.");
          this.textBox15.BackColor = Color.Red;
          return;
        }
        Graphics graphics = Graphics.FromImage((Image) bitmap);
        Brush brush1 = (Brush) new SolidBrush(this.BackColor);
        Pen pen1 = new Pen(brush1, 1f);
        graphics.FillRectangle(brush1, new Rectangle(this.a, this.b, 1010, 1010));
        Brush brush2 = (Brush) new SolidBrush(this.textBox3.BackColor);
        pen1 = new Pen(brush2, 1f);
        graphics.FillRectangle(brush2, new Rectangle(this.a, this.b, this.size, this.size));
        if (this.rd == 0)
        {
          Pen pen2 = new Pen((Brush) new SolidBrush(this.textBox1.BackColor), 1f);
          for (int index = 0; index <= this.size; index += this.prec)
          {
            graphics.DrawLine(pen2, (float) (this.a + index), (float) this.b + num1, (float) (this.a + this.size - index / 2), (float) ((double) this.b + (double) num1 - (double) num2 * (double) index));
            graphics.DrawLine(pen2, (float) (this.a + this.size / 2 - index / 2), (float) this.b + num2 * (float) index, (float) (this.a + this.size - index / 2), (float) ((double) this.b + (double) num1 - (double) num2 * (double) index));
            graphics.DrawLine(pen2, (float) (this.a + this.size / 2 - index / 2), (float) this.b + num2 * (float) index, (float) (this.a + index), (float) this.b + num1);
          }
          if (this.opt < 3)
          {
            Pen pen3 = new Pen((Brush) new SolidBrush(this.textBox4.BackColor), 1f);
            for (int index = 0; index <= this.size / 3; index += this.prec)
            {
              graphics.DrawLine(pen3, (float) (this.a + this.size / 2 - this.size / 6 + index), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0), (float) (this.a + this.size / 2 - index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2));
              graphics.DrawLine(pen3, (float) (this.a + this.size / 2 + index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2), (float) (this.a + this.size / 2 + this.size / 6 - index), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0));
              graphics.DrawLine(pen3, (float) (this.a + this.size / 2 - this.size / 6 + index / 2), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0 + (double) index * (double) num2), (float) (this.a + this.size / 2 + index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2));
            }
          }
        }
        else if (this.rd == 1)
        {
          Color color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
          while (color1 == Color.Transparent)
            color1 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
          pen1 = new Pen((Brush) new SolidBrush(color1), 1f);
          for (int index = 0; index <= this.size; index += this.prec)
          {
            Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color2 == Color.Transparent)
              color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            Pen pen2 = new Pen((Brush) new SolidBrush(color2), 1f);
            graphics.DrawLine(pen2, (float) (this.a + index), (float) this.b + num1, (float) (this.a + this.size - index / 2), (float) ((double) this.b + (double) num1 - (double) num2 * (double) index));
            Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color3 == Color.Transparent)
              color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            Pen pen3 = new Pen((Brush) new SolidBrush(color3), 1f);
            graphics.DrawLine(pen3, (float) (this.a + this.size / 2 - index / 2), (float) this.b + num2 * (float) index, (float) (this.a + this.size - index / 2), (float) ((double) this.b + (double) num1 - (double) num2 * (double) index));
            Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color4 == Color.Transparent)
              color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            Pen pen4 = new Pen((Brush) new SolidBrush(color4), 1f);
            graphics.DrawLine(pen4, (float) (this.a + this.size / 2 - index / 2), (float) this.b + num2 * (float) index, (float) (this.a + index), (float) this.b + num1);
          }
          if (this.opt < 3)
          {
            pen1 = new Pen((Brush) new SolidBrush(this.textBox4.BackColor), 1f);
            Color color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            while (color2 == Color.Transparent)
              color2 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
            pen1 = new Pen((Brush) new SolidBrush(color2), 1f);
            for (int index = 0; index <= this.size / 3; index += this.prec)
            {
              Color color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color3 == Color.Transparent)
                color3 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen2 = new Pen((Brush) new SolidBrush(color3), 1f);
              graphics.DrawLine(pen2, (float) (this.a + this.size / 2 - this.size / 6 + index), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0), (float) (this.a + this.size / 2 - index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2));
              Color color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color4 == Color.Transparent)
                color4 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen3 = new Pen((Brush) new SolidBrush(color4), 1f);
              graphics.DrawLine(pen3, (float) (this.a + this.size / 2 + index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2), (float) (this.a + this.size / 2 + this.size / 6 - index), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0));
              Color color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              while (color5 == Color.Transparent)
                color5 = Color.FromArgb(this.rnd.Next(256), this.rnd.Next(256), this.rnd.Next(256));
              Pen pen4 = new Pen((Brush) new SolidBrush(color5), 1f);
              graphics.DrawLine(pen4, (float) (this.a + this.size / 2 - this.size / 6 + index / 2), (float) ((double) (this.b + this.size / 2) - (double) (this.size / 50) * (double) num2 - 1.0 + (double) index * (double) num2), (float) (this.a + this.size / 2 + index / 2), (float) ((double) this.b + (double) num1 - (double) (this.size / 10) + 3.0 - (double) index * (double) num2));
            }
          }
        }
        try
        {
          bitmap.Save(this.textBox15.Text + ".jpg");
          int num3 = (int) MessageBox.Show("Succes");
          this.textBox15.BackColor = this.BackColor;
        }
        catch
        {
          int num3 = (int) MessageBox.Show("Salvare esuata, incearca alt nume. \n Nu folosi caractere speciale.");
          this.textBox15.BackColor = Color.Red;
        }
      }
    }

    private void button38_Click(object sender, EventArgs e)
    {
      int num = (int) MessageBox.Show("Fisierele cu acelasi nume se vor suprapune.");
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
    }

    private void progressBar1_Click(object sender, EventArgs e)
    {
    }

    private void textBox3_BackColorChanged(object sender, EventArgs e)
    {
      this.cgd = 0;
    }

    private void textBox1_BackColorChanged(object sender, EventArgs e)
    {
      this.cgd = 0;
    }

    private void textBox4_BackColorChanged(object sender, EventArgs e)
    {
      this.cgd = 0;
    }

    private void textBox5_BackColorChanged(object sender, EventArgs e)
    {
      this.cgd = 0;
    }

    private void textBox6_BackColorChanged(object sender, EventArgs e)
    {
      this.cgd = 0;
    }

    private void textBox7_BackColorChanged(object sender, EventArgs e)
    {
      this.cgd = 0;
    }

    private void textBox8_BackColorChanged(object sender, EventArgs e)
    {
      this.cgd = 0;
    }

    private void textBox9_BackColorChanged(object sender, EventArgs e)
    {
      this.cgd = 0;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(549, 443);
            this.Name = "Form1";
            this.ResumeLayout(false);

    }
  }
}
