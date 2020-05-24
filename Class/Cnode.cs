using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLIST.Class
{
    class Cnode
    {
        public Cnode next;
        public Cphanso Data;
        public Cnode()
        {
            Data = new Cphanso();
            Data.nhap();
            next = null;
        }
        public Cnode(Cphanso d)
        {
            Data = d;
            next = null;
        }
        public string innode()
        {
            return Data.xuat();
        }
    }
}
