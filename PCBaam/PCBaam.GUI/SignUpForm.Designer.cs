namespace PCBaam.GUI
{
    partial class SignUpForm
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pwTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nameTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.cellnumTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mailTextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(348, 590);
            this.panelLeft.TabIndex = 0;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.cancelButton);
            this.panelRight.Controls.Add(this.okButton);
            this.panelRight.Controls.Add(this.mailTextbox);
            this.panelRight.Controls.Add(this.cellnumTextbox);
            this.panelRight.Controls.Add(this.label7);
            this.panelRight.Controls.Add(this.nameTextbox);
            this.panelRight.Controls.Add(this.pwTextbox);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.label6);
            this.panelRight.Controls.Add(this.label5);
            this.panelRight.Controls.Add(this.idTextbox);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Font = new System.Drawing.Font("굵은안상수체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panelRight.Location = new System.Drawing.Point(348, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(485, 590);
            this.panelRight.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HY헤드라인M", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(97, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "회원가입";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("문체부 제목 돋음체", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "회원가입";
            // 
            // idTextbox
            // 
            this.idTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.idTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.idTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.idTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.idTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.idTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.idTextbox.HintText = "";
            this.idTextbox.isPassword = false;
            this.idTextbox.LineFocusedColor = System.Drawing.Color.Olive;
            this.idTextbox.LineIdleColor = System.Drawing.Color.OliveDrab;
            this.idTextbox.LineMouseHoverColor = System.Drawing.Color.OliveDrab;
            this.idTextbox.LineThickness = 3;
            this.idTextbox.Location = new System.Drawing.Point(32, 120);
            this.idTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextbox.MaxLength = 32767;
            this.idTextbox.Name = "idTextbox";
            this.idTextbox.Size = new System.Drawing.Size(425, 33);
            this.idTextbox.TabIndex = 3;
            this.idTextbox.Text = "아이디를 입력하세요";
            this.idTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("중간안상수체", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "비밀번호:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 393);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("중간안상수체", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(28, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "아이디:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("중간안상수체", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "이름 : ";
            // 
            // pwTextbox
            // 
            this.pwTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pwTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pwTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pwTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pwTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.pwTextbox.HintText = "";
            this.pwTextbox.isPassword = false;
            this.pwTextbox.LineFocusedColor = System.Drawing.Color.Olive;
            this.pwTextbox.LineIdleColor = System.Drawing.Color.OliveDrab;
            this.pwTextbox.LineMouseHoverColor = System.Drawing.Color.OliveDrab;
            this.pwTextbox.LineThickness = 3;
            this.pwTextbox.Location = new System.Drawing.Point(32, 194);
            this.pwTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.pwTextbox.MaxLength = 32767;
            this.pwTextbox.Name = "pwTextbox";
            this.pwTextbox.Size = new System.Drawing.Size(425, 33);
            this.pwTextbox.TabIndex = 9;
            this.pwTextbox.Text = "비밀번호를 입력하세요";
            this.pwTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nameTextbox
            // 
            this.nameTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.nameTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.nameTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.nameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.nameTextbox.HintText = "";
            this.nameTextbox.isPassword = false;
            this.nameTextbox.LineFocusedColor = System.Drawing.Color.Olive;
            this.nameTextbox.LineIdleColor = System.Drawing.Color.OliveDrab;
            this.nameTextbox.LineMouseHoverColor = System.Drawing.Color.OliveDrab;
            this.nameTextbox.LineThickness = 3;
            this.nameTextbox.Location = new System.Drawing.Point(32, 267);
            this.nameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextbox.MaxLength = 32767;
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(425, 33);
            this.nameTextbox.TabIndex = 10;
            this.nameTextbox.Text = "이름을 입력하세요";
            this.nameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("중간안상수체", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(28, 319);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "연락처 : ";
            // 
            // cellnumTextbox
            // 
            this.cellnumTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.cellnumTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.cellnumTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cellnumTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cellnumTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cellnumTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cellnumTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.cellnumTextbox.HintText = "";
            this.cellnumTextbox.isPassword = false;
            this.cellnumTextbox.LineFocusedColor = System.Drawing.Color.Olive;
            this.cellnumTextbox.LineIdleColor = System.Drawing.Color.OliveDrab;
            this.cellnumTextbox.LineMouseHoverColor = System.Drawing.Color.OliveDrab;
            this.cellnumTextbox.LineThickness = 3;
            this.cellnumTextbox.Location = new System.Drawing.Point(32, 344);
            this.cellnumTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.cellnumTextbox.MaxLength = 32767;
            this.cellnumTextbox.Name = "cellnumTextbox";
            this.cellnumTextbox.Size = new System.Drawing.Size(425, 33);
            this.cellnumTextbox.TabIndex = 12;
            this.cellnumTextbox.Text = "연락처를 입력하세요";
            this.cellnumTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // mailTextbox
            // 
            this.mailTextbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.mailTextbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.mailTextbox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mailTextbox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mailTextbox.HintForeColor = System.Drawing.Color.Empty;
            this.mailTextbox.HintText = "";
            this.mailTextbox.isPassword = false;
            this.mailTextbox.LineFocusedColor = System.Drawing.Color.Olive;
            this.mailTextbox.LineIdleColor = System.Drawing.Color.OliveDrab;
            this.mailTextbox.LineMouseHoverColor = System.Drawing.Color.OliveDrab;
            this.mailTextbox.LineThickness = 3;
            this.mailTextbox.Location = new System.Drawing.Point(32, 418);
            this.mailTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.mailTextbox.MaxLength = 32767;
            this.mailTextbox.Name = "mailTextbox";
            this.mailTextbox.Size = new System.Drawing.Size(425, 33);
            this.mailTextbox.TabIndex = 13;
            this.mailTextbox.Text = "이메일을 입력하세요";
            this.mailTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.OliveDrab;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.SystemColors.Window;
            this.okButton.Location = new System.Drawing.Point(18, 481);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(439, 38);
            this.okButton.TabIndex = 14;
            this.okButton.Text = "회원가입";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.OliveDrab;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Window;
            this.cancelButton.Location = new System.Drawing.Point(18, 531);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(439, 33);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "취소";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 590);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox idTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mailTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cellnumTextbox;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nameTextbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pwTextbox;
        private System.Windows.Forms.Label label1;
    }
}