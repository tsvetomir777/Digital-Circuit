using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalCircuitPro
{
    [Serializable]
    public class Item
    {
        //FIELDS
        private Point position, outputPos, inputPos;

        private int value;
        private List<Connection> listOfConnections;
        private int radius;



        //PROPERTIES
        public int Value { get { return this.value; } set { this.value = value; } }
        public List<Connection> ListOfConnections { get { return this.listOfConnections; }  }
        public Point Position { get { return this.position; } set { this.position = value; } }
        public Point InputPos { get { return this.inputPos; } set { this.inputPos = value; } }
        public Point OutputPos { get { return this.outputPos; } set { this.outputPos = value; } }
        public int Radius { get { return this.radius; } set { this.radius = value; } }
       

        //CONSTRUCTOR
        public Item(Point pos, int radius)
        {
            this.position = pos;
            this.inputPos.X = pos.X - radius; this.inputPos.Y = pos.Y;
            this.outputPos.X = pos.X + radius; this.outputPos.Y = pos.Y;
            this.radius = radius;
            this.value = -1;
            this.listOfConnections = new List<Connection>();
        }

        //METHODS

        public bool addConnection(Connection conn)
        {
            if (conn.ReceivingItem == this)
            {
                if (canBeConnected("input"))
                {
                    listOfConnections.Add(conn);
                    return true;
                }
            }
            else if (conn.SendingItem == this)
            {
                if (canBeConnected("output"))
                {
                    listOfConnections.Add(conn);
                    return true;
                }
            }
            return false;
        }
        public virtual void removeConnection(Connection conn)
        {
            
            this.ListOfConnections.Remove(conn);
            
        }
        public void passValue()
        {
            if (this.listOfConnections.Count != 0)
            foreach (Connection conn in ListOfConnections)
            {
                if (conn.SendingItem == this)
                {
                    if (conn.ReceivingItem is Gate)
                        ((Gate)conn.ReceivingItem).setInputFromConnection(conn);
                    else if (conn.ReceivingItem is Sink)
                        ((Sink)conn.ReceivingItem).setInputFromConnection(conn);

                }
            }
        }
        public bool ContainsPoint(Point p)
        {
            return (this.position.X - p.X) * (this.position.X - p.X) + (this.position.Y - p.Y) * (this.position.Y - p.Y) <= (radius * radius + radius * radius);
        }
        
       
        public virtual void DrawItself(System.Drawing.Graphics gr, ImageList il)
        {
           
        }
        public virtual bool canBeConnected(String connectionType)
        {
            return false;
        }

        

    }
}
