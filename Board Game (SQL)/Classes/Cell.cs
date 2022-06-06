using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Board_Game__SQL_
{
    public class Cell
    {
        public int row;
        public int col;
        public int dist;
        public Cell(int x, int y, int w)
        {
            this.row = x;
            this.col = y;
            this.dist = w;
        }
    }
}
