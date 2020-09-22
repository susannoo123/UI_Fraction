namespace Fraction {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.plus_btn = new System.Windows.Forms.Button();
            this.minus_btn = new System.Windows.Forms.Button();
            this.mul_btn = new System.Windows.Forms.Button();
            this.div_btn = new System.Windows.Forms.Button();
            this.equal_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb_deno1 = new System.Windows.Forms.Label();
            this.lb_deno2 = new System.Windows.Forms.Label();
            this.lb_numer1 = new System.Windows.Forms.Label();
            this.lb_numer2 = new System.Windows.Forms.Label();
            this.txB_num1 = new System.Windows.Forms.TextBox();
            this.txB_deno1 = new System.Windows.Forms.TextBox();
            this.txB_num2 = new System.Windows.Forms.TextBox();
            this.txB_deno2 = new System.Windows.Forms.TextBox();
            this.txB_f1 = new System.Windows.Forms.TextBox();
            this.txB_f2 = new System.Windows.Forms.TextBox();
            this.clr_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 373);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(0, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 75);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fraction 2:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lb2);
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 75);
            this.panel3.TabIndex = 4;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb2.Location = new System.Drawing.Point(13, 24);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(107, 25);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "Fraction 1:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Controls.Add(this.plus_btn);
            this.flowLayoutPanel1.Controls.Add(this.minus_btn);
            this.flowLayoutPanel1.Controls.Add(this.mul_btn);
            this.flowLayoutPanel1.Controls.Add(this.div_btn);
            this.flowLayoutPanel1.Controls.Add(this.equal_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(130, 286);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(433, 87);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // plus_btn
            // 
            this.plus_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plus_btn.BackgroundImage")));
            this.plus_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.plus_btn.FlatAppearance.BorderSize = 0;
            this.plus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_btn.Location = new System.Drawing.Point(3, 3);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(80, 80);
            this.plus_btn.TabIndex = 4;
            this.plus_btn.UseVisualStyleBackColor = true;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // minus_btn
            // 
            this.minus_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minus_btn.BackgroundImage")));
            this.minus_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minus_btn.FlatAppearance.BorderSize = 0;
            this.minus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus_btn.Location = new System.Drawing.Point(89, 3);
            this.minus_btn.Name = "minus_btn";
            this.minus_btn.Size = new System.Drawing.Size(80, 80);
            this.minus_btn.TabIndex = 5;
            this.minus_btn.UseVisualStyleBackColor = true;
            this.minus_btn.Click += new System.EventHandler(this.minus_btn_Click);
            // 
            // mul_btn
            // 
            this.mul_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mul_btn.BackgroundImage")));
            this.mul_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mul_btn.FlatAppearance.BorderSize = 0;
            this.mul_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mul_btn.Location = new System.Drawing.Point(175, 3);
            this.mul_btn.Name = "mul_btn";
            this.mul_btn.Size = new System.Drawing.Size(80, 80);
            this.mul_btn.TabIndex = 6;
            this.mul_btn.UseVisualStyleBackColor = true;
            this.mul_btn.Click += new System.EventHandler(this.mul_btn_Click);
            // 
            // div_btn
            // 
            this.div_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("div_btn.BackgroundImage")));
            this.div_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.div_btn.FlatAppearance.BorderSize = 0;
            this.div_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.div_btn.Location = new System.Drawing.Point(261, 3);
            this.div_btn.Name = "div_btn";
            this.div_btn.Size = new System.Drawing.Size(80, 80);
            this.div_btn.TabIndex = 7;
            this.div_btn.UseVisualStyleBackColor = true;
            this.div_btn.Click += new System.EventHandler(this.div_btn_Click);
            // 
            // equal_btn
            // 
            this.equal_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("equal_btn.BackgroundImage")));
            this.equal_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.equal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equal_btn.Location = new System.Drawing.Point(347, 3);
            this.equal_btn.Name = "equal_btn";
            this.equal_btn.Size = new System.Drawing.Size(80, 80);
            this.equal_btn.TabIndex = 2;
            this.equal_btn.TabStop = false;
            this.equal_btn.UseVisualStyleBackColor = true;
            this.equal_btn.Click += new System.EventHandler(this.equal_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.quit_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(130, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 25);
            this.panel2.TabIndex = 2;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb1.Location = new System.Drawing.Point(131, 28);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(223, 31);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "Enter two fractions";
            // 
            // lb_deno1
            // 
            this.lb_deno1.AutoSize = true;
            this.lb_deno1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_deno1.Location = new System.Drawing.Point(136, 115);
            this.lb_deno1.Name = "lb_deno1";
            this.lb_deno1.Size = new System.Drawing.Size(110, 21);
            this.lb_deno1.TabIndex = 0;
            this.lb_deno1.Text = "Denominator:";
            // 
            // lb_deno2
            // 
            this.lb_deno2.AutoSize = true;
            this.lb_deno2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_deno2.Location = new System.Drawing.Point(136, 205);
            this.lb_deno2.Name = "lb_deno2";
            this.lb_deno2.Size = new System.Drawing.Size(110, 21);
            this.lb_deno2.TabIndex = 0;
            this.lb_deno2.Text = "Denominator:";
            // 
            // lb_numer1
            // 
            this.lb_numer1.AutoSize = true;
            this.lb_numer1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_numer1.Location = new System.Drawing.Point(136, 81);
            this.lb_numer1.Name = "lb_numer1";
            this.lb_numer1.Size = new System.Drawing.Size(93, 21);
            this.lb_numer1.TabIndex = 0;
            this.lb_numer1.Text = "Numerator:";
            // 
            // lb_numer2
            // 
            this.lb_numer2.AutoSize = true;
            this.lb_numer2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_numer2.Location = new System.Drawing.Point(136, 170);
            this.lb_numer2.Name = "lb_numer2";
            this.lb_numer2.Size = new System.Drawing.Size(93, 21);
            this.lb_numer2.TabIndex = 0;
            this.lb_numer2.Text = "Numerator:";
            // 
            // txB_num1
            // 
            this.txB_num1.Location = new System.Drawing.Point(258, 77);
            this.txB_num1.Name = "txB_num1";
            this.txB_num1.Size = new System.Drawing.Size(210, 29);
            this.txB_num1.TabIndex = 0;
            // 
            // txB_deno1
            // 
            this.txB_deno1.Location = new System.Drawing.Point(258, 112);
            this.txB_deno1.Name = "txB_deno1";
            this.txB_deno1.Size = new System.Drawing.Size(210, 29);
            this.txB_deno1.TabIndex = 1;
            // 
            // txB_num2
            // 
            this.txB_num2.Location = new System.Drawing.Point(258, 166);
            this.txB_num2.Name = "txB_num2";
            this.txB_num2.Size = new System.Drawing.Size(210, 29);
            this.txB_num2.TabIndex = 2;
            // 
            // txB_deno2
            // 
            this.txB_deno2.Location = new System.Drawing.Point(258, 201);
            this.txB_deno2.Name = "txB_deno2";
            this.txB_deno2.Size = new System.Drawing.Size(210, 29);
            this.txB_deno2.TabIndex = 3;
            // 
            // txB_f1
            // 
            this.txB_f1.Location = new System.Drawing.Point(475, 82);
            this.txB_f1.Multiline = true;
            this.txB_f1.Name = "txB_f1";
            this.txB_f1.ReadOnly = true;
            this.txB_f1.Size = new System.Drawing.Size(80, 51);
            this.txB_f1.TabIndex = 4;
            this.txB_f1.TabStop = false;
            this.txB_f1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txB_f2
            // 
            this.txB_f2.Location = new System.Drawing.Point(475, 172);
            this.txB_f2.Multiline = true;
            this.txB_f2.Name = "txB_f2";
            this.txB_f2.ReadOnly = true;
            this.txB_f2.Size = new System.Drawing.Size(80, 51);
            this.txB_f2.TabIndex = 4;
            this.txB_f2.TabStop = false;
            this.txB_f2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clr_btn
            // 
            this.clr_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clr_btn.Font = new System.Drawing.Font("Goudy Stout", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr_btn.Location = new System.Drawing.Point(485, 229);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(63, 54);
            this.clr_btn.TabIndex = 5;
            this.clr_btn.TabStop = false;
            this.clr_btn.Text = "C";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quit_btn.BackgroundImage")));
            this.quit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quit_btn.FlatAppearance.BorderSize = 0;
            this.quit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quit_btn.Location = new System.Drawing.Point(401, 2);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(20, 20);
            this.quit_btn.TabIndex = 0;
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 373);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.txB_f2);
            this.Controls.Add(this.txB_f1);
            this.Controls.Add(this.txB_deno2);
            this.Controls.Add(this.txB_num2);
            this.Controls.Add(this.txB_deno1);
            this.Controls.Add(this.txB_num1);
            this.Controls.Add(this.lb_deno2);
            this.Controls.Add(this.lb_numer2);
            this.Controls.Add(this.lb_numer1);
            this.Controls.Add(this.lb_deno1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb_deno1;
        private System.Windows.Forms.Label lb_deno2;
        private System.Windows.Forms.Label lb_numer1;
        private System.Windows.Forms.Label lb_numer2;
        private System.Windows.Forms.TextBox txB_num1;
        private System.Windows.Forms.TextBox txB_deno1;
        private System.Windows.Forms.TextBox txB_num2;
        private System.Windows.Forms.TextBox txB_deno2;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button minus_btn;
        private System.Windows.Forms.Button mul_btn;
        private System.Windows.Forms.Button div_btn;
        private System.Windows.Forms.Button equal_btn;
        private System.Windows.Forms.TextBox txB_f1;
        private System.Windows.Forms.TextBox txB_f2;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.Button quit_btn;
    }
}

