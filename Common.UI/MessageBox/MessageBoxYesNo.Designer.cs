namespace Common.UI
{
    partial class MessageBoxYesNo
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
            button1 = new Button();
            button2 = new Button();
            lblMessage = new Label();
            panel1 = new Panel();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Yes;
            button1.Location = new Point(235, 160);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 0;
            button1.Text = "&Yes";
            button1.UseVisualStyleBackColor = true;
            button1.KeyDown += MessageBoxYesNo_KeyDown;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.No;
            button2.Location = new Point(341, 160);
            button2.Name = "button2";
            button2.Size = new Size(100, 32);
            button2.TabIndex = 1;
            button2.Text = "&No";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Arial", 14.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.Location = new Point(101, 44);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(338, 109);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "This is a message";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOrange;
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 31);
            panel1.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(3, 6);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(427, 19);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "This is a title";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.megaphone_80px_q;
            pictureBox1.Location = new Point(15, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MessageBoxYesNo
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(450, 200);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(lblMessage);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MessageBoxYesNo";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterParent;
            Text = "MessageBox";
            KeyDown += MessageBoxYesNo_KeyDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label lblMessage;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblTitle;
    }
}