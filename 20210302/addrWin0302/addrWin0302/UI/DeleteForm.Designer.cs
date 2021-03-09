
namespace addrWin0302.UI
{
    partial class DeleteForm
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
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.deleteIdTextBox = new Sunny.UI.UITextBox();
            this.upName = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(298, 155);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.TabIndex = 0;
            this.uiSymbolButton1.Text = "종 료";
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(182, 155);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton2.TabIndex = 1;
            this.uiSymbolButton2.Text = "삭 제";
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // deleteIdTextBox
            // 
            this.deleteIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deleteIdTextBox.FillColor = System.Drawing.Color.White;
            this.deleteIdTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.deleteIdTextBox.Location = new System.Drawing.Point(45, 92);
            this.deleteIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteIdTextBox.Maximum = 2147483647D;
            this.deleteIdTextBox.Minimum = -2147483648D;
            this.deleteIdTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.deleteIdTextBox.Name = "deleteIdTextBox";
            this.deleteIdTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.deleteIdTextBox.Size = new System.Drawing.Size(353, 29);
            this.deleteIdTextBox.TabIndex = 2;
            // 
            // upName
            // 
            this.upName.BackColor = System.Drawing.Color.Transparent;
            this.upName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upName.Location = new System.Drawing.Point(12, 49);
            this.upName.MinimumSize = new System.Drawing.Size(1, 1);
            this.upName.Name = "upName";
            this.upName.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.upName.Size = new System.Drawing.Size(146, 35);
            this.upName.Symbol = 62144;
            this.upName.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.upName.TabIndex = 5;
            this.upName.Text = "이 름";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 216);
            this.Controls.Add(this.upName);
            this.Controls.Add(this.deleteIdTextBox);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.uiSymbolButton1);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UITextBox deleteIdTextBox;
        private Sunny.UI.UISymbolLabel upName;
    }
}