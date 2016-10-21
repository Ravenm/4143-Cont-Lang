using System.Windows.Forms;

namespace Shapes
{
    partial class ShapeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCylinder = new System.Windows.Forms.Button();
            this.BtnBox = new System.Windows.Forms.Button();
            this.BtnCube = new System.Windows.Forms.Button();
            this.BtnCircle = new System.Windows.Forms.Button();
            this.BtnRect = new System.Windows.Forms.Button();
            this.BtnSquare = new System.Windows.Forms.Button();
            this.XText = new System.Windows.Forms.TextBox();
            this.YText = new System.Windows.Forms.TextBox();
            this.HeightText = new System.Windows.Forms.TextBox();
            this.WidthText = new System.Windows.Forms.TextBox();
            this.XLable = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLable = new System.Windows.Forms.Label();
            this.DepthText = new System.Windows.Forms.TextBox();
            this.DepthLable = new System.Windows.Forms.Label();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.ShapePic = new System.Windows.Forms.PictureBox();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.RadiusText = new System.Windows.Forms.TextBox();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShapePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCylinder);
            this.panel1.Controls.Add(this.BtnBox);
            this.panel1.Controls.Add(this.BtnCube);
            this.panel1.Controls.Add(this.BtnCircle);
            this.panel1.Controls.Add(this.BtnRect);
            this.panel1.Controls.Add(this.BtnSquare);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 183);
            this.panel1.TabIndex = 0;
            // 
            // BtnCylinder
            // 
            this.BtnCylinder.Location = new System.Drawing.Point(68, 153);
            this.BtnCylinder.Name = "BtnCylinder";
            this.BtnCylinder.Size = new System.Drawing.Size(75, 23);
            this.BtnCylinder.TabIndex = 5;
            this.BtnCylinder.Text = "Cylinder";
            this.BtnCylinder.UseVisualStyleBackColor = true;
            this.BtnCylinder.Click += new System.EventHandler(this.BtnCylinder_Click);
            // 
            // BtnBox
            // 
            this.BtnBox.Location = new System.Drawing.Point(68, 123);
            this.BtnBox.Name = "BtnBox";
            this.BtnBox.Size = new System.Drawing.Size(75, 23);
            this.BtnBox.TabIndex = 4;
            this.BtnBox.Text = "Box";
            this.BtnBox.UseVisualStyleBackColor = true;
            this.BtnBox.Click += new System.EventHandler(this.BtnBox_Click);
            // 
            // BtnCube
            // 
            this.BtnCube.Location = new System.Drawing.Point(68, 93);
            this.BtnCube.Name = "BtnCube";
            this.BtnCube.Size = new System.Drawing.Size(75, 23);
            this.BtnCube.TabIndex = 3;
            this.BtnCube.Text = "Cube";
            this.BtnCube.UseVisualStyleBackColor = true;
            this.BtnCube.Click += new System.EventHandler(this.BtnCube_Click);
            // 
            // BtnCircle
            // 
            this.BtnCircle.Location = new System.Drawing.Point(68, 63);
            this.BtnCircle.Name = "BtnCircle";
            this.BtnCircle.Size = new System.Drawing.Size(75, 23);
            this.BtnCircle.TabIndex = 2;
            this.BtnCircle.Text = "Circle";
            this.BtnCircle.UseVisualStyleBackColor = true;
            this.BtnCircle.Click += new System.EventHandler(this.BtnCircle_Click);
            // 
            // BtnRect
            // 
            this.BtnRect.Location = new System.Drawing.Point(68, 33);
            this.BtnRect.Name = "BtnRect";
            this.BtnRect.Size = new System.Drawing.Size(75, 23);
            this.BtnRect.TabIndex = 1;
            this.BtnRect.Text = "Rectangle";
            this.BtnRect.UseVisualStyleBackColor = true;
            this.BtnRect.Click += new System.EventHandler(this.BtnRect_Click);
            // 
            // BtnSquare
            // 
            this.BtnSquare.Location = new System.Drawing.Point(68, 3);
            this.BtnSquare.Name = "BtnSquare";
            this.BtnSquare.Size = new System.Drawing.Size(75, 23);
            this.BtnSquare.TabIndex = 0;
            this.BtnSquare.Text = "Square";
            this.BtnSquare.UseVisualStyleBackColor = true;
            this.BtnSquare.Click += new System.EventHandler(this.BtnSquare_Click);
            // 
            // XText
            // 
            this.XText.Location = new System.Drawing.Point(243, 45);
            this.XText.Name = "XText";
            this.XText.Size = new System.Drawing.Size(35, 20);
            this.XText.TabIndex = 1;
            this.XText.TextChanged += new System.EventHandler(this.XText_TextChanged);
            // 
            // YText
            // 
            this.YText.Location = new System.Drawing.Point(243, 71);
            this.YText.Name = "YText";
            this.YText.Size = new System.Drawing.Size(35, 20);
            this.YText.TabIndex = 2;
            this.YText.TextChanged += new System.EventHandler(this.YText_TextChanged);
            // 
            // HeightText
            // 
            this.HeightText.Location = new System.Drawing.Point(243, 97);
            this.HeightText.Name = "HeightText";
            this.HeightText.Size = new System.Drawing.Size(35, 20);
            this.HeightText.TabIndex = 3;
            this.HeightText.TextChanged += new System.EventHandler(this.HeightText_TextChanged);
            // 
            // WidthText
            // 
            this.WidthText.Location = new System.Drawing.Point(243, 123);
            this.WidthText.Name = "WidthText";
            this.WidthText.Size = new System.Drawing.Size(35, 20);
            this.WidthText.TabIndex = 4;
            this.WidthText.TextChanged += new System.EventHandler(this.WidthText_TextChanged);
            // 
            // XLable
            // 
            this.XLable.AutoSize = true;
            this.XLable.Location = new System.Drawing.Point(284, 48);
            this.XLable.Name = "XLable";
            this.XLable.Size = new System.Drawing.Size(39, 13);
            this.XLable.TabIndex = 5;
            this.XLable.Text = "X Cord";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(284, 74);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(39, 13);
            this.YLabel.TabIndex = 6;
            this.YLabel.Text = "Y Cord";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(284, 100);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 7;
            this.HeightLabel.Text = "Height";
            // 
            // WidthLable
            // 
            this.WidthLable.AutoSize = true;
            this.WidthLable.Location = new System.Drawing.Point(284, 126);
            this.WidthLable.Name = "WidthLable";
            this.WidthLable.Size = new System.Drawing.Size(35, 13);
            this.WidthLable.TabIndex = 8;
            this.WidthLable.Text = "Width";
            // 
            // DepthText
            // 
            this.DepthText.Location = new System.Drawing.Point(243, 149);
            this.DepthText.Name = "DepthText";
            this.DepthText.Size = new System.Drawing.Size(35, 20);
            this.DepthText.TabIndex = 9;
            this.DepthText.TextChanged += new System.EventHandler(this.DepthText_TextChanged);
            // 
            // DepthLable
            // 
            this.DepthLable.AutoSize = true;
            this.DepthLable.Location = new System.Drawing.Point(284, 149);
            this.DepthLable.Name = "DepthLable";
            this.DepthLable.Size = new System.Drawing.Size(36, 13);
            this.DepthLable.TabIndex = 10;
            this.DepthLable.Text = "Depth";
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(12, 201);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.Size = new System.Drawing.Size(225, 209);
            this.OutputBox.TabIndex = 11;
            this.OutputBox.Text = "";
            // 
            // ShapePic
            // 
            this.ShapePic.Location = new System.Drawing.Point(243, 201);
            this.ShapePic.Name = "ShapePic";
            this.ShapePic.Size = new System.Drawing.Size(223, 205);
            this.ShapePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShapePic.TabIndex = 12;
            this.ShapePic.TabStop = false;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(372, 95);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(75, 23);
            this.BtnCalc.TabIndex = 13;
            this.BtnCalc.Text = "Calculate";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // RadiusText
            // 
            this.RadiusText.Location = new System.Drawing.Point(243, 175);
            this.RadiusText.Name = "RadiusText";
            this.RadiusText.Size = new System.Drawing.Size(35, 20);
            this.RadiusText.TabIndex = 14;
            this.RadiusText.TextChanged += new System.EventHandler(this.RadiusText_TextChanged);
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(284, 175);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(40, 13);
            this.RadiusLabel.TabIndex = 15;
            this.RadiusLabel.Text = "Radius";
            // 
            // ShapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 431);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.RadiusText);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.ShapePic);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.DepthLable);
            this.Controls.Add(this.DepthText);
            this.Controls.Add(this.WidthLable);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLable);
            this.Controls.Add(this.WidthText);
            this.Controls.Add(this.HeightText);
            this.Controls.Add(this.YText);
            this.Controls.Add(this.XText);
            this.Controls.Add(this.panel1);
            this.Name = "ShapeForm";
            this.Text = "Shapes OH MY!";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShapePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCylinder;
        private System.Windows.Forms.Button BtnBox;
        private System.Windows.Forms.Button BtnCube;
        private System.Windows.Forms.Button BtnCircle;
        private System.Windows.Forms.Button BtnRect;
        private System.Windows.Forms.Button BtnSquare;
        private TextBox XText;
        private TextBox YText;
        private TextBox HeightText;
        private System.Windows.Forms.TextBox WidthText;
        private System.Windows.Forms.Label XLable;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLable;
        private System.Windows.Forms.TextBox DepthText;
        private System.Windows.Forms.Label DepthLable;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.PictureBox ShapePic;
        private System.Windows.Forms.Button BtnCalc;
        private TextBox RadiusText;
        private Label RadiusLabel;
    }
}

