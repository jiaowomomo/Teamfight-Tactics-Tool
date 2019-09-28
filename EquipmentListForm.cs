using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YunDingCombination
{
    public partial class EquipmentListForm : Form
    {
        public EquipmentListForm()
        {
            InitializeComponent();
            //设置双缓冲，减少控件闪烁
            tableLayoutPanel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel1, true, null);
        }

        private void EquipmentListForm_Load(object sender, EventArgs e)
        {
            int x = SystemInformation.PrimaryMonitorSize.Width - this.Width;
            //int y = SystemInformation.PrimaryMonitorSize.Height - this.Height;
            this.Location = new Point(x, 0);
        }
    }
}
