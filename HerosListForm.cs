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
    public partial class HerosListForm : Form
    {
        List<IHero> m_listHeros;
        List<IHero> m_listSelectedHeros = new List<IHero>();
        List<SelectedCombination> m_listCombination = new List<SelectedCombination>();

        public HerosListForm(List<IHero> heros)
        {
            InitializeComponent();
            m_listHeros = heros;
            //设置双缓冲，减少控件闪烁
            tableLayoutPanel1.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(tableLayoutPanel1, true, null);
        }

        private void HerosList_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    if ((10 * i + j) < m_listHeros.Count)
                    {
                        PictureBox pb = new PictureBox();
                        pb.Image = m_listHeros[10 * i + j].image;
                        pb.SizeMode = PictureBoxSizeMode.Zoom;
                        pb.Cursor = Cursors.Hand;
                        pb.MouseDown += pb_MouseDown;
                        sb.Clear();
                        sb.Append(m_listHeros[10 * i + j].name + "\r\n消耗：" + m_listHeros[10 * i + j].consumption.ToString() + "\r\n种族+职业：");
                        for (int k = 0; k < 24; k++)
                        {
                            if (((int)m_listHeros[10 * i + j].ct & (int)Math.Pow(2, k)) == (int)Math.Pow(2, k))
                            {
                                sb.Append(((CombinationType)((int)Math.Pow(2, k))).ToString() + "  ");
                            }
                        }
                        sb.Append("\r\n技能：" + m_listHeros[10 * i + j].skill);
                        toolTip1.SetToolTip(pb, sb.ToString());
                        tableLayoutPanel1.Controls.Add(pb, j, i);
                    }
                }
            }
        }

        private void pb_MouseDown(object sender, MouseEventArgs e)
        {
            int row = tableLayoutPanel1.GetRow((PictureBox)sender);
            int col = tableLayoutPanel1.GetColumn((PictureBox)sender);
            if (m_listSelectedHeros.IndexOf(m_listHeros[row * 10 + col]) == -1)
            {
                m_listSelectedHeros.Add(m_listHeros[row * 10 + col]);
            }
            else
            {
                m_listSelectedHeros.Remove(m_listHeros[row * 10 + col]);
            }
            GenerateHeros();
        }

        private void GenerateHeros()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < m_listSelectedHeros.Count; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(60, 60);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = m_listSelectedHeros[i].image;
                flowLayoutPanel1.Controls.Add(pb);
            }
            GenerateEffect();
        }

        private void GenerateEffect()
        {
            m_listCombination.Clear();
            richTextBox1.Clear();
            if (m_listSelectedHeros.Count > 0)
            {
                //获取所有不同的特质
                for (int i = 0; i < m_listSelectedHeros.Count; i++)
                {
                    for (int k = 0; k < 24; k++)
                    {
                        if (((int)m_listSelectedHeros[i].ct & (int)Math.Pow(2, k)) == (int)Math.Pow(2, k))
                        {
                            SelectedCombination sc = new SelectedCombination();
                            sc.ct = (CombinationType)((int)Math.Pow(2, k));
                            bool isExist = false;
                            for (int j = 0; j < m_listCombination.Count; j++)
                            {
                                if ((m_listCombination[j].ct & sc.ct) == sc.ct)
                                {
                                    isExist = true;
                                    break;
                                }
                            }
                            if (!isExist)
                            {
                                m_listCombination.Add(sc);
                            }
                        }
                    }
                }
                for (int i = 0; i < m_listCombination.Count; i++)
                {
                    for (int j = 0; j < m_listSelectedHeros.Count; j++)
                    {
                        if ((m_listCombination[i].ct & m_listSelectedHeros[j].ct) == m_listCombination[i].ct)
                        {
                            m_listCombination[i].nCount++;
                        }
                    }
                }
                richTextBox1.AppendText("目前拥有特质：\r\n");
                for (int i = 0; i < m_listCombination.Count; i++)
                {
                    if (i == m_listCombination.Count - 1)
                    {
                        richTextBox1.AppendText(m_listCombination[i].nCount.ToString() + m_listCombination[i].ct.ToString() + "\r\n");
                    }
                    else
                    {
                        richTextBox1.AppendText(m_listCombination[i].nCount.ToString() + m_listCombination[i].ct.ToString() + "、");
                    }
                }
                richTextBox1.AppendText("产生羁绊：\r\n");
                for (int i = 0; i < m_listCombination.Count; i++)
                {
                    if (TriggerEffect.effect.ContainsKey(m_listCombination[i].nCount.ToString() + m_listCombination[i].ct.ToString()))
                    {
                        richTextBox1.AppendText(TriggerEffect.effect[m_listCombination[i].nCount.ToString() + m_listCombination[i].ct.ToString()] + ".\r\n");
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m_listSelectedHeros.Clear();
            GenerateHeros();
        }
    }
}
