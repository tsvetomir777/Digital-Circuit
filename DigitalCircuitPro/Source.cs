using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalCircuitPro
{
    [Serializable]
    class Source : Item
    {
        //private Graphics g;
        public Source(Point pos, int radius)
        :base(pos, radius){
            this.Value = 0;
        }
        public void changeValue()
        {
            if (this.Value == 1)
                this.Value = 0;
            else
                this.Value = 1;
            if (this.ListOfConnections.Count != 0)
            {
                foreach (Connection conn in ListOfConnections)
                {
                    if (conn.ReceivingItem is Gate)
                    {
                        ((Gate)conn.ReceivingItem).setInputFromConnection(conn);

                    }
                    else if (conn.ReceivingItem is Sink)
                        ((Sink)conn.ReceivingItem).setInputFromConnection(conn);
                }
            }
            
            
        }
        public override bool canBeConnected(string connectionType)
        {
            
            int OutputConnCount = 0;
            if (connectionType == "output")
            {
                foreach (Connection conn in ListOfConnections)
                {
                    if (conn.SendingItem == this)
                        OutputConnCount++;
                }
                if (OutputConnCount == 0)
                    return true;
            }
            else
            {
                MessageBox.Show("Source cannot receive values!");
                return false;
            }
            return false;
        }
        public override void DrawItself(Graphics gr, ImageList il)
        {
            int diameter = 2 * this.Radius;
            if (this.Value == 0)
                gr.DrawImage(il.Images[5], this.Position.X - this.Radius, this.Position.Y - this.Radius, diameter, diameter);
            else
                gr.DrawImage(il.Images[6], this.Position.X - this.Radius, this.Position.Y - this.Radius, diameter, diameter);


        }
    }
}
