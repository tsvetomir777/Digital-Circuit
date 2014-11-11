using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DigitalCircuitPro
{
    [Serializable]
    public class Gate : Item
    {
        //FIELDS
        private int input;
      
        //PROPERTIES
        public int Input { get { return this.input; } set { this.input = value; } }

        //CONSTRUCTOR
        public Gate(Point pos, int radius)
        :base(pos, radius)
        {
            this.input = -1;
            
        }
        //METHODS
        public virtual void Calculate()
        {
            this.Value = this.Input;
            passValue();
            
        }
        //Assigns the value passed by a connection to the input value of the gate. 
        //Should be overridden in AND/OR gates to check which field to use.
        public virtual void setInputFromConnection(Connection conn)
        {
            
            this.input = conn.SendingItem.Value;
            if (Input != -1)
                Calculate();
        }
    }
}
