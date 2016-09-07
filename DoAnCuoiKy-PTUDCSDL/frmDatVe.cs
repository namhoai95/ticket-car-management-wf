using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAnCuoiKy_PTUDCSDL
{
    public partial class frmDatVe : DevExpress.XtraEditors.XtraForm
    {
        public frmDatVe()
        {
            InitializeComponent();
        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            for (int i = 5; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Button button = new Button();
                    button.Location = new Point(i * 50, j * 50);
                    button.Size = new Size(50, 50);
                    

                    button.Text = j.ToString();
                    pnlControl.Controls.Add(button);
                }
            }
        }
    }
}