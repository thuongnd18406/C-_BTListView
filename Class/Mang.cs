using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLIST.Class
{
    public class Mang
    {
        Cphanso[] ps;

        int Spt;
        public Mang()// khai bao mang
        {
            ps = new Cphanso[100 + 10];
            Spt = 10;
        }
        public Mang(int sophantu)
        {
            ps = new Cphanso[sophantu + 10];
            Spt = sophantu;
        }

        public void NhapMangNgauNhien()
        {
            for (int i = 0; i < Spt; i++)
            {
                ps[i] = new Cphanso();
                ps[i].nhap();
            }
        }

        public string XuatMang()
        {
            string s = "";
            for (int i = 0; i < Spt; i++)
            {
                s += ps[i].xuat() + "\t";
            }
            return s;
        }
        public void ChenDau(Cphanso a)
        {
            for (int i = Spt++; i > 0; i--)
            {
                ps[i] = ps[i - 1];
            }
            ps[0] = a;
        }
        public void ChenGiua(Cphanso SoChen, int vitri)
        {
            for (int i = Spt++; i > vitri; i--)
            {
                ps[i] = ps[i - 1];
            }
            ps[vitri] = SoChen;
        }
        public void Chencuoi(Cphanso a)
        {
            ps[Spt] = a;
            Spt++;
        }
        public string Xoa(int vitri)
        {
            int i = 0;
            string s = "";
            i = 0;
            while (i != vitri - 1)
                i++;
            //thay thế vị trí thứ i bằng thứ i+1
            while (i < Spt)
            {
                ps[i] = ps[i + 1];
                i++;
            }
            Spt--;
            //Xuất mảng mới
            return s = XuatMang();

        }

        public string Max()
        {
            Cphanso a = new Cphanso();
            string s = "";
            float max = ps[0].giatri;
            for (int i = 1; i < Spt; i++)
            {
                if (max < ps[i].giatri)
                {
                    a = ps[i];

                    max = ps[i].giatri;
                }
            }
            return s = a.xuat();

        }
        public string Min()
        {
            Cphanso a = new Cphanso();
            string s = "";
            float min = ps[0].giatri;
            for (int i = 1; i < Spt; i++)
            {
                if (min > ps[i].giatri)
                {
                    a = ps[i];
                    min = ps[i].giatri;
                }
            }
            return s = a.xuat();
        }


        public void InterchangeSort()
        {
            for (int i = 0; i < Spt - 1; i++)
            {
                for (int j = i + 1; j < Spt; j++)
                {
                    if (ps[i].giatri > ps[j].giatri)
                    {
                        DoiCho(i, j);
                    }
                }
            }
        }
        public void GiamDanInterchangeSort()
        {
            for (int i = 0; i < Spt - 1; i++)
            {
                for (int j = i + 1; j < Spt; j++)
                {
                    if (ps[i].giatri < ps[j].giatri)
                    {
                        DoiCho(i, j);
                    }
                }
            }
        }
        public void DoiCho(int x, int y)
        {
            Cphanso tam;
            tam = ps[x];
            ps[x] = ps[y];
            ps[y] = tam;
        }
        public void SelectionSort()
        {
            int min;
            for (int i = 0; i < Spt - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < Spt; j++)
                    if (ps[j].giatri < ps[min].giatri)
                        min = j;
                if (min != i)
                {
                    DoiCho(min, i);
                }
            }
        }

        public void BubbleSort()
        {
            for (int i = 0; i < Spt - 1; i++)
                for (int j = Spt - 1; j > i; j--)
                    if (ps[j].giatri < ps[j - 1].giatri)
                        DoiCho(j, j - 1);
        }

    }
}
