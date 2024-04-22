using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private int _width = 800;
        private int _height = 800;
        private int _sizeOfSides;
        public Form1()
        {
            this.Width = _width;
            this.Height = _height;
            InitializeComponent();
            _generateMap();
            this.KeyDown += new KeyEventHandler(OKP);
        }

       private void _generateMap()
        {

        }

        private void OKP(object sender, KeyEventArgs e)
        {
           switch(e.KeyCode.ToString())
            {
                case "Right":
                    cube.Location = new Point(cube.Location.X + 20, cube.Location.Y);
                    break;
                case "Left":
                    cube.Location = new Point(cube.Location.X - 20, cube.Location.Y);
                    break;
                case "Up":
                    cube.Location = new Point(cube.Location.X, cube.Location.Y - 20);
                    break;
                case "Down":
                    cube.Location = new Point(cube.Location.X, cube.Location.Y + 20);
                    break;
            }
        }
    }
}
