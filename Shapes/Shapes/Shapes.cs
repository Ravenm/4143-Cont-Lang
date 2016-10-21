using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class ShapeForm : Form
    {
        public ShapeForm()
        {
            InitializeComponent();
            DisableBox();
            BtnCalc.Enabled = false;
        }

        private Shape _selectedShape = new Shape();

        /// <summary>
        /// used to enable all buttons
        /// </summary>
        private void EnableBtns()
        {
            BtnSquare.Enabled = true;
            BtnRect.Enabled = true;
            BtnBox.Enabled = true;
            BtnCircle.Enabled = true;
            BtnCube.Enabled = true;
            BtnCylinder.Enabled = true;
        }

        /// <summary>
        /// set all fields back to default
        /// </summary>
        private void DisableBox()
        {
            HeightLabel.Text = "Height";
            WidthLable.Enabled = false;
            WidthText.Enabled = false;
            HeightLabel.Enabled = false;
            HeightText.Enabled = false;
            DepthLable.Enabled = false;
            DepthText.Enabled = false;
            HeightText.Clear();
            WidthText.Clear();
            DepthText.Clear();
            RadiusText.Clear();
            RadiusText.Enabled = false;
            RadiusLabel.Enabled = false;
        }

        /// <summary>
        /// Selects a square shape
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSquare_Click(object sender, EventArgs e)
        {
            EnableBtns();
            BtnSquare.Enabled = false;
            DisableBox();
            HeightLabel.Enabled = true;
            HeightText.Enabled = true;
            BtnCalc.Enabled = true;
            HeightLabel.Text = @"Height and Width";
            _selectedShape = new Square(new Point(0, 0));
        }

        /// <summary>
        /// Selects a rectangle shape
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRect_Click(object sender, EventArgs e)
        {
            EnableBtns();
            BtnRect.Enabled = false;
            DisableBox();
            HeightLabel.Enabled = true;
            HeightText.Enabled = true;
            WidthLable.Enabled = true;
            WidthText.Enabled = true;
            BtnCalc.Enabled = true;
            _selectedShape = new Rectangle(new Point(0, 0));
        }

        /// <summary>
        /// selects a circle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCircle_Click(object sender, EventArgs e)
        {
            EnableBtns();
            BtnCircle.Enabled = false;
            DisableBox();
            HeightText.Clear();
            RadiusLabel.Enabled = true;
            RadiusText.Enabled = true;
            BtnCalc.Enabled = true;
            _selectedShape = new Circle(new Point(0, 0));
        }

        /// <summary>
        /// selects a cube
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCube_Click(object sender, EventArgs e)
        {
            EnableBtns();
            BtnCube.Enabled = false;
            DisableBox();
            HeightLabel.Enabled = true;
            HeightLabel.Text = @"Height and Width";
            HeightText.Enabled = true;
            BtnCalc.Enabled = true;
            _selectedShape = new Cube(new Point(0, 0));
        }

        /// <summary>
        /// selects a box or 3d rectangle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBox_Click(object sender, EventArgs e)
        {
            EnableBtns();
            BtnBox.Enabled = false;
            DisableBox();
            WidthLable.Enabled = true;
            WidthText.Enabled = true;
            HeightLabel.Enabled = true;
            HeightText.Enabled = true;
            DepthText.Enabled = true;
            DepthLable.Enabled = true;
            BtnCalc.Enabled = true;
            _selectedShape = new Cube(new Point(0, 0));
        }

        /// <summary>
        /// selects a cylinder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCylinder_Click(object sender, EventArgs e)
        {
            EnableBtns();
            BtnCylinder.Enabled = false;
            DisableBox();
            RadiusLabel.Enabled = true;
            RadiusText.Enabled = true;
            DepthText.Enabled = true;
            DepthLable.Enabled = true;
            BtnCalc.Enabled = true;
            _selectedShape = new Cylender(new Point(0, 0));
        }

        /// <summary>
        /// calculate the information about a shape
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalc_Click(object sender, EventArgs e)
        {
            OutputBox.Clear();
            _selectedShape.MainPoint = new Point(Convert.ToInt32(XText.Text), Convert.ToInt32(YText.Text));
            if (HeightText.Text != "") _selectedShape.Height = Convert.ToInt32(HeightText.Text);
            if (WidthText.Text != "") _selectedShape.Width = Convert.ToInt32(WidthText.Text);
            if (DepthText.Text != "") _selectedShape.Depth = Convert.ToInt32(DepthText.Text);
            if (RadiusText.Text != "") _selectedShape.Radius = Convert.ToInt32(RadiusText.Text);

            _selectedShape.SetAttributes();
            OutputBox.Text = _selectedShape.ToString();
            ShapePic.ImageLocation = _selectedShape.Picture;
        }

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
        /// test feild for changes and remove bad chars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XText_TextChanged(object sender, EventArgs e)
        {
            var num = 0;
            if (XText.Text == string.Empty) return;
            if (int.TryParse(XText.Text, out num) || num < 0) return;
            ErrBox("Only Positive Numbers Allowed");
            XText.Text = XText.Text.TrimEnd(XText.Text[XText.Text.Length - 1]);
        }

        /// <summary>
        /// test feild for changes and remove bad chars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YText_TextChanged(object sender, EventArgs e)
        {
            var num = 0;
            if (YText.Text == string.Empty) return;
            if (int.TryParse(YText.Text, out num) || num < 0) return;
            ErrBox("Only Positive Numbers Allowed");
            YText.Text = YText.Text.TrimEnd(YText.Text[YText.Text.Length - 1]);
        }

        /// <summary>
        /// test feild for changes and remove bad chars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightText_TextChanged(object sender, EventArgs e)
        {
            var num = 0;
            if (HeightText.Text == string.Empty) return;
            if (int.TryParse(HeightText.Text, out num) || num < 0) return;
            ErrBox("Only Positive Numbers Allowed");
            HeightText.Text = HeightText.Text.TrimEnd(HeightText.Text[HeightText.Text.Length - 1]);
        }

        /// <summary>
        /// test feild for changes and remove bad chars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WidthText_TextChanged(object sender, EventArgs e)
        {
            var num = 0;
            if (WidthText.Text == string.Empty) return;
            if (int.TryParse(WidthText.Text, out num) || num < 0) return;
            ErrBox("Only Positive Numbers Allowed");
            WidthText.Text = WidthText.Text.TrimEnd(WidthText.Text[WidthText.Text.Length - 1]);
        }

        /// <summary>
        /// test feild for changes and remove bad chars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepthText_TextChanged(object sender, EventArgs e)
        {
            var num = 0;
            if (DepthText.Text == string.Empty) return;
            if (int.TryParse(DepthText.Text, out num) || num < 0) return;
            ErrBox("Only Positive Numbers Allowed");
            DepthText.Text = DepthText.Text.TrimEnd(DepthText.Text[DepthText.Text.Length - 1]);
        }

        /// <summary>
        /// test feild for changes and remove bad chars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadiusText_TextChanged(object sender, EventArgs e)
        {
            var num = 0;
            if (RadiusText.Text == string.Empty) return;
            if (int.TryParse(RadiusText.Text, out num) || num < 0) return;
            ErrBox("Only Positive Numbers Allowed");
            RadiusText.Text = RadiusText.Text.TrimEnd(RadiusText.Text[RadiusText.Text.Length - 1]);
        }
    }
}
