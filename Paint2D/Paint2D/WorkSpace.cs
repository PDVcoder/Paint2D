using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint2D
{
    public partial class WorkSpace : Form
    {
        public Bitmap bmp, snap;
        int xStart, yStart, xEnd, yEnd;
        public int[] sizeOfPictureBox = new int[2];
        public bool drawing = false, RButton = true;

        int[] ftx = new int[5] { 1, 1, 1, 1, 1 };
        int[] fty = new int[5] { 1, 1, 1, 1, 1 };

        public int pencil = 1;
        //Конструктор
        public WorkSpace()
        {
            Graphics whiteBMP;
            InitializeComponent();
            sizeOfPictureBox[0] = picture.Width;
            sizeOfPictureBox[1] = picture.Height;
            bmp = new Bitmap(sizeOfPictureBox[0], sizeOfPictureBox[1]);
            snap = new Bitmap(sizeOfPictureBox[0], sizeOfPictureBox[1]);
            //xEnd = yEnd = 0;
            whiteBMP = Graphics.FromImage(bmp);
            whiteBMP.Clear(Color.White);
            widthTextbox.Text = Convert.ToString(trackBarWidthOfPen.Value);
        }

        
        
        //Функція створення нової форми
        public void newPCTR(int w, int h)
        {
            Graphics whiteBMP, whiteSNAP;
            bmp.Dispose();
            snap.Dispose();
            bmp = new Bitmap(w, h);
            snap = new Bitmap(w, h);
            picture.Width = w;
            picture.Height = h;
            picture.Image = null;
            sizeOfPictureBox[0] = w;
            sizeOfPictureBox[1] = h;
            whiteBMP = Graphics.FromImage(bmp);
            whiteSNAP = Graphics.FromImage(snap);
            whiteBMP.Clear(Color.White);
            whiteSNAP.Clear(Color.White);
            picture.Image = bmp;
        }

        //Збереження рисунка
        public void savePictures()
        {
            saveImageDialog.ShowDialog();
            if (saveImageDialog.FileName != "")
            {
                bmp.Save(saveImageDialog.FileName);
            }
        }

        //Вибір кольору
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ToolStripButton b = (ToolStripButton)sender;
            buttonCurrentCollor.BackColor = b.BackColor;
        }

        //Збереження
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savePictures();
        }

        //Відкрити
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openImageDialog.ShowDialog();
            if (openImageDialog.FileName != "")
            {
                bmp = (Bitmap)Image.FromFile(openImageDialog.FileName);
                picture.Width = bmp.Width;
                picture.Height = bmp.Height;
                picture.Image = bmp;
                snap = bmp;
            }
        }

        //Вихід
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Вибір поточного кольору
        private void buttonCurrentCollor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            buttonCurrentCollor.BackColor = colorDialog1.Color;
        }

        //Обробка моменту натискання
        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            xStart = e.X;
            yStart = e.Y;
            drawing = true;
            bmp = (Bitmap)snap.Clone();
        }

        // Коефіціент побудови фракталів
        private void fracktalCtrackBar1_ValueChanged(object sender, EventArgs e)
        {
            fracktalCtextBox.Text = Convert.ToString(fracktalCtrackBar1.Value);
            //fractal.devcof = Convert.ToDouble(fracktalCtrackBar1.Value) / 1000;
        }

        // Обробка текстового поля для коефіцієнту побудови фракталів
        private void fracktalCtextBox_TextChanged(object sender, EventArgs e)
        {
            if (fracktalCtextBox.Text != "")
            {
                try
                {
                    int val = Convert.ToInt32(fracktalCtextBox.Text);
                    if (val > fracktalCtrackBar1.Maximum) fracktalCtrackBar1.Value = fracktalCtrackBar1.Maximum;
                    else if (val < fracktalCtrackBar1.Minimum) fracktalCtrackBar1.Value = fracktalCtrackBar1.Minimum;
                    else fracktalCtrackBar1.Value = Convert.ToInt32(fracktalCtextBox.Text);
                    //fractal.devcof = Convert.ToDouble(fracktalCtrackBar1.Value) / 1000;
                }
                catch (Exception)
                {
                    fracktalCtextBox.Text = "1";
                }
            }
        }

        private void isFractalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = isFractalCheckBox.Checked;
            fracktalCtextBox.Visible = isFractalCheckBox.Checked;
            fracktalCtrackBar1.Visible = isFractalCheckBox.Checked;
        }

        private void eraseButton_Click(object sender, EventArgs e)
        {
            pencil = 101;
            toolCurrentPicture.BackgroundImageLayout = ImageLayout.Stretch;
            toolCurrentPicture.BackgroundImage = eraseButton.BackgroundImage;
        }

        //Вибір об'єкту малювання
        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            ToolStripButton b = (ToolStripButton)sender;
            pencil = Convert.ToInt32(b.Text);
            toolCurrentPicture.BackgroundImage = b.Image;
        }

        //Зміна ширини в текстовому полі
        private void trackBarWidthOfPen_ValueChanged(object sender, EventArgs e)
        {
            widthTextbox.Text = Convert.ToString(trackBarWidthOfPen.Value);
        }

        //Обробка текст боксу товщини лінії
        private void widthTextbox_TextChanged(object sender, EventArgs e)
        {
            if (widthTextbox.Text != "")
            {
                try
                {
                    int val = Convert.ToInt32(widthTextbox.Text);
                    if (val > trackBarWidthOfPen.Maximum) trackBarWidthOfPen.Value = trackBarWidthOfPen.Maximum;
                    else if (val < trackBarWidthOfPen.Minimum) trackBarWidthOfPen.Value = trackBarWidthOfPen.Minimum;
                    else trackBarWidthOfPen.Value = Convert.ToInt32(widthTextbox.Text);
                }
                catch (Exception)
                {
                    widthTextbox.Text = "1";
                }        
            }
        }


        //Очищення поля
        private void clearButton_Click(object sender, EventArgs e)
        {
            newPCTR(sizeOfPictureBox[0], sizeOfPictureBox[1]);
            //bmp.Dispose();
            //snap.Dispose();
            //bmp = new Bitmap(widthOfNewPicture, heightOfNewPicture);
            //snap = new Bitmap(widthOfNewPicture, heightOfNewPicture);
            //Graphics g = Graphics.FromImage(bmp);
            //Pen p = new Pen(Color.White, 1);
            //g.Clear(Color.White);
            //g.DrawLine(p, 0, 0, 1, 1);
            //picture.Image = null;
        }

        //Малювання
        private void picture_Paint(object sender, PaintEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);

                Pen penL = new Pen(buttonCurrentCollor.BackColor, trackBarWidthOfPen.Value);
                Pen penR = new Pen(buttonRigthDraw.BackColor, trackBarWidthOfPen.Value);

                penL.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                penL.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                penR.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                penR.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                if (bmp != null)
                {
                    switch (pencil)
                    {
                        //Крива
                        case 1:
                            if (RButton) g.DrawLine(penL, xStart, yStart, xEnd, yEnd);
                            else if (!RButton) g.DrawLine(penR, xStart, yStart, xEnd, yEnd);
                            xStart = xEnd;
                            yStart = yEnd;
                            break;
                        //Прямий відрізок
                        case 2:
                            if (RButton) g.DrawLine(penL, xStart, yStart, xEnd, yEnd);
                            else if (!RButton) g.DrawLine(penR, xStart, yStart, xEnd, yEnd);
                            break;
                        //Коло
                        case 3:
                            if (RButton) g.DrawEllipse(penL, xStart, yStart, xEnd - xStart, yEnd - yStart);
                            else if (!RButton) g.DrawEllipse(penR, xStart, yStart, xEnd - xStart, yEnd - yStart);
                            break;
                        //Прямокутник
                        case 4:
                            if (xStart < xEnd && yStart < yEnd)
                            {
                                if (RButton) g.DrawRectangle(penL, xStart, yStart, xEnd - xStart, yEnd - yStart);
                                else if (!RButton) g.DrawRectangle(penR, xStart, yStart, xEnd - xStart, yEnd - yStart);
                                ftx[1] = xStart;
                                fty[1] = yStart;
                                ftx[2] = xEnd;
                                fty[2] = yEnd;
                            }
                            else if (xStart < xEnd && yStart > yEnd)
                            {
                                if (RButton) g.DrawRectangle(penL, xStart, yEnd, xEnd - xStart, yStart - yEnd);
                                else if (!RButton) g.DrawRectangle(penR, xStart, yEnd, xEnd - xStart, yStart - yEnd);
                                ftx[1] = xStart;
                                fty[1] = yEnd;
                                ftx[2] = xEnd;
                                fty[2] = yStart;
                            }
                            else if (xStart > xEnd && yStart < yEnd)
                            {
                                if (RButton) g.DrawRectangle(penL, xEnd, yStart, xStart - xEnd, yEnd - yStart);
                                else if (!RButton) g.DrawRectangle(penR, xEnd, yStart, xStart - xEnd, yEnd - yStart);
                                ftx[1] = xEnd;
                                fty[1] = yStart;
                                ftx[2] = xStart;
                                fty[2] = yEnd;
                            }
                            else
                            {
                                if (RButton) g.DrawRectangle(penL, xEnd, yEnd, xStart - xEnd, yStart - yEnd);
                                else if (!RButton) g.DrawRectangle(penR, xEnd, yEnd, xStart - xEnd, yStart - yEnd);
                                ftx[1] = xEnd;
                                fty[1] = yEnd;
                                ftx[2] = xStart;
                                fty[2] = yStart;
                            }
                            break;
                        // Трикутник рівнобедренний
                        case 5:
                            if (RButton)
                            {
                                g.DrawLine(penL, xStart, yEnd, xEnd, yEnd);
                                g.DrawLine(penL, xStart, yEnd, xStart + ((xEnd - xStart) / 2), yStart);
                                g.DrawLine(penL, xStart + ((xEnd - xStart) / 2), yStart, xEnd, yEnd);
                            }
                            else if (!RButton)
                            {
                                g.DrawLine(penR, xStart, yEnd, xEnd, yEnd);
                                g.DrawLine(penR, xStart, yEnd, xStart + ((xEnd - xStart) / 2), yStart);
                                g.DrawLine(penR, xStart + ((xEnd - xStart) / 2), yStart, xEnd, yEnd);
                            }
                            ftx[1] = xStart;
                            fty[1] = yEnd;
                            ftx[2] = xStart + ((xEnd - xStart) / 2);
                            fty[2] = yStart;
                            ftx[3] = xEnd;
                            fty[3] = yEnd;
                            break;
                        // Трикутник прямокутний
                        case 6:
                            if (RButton)
                            {
                                g.DrawLine(penL, xStart, yStart, xEnd, yEnd);
                                g.DrawLine(penL, xStart, yEnd, xEnd, yEnd);
                                g.DrawLine(penL, xStart, yStart, xStart, yEnd);
                            }
                            else if (!RButton)
                            {
                                g.DrawLine(penR, xStart, yStart, xEnd, yEnd);
                                g.DrawLine(penR, xStart, yEnd, xEnd, yEnd);
                                g.DrawLine(penR, xStart, yStart, xStart, yEnd);
                            }
                            ftx[1] = xStart;
                            fty[1] = yStart;
                            ftx[2] = xStart;
                            fty[2] = yEnd;
                            ftx[3] = xEnd;
                            fty[3] = yEnd;
                            break;
                        // Ромб
                        case 7:
                            if (RButton)
                            {
                                g.DrawLine(penL, xStart + (xEnd - xStart) / 2, yStart, xEnd, yStart + (yEnd - yStart) / 2);
                                g.DrawLine(penL, xStart + (xEnd - xStart) / 2, yStart, xStart, yStart + (yEnd - yStart) / 2);
                                g.DrawLine(penL, xStart, yStart + (yEnd - yStart) / 2, xStart + (xEnd - xStart) / 2, yEnd);
                                g.DrawLine(penL, xStart + (xEnd - xStart) / 2, yEnd, xEnd, yStart + (yEnd - yStart) / 2);
                            }
                            else if (!RButton)
                            {
                                g.DrawLine(penR, xStart + (xEnd - xStart) / 2, yStart, xEnd, yStart + (yEnd - yStart) / 2);
                                g.DrawLine(penR, xStart + (xEnd - xStart) / 2, yStart, xStart, yStart + (yEnd - yStart) / 2);
                                g.DrawLine(penR, xStart, yStart + (yEnd - yStart) / 2, xStart + (xEnd - xStart) / 2, yEnd);
                                g.DrawLine(penR, xStart + (xEnd - xStart) / 2, yEnd, xEnd, yStart + (yEnd - yStart) / 2);
                            }
                            ftx[1] = xStart + (xEnd - xStart) / 2;
                            fty[1] = yStart;
                            ftx[2] = xEnd;
                            fty[2] = yStart + (yEnd - yStart) / 2;
                            ftx[3] = xStart;
                            fty[3] = yStart + (yEnd - yStart) / 2;
                            ftx[4] = xStart + (xEnd - xStart) / 2;
                            fty[4] = yEnd;
                            break;
                        case 101:
                            penL.Color = Color.White;
                            g.DrawLine(penL, xStart, yStart, xEnd, yEnd);
                            xStart = xEnd;
                            yStart = yEnd;
                            break;
                        default:
                            break;
                    }
                }
                penR.Dispose();
                penL.Dispose();
                e.Graphics.DrawImageUnscaled(bmp, 0, 0);
                g.Dispose();
            }
        }

        //Обробка в момент відпускання клавіші
        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            Fractal fractal = new Fractal(Convert.ToDouble(fracktalCtextBox.Text) / 1000, this);
            drawing = false;
            snap = (Bitmap)bmp.Clone();
            if (isFractalCheckBox.Checked)
            {
                switch (pencil)
                {
                    case 4:
                        fractal.fractal_rect(buttonCurrentCollor.BackColor, ftx[1], fty[1], ftx[2], fty[2]);
                        picture.Image = bmp;
                        snap = bmp;
                        break;
                    case 5:
                    case 6:
                        fractal.fractal_tringle(buttonCurrentCollor.BackColor, ftx[1], fty[1], ftx[2], fty[2], ftx[3], fty[3]);
                        picture.Image = bmp;
                        snap = bmp;
                        break;
                    case 7:
                        fractal.fractal_romb(buttonCurrentCollor.BackColor, ftx[1], fty[1], ftx[2], fty[2], ftx[3], fty[3], ftx[4], fty[4]);
                        picture.Image = bmp;
                        snap = bmp;
                        break;
                    default:
                        break;
                }
            }

        }

        //Вибір кольору ПКМ
        private void buttonRigthDraw_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            buttonRigthDraw.BackColor = colorDialog1.Color;
        }

        //Вибір кольору ПКМ в панелі
        private void toolStripButton1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                ToolStripButton b = (ToolStripButton)sender;
                buttonRigthDraw.BackColor = b.BackColor;
            }
        }

        //Створення нового рисунка
        private void pictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPictureDialog form = new NewPictureDialog(this);
            form.Show();
            SaveDialog form2 = new SaveDialog(this);
            form2.Show();
        }

        //Обробка натискань та координат під час малювання
        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) RButton = true;
            if (e.Button == MouseButtons.Right) RButton = false;
            if (drawing)
            {
                if (pencil != 1 && pencil != 101) bmp = (Bitmap)snap.Clone();
                xEnd = e.X;
                yEnd = e.Y;
                picture.Invalidate();
                picture.Update();
            }

        }

    }
}
