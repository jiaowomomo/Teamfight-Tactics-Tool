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
    public partial class MainForm : Form
    {
        List<SelectedCombination> m_listCombination = new List<SelectedCombination>();
        List<IHero> m_listHero = new List<IHero>();
        List<NeedHeros> m_listAllHeros = new List<NeedHeros>();
        List<Control> m_listAttribute = new List<Control>();

        public MainForm()
        {
            InitializeComponent();

            AddHeros();
            AddControl();
            for (int i = 0; i < m_listAttribute.Count; i++)
            {
               m_listAttribute[i].BackColor= Color.FromArgb(85, 255, 255, 255);
            }
        }

        private void AddControl()
        {
            m_listAttribute.Add(groupBox1);
            m_listAttribute.Add(groupBox2);
            m_listAttribute.Add(groupBox3);
            m_listAttribute.Add(groupBox4);
            m_listAttribute.Add(groupBox5);
            m_listAttribute.Add(groupBox6);
            m_listAttribute.Add(groupBox7);
            m_listAttribute.Add(groupBox8);
            m_listAttribute.Add(groupBox9);
            m_listAttribute.Add(groupBox10);
            m_listAttribute.Add(groupBox11);
            m_listAttribute.Add(groupBox12);
            m_listAttribute.Add(groupBox13);
            m_listAttribute.Add(groupBox14);
            m_listAttribute.Add(groupBox15);
            m_listAttribute.Add(groupBox16);
            m_listAttribute.Add(groupBox17);
            m_listAttribute.Add(groupBox18);
            m_listAttribute.Add(groupBox19);
            m_listAttribute.Add(groupBox20);
            m_listAttribute.Add(groupBox21);
            m_listAttribute.Add(groupBox22);
            m_listAttribute.Add(groupBox23);

            m_listAttribute.Add(label1);
            m_listAttribute.Add(label2);
            m_listAttribute.Add(label3);
        }

        private void AddHeros()
        {
            m_listHero.Add(new 暗影猎手());
            m_listHero.Add(new 傲之追猎者());
            m_listHero.Add(new 北地之怒());
            m_listHero.Add(new 冰晶凤凰());
            m_listHero.Add(new 冰霜女巫());
            m_listHero.Add(new 不详之刃());
            m_listHero.Add(new 惩戒之箭());
            m_listHero.Add(new 崔斯特());
            m_listHero.Add(new 德玛西亚之力());
            m_listHero.Add(new 堕落天使());
            m_listHero.Add(new 法外狂徒());
            m_listHero.Add(new 弗雷尔卓德之心());
            m_listHero.Add(new 复仇焰魂());
            m_listHero.Add(new 海洋之灾());
            m_listHero.Add(new 寒冰射手());
            m_listHero.Add(new 疾风剑豪());
            m_listHero.Add(new 剑魔());
            m_listHero.Add(new 九尾妖狐());
            m_listHero.Add(new 狂暴之心());
            m_listHero.Add(new 狂野女猎手());
            m_listHero.Add(new 雷霆咆哮());
            m_listHero.Add(new 离群之刺());
            m_listHero.Add(new 龙血武姬());
            m_listHero.Add(new 麦林炮手());
            m_listHero.Add(new 迷失之牙());
            m_listHero.Add(new 暮光之眼());
            m_listHero.Add(new 诺克萨斯统领());
            m_listHero.Add(new 诺克萨斯之手());
            m_listHero.Add(new 荣耀行刑官());
            m_listHero.Add(new 赏金猎人());
            m_listHero.Add(new 圣锤之毅());
            m_listHero.Add(new 圣枪游侠());
            m_listHero.Add(new 曙光女神());
            m_listHero.Add(new 死亡歌颂者());
            m_listHero.Add(new 铁铠冥魂());
            m_listHero.Add(new 痛苦之拥());
            m_listHero.Add(new 无双剑姬());
            m_listHero.Add(new 仙灵女巫());
            m_listHero.Add(new 邪恶小法师());
            m_listHero.Add(new 虚空遁地兽());
            m_listHero.Add(new 虚空行者());
            m_listHero.Add(new 虚空恐惧());
            m_listHero.Add(new 虚空掠夺者());
            m_listHero.Add(new 血港魅影());
            m_listHero.Add(new 影流之主());
            m_listHero.Add(new 永猎双子());
            m_listHero.Add(new 蒸汽机器人());
            m_listHero.Add(new 正义天使());
            m_listHero.Add(new 蜘蛛女皇());
            m_listHero.Add(new 铸星龙王());
            m_listHero.Add(new 祖安怒兽());
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            m_listCombination.Clear();
            foreach (Control ctl in this.Controls)
            {
                if (ctl is GroupBox)
                {
                    foreach (Control ctli in ((GroupBox)ctl).Controls)
                    {
                        if (ctli is CheckBox)
                        {
                            if (((CheckBox)ctli).Checked)
                            {
                                string name = ((CheckBox)ctli).Text;
                                string count = name.Substring(0, 1);
                                string type = name.Substring(1, name.Length - 1);
                                SelectedCombination sc = new SelectedCombination();
                                sc.ct = (CombinationType)System.Enum.Parse(typeof(CombinationType), type);
                                sc.nCount = Convert.ToInt32(count);
                                m_listCombination.Add(sc);
                                break;
                            }
                        }
                    }
                }
            }
            RefreshSelectedCombination();
        }

        private void RefreshSelectedCombination()
        {
            listBox1.Items.Clear();
            for (int i = 0; i < m_listCombination.Count; i++)
            {
                listBox1.Items.Add(m_listCombination[i].nCount.ToString() + m_listCombination[i].ct.ToString());
            }
        }

        private void RefreshNeedCombination()
        {
            panel1.Controls.Clear();
            for (int i = 0; i < m_listAllHeros.Count; i++)
            {
                GroupBox gb = new GroupBox();
                gb.Dock = DockStyle.Top;
                gb.Size = new Size(376, 138);
                gb.Text = m_listAllHeros[i].ct.ToString();
                gb.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;
                flp.AutoScroll = true;
                gb.Controls.Add(flp);
                for (int j = 0; j < m_listAllHeros[i].m_listNeedHeros.Count; j++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(60, 60);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = m_listAllHeros[i].m_listNeedHeros[j].image;
                    flp.Controls.Add(pb);
                }
                panel1.Controls.Add(gb);
            }

            GenerateMinCombination();
        }

        private void GenerateMinCombination()
        {
            panel2.Controls.Clear();
            if (m_listAllHeros.Count != 0)
            {
                //去除重复的英雄
                List<IHero> m_listUniqueHeros = new List<IHero>();
                for (int i = 0; i < m_listAllHeros.Count; i++)
                {
                    for (int j = 0; j < m_listAllHeros[i].m_listNeedHeros.Count; j++)
                    {
                        if (m_listUniqueHeros.IndexOf(m_listAllHeros[i].m_listNeedHeros[j]) == -1)
                        {
                            m_listUniqueHeros.Add(m_listAllHeros[i].m_listNeedHeros[j]);
                        }
                    }
                }

                //选取符合多属性的英雄
                List<IHero> m_listDoubleAttribute = new List<IHero>();
                for (int i = 0; i < m_listUniqueHeros.Count; i++)
                {
                    int[] judge = new int[m_listCombination.Count];
                    for (int j = 0; j < m_listCombination.Count; j++)
                    {
                        if ((m_listUniqueHeros[i].ct & m_listCombination[j].ct) == m_listCombination[j].ct)
                        {
                            judge[j] = 1;
                        }
                    }
                    int AttributeCount = 0;
                    for (int k = 0; k < judge.Length; k++)
                    {
                        if (judge[k] == 1)
                        {
                            AttributeCount++;
                        }
                    }
                    if (AttributeCount >= 2)
                    {
                        m_listDoubleAttribute.Add(m_listUniqueHeros[i]);
                    }
                }
                //移除符合多属性的英雄，减少选取数量
                for (int i = 0; i < m_listDoubleAttribute.Count; i++)
                {
                    for (int j = 0; j < m_listCombination.Count; j++)
                    {
                        if ((m_listDoubleAttribute[i].ct & m_listCombination[j].ct) == m_listCombination[j].ct)
                        {
                            m_listCombination[j].nCount--;
                        }
                    }
                    m_listUniqueHeros.Remove(m_listDoubleAttribute[i]);
                }

                List<IHero> m_listMinHeros = m_listDoubleAttribute;
                for (int i = 0; i < m_listUniqueHeros.Count; i++)
                {
                    int[] judge = new int[m_listCombination.Count];
                    for (int j = 0; j < m_listCombination.Count; j++)
                    {
                        if ((m_listUniqueHeros[i].ct & m_listCombination[j].ct) == m_listCombination[j].ct)
                        {
                            if (m_listCombination[j].nCount > 0)
                            {
                                m_listCombination[j].nCount--;
                                judge[j] = 1;
                            }
                        }
                    }
                    if ((judge.ToList().IndexOf(1) != -1) && (m_listMinHeros.IndexOf(m_listUniqueHeros[i]) == -1))
                    {
                        m_listMinHeros.Add(m_listUniqueHeros[i]);
                    }
                }

                GroupBox gb = new GroupBox();
                gb.Dock = DockStyle.Fill;
                gb.Size = new Size(376, 138);
                gb.Text = "";
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;
                flp.AutoScroll = true;
                gb.Controls.Add(flp);
                for (int j = 0; j < m_listMinHeros.Count; j++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(60, 60);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = m_listMinHeros[j].image;
                    flp.Controls.Add(pb);
                }
                panel2.Controls.Add(gb);
            }
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            checkBox_CheckedChanged(null, new EventArgs());
            if (m_listCombination.Count > 0)
            {
                panel1.BackColor = Color.Ivory;
                panel2.BackColor = Color.Ivory;
            }
            else
            {
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
            }
            //选取所有需要的英雄
            m_listAllHeros.Clear();
            for (int i = 0; i < m_listCombination.Count; i++)
            {
                NeedHeros nh = new NeedHeros();
                nh.ct = m_listCombination[i].ct;
                for (int j = 0; j < m_listHero.Count; j++)
                {
                    if ((m_listHero[j].ct & m_listCombination[i].ct) == m_listCombination[i].ct)
                    {
                        nh.m_listNeedHeros.Add(m_listHero[j]);
                    }
                }
                m_listAllHeros.Add(nh);
            }
            RefreshNeedCombination();
        }
    }
}
