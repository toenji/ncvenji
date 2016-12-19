using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace ncvplugin
{
    public class Class1:Plugin.IPlugin
    {
        #region IPlugin メンバ

        //ホストをもらう変数
        public Plugin.IPluginHost host = null;
       // public int formclosed;
        //フォームの変数
        public Form1 form = null;
        public int connectflag = 0;

       // public Plugin.ReceivedCommentEventArgs forclose;


        public void AutoRun()
        {/// IsAutoRunがtrueの時NCVを実行したときに呼ばれる
           // throw new NotImplementedException();
        }

        public string Description
        {
            //get { throw new NotImplementedException(); }
            get { return "a"; }
        }

        public Plugin.IPluginHost Host
        {
            get
            {
                //throw new NotImplementedException();
                return this.host;

            }
            set
            {
                //throw new NotImplementedException();
                this.host = value;

            }
        }

        public bool IsAutoRun
        { 
            //get { throw new NotImplementedException(); }
            get { return false; }

        }

        public string Name
        {
            //get { throw new NotImplementedException(); }
            get { return "園児専用コメント簡易送信"; }
        }

        public void Run()
        {/// プラグイン実行時に呼ばれる
            //throw new NotImplementedException();
            if (form == null)
            {
                //フォームの生成
                form = new Form1();
                //オーナー設定
                //form.Owner = host.MainForm;
                //TopMostを受け取る
                //form.TopMost = host.MainForm.TopMost;

                //フォームの表示
                form.Show();
                form.FormClosed += new System.Windows.Forms.FormClosedEventHandler(form_FormClosed);
                //接続・切断のイベントを追加す
              //  host.BroadcastConnected += new Plugin.BroadcastConnectedEventHandler(host_BroadcastConnected);
              //  host.BroadcastDisConnected += new Plugin.BroadcastDisConnectedEventHandler(host_BroadcastDisConnected);
                //受信
               // host.ReceivedComment += new Plugin.ReceivedCommentEventHandler(host_ReceivedComment);
               // form.button1.Click += new EventHandler(buttun1click);
              //  form.delivertextboxhandle().Text = "1";
                //イベントハンドラにこのクラスのメソッド割り当て
                form.ButtonClicked += this.buttun1click;
                form.ButtonClicked2 += this.buttun2click;
                form.ButtonClicked3 += this.buttun3click;
                form.ButtonClicked4 += this.buttun4click;
                form.ButtonClicked5 += this.buttun5click;
                form.ButtonClicked6 += this.buttun6click;
                form.ButtonClicked7 += this.buttun7click;
                form.ButtonClicked8 += this.buttun8click;
                form.ButtonClicked9 += this.buttun9click;
                form.ButtonClicked10 += this.buttun10click;
                form.ButtonClicked11 += this.buttun11click;
                form.ButtonClicked12 += this.buttun12click;

               // string text = "";
                string curdir = System.AppDomain.CurrentDomain.BaseDirectory;
                
                try
                {
                    using (StreamReader sr = new StreamReader(
                        curdir+"\\plugins\\enjikome.ini", Encoding.GetEncoding("Shift_JIS")))
                    {

                      //  text = sr.ReadToEnd();
                          form.delivertextbox2handle().Text= sr.ReadLine();
                          form.delivertextbox3handle().Text = sr.ReadLine();
                          form.delivertextbox4handle().Text = sr.ReadLine();
                          form.delivertextbox5handle().Text = sr.ReadLine();
                          form.delivertextbox6handle().Text = sr.ReadLine();
                          form.delivertextbox7handle().Text = sr.ReadLine();
                          form.delivertextbox8handle().Text = sr.ReadLine();
                          form.delivertextbox9handle().Text = sr.ReadLine();
                          form.delivertextbox10handle().Text = sr.ReadLine();
                          form.delivertextbox11handle().Text = sr.ReadLine();
                          form.delivertextbox12handle().Text = sr.ReadLine();
                          form.delivertextbox13handle().Text = sr.ReadLine();
                          
                        
                    }

                    //Console.Write(text);
                   

                }
                catch (Exception)
                {
                    //Console.WriteLine(e.Message);
                    MessageBox.Show("設定ファイルがないにょ\nデフォルトの文字をセットします");
                }
                 
                //接続・切断のイベントを追加す
                host.BroadcastConnected += new Plugin.BroadcastConnectedEventHandler(host_BroadcastConnected);
                host.BroadcastDisConnected += new Plugin.BroadcastDisConnectedEventHandler(host_BroadcastDisConnected);
                
                //受信
                host.ReceivedComment += new Plugin.ReceivedCommentEventHandler(host_ReceivedComment);

                connectflag = 1;
            }
          }
        public void buttun1click(Object sender, EventArgs e)
        {
         //   throw new NotImplementedException();
           // host.SendComment("", "a");
            if (connectflag==1)
            host.SendComment("184", form.delivertextbox2handle().Text);
            else comentprocess("接続されてないにょ");
        }
        public void buttun2click(Object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            // host.SendComment("", "a");
            if (connectflag == 1)
            host.SendComment("184", form.delivertextbox3handle().Text);
            else comentprocess("接続されてないにょ");
        }

        public void buttun3click(Object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            // host.SendComment("", "a");
            if (connectflag == 1)
            host.SendComment("184", form.delivertextbox4handle().Text);
            else comentprocess("接続されてないにょ");
        }

        public void buttun4click(Object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            // host.SendComment("", "a");
            if (connectflag == 1)
            host.SendComment("184", form.delivertextbox5handle().Text);
            else comentprocess("接続されてないにょ");
        }

        public void buttun5click(Object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            // host.SendComment("", "a");
            if (connectflag == 1)
            host.SendComment("184", form.delivertextbox6handle().Text);
            else comentprocess("接続されてないにょ");
        }

        public void buttun6click(Object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            // host.SendComment("", "a");
            if (connectflag == 1)
            host.SendComment("184", form.delivertextbox7handle().Text);
            else comentprocess("接続されてないにょ");
        }

        public void buttun7click(Object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            // host.SendComment("", "a");
            if (connectflag == 1)
            host.SendComment("184", form.delivertextbox8handle().Text);
            else comentprocess("接続されてないにょ");
        }

        public void buttun8click(Object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            // host.SendComment("", "a");
            if (connectflag == 1)
            host.SendComment("184", form.delivertextbox9handle().Text);
            else comentprocess("接続されてないにょ");
        }

        public void buttun9click(Object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            // host.SendComment("", "a");
            if (connectflag == 1)
            host.SendComment("184", form.delivertextbox10handle().Text);
            else comentprocess("接続されてないにょ");
        }

        public void buttun10click(Object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            // host.SendComment("", "a");
            if (connectflag == 1)
            host.SendComment("184", form.delivertextbox11handle().Text);
            else comentprocess("接続されてないにょ");
        }

        public void buttun11click(Object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            // host.SendComment("", "a");
            if (connectflag == 1)
            host.SendComment("184", form.delivertextbox12handle().Text);
            else comentprocess("接続されてないにょ");
        }

        public void buttun12click(Object sender, EventArgs e)
        {
            //   throw new NotImplementedException();
            // host.SendComment("", "a");
            if (connectflag == 1)
            host.SendComment("184", form.delivertextbox13handle().Text);
            else comentprocess("接続されてないにょ");
        }



        void host_ReceivedComment(object sender, Plugin.ReceivedCommentEventArgs e)
        {
            //throw new NotImplementedException();
            //コメントデータリスト数を取り出す
            int count = e.CommentDataList.Count;
           // return;
            //forclose = e;
            connectflag = 1;
            //コメントデータリスト数が0ならreturnして終わり
            if (count == 0)
            {
                return;
            }
            //コメントデータリスト数が1以上ならリストを見る
            else
            {
                for (int RNGcount = 0; count > RNGcount; RNGcount++)
                {
                    //コメントデータを取り出す
                    NicoLibrary.NicoLiveData.LiveCommentData commentData = e.CommentDataList[RNGcount];
                    //comentprocessを呼んでコメント番号を渡す
                   // comentprocess(int.Parse(commentData.No));
                    comentprocess(commentData.Comment);

                }
            }

        }
        public void comentprocess(string coment)
        {
            if (form.formcloseflag == 0)
            {
                form.delivertextbox1handle().Text = coment;
            }


        }

        void host_BroadcastDisConnected(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
           // MessageBox.Show("放送から切断されました","",MessageBoxButtons.OK,MessageBoxIcon.None);
            connectflag = 0;
            form.delivertextbox1handle().Text = "ncvから切断されました。";

        }

        void host_BroadcastConnected(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
         //   MessageBox.Show("放送に接続されました","",MessageBoxButtons.OK,MessageBoxIcon.None);
            connectflag = 1;
            form.delivertextbox1handle().Text = "ncvから接続されました。";

        }

        void form_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            //form.FormClosed -= form.FormClosed;
            //host.BroadcastConnected -= host.BroadcastConnected;
            //host.BroadcastDisConnected -= host.BroadcastDisConnected;
            form.FormClosed -= new System.Windows.Forms.FormClosedEventHandler(form_FormClosed);
            host.BroadcastConnected -= new Plugin.BroadcastConnectedEventHandler(host_BroadcastConnected);
            host.BroadcastDisConnected -= new Plugin.BroadcastDisConnectedEventHandler(host_BroadcastDisConnected);
            host.ReceivedComment -= new Plugin.ReceivedCommentEventHandler(host_ReceivedComment);
               
            form.Dispose();
            form.Close();
            //Plugin.ReceivedCommentEventHandler.finalize;
            //forclose.finalize();
            form = null;
        }

        public string Version
        {
            //get { throw new NotImplementedException(); }
             get { return "1.0"; }

        }

        #endregion
    }
}
