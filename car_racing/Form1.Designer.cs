namespace car_racing
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
            this.components = new System.ComponentModel.Container();
            this.road1 = new System.Windows.Forms.PictureBox();
            this.road2 = new System.Windows.Forms.PictureBox();
            this.road3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Scorel = new System.Windows.Forms.Label();
            this.car = new System.Windows.Forms.PictureBox();
            this.ecar1 = new System.Windows.Forms.PictureBox();
            this.ecar2 = new System.Windows.Forms.PictureBox();
            this.ecar3 = new System.Windows.Forms.PictureBox();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.road1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecar3)).BeginInit();
            this.SuspendLayout();
            // 
            // road1
            // 
            this.road1.BackColor = System.Drawing.Color.White;
            this.road1.Location = new System.Drawing.Point(175, 29);
            this.road1.Name = "road1";
            this.road1.Size = new System.Drawing.Size(18, 97);
            this.road1.TabIndex = 0;
            this.road1.TabStop = false;
            // 
            // road2
            // 
            this.road2.BackColor = System.Drawing.Color.White;
            this.road2.Location = new System.Drawing.Point(175, 160);
            this.road2.Name = "road2";
            this.road2.Size = new System.Drawing.Size(18, 113);
            this.road2.TabIndex = 1;
            this.road2.TabStop = false;
            // 
            // road3
            // 
            this.road3.BackColor = System.Drawing.Color.White;
            this.road3.Location = new System.Drawing.Point(175, 302);
            this.road3.Name = "road3";
            this.road3.Size = new System.Drawing.Size(18, 102);
            this.road3.TabIndex = 2;
            this.road3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(1, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 465);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Location = new System.Drawing.Point(368, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 465);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Scorel
            // 
            this.Scorel.AutoSize = true;
            this.Scorel.BackColor = System.Drawing.Color.Transparent;
            this.Scorel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Scorel.ForeColor = System.Drawing.Color.Lime;
            this.Scorel.Location = new System.Drawing.Point(25, 0);
            this.Scorel.Name = "Scorel";
            this.Scorel.Size = new System.Drawing.Size(95, 37);
            this.Scorel.TabIndex = 5;
            this.Scorel.Text = "Score:";
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Black;
            this.car.Image = global::car_racing.Properties.Resources.redcar;
            this.car.Location = new System.Drawing.Point(136, 397);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(33, 68);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 6;
            this.car.TabStop = false;
            // 
            // ecar1
            // 
            this.ecar1.Image = global::car_racing.Properties.Resources.ecar;
            this.ecar1.Location = new System.Drawing.Point(39, 84);
            this.ecar1.Name = "ecar1";
            this.ecar1.Size = new System.Drawing.Size(36, 65);
            this.ecar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ecar1.TabIndex = 7;
            this.ecar1.TabStop = false;
            // 
            // ecar2
            // 
            this.ecar2.Image = global::car_racing.Properties.Resources.ecar;
            this.ecar2.Location = new System.Drawing.Point(199, 194);
            this.ecar2.Name = "ecar2";
            this.ecar2.Size = new System.Drawing.Size(36, 65);
            this.ecar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ecar2.TabIndex = 8;
            this.ecar2.TabStop = false;
            // 
            // ecar3
            // 
            this.ecar3.Image = global::car_racing.Properties.Resources.ecar;
            this.ecar3.Location = new System.Drawing.Point(291, 84);
            this.ecar3.Name = "ecar3";
            this.ecar3.Size = new System.Drawing.Size(36, 65);
            this.ecar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ecar3.TabIndex = 9;
            this.ecar3.TabStop = false;
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Yellow;
            this.button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button.ForeColor = System.Drawing.Color.Red;
            this.button.Location = new System.Drawing.Point(99, 265);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(191, 89);
            this.button.TabIndex = 10;
            this.button.Text = "Game Over..!";
            this.button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.button);
            this.Controls.Add(this.ecar3);
            this.Controls.Add(this.ecar2);
            this.Controls.Add(this.ecar1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.Scorel);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.road3);
            this.Controls.Add(this.road2);
            this.Controls.Add(this.road1);
            this.Name = "Form1";
            this.Text = "Car Racing ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyup);
            ((System.ComponentModel.ISupportInitialize)(this.road1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox road1;
        private PictureBox road2;
        private PictureBox road3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private Label Scorel;
        private PictureBox car;
        private PictureBox ecar1;
        private PictureBox ecar2;
        private PictureBox ecar3;
        private Button button;
    }
}