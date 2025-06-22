using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cables;

namespace main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Cable> cables = new List<Cable>();
        List<EnhancedCable> enhancedCables = new List<EnhancedCable>();
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.ContextMenuStrip = contextMenuStrip1;
        }
        private string TryConvertDouble(string a)
        {
            if (!double.TryParse(a, out double n))
            {
                return "Ошибка";
            }
            return "";
        }

        private string SearchDigit(string a)
        {
            foreach (var c in tb_color.Text)
            {
                if (!char.IsLetter(c))
                {
                    return "Цвет не может содержать цифр";
                }
            }
            return "";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tb_type.Text == "" && tb_diam.Text == "" && tb_pr.Text == "" && tb_costForMeter.Text == "" && tb_color.Text == "" && cb_opl.Text == "")
            {
                MessageBox.Show("Заполните пустые поля");
            }
            else
            {
                if (TryConvertDouble(tb_diam.Text) != "" && TryConvertDouble(tb_costForMeter.Text) != "")
                {
                    MessageBox.Show(TryConvertDouble(tb_diam.Text));
                }
                else
                {
                    if(SearchDigit(tb_color.Text) != "")
                    {
                        MessageBox.Show(SearchDigit(tb_color.Text));
                    }
                    else
                    {
                        bool on = cb_opl.Text == "Да" ? true: false;

                        Cable.AddCable(cables, tb_type.Text, (int)nud_count.Value, double.Parse(tb_diam.Text), tb_pr.Text, double.Parse(tb_costForMeter.Text));
                        EnhancedCable.AddEnhancedCable(enhancedCables, tb_type.Text, (int)nud_count.Value, double.Parse(tb_diam.Text), tb_pr.Text, double.Parse(tb_costForMeter.Text), on, tb_color.Text);
                        listBox1.Items.Add(tb_type.Text);
                        tb_type.Text = "";
                        tb_pr.Text = "";
                        tb_diam.Text = "";
                        tb_costForMeter.Text = "";
                        tb_color.Text = "";
                        cb_opl.Text = "";
                        nud_count.Value = 1;
                    }
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cables.Count > 0)
            {
                Cable.RemoveCable(cables, cables[listBox1.SelectedIndex]);
                EnhancedCable.RemoveEnhancedCable(enhancedCables, enhancedCables[listBox1.SelectedIndex]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                label8.Text = "Информация: ";
            }
            else
            {
                MessageBox.Show("Список пуст");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = $"Информация:\n\n\n{enhancedCables[listBox1.SelectedIndex].DisplayInfo()}";
        }
    }
}
