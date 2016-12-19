using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ncvplugin
{
    public partial class Form1 : Form
    {
       // public event EventHandler<EventArgs> ButtonClicked;

        public event EventHandler<EventArgs> ButtonClicked;
        public event EventHandler<EventArgs> ButtonClicked2;
        public event EventHandler<EventArgs> ButtonClicked3;
        public event EventHandler<EventArgs> ButtonClicked4;
        public event EventHandler<EventArgs> ButtonClicked5;
        public event EventHandler<EventArgs> ButtonClicked6;
        public event EventHandler<EventArgs> ButtonClicked7;
        public event EventHandler<EventArgs> ButtonClicked8;
        public event EventHandler<EventArgs> ButtonClicked9;
        public event EventHandler<EventArgs> ButtonClicked10;
        public event EventHandler<EventArgs> ButtonClicked11;
        public event EventHandler<EventArgs> ButtonClicked12;
       // public event EventHandler<EventArgs> ButtonClicked13;
        public int formcloseflag = 0;
        public Form1()
        {
            InitializeComponent();
            formcloseflag = 0;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。イベントハンドラはclass1.csに書いてある
            if (ButtonClicked != null) ButtonClicked(this, e);   
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            //this.textBox1.Text = "";
        }

        public TextBox delivertextbox1handle()
        {
            return textBox1;
        }
        public TextBox delivertextbox2handle()
        {
            return textBox2;
        }

        public TextBox delivertextbox3handle()
        {
            return textBox3;
        }

        

        public TextBox delivertextbox4handle()
        {
            return textBox4;
        }
        public TextBox delivertextbox5handle()
        {
            return textBox5;
        }
        public TextBox delivertextbox6handle()
        {
            return textBox6;
        }
        public TextBox delivertextbox7handle()
        {
            return textBox7;
        }
        public TextBox delivertextbox8handle()
        {
            return textBox8;
        }

        public TextBox delivertextbox9handle()
        {
            return textBox9;
        }

        public TextBox delivertextbox10handle()
        {
            return textBox10;
        }

        public TextBox delivertextbox11handle()
        {
            return textBox11;
        }

        public TextBox delivertextbox12handle()
        {
            return textBox12;
        }

        public TextBox delivertextbox13handle()
        {
            return textBox13;
        }


        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Ansi)]
       
      static extern IntPtr LoadImage(IntPtr hinst, string lpszName, uint uType,int cxDesired, int cyDesired, uint fuLoad);
      //  [DllImport("curdll.dll")]
       // private static extern IntPtr GetHCursor();


               // IMAGE_CURSOR 2 LR_DEFAULTCOLOR 0
        private IntPtr hmyCursor;
       
        private void Form1_Load(object sender, EventArgs e)
        {
      //      [DllImport("user32.dll")]

          // System.Reflection.Module[] m = System.Reflection.Assembly.GetExecutingAssembly().GetModules();
           // IntPtr hInstance = Marshal.GetHINSTANCE(m[0]);
            //const int IMAGE_CURSOR = 2;
            //const int LR_LOADFROMFILE = 0x0010;
            //const int LR_DEFAULTSIZE = 0x0040;
            int a;
          //  string stCurrentDir = System.IO.Directory.GetCurrentDirectory();
            string curdir;

            // カレントディレクトリを表示する
            //MessageBox.Show(stCurrentDir);

            //System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetEntryAssembly();
            //string path = myAssembly.Location;

            //MessageBox.Show(path);
            //MessageBox.Show(Application.ExecutablePath);
           // MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory);

            curdir = System.AppDomain.CurrentDomain.BaseDirectory;

            //hmyCursor = LoadImage((IntPtr)0, ".curam2.cur", 2, 0, 0, 0x10);
           hmyCursor = LoadImage((IntPtr)0, curdir+"\\plugins\\curam2.cur", 2, 0, 0, 0x10);
            //hmyCursor = LoadImage(this, "ncvplugin.Properties.curam2", 2, 0, 0, 0);
            a = Marshal.GetLastWin32Error();
            if (hmyCursor == (IntPtr)0) {
                MessageBox.Show("アイコン読めないにょ", a.ToString(), MessageBoxButtons.OK, MessageBoxIcon.None);
            }
              this.Cursor = new Cursor(hmyCursor);
            

          // MessageBox.Show("放送から切断されました","",MessageBoxButtons.OK,MessageBoxIcon.None);
          //  if ((int)GetHCursor() == 0) OutputDebugString("0");
           // Debug.WriteLine("Debug Information-Product Starting ");
            //Cursor.Current = new Cursor(GetHCursor());
            //Cursor.Current = new Cursor(hmyCursor);
      //static extern IntPtr LoadImage(IntPtr hinst, string lpszName, uint uType,int cxDesired, int cyDesired, uint fuLoad);        

　　//System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
 　　//Cursor myCursor = new Cursor(asm.GetManifestResourceStream(asm.GetName().Name + ".curam2.cur"));
　　     //  this.Cursor = myCursor;

            // Assembly Reference
           // System.Reflection.Assembly assembly = System.Reflection.Assembly.GetEntryAssembly();

           // System.IO.Stream stream;
          //  System.IO.StreamReader reader;

          //  stream = assembly.GetManifestResourceStream("ncvplugin.curam2.cur");
           // reader = new System.IO.StreamReader(stream);
           // this.Cursor= new Cursor(reader.BaseStream);

          //  System.Reflection.Assembly.LoadFile("Cursor")
           // PictureBox pictureBox1 = new PictureBox();
           // pictureBox1.Image = ncvplugin.Properties.Resources.curam2;

///////////////////これだと白黒になる
        /*    using (MemoryStream ms = new MemoryStream(ncvplugin.Properties.Resources.curam2))
            {
                this.Cursor = new Cursor(ms);
            }
            */


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            formcloseflag = 1;
            //Cursor.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。
            if (ButtonClicked2 != null) ButtonClicked2(this, e); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。
            if (ButtonClicked3 != null) ButtonClicked3(this, e);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。
            if (ButtonClicked4 != null) ButtonClicked4(this, e);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。
            if (ButtonClicked5 != null) ButtonClicked5(this, e);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。
            if (ButtonClicked6 != null) ButtonClicked6(this, e);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。
            if (ButtonClicked7 != null) ButtonClicked7(this, e);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。
            if (ButtonClicked8 != null) ButtonClicked8(this, e);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。
            if (ButtonClicked9 != null) ButtonClicked9(this, e);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。
            if (ButtonClicked10 != null) ButtonClicked10(this, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。
            if (ButtonClicked11 != null) ButtonClicked11(this, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // nullでないことを確認し、メソッドとして呼び出し。
            if (ButtonClicked12 != null) ButtonClicked12(this, e);
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;

        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.7;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            this.Opacity = 0.5;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.7;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            this.Opacity = 0.9;
        }

        private void このプラグインについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("制作：園児\nver1.00", "このソフトについて", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

       

     

    }
}
