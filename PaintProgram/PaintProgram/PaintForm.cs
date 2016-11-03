using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;


/// <summary>
/// This simple program emulates microsoft paint
/// A user is able to create a picture, save it, load it
/// and clear the screen
/// There is an array of shapes and colours that can be
/// used.
/// Created by: Andrew Nash
/// Link to repo: https://github.com/Ravenm/4143-Cont-Lang
/// Color pallet created by: adriancs
/// Link to repo: 
/// http://www.codeproject.com/Tips/638824/Yet-Another-Color-Picker-for-Csharp-VB-NET-WinForm
/// </summary>
namespace PaintProgram
{
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();
            _graphics = panelDraw.CreateGraphics();
            _selectedColor = Color.Black;
            panelDraw.BackColor = Color.White;
            roundBtn.Checked = true;
            size8Btn.Checked = true;
            _bitmap = new Bitmap(panelDraw.Width, panelDraw.Height);
        }

        bool _startPaint = false;
        private Graphics _graphics;
        //nullable int for storing Null value  
        int? _initX = null;
        int? _initY = null;
        bool _drawSquare = false;
        bool _drawRectangle = false;
        bool _drawCircle = false;
        private int _selectedSize = 8;
        private Bitmap _bitmap;
        private Color _selectedColor;

        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(_bitmap, Point.Empty);
        }

        /// <summary>
        /// mouse down event looks to _draw** for what brush shape to use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelDraw_MouseDown(object sender, MouseEventArgs e)
        {
            _startPaint = true;
            using (_graphics = Graphics.FromImage(_bitmap))
            {
                if (_drawSquare)
                {
                    SolidBrush sb = new SolidBrush(_selectedColor);
                    _graphics.FillRectangle(sb, e.X, e.Y, _selectedSize, _selectedSize);
                    _startPaint = false;
                }
                if (_drawRectangle)
                {
                    SolidBrush sb = new SolidBrush(_selectedColor);
                    _graphics.FillRectangle(sb, e.X, e.Y, 2*_selectedSize, _selectedSize);
                    _startPaint = false;
                }
                if (_drawCircle)
                {
                    SolidBrush sb = new SolidBrush(_selectedColor);
                    _graphics.FillEllipse(sb, e.X, e.Y, _selectedSize, _selectedSize);
                    _startPaint = false;
                }
                panelDraw.Invalidate();
            }
        }

        /// <summary>
        /// turns off paintbrush when mouse is lifted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelDraw_MouseUp(object sender, MouseEventArgs e)
        {
            _startPaint = false;
            _initX = null;
            _initY = null;
        }

        /// <summary>
        /// tracks mouse movement and while button is down creates a line.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_startPaint) return;
            using (_graphics = Graphics.FromImage(_bitmap))
            {
                var p = new Pen(_selectedColor, _selectedSize);
                _graphics.DrawLine(p, new Point(_initX ?? e.X, _initY ?? e.Y), new Point(e.X, e.Y));
                _initX = e.X;
                _initY = e.Y;
            }
            panelDraw.Invalidate();
        }

        /// <summary>
        /// This is the clear controls
        /// </summary>
        #region clear screen

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ClearScreen()
        {
            using (_graphics = Graphics.FromImage(_bitmap))
            {
                _graphics.Clear(panelDraw.BackColor);
                panelDraw.BackColor = Color.White;
            }
            panelDraw.Invalidate();
        }        

        #endregion

        /// <summary>
        /// prompts user to confirm they want to close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(@"Do you want to Exit?", @"Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// gives user a chance to change their mind about closing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you want to Exit?", @"Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// uses bitmap to save the panel state or load an image to panel.
        /// NOTE: the image loaded does not need to be from the panel,
        /// however large images will cause issues when saving as bitmap
        /// has a limited size in this case and is easy to overflow.
        /// </summary>
        #region save/load btns

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                _bitmap = new Bitmap(openFileDialog1.FileName);
                panelDraw.Invalidate();
            }
            catch (IOException)
            {
                MessageBox.Show(@"There was an issue reading from file. Try again");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                _bitmap.Save(saveFileDialog1.FileName);
            }
            catch (IOException)
            {
                MessageBox.Show(@"There was some issue with saving check file name and try agian");
            }
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        #endregion

        /// <summary>
        /// Large group of controls that allow user to select a set of sizes.
        /// </summary>
        #region Menu Size

        private void SetSize(int size = 8)
        {
            freeFormSizeBox.Clear();
            _selectedSize = size;
        }

        private void px8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSize(8);
        }

        private void px9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSize(9);
        }

        private void px10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSize(10);
        }

        private void px11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSize(11);
        }

        private void px12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSize(12);
        }

        private void px13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSize(13);
        }

        private void size8Btn_Click(object sender, EventArgs e)
        {
            SetSize(8);
        }

        private void size9Btn_Click(object sender, EventArgs e)
        {
            SetSize(9);
        }

        private void size10Btn_Click(object sender, EventArgs e)
        {
            SetSize(10);
        }

        private void size11Btn_Click(object sender, EventArgs e)
        {
            SetSize(11);
        }

        private void size12Btn_Click(object sender, EventArgs e)
        {
            SetSize(12);
        }

        private void size13Btn_Click(object sender, EventArgs e)
        {
            SetSize(13);
        }

        #endregion

        /// <summary>
        /// set _draw** to be true for that shape so it can be drawn
        /// brush will set all shapes to false
        /// </summary>
        #region Menu Shapes

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetShapeFalse();
            _drawSquare = true;
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetShapeFalse();
            _drawCircle = true;
        }

        private void boxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetShapeFalse();
            _drawRectangle = true;
        }

        private void brushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetShapeFalse();
        }

        #endregion

        #region Shape Buttons

        private void roundBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetShapeFalse();
        }

        private void squareBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetShapeFalse();
        }

        private void boxBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetShapeFalse();
        }

        private void circleBtn_CheckedChanged(object sender, EventArgs e)
        {
            SetShapeFalse();
        }

        private void SetShapeFalse()
        {
            _drawCircle = false;
            _drawRectangle = false;
            _drawSquare = false;
        }

        private void circleBtn_Click(object sender, EventArgs e)
        {
            _drawCircle = true;
        }

        private void boxBtn_Click(object sender, EventArgs e)
        {
            _drawRectangle = true;
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            _drawSquare = true;
        }
        #endregion

        /// <summary>
        /// using a premade colour pallet to allow for selection of any colour
        /// </summary>
        #region Color selections

        private void themeColorPicker1_ColorSelected(object sender, ColorSelectedArg e)
        {
            _selectedColor = e.Color;
        }

        private void themeColorPickerToolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void themeColorPickerToolStripSplitButton1_ColorSelected(object sender, ColorSelectedArg e)
        {
            _selectedColor = e.Color;
        }
        #endregion

        /// <summary>
        /// oops box
        /// </summary>
        /// <param name="msg"></param>
        private void ErrBox(string msg)
        {
            MessageBox.Show(msg, @"Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// allows custom sizes unchecks radio buttons to let user know
        /// custom size is in use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void freeFormSizeBox_TextChanged(object sender, EventArgs e)
        {
            var num = 0;
            if (freeFormSizeBox.Text == string.Empty) return;
            if (int.TryParse(freeFormSizeBox.Text, out num))
            {
                _selectedSize = num;
                size8Btn.Checked = false;
                size9Btn.Checked = false;
                size10Btn.Checked = false;
                size11Btn.Checked = false;
                size12Btn.Checked = false;
                size13Btn.Checked = false;
                return;
            }
            ErrBox("Only Positive Numbers Allowed");
            freeFormSizeBox.Text = freeFormSizeBox.Text.TrimEnd(freeFormSizeBox.Text[freeFormSizeBox.Text.Length - 1]);
            _selectedSize = num;
        }
    }

}
