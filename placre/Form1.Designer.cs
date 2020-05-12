namespace placre
{
    partial class Form1
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
            this.main = new GMap.NET.WindowsForms.GMapControl();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Bearing = 0F;
            this.main.CanDragMap = true;
            this.main.EmptyTileColor = System.Drawing.Color.Navy;
            this.main.GrayScaleMode = false;
            this.main.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.main.LevelsKeepInMemory = 5;
            this.main.Location = new System.Drawing.Point(-3, -1);
            this.main.MarkersEnabled = true;
            this.main.MaxZoom = 18;
            this.main.MinZoom = 2;
            this.main.MouseWheelZoomEnabled = true;
            this.main.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.main.Name = "main";
            this.main.NegativeMode = false;
            this.main.PolygonsEnabled = true;
            this.main.RetryLoadTile = 0;
            this.main.RoutesEnabled = true;
            this.main.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.main.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.main.ShowTileGridLines = false;
            this.main.Size = new System.Drawing.Size(581, 454);
            this.main.TabIndex = 0;
            this.main.Zoom = 13D;
            this.main.Load += new System.EventHandler(this.main_Load);
            this.main.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.main_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(584, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(598, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(598, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Check Address";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl main;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

