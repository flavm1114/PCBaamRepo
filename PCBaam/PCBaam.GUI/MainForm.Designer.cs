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
            this.loginButton = new System.Windows.Forms.Button();
            this.IDLabel = new System.Windows.Forms.Label();
            this.FindIdPw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.pwTextbox = new System.Windows.Forms.TextBox();
            this.idTextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PCBaam.GUI.Properties.Resources.mainformscreen_jpg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.IDLabel);
            this.panel1.Controls.Add(this.FindIdPw);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SignUpButton);
            this.panel1.Controls.Add(this.pwTextbox);
            this.panel1.Controls.Add(this.idTextbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 367);
            this.panel1.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.BackColor = System.Drawing.Color.Black;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ExitButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.ExitButton.Location = new System.Drawing.Point(642, 312);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(122, 31);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "종료";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButton.BackColor = System.Drawing.Color.Black;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.loginButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.loginButton.Location = new System.Drawing.Point(662, 230);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(103, 77);
            this.loginButton.TabIndex = 13;
            this.loginButton.Text = "로그인";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.IDLabel.Font = new System.Drawing.Font("함초롬바탕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IDLabel.ForeColor = System.Drawing.Color.Black;
            this.IDLabel.Location = new System.Drawing.Point(396, 232);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(113, 29);
            this.IDLabel.TabIndex = 9;
            this.IDLabel.Text = "아이디(ID)";
            // 
            // FindIdPw
            // 
            this.FindIdPw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FindIdPw.BackColor = System.Drawing.Color.Black;
            this.FindIdPw.Cursor = System.Windows.Forms.Cursors.Default;
            this.FindIdPw.ForeColor = System.Drawing.Color.LavenderBlush;
            this.FindIdPw.Location = new System.Drawing.Point(514, 312);
            this.FindIdPw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindIdPw.Name = "FindIdPw";
            this.FindIdPw.Size = new System.Drawing.Size(122, 31);
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
            this.label1.Location = new System.Drawing.Point(362, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "비밀번호(PW)";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUpButton.BackColor = System.Drawing.Color.Black;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SignUpButton.ForeColor = System.Drawing.Color.LavenderBlush;
            this.SignUpButton.Location = new System.Drawing.Point(382, 312);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(128, 31);
            this.SignUpButton.TabIndex = 14;
            this.SignUpButton.Text = "회원가입";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click_1);
            // 
            // pwTextbox
            // 
            this.pwTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pwTextbox.Location = new System.Drawing.Point(522, 274);
            this.pwTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pwTextbox.Name = "pwTextbox";
            this.pwTextbox.PasswordChar = '*';
            this.pwTextbox.Size = new System.Drawing.Size(134, 21);
            this.pwTextbox.TabIndex = 12;
            // 
            // idTextbox
            // 
            this.idTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextbox.Location = new System.Drawing.Point(522, 240);
            this.idTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(134, 21);
            this.idTextbox.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(790, 367);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button FindIdPw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox pwTextbox;
        private System.Windows.Forms.TextBox idTextbox;
    }
}

