using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalCircuitPro
{
    [Serializable]
    public class GateNOT : Gate
    {
        public GateNOT(Point pos, int radius)
            : base(pos, radius)
        {

        }
        public override void Calculate()
        {
            if (Input == 1)
            {
                this.Value = 0;
                passValue();
            }
            else if (Input == 0)
            {
                this.Value = 1;
                passValue();
            }
            else
            {
                this.Value = -1;

            }
        }
        public override bool canBeConnected(string connectionType)
        {
            int InputconnCount = 0;
            int OutputConnCount = 0;
            if (connectionType == "input")
            {
                foreach (Connection conn in ListOfConnections)
                {
                    if (conn.ReceivingItem == this)
                        InputconnCount++;
                }
                if (InputconnCount < 1)
                    return true;
            }
            else if (connectionType == "output")
            {
                foreach (Connection conn in ListOfConnections)
                {
                    if (conn.SendingItem == this)
                        InputconnCount++;
                }
                if (OutputConnCount == 0)
                    return true;
            }
            return false;
        }
        public override void setInputFromConnection(Connection conn)
        {
            Input = conn.SendingItem.Value;
            if (Input != -1)
                Calculate();

        }
        public override void DrawItself(Graphics gr, ImageList il)
        {
            int diameter = 2 * this.Radius;
            gr.DrawImage(il.Images[1], this.Position.X - this.Radius, this.Position.Y - this.Radius, diameter, diameter);
            //gr.DrawImageUnscaled(il.Images[1], this.Position);

        }
        public override void removeConnection(Connection conn)
        {

            if (conn.ReceivingItem == this)
                this.Input = -1;
            this.ListOfConnections.Remove(conn);
            
        }
    }
}
