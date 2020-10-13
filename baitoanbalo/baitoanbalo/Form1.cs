using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace baitoanbalo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int maxItem;
        Item[] item;
        int[] x, xop;
        float maxW, cost, Weight, maxVal;
        
        private void load()
        {
            try
            {
                maxItem = Int32.Parse(txt_maxItem.Text);
                maxW = float.Parse(txt_maxW.Text);
                dgv_info.RowCount = maxItem;
            }
            catch
            {
                MessageBox.Show("Chỉ nhập số");
            }
        }

        bool comp(Item a, Item b)
        {
            float r1 = a.Value / a.Weight;
            float r2 = b.Value / b.Weight;
            return r1 < r2;
        }

        private void bt_nhap_Click(object sender, EventArgs e)
        {
            load();
        }

        private bool init()
        {
            item = new Item[maxItem];
            x = new int[maxItem];
            xop = new int[maxItem];
            for (int i = 0; i < maxItem; i++)
            {
                item[i] = new Item();
                if (dgv_info.Rows[i].Cells["wei"].Value != null &&
                    dgv_info.Rows[i].Cells["val"].Value != null &&
                    dgv_info.Rows[i].Cells["item_name"].Value != null)
                {
                    item[i].Weight = float.Parse(dgv_info.Rows[i].Cells["wei"].Value.ToString());
                    item[i].Value = float.Parse(dgv_info.Rows[i].Cells["val"].Value.ToString());
                    item[i].Name = dgv_info.Rows[i].Cells["item_name"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Sai hoặc thiếu dữ liệu");
                    return false;
                }
            }
            return true;
        }

        private void nhanhcan(int i)
        {
            int j;
            int t = (int)((maxW - Weight)/  item[i].Weight);
            for (j = t; j >= 0; j--)
            {
                x[i] = j;
                Weight += item[i].Weight * x[i];
                cost += item[i].Value * x[i];
                if (i == maxItem-1) 
                    update();
                else if (cost + item[i + 1].Value * (int)((maxW - Weight) / item[i + 1].Weight) > maxVal)
                    nhanhcan(i + 1);
                Weight -= item[i].Weight * x[i];
                cost -= item[i].Value * x[i];
            }
        }

        private void update()
        {
            if(cost>maxVal)
            {
                for(int i=0;i<maxItem;i++)
                {
                    xop[i] = x[i];
                    maxVal = cost;
                }
            }
        }

        private void result()
        {
            txt_sum_val.Text = maxVal.ToString();
            float W=0;
            txt_name.ResetText();
            for(int i =0;i<maxItem;i++)
            {
                if(xop[i]!=0)
                {
                    W += item[i].Weight * xop[i];
                    txt_name.Text += item[i].Name + " lấy " + xop[i] + "\r\n";
                }
            }
            txt_sum_w.Text = W.ToString();
        }

        private void start()
        {
            Item t;
            maxVal = 0; Weight = 0;
            for (int i = 0; i < maxItem-1; i++)
                for (int j = i+1; j < maxItem; j++)
                    if (comp(item[i],item[j]))
                    {
                        t = item[i];
                        item[i] = item[j];
                        item[j] = t;
                    }
        }

        private void bt_result_Click(object sender, EventArgs e)
        {
            if(dgv_info.RowCount==0)
            {
                MessageBox.Show("Chưa nhập dữ liệu");
                return;
            }
            if (init() == false)
                return;
            start();
            nhanhcan(0);
            result();
        }
    }
}
