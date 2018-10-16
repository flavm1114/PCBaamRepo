namespace PCBaam.GUI
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.FindIdPw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PCBaam.GUI.Properties.Resources.mainformscreen_jpg1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Controls.Add(this.FindIdPw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SignUpButton);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 459);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ExitButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.ExitButton.Location = new System.Drawing.Point(734, 390);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 39);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "종료";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button1.Location = new System.Drawing.Point(756, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 96);
            this.button1.TabIndex = 13;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.IDLabel.Font = new System.Drawing.Font("함초롬바탕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IDLabel.ForeColor = System.Drawing.Color.Black;
            this.IDLabel.Location = new System.Drawing.Point(453, 290);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(138, 35);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "아이디(ID)";
            // 
            // FindIdPw
            // 
            this.FindIdPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FindIdPw.BackColor = System.Drawing.Color.Black;
            this.FindIdPw.Cursor = System.Windows.Forms.Cursors.Default;
            this.FindIdPw.ForeColor = System.Drawing.Color.LavenderBlush;
            this.FindIdPw.Location = new System.Drawing.Point(588, 390);
            this.FindIdPw.Name = "FindIdPw";
            this.FindIdPw.Size = new System.Drawing.Size(140, 39);
            this.FindIdPw.TabIndex = 15;
            this.FindIdPw.Text = "ID/PW 찾기";
            this.FindIdPw.UseVisualStyleBackColor = false;
            this.FindIdPw.Click += new System.EventHandler(this.FindIdPw_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Font = new System.Drawing.Font("함초롬바탕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(414, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "비밀번호(PW)";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpButton.BackColor = System.Drawing.Color.Black;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SignUpButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.SignUpButton.Location = new System.Drawing.Point(436, 390);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(146, 39);
            this.SignUpButton.TabIndex = 14;
            this.SignUpButton.Text = "회원가입";
            this.SignUpButton.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(597, 342);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(153, 25);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(597, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 25);
            this.textBox1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(903, 459);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button FindIdPw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

