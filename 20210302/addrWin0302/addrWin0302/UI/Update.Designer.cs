
namespace addrWin0302.UI
{
    partial class Update
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
            this.addTel = new Sunny.UI.UITextBox();
            this.upTel = new Sunny.UI.UISymbolLabel();
            this.addEmail = new Sunny.UI.UITextBox();
            this.addAddress = new Sunny.UI.UITextBox();
            this.upEmail = new Sunny.UI.UISymbolLabel();
            this.upAddr = new Sunny.UI.UISymbolLabel();
            this.addName = new Sunny.UI.UITextBox();
            this.upName = new Sunny.UI.UISymbolLabel();
            this.upOK = new Sunny.UI.UISymbolButton();
            this.upCancel = new Sunny.UI.UISymbolButton();
            this.uplist = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addTel
            // 
            this.addTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addTel.FillColor = System.Drawing.Color.White;
            this.addTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addTel.Location = new System.Drawing.Point(227, 345);
            this.addTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTel.Maximum = 2147483647D;
            this.addTel.Minimum = -2147483648D;
            this.addTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addTel.Name = "addTel";
            this.addTel.Padding = new System.Windows.Forms.Padding(5);
            this.addTel.Size = new System.Drawing.Size(321, 29);
            this.addTel.TabIndex = 9;
            // 
            // upTel
            // 
            this.upTel.BackColor = System.Drawing.Color.Transparent;
            this.upTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upTel.Location = new System.Drawing.Point(50, 339);
            this.upTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.upTel.Name = "upTel";
            this.upTel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.upTel.Size = new System.Drawing.Size(170, 35);
            this.upTel.Symbol = 57488;
            this.upTel.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.upTel.TabIndex = 6;
            this.upTel.Text = "전 화";
            // 
            // addEmail
            // 
            this.addEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmail.FillColor = System.Drawing.Color.White;
            this.addEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addEmail.Location = new System.Drawing.Point(227, 428);
            this.addEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmail.Maximum = 2147483647D;
            this.addEmail.Minimum = -2147483648D;
            this.addEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.addEmail.Name = "addEmail";
            this.addEmail.Padding = new System.Windows.Forms.Padding(5);
            this.addEmail.Size = new System.Drawing.Size(321, 29);
            this.addEmail.TabIndex = 10;
            // 
            // addAddress
            // 
            this.addAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addAddress.FillColor = System.Drawing.Color.White;
            this.addAddress.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addAddress.Location = new System.Drawing.Point(227, 386);
            this.addAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addAddress.Maximum = 2147483647D;
            this.addAddress.Minimum = -2147483648D;
            this.addAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.addAddress.Name = "addAddress";
            this.addAddress.Padding = new System.Windows.Forms.Padding(5);
            this.addAddress.Size = new System.Drawing.Size(321, 29);
            this.addAddress.TabIndex = 11;
            // 
            // upEmail
            // 
            this.upEmail.BackColor = System.Drawing.Color.Transparent;
            this.upEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upEmail.Location = new System.Drawing.Point(50, 428);
            this.upEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.upEmail.Name = "upEmail";
            this.upEmail.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.upEmail.Size = new System.Drawing.Size(170, 35);
            this.upEmail.Symbol = 61946;
            this.upEmail.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.upEmail.TabIndex = 7;
            this.upEmail.Text = "메 일";
            // 
            // upAddr
            // 
            this.upAddr.BackColor = System.Drawing.Color.Transparent;
            this.upAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upAddr.Location = new System.Drawing.Point(50, 380);
            this.upAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.upAddr.Name = "upAddr";
            this.upAddr.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.upAddr.Size = new System.Drawing.Size(170, 35);
            this.upAddr.Symbol = 61649;
            this.upAddr.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.upAddr.TabIndex = 8;
            this.upAddr.Text = "주 소";
            // 
            // addName
            // 
            this.addName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addName.FillColor = System.Drawing.Color.White;
            this.addName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addName.Location = new System.Drawing.Point(227, 299);
            this.addName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addName.Maximum = 2147483647D;
            this.addName.Minimum = -2147483648D;
            this.addName.MinimumSize = new System.Drawing.Size(1, 1);
            this.addName.Name = "addName";
            this.addName.Padding = new System.Windows.Forms.Padding(5);
            this.addName.Size = new System.Drawing.Size(321, 29);
            this.addName.TabIndex = 5;
            // 
            // upName
            // 
            this.upName.BackColor = System.Drawing.Color.Transparent;
            this.upName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upName.Location = new System.Drawing.Point(50, 293);
            this.upName.MinimumSize = new System.Drawing.Size(1, 1);
            this.upName.Name = "upName";
            this.upName.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.upName.Size = new System.Drawing.Size(170, 35);
            this.upName.Symbol = 62144;
            this.upName.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.upName.TabIndex = 4;
            this.upName.Text = "이 름";
            // 
            // upOK
            // 
            this.upOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upOK.FillColor = System.Drawing.Color.Cyan;
            this.upOK.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upOK.IsCircle = true;
            this.upOK.Location = new System.Drawing.Point(241, 489);
            this.upOK.MinimumSize = new System.Drawing.Size(1, 1);
            this.upOK.Name = "upOK";
            this.upOK.RectColor = System.Drawing.Color.Cyan;
            this.upOK.Size = new System.Drawing.Size(60, 60);
            this.upOK.Style = Sunny.UI.UIStyle.Custom;
            this.upOK.SymbolSize = 40;
            this.upOK.TabIndex = 17;
            this.upOK.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // upCancel
            // 
            this.upCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upCancel.FillColor = System.Drawing.Color.Red;
            this.upCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upCancel.IsCircle = true;
            this.upCancel.Location = new System.Drawing.Point(363, 489);
            this.upCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.upCancel.Name = "upCancel";
            this.upCancel.RectColor = System.Drawing.Color.Red;
            this.upCancel.Size = new System.Drawing.Size(60, 60);
            this.upCancel.Style = Sunny.UI.UIStyle.Custom;
            this.upCancel.Symbol = 61453;
            this.upCancel.SymbolSize = 40;
            this.upCancel.TabIndex = 18;
            this.upCancel.Click += new System.EventHandler(this.upCancel_Click);
            // 
            // uplist
            // 
            this.uplist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_addr,
            this.list_email});
            this.uplist.FullRowSelect = true;
            this.uplist.HideSelection = false;
            this.uplist.Location = new System.Drawing.Point(12, 78);
            this.uplist.Name = "uplist";
            this.uplist.Size = new System.Drawing.Size(663, 203);
            this.uplist.TabIndex = 20;
            this.uplist.UseCompatibleStateImageBehavior = false;
            this.uplist.View = System.Windows.Forms.View.Details;
            this.uplist.SelectedIndexChanged += new System.EventHandler(this.uplist_SelectedIndexChanged);
            // 
            // list_count
            // 
            this.list_count.Text = "번 호";
            // 
            // list_name
            // 
            this.list_name.Text = "이 름";
            this.list_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_name.Width = 80;
            // 
            // list_tel
            // 
            this.list_tel.Text = "전 화 ";
            this.list_tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_tel.Width = 140;
            // 
            // list_addr
            // 
            this.list_addr.Text = "주 소";
            this.list_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_addr.Width = 200;
            // 
            // list_email
            // 
            this.list_email.Text = "이메일";
            this.list_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_email.Width = 150;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 607);
            this.Controls.Add(this.uplist);
            this.Controls.Add(this.upCancel);
            this.Controls.Add(this.upOK);
            this.Controls.Add(this.addTel);
            this.Controls.Add(this.upTel);
            this.Controls.Add(this.addEmail);
            this.Controls.Add(this.addAddress);
            this.Controls.Add(this.upEmail);
            this.Controls.Add(this.upAddr);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.upName);
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "데이터 수정";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox addTel;
        private Sunny.UI.UISymbolLabel upTel;
        private Sunny.UI.UITextBox addEmail;
        private Sunny.UI.UITextBox addAddress;
        private Sunny.UI.UISymbolLabel upEmail;
        private Sunny.UI.UISymbolLabel upAddr;
        private Sunny.UI.UITextBox addName;
        private Sunny.UI.UISymbolLabel upName;
        private Sunny.UI.UISymbolButton upOK;
        private Sunny.UI.UISymbolButton upCancel;
        private System.Windows.Forms.ListView uplist;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
    }
}