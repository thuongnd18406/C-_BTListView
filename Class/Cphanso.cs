using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BTLIST.Class
{
    public class Cphanso
    {
        public int tu;
        public int mau;

        public Cphanso()
        {
            tu = 0;
            mau = 1;
        }
        public int Tu
        {
            get;
            set;
        }

        public int Mau
        {
            get { return mau; }
            set
            {
                if (value != 0)
                    mau = value;
            }
        }
        public void nhap()
        {
            Random rd = new Random();
            Thread.Sleep(10);//ramdom cham
            Tu = rd.Next(-9, 9);
            Thread.Sleep(10);
            Mau = rd.Next(1, 10);
        }
        public void PhanTichChuoi(string ps)
        {
            string[] arr = ps.Split('/');
            Tu = int.Parse(arr[0]);
            Mau = int.Parse(arr[1]);
        }
        public float giatri { get { return (float)(Tu / Mau); } }
        public string xuat()
        {
            return Tu.ToString() + "/" + Mau.ToString();
        }
    }
}
