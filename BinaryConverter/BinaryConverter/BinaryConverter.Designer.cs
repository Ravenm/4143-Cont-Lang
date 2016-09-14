namespace BinaryConverter
{
    partial class BinaryConvterForm
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
            this.components = new System.ComponentModel.Container();
            this.convertToBin = new System.Windows.Forms.Button();
            this.binBox = new System.Windows.Forms.TextBox();
            this.binResult = new System.Windows.Forms.TextBox();
            this.binInputError = new System.Windows.Forms.ErrorProvider(this.components);
            this.binInputLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.errMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.binInputError)).BeginInit();
            this.SuspendLayout();
            // 
            // convertToBin
            // 
            this.convertToBin.Enabled = false;
            this.convertToBin.Location = new System.Drawing.Point(12, 117);
            this.convertToBin.Name = "convertToBin";
            this.convertToBin.Size = new System.Drawing.Size(75, 23);
            this.convertToBin.TabIndex = 0;
            this.convertToBin.Text = "Convert";
            this.convertToBin.UseVisualStyleBackColor = true;
            this.convertToBin.Click += new System.EventHandler(this.convertToBin_Click);
            // 
            // binBox
            // 
            this.binBox.Location = new System.Drawing.Point(12, 48);
            this.binBox.Name = "binBox";
            this.binBox.Size = new System.Drawing.Size(300, 20);
            this.binBox.TabIndex = 1;
            this.binBox.TextChanged += new System.EventHandler(this.binBox_TextChanged);
            // 
            // binResult
            // 
            this.binResult.Location = new System.Drawing.Point(12, 91);
            this.binResult.Name = "binResult";
            this.binResult.ReadOnly = true;
            this.binResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.binResult.Size = new System.Drawing.Size(299, 20);
            this.binResult.TabIndex = 2;
            this.binResult.TabStop = false;
            // 
            // binInputError
            // 
            this.binInputError.ContainerControl = this;
            // 
            // binInputLabel
            // 
            this.binInputLabel.AutoSize = true;
            this.binInputLabel.Location = new System.Drawing.Point(9, 32);
            this.binInputLabel.Name = "binInputLabel";
            this.binInputLabel.Size = new System.Drawing.Size(104, 13);
            this.binInputLabel.TabIndex = 3;
            this.binInputLabel.Text = "Enter Binary Number";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 75);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(37, 13);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result";
            // 
            // errMsg
            // 
            this.errMsg.AutoSize = true;
            this.errMsg.BackColor = System.Drawing.SystemColors.Control;
            this.errMsg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errMsg.Cursor = System.Windows.Forms.Cursors.Help;
            this.errMsg.ForeColor = System.Drawing.SystemColors.InfoText;
            this.errMsg.Location = new System.Drawing.Point(119, 30);
            this.errMsg.Name = "errMsg";
            this.errMsg.Size = new System.Drawing.Size(65, 15);
            this.errMsg.TabIndex = 5;
            this.errMsg.Text = "Placeholder";
            this.errMsg.Visible = false;
            // 
            // BinaryConvterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 165);
            this.Controls.Add(this.errMsg);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.binInputLabel);
            this.Controls.Add(this.binResult);
            this.Controls.Add(this.binBox);
            this.Controls.Add(this.convertToBin);
            this.Name = "BinaryConvterForm";
            this.Text = "Binary Converter";
            ((System.ComponentModel.ISupportInitialize)(this.binInputError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button convertToBin;
        private System.Windows.Forms.TextBox binBox;
        private System.Windows.Forms.TextBox binResult;
        private System.Windows.Forms.ErrorProvider binInputError;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label binInputLabel;
        private System.Windows.Forms.Label errMsg;
    }
}

