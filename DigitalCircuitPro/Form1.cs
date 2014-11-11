using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DigitalCircuitPro
{
    public partial class Form1 : Form
    {
        enum WhatToDraw { andgate, orgate, notgate, sink, source, none, startline, endline, remove };
        Grid gridd;
        WhatToDraw temp;
        Item c, istart, iend;
        bool colorblind = false;
        

        public Form1()
        {
            InitializeComponent();
            gridd = new Grid();
            temp = WhatToDraw.none;
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {   
            Point p = e.Location;

            switch (temp)
            {
                case WhatToDraw.andgate:
                    gridd.addItem(c = new GateAND(p, 30));
                        //ListOfItems.Add(c = new GateAND(p, 40));
                    temp = WhatToDraw.none;
                    break;
                case WhatToDraw.orgate:
                    gridd.addItem(c = new GateOR(p, 30));
                    temp = WhatToDraw.none;
                    break;
                case WhatToDraw.notgate:
                    gridd.addItem(c = new GateNOT(p, 30));
                    temp = WhatToDraw.none;
                    break;
                case WhatToDraw.sink:
                    gridd.addItem(c = new Sink(p, 30));
                    temp = WhatToDraw.none;
                    break;
                case WhatToDraw.source:
                    gridd.addItem(c = new Source(p, 30));
                    temp = WhatToDraw.none;
                    break;
                case WhatToDraw.none:
                    c = gridd.getItemByPoint(e.Location);
                    if ((c != null) && (c is Source))
                    {
                        ((Source)c).changeValue();
                        gridd.SetAllConnectionValues();
                     }
                    else
                        MessageBox.Show("You need to select a tool or \n source to change it's value");
                    break;
                case WhatToDraw.startline:
                    c = gridd.getItemByPoint(e.Location);
                     if (c != null)
                    {
                        if (c.canBeConnected("output"))
                        {
                            istart = c;
                            temp = WhatToDraw.endline;
                        }
                    }
                    break;
                case WhatToDraw.endline:
                    c = gridd.getItemByPoint(e.Location);
                    try
                    {
                        if (c.canBeConnected("input"))
                        {
                            iend = gridd.getItemByPoint(e.Location);
                            Connection conn = new Connection(iend, istart);
                            iend.addConnection(conn);
                            istart.addConnection(conn);
                            gridd.SetAllConnectionValues();
                            panel1.Invalidate();

                        }
                    }
                    catch (Exception ex) { MessageBox.Show("You can't make a connection with nothing"); }
                    temp = WhatToDraw.none;
                    break;
                case WhatToDraw.remove:
                    c = gridd.getItemByPoint(e.Location);
                    gridd.RemoveConnections(c);
                    gridd.ListOfItems.Remove(c);
                    temp = WhatToDraw.none;
                    break;
                default:
                    break;
            }
            
            this.Refresh();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            gridd.DrawAllItems(e.Graphics, imageList1);
            gridd.DrawAllLines(e.Graphics, colorblind);
           
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
          
        }

        private void OrGate_Click_1(object sender, EventArgs e)
        {
            temp = WhatToDraw.orgate;
        }

        private void NotGate_Click_1(object sender, EventArgs e)
        {
            temp = WhatToDraw.notgate;
        }

        private void Sink_Click_1(object sender, EventArgs e)
        {
            temp = WhatToDraw.sink;
        }

        private void Source_Click_1(object sender, EventArgs e)
        {
            temp = WhatToDraw.source;
        }

        private void pbLines_Click(object sender, EventArgs e)
        {
            temp = WhatToDraw.remove;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            temp = WhatToDraw.startline;

        }

        private void AndGate_Click(object sender, EventArgs e)
        {
            temp = WhatToDraw.andgate;
        }

       

        


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                colorblind = true;
            else
                colorblind = false;
            panel1.Invalidate();
        }

       

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (gridd.ListOfItems.Count == 0)
            {
                gridd.ListOfItems.Clear();
                Form1.ActiveForm.Refresh();
            }
            else
            {
                string message = "Do you want to save before making a new circuit document ?";
                string caption = "Word Processor";
                MessageBoxButtons buttton = MessageBoxButtons.YesNoCancel;
                MessageBoxIcon ikon = MessageBoxIcon.Warning;
                if (MessageBox.Show(message, caption, buttton, ikon) == DialogResult.Yes)
                {
                    gridd.SaveToFile();
                    gridd.ListOfItems.Clear();
                    Form1.ActiveForm.Refresh();
                }
                else if ((MessageBox.Show(message, caption, buttton, ikon) == DialogResult.No))
                {
                    gridd.ListOfItems.Clear();
                    Form1.ActiveForm.Refresh();
                }

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (gridd.ListOfItems.Count == 0)
            {
                MessageBox.Show("There is no data to save !");
            }
            else
            {
                gridd.SaveToFile();
            }
           
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (gridd.ListOfItems.Count == 0)
            {
                gridd.LoadFromFile();
            }
            else
            {
                string message = "Do you want to save before loading circuit document ?";
                string caption = "Word Processor";
                MessageBoxButtons buttton = MessageBoxButtons.YesNoCancel;
                MessageBoxIcon ikon = MessageBoxIcon.Warning;
                if (MessageBox.Show(message, caption, buttton, ikon) == DialogResult.Yes)
                {
                    gridd.SaveToFile();
                    gridd.ListOfItems.Clear();
                    gridd.LoadFromFile();
                    Form1.ActiveForm.Refresh();
                }
                else if (MessageBox.Show(message, caption, buttton, ikon) == DialogResult.No)
                {
                    gridd.ListOfItems.Clear();
                    gridd.LoadFromFile();
                    Form1.ActiveForm.Refresh();
                }
                else
                {
                    Form1.ActiveForm.Refresh();
                }
                
            }
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form f2 = new Form1();
            f2.Show();
        }




    }
}
