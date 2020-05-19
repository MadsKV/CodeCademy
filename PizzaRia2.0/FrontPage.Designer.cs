namespace PizzaRia2._0
{
    partial class FrontPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPage));
            this.PriceTag = new System.Windows.Forms.Label();
            this.OnlyTag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PremiumOrderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Content = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceTag
            // 
            this.PriceTag.AutoSize = true;
            this.PriceTag.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTag.ForeColor = System.Drawing.Color.DarkOrange;
            this.PriceTag.Location = new System.Drawing.Point(78, 67);
            this.PriceTag.Name = "PriceTag";
            this.PriceTag.Size = new System.Drawing.Size(209, 112);
            this.PriceTag.TabIndex = 0;
            this.PriceTag.Text = "18$";
            // 
            // OnlyTag
            // 
            this.OnlyTag.AutoSize = true;
            this.OnlyTag.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnlyTag.ForeColor = System.Drawing.Color.DarkOrange;
            this.OnlyTag.Location = new System.Drawing.Point(57, 34);
            this.OnlyTag.Name = "OnlyTag";
            this.OnlyTag.Size = new System.Drawing.Size(75, 33);
            this.OnlyTag.TabIndex = 1;
            this.OnlyTag.Text = "Only";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peporoni Pizza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "With Tomato Sauce, Cheese, Garlic and chilli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(467, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PremiumOrderButton
            // 
            this.PremiumOrderButton.BackColor = System.Drawing.Color.Orange;
            this.PremiumOrderButton.FlatAppearance.BorderSize = 0;
            this.PremiumOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PremiumOrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PremiumOrderButton.ForeColor = System.Drawing.Color.White;
            this.PremiumOrderButton.Location = new System.Drawing.Point(140, 342);
            this.PremiumOrderButton.Name = "PremiumOrderButton";
            this.PremiumOrderButton.Size = new System.Drawing.Size(128, 34);
            this.PremiumOrderButton.TabIndex = 5;
            this.PremiumOrderButton.Text = "Order Now";
            this.PremiumOrderButton.UseVisualStyleBackColor = false;
            this.PremiumOrderButton.Click += new System.EventHandler(this.PremiumOrderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Try out our premium Peporoni Pizza,\r\nrecommended from the customers,\r\nfor its exo" +
    "tic taste, great texture and thin crispy crust\r\n";
            // 
            // Content
            // 
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(817, 423);
            this.Content.TabIndex = 7;
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PremiumOrderButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OnlyTag);
            this.Controls.Add(this.PriceTag);
            this.Controls.Add(this.Content);
            this.Name = "FrontPage";
            this.Size = new System.Drawing.Size(817, 423);
            this.Load += new System.EventHandler(this.FrontPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceTag;
        private System.Windows.Forms.Label OnlyTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PremiumOrderButton;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel Content;
    }
}
