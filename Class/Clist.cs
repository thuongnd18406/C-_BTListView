using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLIST.Class
{
    class Clist
    {
        Cnode head;
        Cnode tail;
        public int spt;

        //khoi tao
        public Clist()
        {
            head = tail = null;
            spt = 0;
        }

        public Clist(Cnode a)
        {
            head = tail = a;
            spt = 1;
        }
        public void chendauphanso(Cphanso a)
        {
            Cnode nodea = new Cnode(a);
            if (head == null)
            {
                head = tail = nodea;
            }
            else
            {
                nodea.next = head;
                head = nodea;
            }
        }
        public void chendau2(Cnode nodea)
        {
            if (head == null)
            {
                head = tail = nodea;
            }
            else
            {
                nodea.next = head;
                head = nodea;
            }

        }
        public string inlist()
        {
            Cnode t = head;
            string kq = "";
            while (t != null)
            {
                kq += "\t" + t.innode();
                t = t.next;
            }
            return kq;
        }
        public void chencuoi(Cnode a)
        {
            if (head == null)
            {
                head = tail = a;
            }
            else
            {
                tail.next = a;
                tail = a;
            }
        }
        public void chencuoiPhanSo(Cphanso a)
        {
            Cnode nodea = new Cnode(a);
            if (head == null)
            {
                head = tail = nodea;
            }
            else
            {
                tail.next = nodea;
                tail = nodea;
            }
        }
        public void xoadau()
        {
            head = head.next;
        }
        public void xoacuoi()
        {
            if (tail.next == null)
            {
                tail = null;
            }
        }
        public void NhapList()
        {
            for (int i = 0; i < spt; i++)
            {
                Cnode a = new Cnode();
                chencuoi(a);
            }
        }
        //interchangesort
        public void SapxepTangDan()
        {
            for (Cnode p = head; p != null; p = p.next)
            {
                for (Cnode q = p; q != null; q = q.next)
                {
                    if (p.Data.giatri > q.Data.giatri)
                    {
                        Cphanso tam = p.Data;
                        p.Data = q.Data;
                        q.Data = tam;
                    }
                }
            }
        }
        public void Tron2List(Clist a, Clist b)
        {
            Cnode c = head;
            Cnode p = a.head;
            Cnode q = b.head;
            while (p != null && q != null)
            {
                if (p.Data.giatri < q.Data.giatri)
                {
                    c.Data = p.Data;
                    c = c.next;
                    p = p.next;
                }
                else
                {
                    c.Data = q.Data;
                    c = c.next;
                    q = q.next;
                }
            }
            while (p != null)
            {
                c.Data = p.Data;
                c = c.next;
                p = p.next;
            }
            while (p != null)
            {
                c.Data = q.Data;
                c = c.next;
                q = q.next;
            }
        }
    }
}
