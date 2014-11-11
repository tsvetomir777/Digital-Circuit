using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DigitalCircuitPro
{
    [Serializable]
    public class Connection
    {
        //FIELDS
        private Item receivingItem;
        private Item sendingItem;
        private Point sendingPoint, receivingPoint;
        

        //PROPERTIES

        public Item ReceivingItem { get{return this.receivingItem;}}
        public Item SendingItem { get { return this.sendingItem; } }
        public Point SendingPoint { get { return this.sendingPoint; } set { this.sendingPoint = value; } }
        public Point ReceivingPoint { get { return this.receivingPoint; } set { this.receivingPoint = value; } }



        //CONSTRUCTOR
        public Connection(Item receivingItem, Item sendingItem)
        {
            this.receivingItem = receivingItem;
            this.sendingItem = sendingItem;
            this.sendingPoint = sendingItem.OutputPos;
            this.receivingPoint = ReceivingItem.InputPos;
            //if (sendingItem.Value != -1)
            if (receivingItem is Gate)
            {
                if (receivingItem is GateAND)
                    this.receivingPoint = ((GateAND)ReceivingItem).ChosenPos;
                else if (receivingItem is GateOR)
                    this.receivingPoint = ((GateOR)ReceivingItem).ChosenPos;
                ((Gate)receivingItem).setInputFromConnection(this);
            }
            else if (receivingItem is Sink)
                ((Sink)receivingItem).setInputFromConnection(this);

        }

    }
}
