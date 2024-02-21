namespace MoveCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.keyEvent = new System.Windows.Forms.TextBox();
            this.dilayCar = new System.Timers.Timer();
            this.road = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.start = new System.Timers.Timer();
            this.moveCar = new System.Timers.Timer();
            this.barrier1 = new System.Windows.Forms.PictureBox();
            this.barrier2 = new System.Windows.Forms.PictureBox();
            this.barrier3 = new System.Windows.Forms.PictureBox();
            this.barrier4 = new System.Windows.Forms.PictureBox();
            this.message1 = new System.Windows.Forms.Label();
            this.message2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dilayCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier4)).BeginInit();
            this.SuspendLayout();
            // 
            // keyEvent
            // 
            this.keyEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.keyEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyEvent.Location = new System.Drawing.Point(0, 605);
            this.keyEvent.Name = "keyEvent";
            this.keyEvent.Size = new System.Drawing.Size(59, 15);
            this.keyEvent.TabIndex = 2;
            this.keyEvent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyEvent_KeyDown);
            this.keyEvent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyEvent_KeyUp);
            // 
            // dilayCar
            // 
            this.dilayCar.Enabled = true;
            this.dilayCar.Interval = 1D;
            this.dilayCar.SynchronizingObject = this;
            this.dilayCar.Elapsed += new System.Timers.ElapsedEventHandler(this.dilayCar_Elapsed);
            // 
            // road
            // 
            this.road.Image = global::MoveCar.Properties.Resources.full_road;
            this.road.Location = new System.Drawing.Point(0, -600);
            this.road.Margin = new System.Windows.Forms.Padding(0);
            this.road.Name = "road";
            this.road.Size = new System.Drawing.Size(300, 1200);
            this.road.TabIndex = 4;
            this.road.TabStop = false;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Transparent;
            this.car.Image = global::MoveCar.Properties.Resources.car;
            this.car.Location = new System.Drawing.Point(105, 355);
            this.car.Margin = new System.Windows.Forms.Padding(0);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(90, 174);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 5;
            this.car.TabStop = false;
            // 
            // start
            // 
            this.start.Interval = 1D;
            this.start.SynchronizingObject = this;
            this.start.Elapsed += new System.Timers.ElapsedEventHandler(this.start_Elapsed);
            // 
            // moveCar
            // 
            this.moveCar.Interval = 1D;
            this.moveCar.SynchronizingObject = this;
            this.moveCar.Elapsed += new System.Timers.ElapsedEventHandler(this.moveCar_Elapsed);
            // 
            // barrier1
            // 
            this.barrier1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.barrier1.Image = global::MoveCar.Properties.Resources.barrier;
            this.barrier1.Location = new System.Drawing.Point(165, -90);
            this.barrier1.Margin = new System.Windows.Forms.Padding(0);
            this.barrier1.Name = "barrier1";
            this.barrier1.Size = new System.Drawing.Size(90, 90);
            this.barrier1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barrier1.TabIndex = 6;
            this.barrier1.TabStop = false;
            // 
            // barrier2
            // 
            this.barrier2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.barrier2.Image = global::MoveCar.Properties.Resources.rock;
            this.barrier2.Location = new System.Drawing.Point(165, -90);
            this.barrier2.Margin = new System.Windows.Forms.Padding(0);
            this.barrier2.Name = "barrier2";
            this.barrier2.Size = new System.Drawing.Size(90, 90);
            this.barrier2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barrier2.TabIndex = 7;
            this.barrier2.TabStop = false;
            // 
            // barrier3
            // 
            this.barrier3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.barrier3.Image = global::MoveCar.Properties.Resources.barrier;
            this.barrier3.Location = new System.Drawing.Point(45, -90);
            this.barrier3.Margin = new System.Windows.Forms.Padding(0);
            this.barrier3.Name = "barrier3";
            this.barrier3.Size = new System.Drawing.Size(90, 90);
            this.barrier3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barrier3.TabIndex = 8;
            this.barrier3.TabStop = false;
            // 
            // barrier4
            // 
            this.barrier4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(91)))), ((int)(((byte)(108)))));
            this.barrier4.Image = global::MoveCar.Properties.Resources.rock;
            this.barrier4.Location = new System.Drawing.Point(45, -90);
            this.barrier4.Margin = new System.Windows.Forms.Padding(0);
            this.barrier4.Name = "barrier4";
            this.barrier4.Size = new System.Drawing.Size(90, 90);
            this.barrier4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barrier4.TabIndex = 9;
            this.barrier4.TabStop = false;
            // 
            // message1
            // 
            this.message1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.message1.Font = new System.Drawing.Font("B Mehr", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.message1.ForeColor = System.Drawing.Color.White;
            this.message1.Location = new System.Drawing.Point(-1, 90);
            this.message1.Name = "message1";
            this.message1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.message1.Size = new System.Drawing.Size(302, 45);
            this.message1.TabIndex = 10;
            this.message1.Text = "برای شروع فاصله را بزنید.";
            this.message1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // message2
            // 
            this.message2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.message2.Font = new System.Drawing.Font("B Mehr", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.message2.ForeColor = System.Drawing.Color.White;
            this.message2.Location = new System.Drawing.Point(-1, 140);
            this.message2.Name = "message2";
            this.message2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.message2.Size = new System.Drawing.Size(302, 45);
            this.message2.TabIndex = 11;
            this.message2.Text = "برای شروع مجدد R را بزنید.";
            this.message2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.message2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(300, 600);
            this.Controls.Add(this.message2);
            this.Controls.Add(this.message1);
            this.Controls.Add(this.barrier4);
            this.Controls.Add(this.barrier3);
            this.Controls.Add(this.barrier2);
            this.Controls.Add(this.barrier1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.road);
            this.Controls.Add(this.keyEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(306, 635);
            this.MinimumSize = new System.Drawing.Size(306, 635);
            this.Name = "Form1";
            this.Text = "!تصادف نکن";
            ((System.ComponentModel.ISupportInitialize)(this.dilayCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.road)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barrier4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label message2;

        private System.Windows.Forms.Label message1;

        private System.Windows.Forms.PictureBox barrier3;

        private System.Windows.Forms.PictureBox barrier4;

        private System.Windows.Forms.PictureBox barrier1;

        private System.Windows.Forms.PictureBox barrier2;

        private System.Timers.Timer moveCar;

        private System.Timers.Timer start;

        private System.Windows.Forms.PictureBox car;

        private System.Windows.Forms.PictureBox road;

        private System.Timers.Timer dilayCar;

        private System.Windows.Forms.TextBox keyEvent;

        #endregion
    }
}