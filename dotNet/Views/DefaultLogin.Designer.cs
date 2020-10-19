namespace Atomus.Control.Login
{
    partial class DefaultLogin
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label3 = new System.Windows.Forms.Label();
            this.Bnt_Login = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.ComboBox();
            this.Bnt_Exit = new System.Windows.Forms.Button();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.ACCESS_NUMBER = new System.Windows.Forms.TextBox();
            this.Bnt_Join = new System.Windows.Forms.Button();
            this.IS_EMAIL_SAVE = new System.Windows.Forms.CheckBox();
            this.IS_AUTO_LOGIN = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.ForeColor = System.Drawing.Color.White;
            this.Label3.Location = new System.Drawing.Point(0, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 26);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "언어";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Bnt_Login
            // 
            this.Bnt_Login.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Bnt_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bnt_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bnt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnt_Login.ForeColor = System.Drawing.Color.White;
            this.Bnt_Login.Location = new System.Drawing.Point(178, 76);
            this.Bnt_Login.Margin = new System.Windows.Forms.Padding(0);
            this.Bnt_Login.Name = "Bnt_Login";
            this.Bnt_Login.Size = new System.Drawing.Size(73, 22);
            this.Bnt_Login.TabIndex = 6;
            this.Bnt_Login.Text = "접속";
            this.Bnt_Login.UseVisualStyleBackColor = true;
            this.Bnt_Login.Click += new System.EventHandler(this.Bnt_Login_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(0, 50);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(94, 26);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "비밀번호";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 26);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(94, 26);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "사용자";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Language
            // 
            this.Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Language.FormattingEnabled = true;
            this.Language.Location = new System.Drawing.Point(100, 2);
            this.Language.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(97, 20);
            this.Language.TabIndex = 1;
            this.Language.SelectedIndexChanged += new System.EventHandler(this.Language_SelectedIndexChanged);
            this.Language.DropDownClosed += new System.EventHandler(this.Language_DropDownClosed);
            this.Language.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Language_KeyPress);
            // 
            // Bnt_Exit
            // 
            this.Bnt_Exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Bnt_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bnt_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bnt_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnt_Exit.ForeColor = System.Drawing.Color.White;
            this.Bnt_Exit.Location = new System.Drawing.Point(262, 76);
            this.Bnt_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bnt_Exit.Name = "Bnt_Exit";
            this.Bnt_Exit.Size = new System.Drawing.Size(73, 22);
            this.Bnt_Exit.TabIndex = 7;
            this.Bnt_Exit.Text = "종료";
            this.Bnt_Exit.UseVisualStyleBackColor = true;
            this.Bnt_Exit.Click += new System.EventHandler(this.Bnt_Exit_Click);
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(100, 26);
            this.EMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(149, 21);
            this.EMAIL.TabIndex = 3;
            this.EMAIL.TextChanged += new System.EventHandler(this.EMAIL_TextChanged);
            this.EMAIL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EMAIL_KeyPress);
            // 
            // ACCESS_NUMBER
            // 
            this.ACCESS_NUMBER.Location = new System.Drawing.Point(100, 52);
            this.ACCESS_NUMBER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ACCESS_NUMBER.Name = "ACCESS_NUMBER";
            this.ACCESS_NUMBER.PasswordChar = '*';
            this.ACCESS_NUMBER.Size = new System.Drawing.Size(149, 21);
            this.ACCESS_NUMBER.TabIndex = 5;
            this.ACCESS_NUMBER.TextChanged += new System.EventHandler(this.ACCESS_NUMBER_TextChanged);
            this.ACCESS_NUMBER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ACCESS_NUMBER_KeyPress);
            // 
            // Bnt_Join
            // 
            this.Bnt_Join.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Bnt_Join.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Bnt_Join.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Bnt_Join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bnt_Join.ForeColor = System.Drawing.Color.White;
            this.Bnt_Join.Location = new System.Drawing.Point(33, 76);
            this.Bnt_Join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bnt_Join.Name = "Bnt_Join";
            this.Bnt_Join.Size = new System.Drawing.Size(131, 22);
            this.Bnt_Join.TabIndex = 8;
            this.Bnt_Join.Text = "가입/비밀번호변경";
            this.Bnt_Join.UseVisualStyleBackColor = true;
            this.Bnt_Join.Click += new System.EventHandler(this.Bnt_Join_Click);
            // 
            // IS_EMAIL_SAVE
            // 
            this.IS_EMAIL_SAVE.ForeColor = System.Drawing.Color.White;
            this.IS_EMAIL_SAVE.Location = new System.Drawing.Point(253, 23);
            this.IS_EMAIL_SAVE.Margin = new System.Windows.Forms.Padding(2);
            this.IS_EMAIL_SAVE.Name = "IS_EMAIL_SAVE";
            this.IS_EMAIL_SAVE.Size = new System.Drawing.Size(52, 26);
            this.IS_EMAIL_SAVE.TabIndex = 9;
            this.IS_EMAIL_SAVE.Text = "저장";
            this.IS_EMAIL_SAVE.UseVisualStyleBackColor = true;
            this.IS_EMAIL_SAVE.CheckedChanged += new System.EventHandler(this.IS_EMAIL_SAVE_CheckedChanged);
            // 
            // IS_AUTO_LOGIN
            // 
            this.IS_AUTO_LOGIN.ForeColor = System.Drawing.Color.White;
            this.IS_AUTO_LOGIN.Location = new System.Drawing.Point(252, 49);
            this.IS_AUTO_LOGIN.Margin = new System.Windows.Forms.Padding(2);
            this.IS_AUTO_LOGIN.Name = "IS_AUTO_LOGIN";
            this.IS_AUTO_LOGIN.Size = new System.Drawing.Size(96, 26);
            this.IS_AUTO_LOGIN.TabIndex = 10;
            this.IS_AUTO_LOGIN.Text = "자동로그인";
            this.IS_AUTO_LOGIN.UseVisualStyleBackColor = true;
            this.IS_AUTO_LOGIN.CheckedChanged += new System.EventHandler(this.IS_AUTO_LOGIN_CheckedChanged);
            // 
            // DefaultLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.IS_AUTO_LOGIN);
            this.Controls.Add(this.IS_EMAIL_SAVE);
            this.Controls.Add(this.Bnt_Join);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Bnt_Login);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.Bnt_Exit);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.ACCESS_NUMBER);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DefaultLogin";
            this.Size = new System.Drawing.Size(594, 468);
            this.Load += new System.EventHandler(this.DefaultLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DefaultLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DefaultLogin_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button Bnt_Login;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox Language;
        internal System.Windows.Forms.Button Bnt_Exit;
        internal System.Windows.Forms.TextBox EMAIL;
        internal System.Windows.Forms.TextBox ACCESS_NUMBER;
        internal System.Windows.Forms.Button Bnt_Join;
        private System.Windows.Forms.CheckBox IS_EMAIL_SAVE;
        private System.Windows.Forms.CheckBox IS_AUTO_LOGIN;
    }
}
