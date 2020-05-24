using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BTLIST.Class;

namespace BTLIST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
         Mang a = new Mang();        
        Clist b = new Clist();
        Clist c = new Clist();
        Clist tam = new Clist();        
        private void BtnXuatList1_Click(object sender, RoutedEventArgs e)
        {
            b.spt = int.Parse(txtSPTList1.Text);
            b.NhapList();
            txtKQList.Text = b.inlist();
        }
        private void BtnThemDauList1_Click(object sender, RoutedEventArgs e)
        {
            Cphanso x = new Cphanso();
            x.PhanTichChuoi(txtSoMoiList.Text);
            b.chendauphanso(x);
            txtKQList.Text = b.inlist();
        }
        private void BtnThemCuoiList1_Click_1(object sender, RoutedEventArgs e)
        {
            Cphanso x = new Cphanso();
            x.PhanTichChuoi(txtSoMoiList.Text);
            b.chencuoiPhanSo(x);
            txtKQList.Text = b.inlist();
        }
        private void BtnChenList1_Click(object sender, RoutedEventArgs e)
        {

        }
        private void BtnXoaList1_Click_1(object sender, RoutedEventArgs e)
        {
            b.xoacuoi();
            txtKQList.Text = b.inlist();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            b.SapxepTangDan();
            c.SapxepTangDan();
            MessageBox.Show("Sắp xếp thành công");
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            txtKQList.Text = "";
            tam.Tron2List(b, c);
            txtKQList.Text = tam.inlist();
        }
    }
}
