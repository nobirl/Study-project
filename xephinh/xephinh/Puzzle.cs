using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Dynamic;

namespace xephinh
{
    public partial class puzzle_form : Form
    {
        public puzzle_form()
        {
            InitializeComponent();
        }

        Image image;
        PictureBox box = null;
        OpenFileDialog op = null;
        PictureBox[] boxs = null;
        Image[] images = null;
        int[] lv = new int[5] { 2, 3, 4, 6, 10 };
        int curLv = 0;
        int[,] clue;
        int[,] suufe;
        private void choose_img_Click(object sender, EventArgs e)
        {
            if (op == null)
                op = new OpenFileDialog();
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                image = cre_bitmap(Image.FromFile(op.FileName));
                if (box == null)
                {
                    box = new PictureBox();
                    box.Height = puzzle.Height;
                    box.Width = puzzle.Width;
                    puzzle.Controls.Add(box);
                }
                box.Image = image;
            }
        }

        private Bitmap cre_bitmap(Image img)
        {
            Bitmap bm = new Bitmap(puzzle.Width, puzzle.Height);

            Graphics objGra = Graphics.FromImage(bm);
            objGra.Clear(Color.White);

            objGra.DrawImage(img, new Rectangle(0, 0, puzzle.Width, puzzle.Height));
            objGra.Flush();
            return bm;
        }

        private void cre_bitmap(Image image, Image[] images, int index, int lv, int size)
        {
            images[index] = new Bitmap(size, size);

            Graphics objGra = Graphics.FromImage(images[index]);
            objGra.Clear(Color.White);

            objGra.DrawImage(image,
                new Rectangle(0, 0, size, size),
                new Rectangle(size * (index % lv), size * (index / lv), size, size),
                GraphicsUnit.Pixel);
            objGra.Flush();
        }

        private void make_lv(int x)
        {
            if (box != null)
            {
                puzzle.Controls.Remove(box);
                box.Dispose();
                box = null;
            }
            if (box == null)
            {
                boxs = new PictureBox[x * x];
                images = new Image[x * x];
            }
            int size = puzzle.Width / x;
            int[] id = new int[x * x];

            try
            {
                for (int i = 0; i < x * x; i++)
                {
                    id[i] = i;
                    if (boxs[i] == null)
                    {
                        boxs[i] = new PtB();
                        boxs[i].BorderStyle = BorderStyle.Fixed3D;
                        boxs[i].Click += new EventHandler(puzzle_click);
                    }
                    boxs[i].Width = boxs[i].Height = size;
                    ((PtB)boxs[i]).Index = i;

                    cre_bitmap(image, images, i, x, size);

                    boxs[i].Location = new Point(size * (i % x), size * (i / x));
                    if (!puzzle.Controls.Contains(boxs[i]))
                        puzzle.Controls.Add(boxs[i]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa chọn ảnh");
                return;
            }

            clue = new int[x * x, x * x];
            suufe = new int[x,x];
            suffle(ref id);
            for (int i = 0; i < x * x; i++)
            {
                boxs[i].Image = images[id[i]];
                images[i].Tag = id[i];
                ((PtB)boxs[i]).ImageID = id[i];
            }
            int count = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    suufe[i, j] = id[count];
                    count++;
                }
            }

            suffle(ref id);
            for (int i = 0; i < x * x; i++)
            {
                for (int j = 0; j < x * x; j++)
                {
                    if (Int32.Parse(images[j].Tag.ToString()) == id[i])
                    {
                        boxs[i].Image = images[j];
                        ((PtB)boxs[i]).ImageID = id[i];
                        break;
                    }
                }
            }

            for (int i=0;i<x*x;i++)
            {
                for(int j=0;j<x*x;j++)
                {
                    clue[i, j] = 0;
                }
            }
        }

        private void bt_lv1_Click(object sender, EventArgs e)
        {
            curLv = lv[0];
            make_lv(curLv);
        }

        private void bt_lv2_Click(object sender, EventArgs e)
        {
            curLv = lv[1];
            make_lv(curLv);
        }

        private void bt_lv3_Click(object sender, EventArgs e)
        {
            curLv = lv[2];
            make_lv(curLv);
        }

        private void bt_lv4_Click(object sender, EventArgs e)
        {
            curLv = lv[3];
            make_lv(curLv);
        }

        private void bt_lv5_Click(object sender, EventArgs e)
        {
            curLv = lv[4];
            make_lv(curLv);
        }

        private void suffle(ref int[] arr)
        {
            Random rd = new Random();
            int n = arr.Length-1;
            while (n >= 1)
            {
                int k = rd.Next(n);
                n--;               
                int temp = arr[n];
                arr[n] = arr[k];
                arr[k] = temp;
            }
        }

        PtB box1 = null;
        PtB box2 = null;

        public void puzzle_click(object sender, EventArgs e)
        {
            if (box1 == null)
            {
                box1 = (PtB)sender;
                box1.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (box2 == null)
            {
                box2 = (PtB)sender;
                box1.BorderStyle = BorderStyle.Fixed3D;
                //box2.BorderStyle = BorderStyle.FixedSingle;
                switch_img(box1, box2);
                box1 = box2 = null;
            }
            /*if (check())
            {
                MessageBox.Show("Đã hoàn thành");
            }*/
            /*else
            {
                box1 = box2;
                box1.BorderStyle = BorderStyle.Fixed3D;
                box2 = (PtB)sender;
                box2.BorderStyle = BorderStyle.FixedSingle;
                switch_img(box1, box2);
            }*/
        }
        private void switch_img(PtB _box1, PtB _box2)
        {
            int temp = _box2.ImageID;
            PtB _box_t = new PtB();
            _box_t.Image = _box2.Image;
            _box2.Image = _box1.Image;
            _box2.ImageID = _box1.ImageID;
            _box1.Image = _box_t.Image;
            _box1.ImageID = temp;
            if (check())
            {
                MessageBox.Show("Đã hoàn thành");
            }
        }
        private bool check()
        {
            for (int i = 0; i < curLv * curLv; i++)
                /*if (((PtB)boxs[i]).ImageID != ((PtB)boxs[i]).Index)*/
                if (((PtB)boxs[i]).ImageID != Int32.Parse(images[i].Tag.ToString()))
                    return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            make_clue(curLv);
            row1(curLv);
            sort_auto(curLv);
        }

        private void row1(int col)
        {
            firstclue(col);
 
            for(int i=2;i<col;i++)
            {
                for (int j =i;j<col*col;j++)
                {
                    int x = i / col;
                    int y = j % col;
                    if (i != col - 1)
                    {
                        if(clue[suufe[x,i-1], ((PtB)boxs[j]).ImageID]== 1)
                        {
                            if (clue[((PtB)boxs[j]).ImageID, ((PtB)boxs[j]).ImageID] == 3)
                            {
                                if (j == i)
                                    break;
                                switch_img((PtB)boxs[i], (PtB)boxs[j]);
                                break;
                            }
                        }
                    }
                    else
                    {
                        if(clue[((PtB)boxs[j]).ImageID, ((PtB)boxs[j]).ImageID] == 2)
                        {
                            if(clue[suufe[x,i-1], ((PtB)boxs[j]).ImageID] == 1)
                            {
                                if (j == i)
                                    break;
                                switch_img((PtB)boxs[i], (PtB)boxs[j]);
                                break;
                            }
                        }
                        
                    }
                }
                //Thread.Sleep(500);
            }
        }

        private void firstclue(int col)
        {
            if(((PtB)boxs[0]).ImageID != suufe[0, 0])
                for(int i=1;i<col*col;i++)
                {
                    if (((PtB)boxs[i]).ImageID == suufe[0, 0])
                    {
                        switch_img((PtB)boxs[0], (PtB)boxs[i]);
                        break;
                    }
                }
            if (((PtB)boxs[1]).ImageID != suufe[0, 1])
                for (int i = 2; i < col * col; i++)
                {
                    if (((PtB)boxs[i]).ImageID == suufe[0, 1])
                    {
                        switch_img((PtB)boxs[1], (PtB)boxs[i]);
                        break;
                    }
                }
            /*for (int i = 0; i < col * col; i++)
            {
                if (((PtB)boxs[i]).ImageID == suufe[0,0] && i != 0)
                    switch_img((PtB)boxs[0], (PtB)boxs[i]);
                if (((PtB)boxs[i]).ImageID == suufe[0,1] && i != 1)
                    switch_img((PtB)boxs[1], (PtB)boxs[i]);
            }*/
        }

        private void make_clue(int lv)
        {
            int x=0,y=0,x1;
            for (int i = 0; i < lv * lv; i++)
            {
                /*for(int j=0;j<lv*lv;j++)
                {
                    if(((PtB)boxs[j]).ImageID==i)
                    {
                        x = j / lv;
                        y = j % lv;
                        break;
                    }
                }*/
                x1 = Int32.Parse(images[i].Tag.ToString());
                x = i / lv;
                y = i % lv;
                if(x==0)
                {
                    if(y==0)
                    {
                        clue[x1, x1] = 2;
                        clue[x1, suufe[x, y+1]] = 1;
                        clue[x1, suufe[x+1, y]] = 1;
                    }
                    else if(y==lv-1)
                    {
                        clue[x1, x1] = 2;
                        clue[x1, suufe[x, y-1]] = 1;
                        clue[x1, suufe[x+1, y]] = 1;
                    }
                    else
                    {
                        clue[x1, x1] = 3;
                        clue[x1, suufe[x, y-1]] = 1;
                        clue[x1, suufe[x, y+1]] = 1;
                        clue[x1, suufe[x + 1, y]] = 1;
                    }
                }
                else if(x==lv-1)
                {
                    if(y==0)
                    {
                        clue[x1, x1] = 2;
                        clue[x1, suufe[x, y + 1]] = 1;
                        clue[x1, suufe[x - 1, y]] = 1;
                    }
                    else if(y==lv-1)
                    {
                        clue[x1, x1] = 2;
                        clue[x1, suufe[x, y - 1]] = 1;
                        clue[x1, suufe[x - 1, y]] = 1;
                    }
                    else
                    {
                        clue[x1, x1] = 3;
                        clue[x1, suufe[x, y - 1]] = 1;
                        clue[x1, suufe[x, y + 1]] = 1;
                        clue[x1, suufe[x - 1, y]] = 1;
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        clue[x1, x1] = 3;
                        clue[x1, suufe[x, y + 1]] = 1;
                        clue[x1, suufe[x - 1, y]] = 1;
                        clue[x1, suufe[x + 1, y]] = 1;
                    }
                    else if (y == lv - 1)
                    {
                        clue[x1, x1] = 3;
                        clue[x1, suufe[x, y - 1]] = 1;
                        clue[x1, suufe[x - 1, y]] = 1;
                        clue[x1, suufe[x + 1, y]] = 1;
                    }
                    else
                    {
                        clue[x1, x1] = 4;
                        clue[x1, suufe[x, y + 1]] = 1;
                        clue[x1, suufe[x, y - 1]] = 1;
                        clue[x1, suufe[x + 1, y]] = 1;
                        clue[x1, suufe[x - 1, y]] = 1;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for(int i=0;i<curLv;i++)
            {
                for(int j=0;j<curLv;j++)
                {
                    label1.Text += (suufe[i, j] + "    ");
                }
                label1.Text += "\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            make_clue(curLv);
            label2.ResetText();
            for (int i = 0; i < curLv * curLv; i++)
            {
                for (int j = 0; j < curLv*curLv; j++)
                    label2.Text += clue[i, j] + "   ";
                label2.Text += "\n";
            }
                

        }

        private void sort_auto(int lv)
        {
            int x, y;
            for(int i=lv;i<lv*lv;i++)
            {
                for(int j=i;j<lv*lv;j++)
                {
                    x = i / lv;
                    y = i % lv;
                    if (y == 0)
                    {
                        if(clue[((PtB)boxs[j]).ImageID, suufe[x-1,y]] ==1)
                        {
                            if (i == j)
                                break;
                            switch_img((PtB)boxs[i], ((PtB)boxs[j]));
                            break;
                        }
                    }
                    else if(clue[((PtB)boxs[j]).ImageID,suufe[x,y-1]] == 1 &&
                        clue[((PtB)boxs[j]).ImageID, suufe[x-1, y]] ==1)
                    {
                        if (i == j)
                            break;
                        switch_img((PtB)boxs[i], ((PtB)boxs[j]));
                        break;
                    }
                }
            }
        }
    }
}
