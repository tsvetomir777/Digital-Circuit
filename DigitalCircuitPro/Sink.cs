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
    class Sink : Item
    {
        //FIELDS

        //PROPERTIES

        //CONSTRUCTOR

        public Sink(Point pos, int radius)
            : base(pos, radius)
        { }

        //METHODS
        public override bool canBeConnected(string connectionType)
        {

            int InputConnCount = 0;
            if (connectionType == "input")
            {
                foreach (Connection conn in ListOfConnections)
                {
                    if (conn.SendingItem == this)
                        InputConnCount++;
                    
                }
                if (InputConnCount == 0)
                    return true;
                else if (InputConnCount > 0)
                    return false;
                
            }
            else
            {
                MessageBox.Show("Sink cannot send values!");
                return false;
            }
            return false;
        }
        public void setInputFromConnection(Connection conn)
        {
            this.Value = conn.SendingItem.Value;
            
        }
        public override void DrawItself(Graphics gr, ImageList il)
        {
            int diameter = 2 * this.Radius;
            if ((this.Value == 0) || (this.Value == -1))
                gr.DrawImage(il.Images[3], this.Position.X - this.Radius, this.Position.Y - this.Radius, diameter, diameter);
            else
                gr.DrawImage(il.Images[4], this.Position.X - this.Radius, this.Position.Y - this.Radius, diameter, diameter);


        }
        public override void removeConnection(Connection conn)
        {
            this.ListOfConnections.Remove(conn);
            this.Value = -1;
        }
    }
}
