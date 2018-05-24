using System;
using System.Windows.Forms;

namespace Turrel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GameObject[] TargetList = new GameObject[100];

        private void button1_Click(object sender, EventArgs e)
        {
            GameObject NewObj = new GameObject();


            ObjTools.AddNewTarget(NewObj, TargetList);
           // if (ObjTools.AddNewTarget(NewObj,TargetList))  MessageBox.Show(NewObj.obj_name + " создан !");
           // else MessageBox.Show(NewObj.obj_name + " ошибка !");
            this.richTextBox1.Clear();

            foreach (var p in TargetList)
            {
                if (p != null)
                {
                    this.richTextBox1.AppendText("\r\n" + p.obj_name); 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string RemoveObjName = this.textBox1.Text;

            string nextObjName = ObjTools.GetNextObj(RemoveObjName, TargetList);

            if (!String.IsNullOrEmpty(RemoveObjName))
            {
                ObjTools.RemoveTarget(RemoveObjName, TargetList);


                this.richTextBox1.Clear();
                foreach (var p in TargetList)
                {
                    if (p != null)
                    {
                        this.richTextBox1.AppendText("\r\n" + p.obj_name);
                    }
                }

                
                this.textBox1.Text = "";
            }
        }
    }
}
