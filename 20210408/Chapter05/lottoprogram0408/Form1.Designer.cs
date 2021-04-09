
namespace lottoprogram0408
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.uiImageButton1 = new Sunny.UI.UIImageButton();
            this.lotto_button = new CxFlatUI.Controls.CxFlatButton();
            this.label_6 = new System.Windows.Forms.Label();
            this.label_5 = new System.Windows.Forms.Label();
            this.label_4 = new System.Windows.Forms.Label();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // uiImageButton1
            // 
            this.uiImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiImageButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("uiImageButton1.Image")));
            this.uiImageButton1.Location = new System.Drawing.Point(12, 12);
            this.uiImageButton1.Name = "uiImageButton1";
            this.uiImageButton1.Size = new System.Drawing.Size(349, 216);
            this.uiImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiImageButton1.TabIndex = 0;
            this.uiImageButton1.TabStop = false;
            this.uiImageButton1.Text = null;
            // 
            // lotto_button
            // 
            this.lotto_button.BackColor = System.Drawing.Color.Red;
            this.lotto_button.ButtonType = CxFlatUI.ButtonType.Primary;
            this.lotto_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lotto_button.Location = new System.Drawing.Point(208, 393);
            this.lotto_button.Name = "lotto_button";
            this.lotto_button.Size = new System.Drawing.Size(153, 45);
            this.lotto_button.TabIndex = 1;
            this.lotto_button.Text = "돌리기";
            this.lotto_button.TextColor = System.Drawing.Color.White;
            this.lotto_button.Click += new System.EventHandler(this.lotto_button_Click);
            // 
            // label_6
            // 
            this.label_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_6.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_6.Location = new System.Drawing.Point(194, 328);
            this.label_6.Name = "label_6";
            this.label_6.Size = new System.Drawing.Size(51, 33);
            this.label_6.TabIndex = 15;
            this.label_6.Text = "0";
            this.label_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_6.Click += new System.EventHandler(this.label_6_Click);
            // 
            // label_5
            // 
            this.label_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label_5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_5.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_5.Location = new System.Drawing.Point(112, 328);
            this.label_5.Name = "label_5";
            this.label_5.Size = new System.Drawing.Size(47, 33);
            this.label_5.TabIndex = 14;
            this.label_5.Text = "0";
            this.label_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_5.Click += new System.EventHandler(this.label_5_Click);
            // 
            // label_4
            // 
            this.label_4.BackColor = System.Drawing.Color.Yellow;
            this.label_4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_4.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_4.Location = new System.Drawing.Point(22, 328);
            this.label_4.Name = "label_4";
            this.label_4.Size = new System.Drawing.Size(51, 33);
            this.label_4.TabIndex = 13;
            this.label_4.Text = "0";
            this.label_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_4.Click += new System.EventHandler(this.label_4_Click);
            // 
            // label_3
            // 
            this.label_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_3.Location = new System.Drawing.Point(198, 249);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(47, 33);
            this.label_3.TabIndex = 12;
            this.label_3.Text = "0";
            this.label_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_3.Click += new System.EventHandler(this.label_3_Click);
            // 
            // label_2
            // 
            this.label_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_2.Location = new System.Drawing.Point(112, 249);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(49, 33);
            this.label_2.TabIndex = 11;
            this.label_2.Text = "0";
            this.label_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_2.Click += new System.EventHandler(this.label_2_Click);
            // 
            // label_1
            // 
            this.label_1.BackColor = System.Drawing.Color.Lime;
            this.label_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_1.Location = new System.Drawing.Point(22, 248);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(47, 33);
            this.label_1.TabIndex = 10;
            this.label_1.Text = "0";
            this.label_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_1.Click += new System.EventHandler(this.label_1_Click);
            // 
            // label_7
            // 
            this.label_7.BackColor = System.Drawing.Color.Aqua;
            this.label_7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_7.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_7.Location = new System.Drawing.Point(314, 293);
            this.label_7.Name = "label_7";
            this.label_7.Size = new System.Drawing.Size(47, 33);
            this.label_7.TabIndex = 16;
            this.label_7.Text = "0";
            this.label_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "보너스";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(373, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_7);
            this.Controls.Add(this.label_6);
            this.Controls.Add(this.label_5);
            this.Controls.Add(this.label_4);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.lotto_button);
            this.Controls.Add(this.uiImageButton1);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private Sunny.UI.UIImageButton uiImageButton1;
        private CxFlatUI.Controls.CxFlatButton lotto_button;
        private System.Windows.Forms.Label label_6;
        private System.Windows.Forms.Label label_5;
        private System.Windows.Forms.Label label_4;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label_7;
        private System.Windows.Forms.Label label1;
    }
}

