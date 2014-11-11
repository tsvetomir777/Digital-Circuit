using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalCircuitPro
{
    [Serializable]
    public class GateAND : Gate
    {
        //FIELDS
        private int input2;
        private Point input2Pos, chosenPos, tempPos;
        
        //PROPERTIES
        public int Input2 { get { return this.input2; } set { this.input2 = value; } }
        public Point Input2Pos { get { return this.input2Pos; } set { this.input2Pos = value; } }
        public Point ChosenPos { get { return this.chosenPos; } set { this.chosenPos = value; } }

        //CONSTRUCTOR
        public GateAND(Point pos, int radius)
        :base(pos, radius)
        {
            this.input2 = -1;

            //SET input1, input2 and output Point positions
            this.input2Pos.X = pos.X - radius; this.input2Pos.Y = pos.Y - (int)(radius * 0.5);
            this.tempPos.X = pos.X - radius; this.tempPos.Y = pos.Y + (int)(radius * 0.5);
            this.InputPos = tempPos;
            this.chosenPos = InputPos;
            
            
            
        }
        //METHODS

        public override void Calculate()
        {
            if ((Input == 1) && (Input2 == 1))
            {
                this.Value = 1;
                passValue();
            }
            else if ((Input == -1) || (Input2 == -1))
            {
                this.Value = -1;

            }
            else
            {
                this.Value = 0;
                passValue();
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
                if (InputconnCount < 2)
                    return true;
            }
            else if (connectionType == "output")
            {
                foreach (Connection conn in ListOfConnections)
                {
                    if (conn.SendingItem == this)
                        OutputConnCount++;
                }
                if (OutputConnCount == 0)
                    return true;
            }
            return false;
        }
       
        public override void setInputFromConnection(Connection conn)
        {
            if (Input == -1)
            {
                Input = conn.SendingItem.Value;
                conn.ReceivingPoint = this.InputPos;
            }
            else if (Input2 == -1)
            {
                Input2 = conn.SendingItem.Value;
                conn.ReceivingPoint = this.Input2Pos;
            }
            else if ((conn.ReceivingPoint == this.InputPos) && (Input != -1))
                Input = conn.SendingItem.Value;
            else if ((conn.ReceivingPoint == this.Input2Pos) && (Input2 != -1))
                Input2 = conn.SendingItem.Value;
            Calculate();

        }

        public override void removeConnection(Connection conn)
        {
            if (conn.ReceivingItem == this)
            {
                if (conn.ReceivingPoint == InputPos)
                    this.Input = -1;
                else
                    this.Input2 = -1;
            }
            this.ListOfConnections.Remove(conn);
            this.Calculate();
        }

        public override void DrawItself(Graphics gr, ImageList il)
        {
            int diameter = 2 * this.Radius;
            gr.DrawImage(il.Images[0], this.Position.X - this.Radius, this.Position.Y - this.Radius, diameter, diameter);

        }
    }
}
