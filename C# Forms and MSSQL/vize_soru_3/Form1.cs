using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_soru_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<sbyte> coordinateArea;

        private void Form1_Load(object sender, EventArgs e)
        {
            coordinateArea = new List<sbyte>();
        }

        private void btnAddCoordinate_Click(object sender, EventArgs e)
        {
            int coordinateX; int coordinateY;
            if (int.TryParse(textBoxCoordinateX.Text.Trim(), out coordinateX) && int.TryParse(textBoxCoordinateY.Text.Trim(), out coordinateY))
            {
                if (coordinateX > 0)
                {
                    if (coordinateY > 0)
                        coordinateArea.Add(1);
                    else
                        coordinateArea.Add(4);
                }
                else
                {
                    if (coordinateY > 0)
                        coordinateArea.Add(2);
                    else
                        coordinateArea.Add(3);
                }
                textBoxCoordinateX.Clear();
                textBoxCoordinateY.Clear();
                textBoxCoordinateX.Focus();
            }
            else
                MessageBox.Show("GİRİŞ HATASI !");
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int area1Count; int area2Count; int area3Count; int area4Count;
            area1Count = area2Count = area3Count = area4Count = 0;
            foreach (var item in coordinateArea)
            {
                switch (item)
                {
                    case 1:
                        area1Count++;
                        break;
                    case 2:
                        area2Count++;
                        break;
                    case 3:
                        area3Count++;
                        break;
                    case 4:
                        area4Count++;
                        break;
                    default:
                        break;
                }
            }
            string temple = "1.Bölge: " + area1Count.ToString() + "\n" + "2.Bölge: " + area2Count.ToString() + "\n" +
                "3.Bölge: " + area3Count.ToString() + "\n" + "4.Bölge: " + area4Count.ToString();
            MessageBox.Show(temple);
        }
    }
}
