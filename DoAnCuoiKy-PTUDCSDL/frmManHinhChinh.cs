using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAnCuoiKy_PTUDCSDL
{
    public partial class frmManHinhChinh : Form
    {
        public frmManHinhChinh()
        {
            InitializeComponent();
        }

        private bool ExistForm(XtraForm form)
        {
            foreach(var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDanhSachVe();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnDatVe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new frmDatVe();
            if (ExistForm(frm)) return;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
