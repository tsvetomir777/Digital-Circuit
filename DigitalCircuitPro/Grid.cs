using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;


namespace DigitalCircuitPro
{
    [Serializable]
    public class Grid
    {
        //FIELDS
        private List<Item> listOfItems;
        
        //PROPERTIES
        public List<Item> ListOfItems { get { return this.listOfItems; }}

        //CONSTRUCTOR
        public Grid()
        {
            this.listOfItems = new List<Item>();
        }
        //METHODS
        public bool addItem(Item i)
        {
            if (getItemByPoint(i.Position) != null)
                return false;
            else
            {
                listOfItems.Add(i);
                return true;
            }
        }
        public Item getItemByPoint(Point p)
        {
            foreach (Item i in listOfItems)
            {
                if (i.ContainsPoint(p))
                    return i;
            }
            return null;
        }
        public bool RemoveItem(Point p)
        {
            foreach (Item tempItem in listOfItems)
            {
                if (tempItem.ContainsPoint(p))
                {
                    listOfItems.Remove(tempItem);
                    //REFRESH GRID
                    return true;
                } 
            }
            return false;
        }
        public bool addConnection(Item sendingItem, Item receivingItem)
        {
            Connection conn = new Connection(receivingItem, sendingItem);
            if ((sendingItem.addConnection(conn)) && (receivingItem.addConnection(conn)))

                return true;
            else
                return false;
        }
        public void DrawAllItems(Graphics gr, ImageList il)
        {
            foreach (Item i in this.listOfItems)
            {
                i.DrawItself(gr, il);
            }
        }

        /// <summary>
        /// All lines (connections, edges) are drawn in black on the graphics gr
        /// 
        /// </summary>
        /// <param name="gr"></param>
        public void DrawAllLines(Graphics gr, bool colorblind)
        {
            if (colorblind)
            {
                foreach (Item i in this.listOfItems)
                {
                    foreach (Connection n in i.ListOfConnections)
                    {
                        Pen defaultpen = new Pen(Color.Black, 5);
                        if (n.SendingItem.Value == 1)
                        {
                            defaultpen.Color = Color.Yellow;
                            gr.DrawLine(defaultpen, n.SendingPoint.X, n.SendingPoint.Y, n.ReceivingPoint.X, n.ReceivingPoint.Y);
                        }
                        else
                        {
                            defaultpen.Color = Color.Blue;
                            gr.DrawLine(defaultpen, n.SendingPoint.X, n.SendingPoint.Y, n.ReceivingPoint.X, n.ReceivingPoint.Y);
                        }

                    }
                }
            }
            else
            {
                foreach (Item i in this.listOfItems)
                {
                    foreach (Connection n in i.ListOfConnections)
                    {
                        Pen defaultpen = new Pen(Color.Black, 5);
                        if (n.SendingItem.Value == 1)
                        {
                            defaultpen.Color = Color.Green;
                            gr.DrawLine(defaultpen, n.SendingPoint.X, n.SendingPoint.Y, n.ReceivingPoint.X, n.ReceivingPoint.Y);
                        }
                        else
                        {
                            defaultpen.Color = Color.Red;
                            gr.DrawLine(defaultpen, n.SendingPoint.X, n.SendingPoint.Y, n.ReceivingPoint.X, n.ReceivingPoint.Y);
                        }

                    }
                }
            }
        }
        public void RemoveConnections(Item i)
        {
            
            foreach (Item myitem in ListOfItems)
            {
               
                if (myitem.ListOfConnections.Count != 0)
                {
                    List<Connection> templist = new List<Connection>();
                foreach (Connection conn in myitem.ListOfConnections)
                {
                    if ((conn.SendingItem == i) || (conn.ReceivingItem == i))
                    {
                        
                        templist.Add(conn);
                    }
                }
                foreach (Connection tempconn in templist)
                {
                    myitem.removeConnection(tempconn);
                }
                
                }
            }
        }
        public void SetAllConnectionValues()
        {
            foreach (Item i in this.listOfItems)
            {
                foreach (Connection conn in i.ListOfConnections)
                {
                    if ((i is Gate) && (conn.ReceivingItem == i))
                        ((Gate)i).setInputFromConnection(conn);
                    else if ((i is Sink) && (conn.ReceivingItem == i))
                        ((Sink)i).setInputFromConnection(conn);
                }
                
            }
        }
        

         public void SaveToFile()
         {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Binary files Files (*.bin*)|*.bin";
            sfd.DefaultExt = "bin";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {

                FileStream fs = null;
                BinaryFormatter bf = null;
                

                try
                {
                    fs = new FileStream(sfd.FileName, FileMode.CreateNew, FileAccess.Write);
                    bf = new BinaryFormatter();
                    bf.Serialize(fs,listOfItems);

                }
                catch (IOException e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
                MessageBox.Show("Saved");

            }
        }

        public void LoadFromFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                BinaryFormatter bf = null;
              
                try
                {
                    fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
                    bf = new BinaryFormatter();
                    listOfItems = (List<Item>)(bf.Deserialize(fs));
                    
                }
                catch (IOException)
                {
                    MessageBox.Show("Input/Output error");
                }
                finally
                {
                    if (fs != null) fs.Close();
                    
                }
                MessageBox.Show("Loading done !");
                Form1.ActiveForm.Refresh();
            }
        }


       

    }
}
