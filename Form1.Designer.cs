namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblAppName = new Label();
            txtID = new TextBox();
            txtPW = new TextBox();
            btnLogin = new Button();
            lblErrorMessage = new Label();
            btnIdClear = new Button();
            btnPwClear = new Button();
            btnPwShow = new Button();
            txtTimer = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("함초롬바탕 확장", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.FromArgb(128, 128, 255);
            lblAppName.Location = new Point(218, 25);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(212, 83);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            lblAppName.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(142, 122);
            txtID.Name = "txtID";
            txtID.Size = new Size(364, 54);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // txtPW
            // 
            txtPW.BorderStyle = BorderStyle.FixedSingle;
            txtPW.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(142, 195);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(364, 54);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Info;
            btnLogin.Font = new Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(230, 288);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 78);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(142, 262);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(223, 15);
            lblErrorMessage.TabIndex = 4;
            lblErrorMessage.Text = "아이디 또는 비밀번호가 잘못되었습니다";
            lblErrorMessage.Visible = false;
            // 
            // btnIdClear
            // 
            btnIdClear.FlatStyle = FlatStyle.Flat;
            btnIdClear.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnIdClear.Location = new Point(470, 132);
            btnIdClear.Name = "btnIdClear";
            btnIdClear.Size = new Size(27, 32);
            btnIdClear.TabIndex = 5;
            btnIdClear.Text = "X";
            btnIdClear.TextAlign = ContentAlignment.TopCenter;
            btnIdClear.UseVisualStyleBackColor = true;
            btnIdClear.Click += btnIdClear_Click;
            // 
            // btnPwClear
            // 
            btnPwClear.FlatStyle = FlatStyle.Flat;
            btnPwClear.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnPwClear.Location = new Point(470, 204);
            btnPwClear.Name = "btnPwClear";
            btnPwClear.Size = new Size(27, 32);
            btnPwClear.TabIndex = 6;
            btnPwClear.Text = "X";
            btnPwClear.TextAlign = ContentAlignment.TopCenter;
            btnPwClear.UseVisualStyleBackColor = true;
            btnPwClear.Click += btnPwClear_Click;
            // 
            // btnPwShow
            // 
            btnPwShow.BackgroundImageLayout = ImageLayout.Zoom;
            btnPwShow.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnPwShow.Location = new Point(512, 204);
            btnPwShow.Name = "btnPwShow";
            btnPwShow.Size = new Size(34, 36);
            btnPwShow.TabIndex = 7;
            btnPwShow.Text = "⊙";
            btnPwShow.UseVisualStyleBackColor = true;
            btnPwShow.Click += btnPwShow_Click;
            // 
            // txtTimer
            // 
            txtTimer.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtTimer.Location = new Point(172, 312);
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(206, 27);
            txtTimer.TabIndex = 8;
            txtTimer.Text = "다음 시간 이후 시도하십시오";
            txtTimer.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 408);
            Controls.Add(txtTimer);
            Controls.Add(btnPwShow);
            Controls.Add(btnPwClear);
            Controls.Add(btnIdClear);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(txtID);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtID;
        private TextBox txtPW;
        private Button btnLogin;
        private Label lblErrorMessage;
        private Button btnIdClear;
        private Button btnPwClear;
        private Button btnPwShow;
        private TextBox txtTimer;
        private System.Windows.Forms.Timer timer1;
    }
}
