namespace Doctor_Codenstein
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txt_Input = new TextBox();
            btn_AddIng = new Button();
            lb_Ingridients = new ListBox();
            lbl_FunMes = new Label();
            btn_CookPot = new Button();
            pictureBox1 = new PictureBox();
            lbl_Heading = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            btn_Info = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_Input
            // 
            txt_Input.Font = new Font("Segoe UI", 15F);
            txt_Input.Location = new Point(204, 310);
            txt_Input.Name = "txt_Input";
            txt_Input.Size = new Size(482, 34);
            txt_Input.TabIndex = 0;
            // 
            // btn_AddIng
            // 
            btn_AddIng.BackColor = Color.Black;
            btn_AddIng.FlatStyle = FlatStyle.Flat;
            btn_AddIng.Font = new Font("Segoe UI", 16F);
            btn_AddIng.ForeColor = Color.FromArgb(168, 255, 221);
            btn_AddIng.Location = new Point(204, 407);
            btn_AddIng.Name = "btn_AddIng";
            btn_AddIng.Size = new Size(195, 61);
            btn_AddIng.TabIndex = 1;
            btn_AddIng.Text = "Добави съставка";
            btn_AddIng.UseVisualStyleBackColor = false;
            btn_AddIng.Click += btn_AddIng_Click;
            // 
            // lb_Ingridients
            // 
            lb_Ingridients.Font = new Font("Segoe UI", 15F);
            lb_Ingridients.FormattingEnabled = true;
            lb_Ingridients.ItemHeight = 28;
            lb_Ingridients.Location = new Point(824, 310);
            lb_Ingridients.Name = "lb_Ingridients";
            lb_Ingridients.Size = new Size(414, 340);
            lb_Ingridients.TabIndex = 2;
            // 
            // lbl_FunMes
            // 
            lbl_FunMes.AutoSize = true;
            lbl_FunMes.Font = new Font("Segoe UI", 15F);
            lbl_FunMes.ForeColor = SystemColors.Control;
            lbl_FunMes.Location = new Point(22, 602);
            lbl_FunMes.Name = "lbl_FunMes";
            lbl_FunMes.Size = new Size(181, 28);
            lbl_FunMes.TabIndex = 3;
            lbl_FunMes.Text = "nothing to see here";
            // 
            // btn_CookPot
            // 
            btn_CookPot.BackColor = Color.Black;
            btn_CookPot.FlatStyle = FlatStyle.Flat;
            btn_CookPot.Font = new Font("Segoe UI", 16F);
            btn_CookPot.ForeColor = Color.FromArgb(168, 255, 221);
            btn_CookPot.Location = new Point(491, 407);
            btn_CookPot.Name = "btn_CookPot";
            btn_CookPot.Size = new Size(195, 61);
            btn_CookPot.TabIndex = 4;
            btn_CookPot.Text = "Свари отварата";
            btn_CookPot.UseVisualStyleBackColor = false;
            btn_CookPot.Click += btn_CookPot_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(959, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // lbl_Heading
            // 
            lbl_Heading.AutoSize = true;
            lbl_Heading.Font = new Font("Segoe UI", 20F);
            lbl_Heading.ForeColor = SystemColors.ButtonHighlight;
            lbl_Heading.Location = new Point(939, 9);
            lbl_Heading.Name = "lbl_Heading";
            lbl_Heading.Size = new Size(245, 37);
            lbl_Heading.TabIndex = 6;
            lbl_Heading.Text = "Проф. Коденщайн";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = Color.FromArgb(168, 255, 221);
            button1.Location = new Point(204, 483);
            button1.Name = "button1";
            button1.Size = new Size(195, 67);
            button1.TabIndex = 7;
            button1.Text = "Премахни съставки";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(204, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(482, 181);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btn_Info
            // 
            btn_Info.BackColor = Color.FromArgb(29, 26, 49);
            btn_Info.BackgroundImage = (Image)resources.GetObject("btn_Info.BackgroundImage");
            btn_Info.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Info.FlatAppearance.BorderSize = 0;
            btn_Info.FlatStyle = FlatStyle.Flat;
            btn_Info.ForeColor = Color.Transparent;
            btn_Info.Location = new Point(12, -53);
            btn_Info.Name = "btn_Info";
            btn_Info.Size = new Size(166, 203);
            btn_Info.TabIndex = 9;
            btn_Info.UseVisualStyleBackColor = false;
            btn_Info.Click += btn_Info_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 26, 49);
            ClientSize = new Size(1264, 681);
            Controls.Add(btn_Info);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(lbl_Heading);
            Controls.Add(pictureBox1);
            Controls.Add(btn_CookPot);
            Controls.Add(lbl_FunMes);
            Controls.Add(lb_Ingridients);
            Controls.Add(btn_AddIng);
            Controls.Add(txt_Input);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "PotionBrewer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Input;
        private Button btn_AddIng;
        private ListBox lb_Ingridients;
        private Label lbl_FunMes;
        private Button btn_CookPot;
        private PictureBox pictureBox1;
        private Label lbl_Heading;
        private Button button1;
        private PictureBox pictureBox2;
        private Button btn_Info;
    }
}
