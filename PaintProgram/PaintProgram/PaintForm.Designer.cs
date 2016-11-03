namespace PaintProgram
{
    partial class PaintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.themeColorPicker = new System.Windows.Forms.ThemeColorPicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.px8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.px9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.px10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.px11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.px12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.px13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeColorPickerToolStripSplitButton1 = new ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBrushSize = new System.Windows.Forms.GroupBox();
            this.size13Btn = new System.Windows.Forms.RadioButton();
            this.size12Btn = new System.Windows.Forms.RadioButton();
            this.size11Btn = new System.Windows.Forms.RadioButton();
            this.size10Btn = new System.Windows.Forms.RadioButton();
            this.size9Btn = new System.Windows.Forms.RadioButton();
            this.size8Btn = new System.Windows.Forms.RadioButton();
            this.groupBrushShape = new System.Windows.Forms.GroupBox();
            this.circleBtn = new System.Windows.Forms.RadioButton();
            this.boxBtn = new System.Windows.Forms.RadioButton();
            this.squareBtn = new System.Windows.Forms.RadioButton();
            this.roundBtn = new System.Windows.Forms.RadioButton();
            this.panelDraw = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.brushSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeFormSizeBox = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBrushSize.SuspendLayout();
            this.groupBrushShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // themeColorPicker
            // 
            this.themeColorPicker.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("themeColorPicker.BackgroundImage")));
            this.themeColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.themeColorPicker.Color = System.Drawing.Color.Empty;
            this.themeColorPicker.CustomColors = new int[0];
            this.themeColorPicker.Location = new System.Drawing.Point(562, 27);
            this.themeColorPicker.Name = "themeColorPicker";
            this.themeColorPicker.Size = new System.Drawing.Size(194, 166);
            this.themeColorPicker.TabIndex = 0;
            this.themeColorPicker.ColorSelected += new System.Windows.Forms.ThemeColorPicker.colorSelected(this.themeColorPicker1_ColorSelected);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.brushSizeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.aToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newToolStripMenuItem.Text = "Clear";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(151, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.saveToolStripMenuItem.Text = "Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.shapeToolStripMenuItem,
            this.colourToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.px8ToolStripMenuItem,
            this.px9ToolStripMenuItem,
            this.px10ToolStripMenuItem,
            this.px11ToolStripMenuItem,
            this.px12ToolStripMenuItem,
            this.px13ToolStripMenuItem});
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // px8ToolStripMenuItem
            // 
            this.px8ToolStripMenuItem.Name = "px8ToolStripMenuItem";
            this.px8ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.px8ToolStripMenuItem.Text = "8px";
            this.px8ToolStripMenuItem.Click += new System.EventHandler(this.px8ToolStripMenuItem_Click);
            // 
            // px9ToolStripMenuItem
            // 
            this.px9ToolStripMenuItem.Name = "px9ToolStripMenuItem";
            this.px9ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.px9ToolStripMenuItem.Text = "9px";
            this.px9ToolStripMenuItem.Click += new System.EventHandler(this.px9ToolStripMenuItem_Click);
            // 
            // px10ToolStripMenuItem
            // 
            this.px10ToolStripMenuItem.Name = "px10ToolStripMenuItem";
            this.px10ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.px10ToolStripMenuItem.Text = "10px";
            this.px10ToolStripMenuItem.Click += new System.EventHandler(this.px10ToolStripMenuItem_Click);
            // 
            // px11ToolStripMenuItem
            // 
            this.px11ToolStripMenuItem.Name = "px11ToolStripMenuItem";
            this.px11ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.px11ToolStripMenuItem.Text = "11px";
            this.px11ToolStripMenuItem.Click += new System.EventHandler(this.px11ToolStripMenuItem_Click);
            // 
            // px12ToolStripMenuItem
            // 
            this.px12ToolStripMenuItem.Name = "px12ToolStripMenuItem";
            this.px12ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.px12ToolStripMenuItem.Text = "12px";
            this.px12ToolStripMenuItem.Click += new System.EventHandler(this.px12ToolStripMenuItem_Click);
            // 
            // px13ToolStripMenuItem
            // 
            this.px13ToolStripMenuItem.Name = "px13ToolStripMenuItem";
            this.px13ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.px13ToolStripMenuItem.Text = "13px";
            this.px13ToolStripMenuItem.Click += new System.EventHandler(this.px13ToolStripMenuItem_Click);
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.boxToolStripMenuItem,
            this.brushToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shapeToolStripMenuItem.Text = "Shape";
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // boxToolStripMenuItem
            // 
            this.boxToolStripMenuItem.Name = "boxToolStripMenuItem";
            this.boxToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.boxToolStripMenuItem.Text = "Box";
            this.boxToolStripMenuItem.Click += new System.EventHandler(this.boxToolStripMenuItem_Click);
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.brushToolStripMenuItem.Text = "Brush";
            this.brushToolStripMenuItem.Click += new System.EventHandler(this.brushToolStripMenuItem_Click);
            // 
            // colourToolStripMenuItem
            // 
            this.colourToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeColorPickerToolStripSplitButton1});
            this.colourToolStripMenuItem.Name = "colourToolStripMenuItem";
            this.colourToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colourToolStripMenuItem.Text = "Colour";
            // 
            // themeColorPickerToolStripSplitButton1
            // 
            this.themeColorPickerToolStripSplitButton1.Color = System.Drawing.Color.White;
            this.themeColorPickerToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.themeColorPickerToolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("themeColorPickerToolStripSplitButton1.Image")));
            this.themeColorPickerToolStripSplitButton1.ImageHeight = 16;
            this.themeColorPickerToolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.themeColorPickerToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.themeColorPickerToolStripSplitButton1.ImageWidth = 32;
            this.themeColorPickerToolStripSplitButton1.Name = "themeColorPickerToolStripSplitButton1";
            this.themeColorPickerToolStripSplitButton1.Size = new System.Drawing.Size(48, 20);
            this.themeColorPickerToolStripSplitButton1.Text = "themeColorPickerToolStripSplitButton1";
            this.themeColorPickerToolStripSplitButton1.ColorSelected += new ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton.colorSelected(this.themeColorPickerToolStripSplitButton1_ColorSelected);
            this.themeColorPickerToolStripSplitButton1.ButtonClick += new System.EventHandler(this.themeColorPickerToolStripSplitButton1_ButtonClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.contentsToolStripMenuItem.Text = "No Help For You";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(667, 457);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Close";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(667, 428);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(75, 23);
            this.loadBtn.TabIndex = 3;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(667, 399);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(667, 370);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // groupBrushSize
            // 
            this.groupBrushSize.Controls.Add(this.size13Btn);
            this.groupBrushSize.Controls.Add(this.size12Btn);
            this.groupBrushSize.Controls.Add(this.size11Btn);
            this.groupBrushSize.Controls.Add(this.size10Btn);
            this.groupBrushSize.Controls.Add(this.size9Btn);
            this.groupBrushSize.Controls.Add(this.size8Btn);
            this.groupBrushSize.Location = new System.Drawing.Point(667, 199);
            this.groupBrushSize.Name = "groupBrushSize";
            this.groupBrushSize.Size = new System.Drawing.Size(89, 165);
            this.groupBrushSize.TabIndex = 6;
            this.groupBrushSize.TabStop = false;
            this.groupBrushSize.Text = "Brush Size";
            // 
            // size13Btn
            // 
            this.size13Btn.AutoSize = true;
            this.size13Btn.Location = new System.Drawing.Point(6, 134);
            this.size13Btn.Name = "size13Btn";
            this.size13Btn.Size = new System.Drawing.Size(48, 17);
            this.size13Btn.TabIndex = 5;
            this.size13Btn.TabStop = true;
            this.size13Btn.Text = "13px";
            this.size13Btn.UseVisualStyleBackColor = true;
            this.size13Btn.Click += new System.EventHandler(this.size13Btn_Click);
            // 
            // size12Btn
            // 
            this.size12Btn.AutoSize = true;
            this.size12Btn.Location = new System.Drawing.Point(6, 111);
            this.size12Btn.Name = "size12Btn";
            this.size12Btn.Size = new System.Drawing.Size(48, 17);
            this.size12Btn.TabIndex = 4;
            this.size12Btn.TabStop = true;
            this.size12Btn.Text = "12px";
            this.size12Btn.UseVisualStyleBackColor = true;
            this.size12Btn.Click += new System.EventHandler(this.size12Btn_Click);
            // 
            // size11Btn
            // 
            this.size11Btn.AutoSize = true;
            this.size11Btn.Location = new System.Drawing.Point(6, 88);
            this.size11Btn.Name = "size11Btn";
            this.size11Btn.Size = new System.Drawing.Size(48, 17);
            this.size11Btn.TabIndex = 3;
            this.size11Btn.TabStop = true;
            this.size11Btn.Text = "11px";
            this.size11Btn.UseVisualStyleBackColor = true;
            this.size11Btn.Click += new System.EventHandler(this.size11Btn_Click);
            // 
            // size10Btn
            // 
            this.size10Btn.AutoSize = true;
            this.size10Btn.Location = new System.Drawing.Point(6, 65);
            this.size10Btn.Name = "size10Btn";
            this.size10Btn.Size = new System.Drawing.Size(48, 17);
            this.size10Btn.TabIndex = 2;
            this.size10Btn.TabStop = true;
            this.size10Btn.Text = "10px";
            this.size10Btn.UseVisualStyleBackColor = true;
            this.size10Btn.Click += new System.EventHandler(this.size10Btn_Click);
            // 
            // size9Btn
            // 
            this.size9Btn.AutoSize = true;
            this.size9Btn.Location = new System.Drawing.Point(6, 42);
            this.size9Btn.Name = "size9Btn";
            this.size9Btn.Size = new System.Drawing.Size(42, 17);
            this.size9Btn.TabIndex = 1;
            this.size9Btn.TabStop = true;
            this.size9Btn.Text = "9px";
            this.size9Btn.UseVisualStyleBackColor = true;
            this.size9Btn.Click += new System.EventHandler(this.size9Btn_Click);
            // 
            // size8Btn
            // 
            this.size8Btn.AutoSize = true;
            this.size8Btn.Location = new System.Drawing.Point(6, 19);
            this.size8Btn.Name = "size8Btn";
            this.size8Btn.Size = new System.Drawing.Size(42, 17);
            this.size8Btn.TabIndex = 0;
            this.size8Btn.TabStop = true;
            this.size8Btn.Text = "8px";
            this.size8Btn.UseVisualStyleBackColor = true;
            this.size8Btn.Click += new System.EventHandler(this.size8Btn_Click);
            // 
            // groupBrushShape
            // 
            this.groupBrushShape.Controls.Add(this.circleBtn);
            this.groupBrushShape.Controls.Add(this.boxBtn);
            this.groupBrushShape.Controls.Add(this.squareBtn);
            this.groupBrushShape.Controls.Add(this.roundBtn);
            this.groupBrushShape.Location = new System.Drawing.Point(562, 200);
            this.groupBrushShape.Name = "groupBrushShape";
            this.groupBrushShape.Size = new System.Drawing.Size(99, 113);
            this.groupBrushShape.TabIndex = 7;
            this.groupBrushShape.TabStop = false;
            this.groupBrushShape.Text = "Brush Shape";
            // 
            // circleBtn
            // 
            this.circleBtn.AutoSize = true;
            this.circleBtn.Location = new System.Drawing.Point(7, 89);
            this.circleBtn.Name = "circleBtn";
            this.circleBtn.Size = new System.Drawing.Size(51, 17);
            this.circleBtn.TabIndex = 3;
            this.circleBtn.TabStop = true;
            this.circleBtn.Text = "Circle";
            this.circleBtn.UseVisualStyleBackColor = true;
            this.circleBtn.CheckedChanged += new System.EventHandler(this.circleBtn_CheckedChanged);
            this.circleBtn.Click += new System.EventHandler(this.circleBtn_Click);
            // 
            // boxBtn
            // 
            this.boxBtn.AutoSize = true;
            this.boxBtn.Location = new System.Drawing.Point(7, 66);
            this.boxBtn.Name = "boxBtn";
            this.boxBtn.Size = new System.Drawing.Size(43, 17);
            this.boxBtn.TabIndex = 2;
            this.boxBtn.TabStop = true;
            this.boxBtn.Text = "Box";
            this.boxBtn.UseVisualStyleBackColor = true;
            this.boxBtn.CheckedChanged += new System.EventHandler(this.boxBtn_CheckedChanged);
            this.boxBtn.Click += new System.EventHandler(this.boxBtn_Click);
            // 
            // squareBtn
            // 
            this.squareBtn.AutoSize = true;
            this.squareBtn.Location = new System.Drawing.Point(7, 43);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(59, 17);
            this.squareBtn.TabIndex = 1;
            this.squareBtn.TabStop = true;
            this.squareBtn.Text = "Square";
            this.squareBtn.UseVisualStyleBackColor = true;
            this.squareBtn.CheckedChanged += new System.EventHandler(this.squareBtn_CheckedChanged);
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // roundBtn
            // 
            this.roundBtn.AutoSize = true;
            this.roundBtn.Location = new System.Drawing.Point(7, 20);
            this.roundBtn.Name = "roundBtn";
            this.roundBtn.Size = new System.Drawing.Size(52, 17);
            this.roundBtn.TabIndex = 0;
            this.roundBtn.TabStop = true;
            this.roundBtn.Text = "Brush";
            this.roundBtn.UseVisualStyleBackColor = true;
            this.roundBtn.CheckedChanged += new System.EventHandler(this.roundBtn_CheckedChanged);
            // 
            // panelDraw
            // 
            this.panelDraw.Location = new System.Drawing.Point(13, 28);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(543, 452);
            this.panelDraw.TabIndex = 8;
            this.panelDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDraw_Paint);
            this.panelDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseDown);
            this.panelDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseMove);
            this.panelDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDraw_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // brushSizeToolStripMenuItem
            // 
            this.brushSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.freeFormSizeBox});
            this.brushSizeToolStripMenuItem.Name = "brushSizeToolStripMenuItem";
            this.brushSizeToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.brushSizeToolStripMenuItem.Text = "Brush Size";
            // 
            // freeFormSizeBox
            // 
            this.freeFormSizeBox.Name = "freeFormSizeBox";
            this.freeFormSizeBox.Size = new System.Drawing.Size(100, 23);
            this.freeFormSizeBox.TextChanged += new System.EventHandler(this.freeFormSizeBox_TextChanged);
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(768, 500);
            this.Controls.Add(this.panelDraw);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBrushShape);
            this.Controls.Add(this.groupBrushSize);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.themeColorPicker);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaintForm";
            this.Text = "Discount Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBrushSize.ResumeLayout(false);
            this.groupBrushSize.PerformLayout();
            this.groupBrushShape.ResumeLayout(false);
            this.groupBrushShape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ThemeColorPicker themeColorPicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colourToolStripMenuItem;
        private ExHtmlEditor.ColorPicker.ThemeColorPickerToolStripSplitButton themeColorPickerToolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.GroupBox groupBrushSize;
        private System.Windows.Forms.RadioButton size13Btn;
        private System.Windows.Forms.RadioButton size12Btn;
        private System.Windows.Forms.RadioButton size11Btn;
        private System.Windows.Forms.RadioButton size10Btn;
        private System.Windows.Forms.RadioButton size9Btn;
        private System.Windows.Forms.RadioButton size8Btn;
        private System.Windows.Forms.GroupBox groupBrushShape;
        private System.Windows.Forms.RadioButton squareBtn;
        private System.Windows.Forms.RadioButton roundBtn;
        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.RadioButton circleBtn;
        private System.Windows.Forms.RadioButton boxBtn;
        private System.Windows.Forms.ToolStripSeparator aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem px8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem px9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem px10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem px11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem px12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem px13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem brushSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox freeFormSizeBox;
    }
}

