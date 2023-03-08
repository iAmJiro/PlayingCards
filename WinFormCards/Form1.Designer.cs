namespace WinFormCards
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PictureBoxDeck = new System.Windows.Forms.PictureBox();
            this.PictureBoxCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCard)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "clubs-a-75.png");
            this.imageList1.Images.SetKeyName(1, "clubs-2-75.png");
            this.imageList1.Images.SetKeyName(2, "clubs-3-75.png");
            this.imageList1.Images.SetKeyName(3, "clubs-4-75.png");
            this.imageList1.Images.SetKeyName(4, "clubs-5-75.png");
            this.imageList1.Images.SetKeyName(5, "clubs-6-75.png");
            this.imageList1.Images.SetKeyName(6, "clubs-7-75.png");
            this.imageList1.Images.SetKeyName(7, "clubs-8-75.png");
            this.imageList1.Images.SetKeyName(8, "clubs-9-75.png");
            this.imageList1.Images.SetKeyName(9, "clubs-10-75.png");
            this.imageList1.Images.SetKeyName(10, "clubs-j-75.png");
            this.imageList1.Images.SetKeyName(11, "clubs-q-75.png");
            this.imageList1.Images.SetKeyName(12, "clubs-k-75.png");
            this.imageList1.Images.SetKeyName(13, "diamonds-a-75.png");
            this.imageList1.Images.SetKeyName(14, "diamonds-2-75.png");
            this.imageList1.Images.SetKeyName(15, "diamonds-3-75.png");
            this.imageList1.Images.SetKeyName(16, "diamonds-4-75.png");
            this.imageList1.Images.SetKeyName(17, "diamonds-5-75.png");
            this.imageList1.Images.SetKeyName(18, "diamonds-6-75.png");
            this.imageList1.Images.SetKeyName(19, "diamonds-7-75.png");
            this.imageList1.Images.SetKeyName(20, "diamonds-8-75.png");
            this.imageList1.Images.SetKeyName(21, "diamonds-9-75.png");
            this.imageList1.Images.SetKeyName(22, "diamonds-10-75.png");
            this.imageList1.Images.SetKeyName(23, "diamonds-j-75.png");
            this.imageList1.Images.SetKeyName(24, "diamonds-q-75.png");
            this.imageList1.Images.SetKeyName(25, "diamonds-k-75.png");
            this.imageList1.Images.SetKeyName(26, "hearts-a-75.png");
            this.imageList1.Images.SetKeyName(27, "hearts-2-75.png");
            this.imageList1.Images.SetKeyName(28, "hearts-3-75.png");
            this.imageList1.Images.SetKeyName(29, "hearts-4-75.png");
            this.imageList1.Images.SetKeyName(30, "hearts-5-75.png");
            this.imageList1.Images.SetKeyName(31, "hearts-6-75.png");
            this.imageList1.Images.SetKeyName(32, "hearts-7-75.png");
            this.imageList1.Images.SetKeyName(33, "hearts-8-75.png");
            this.imageList1.Images.SetKeyName(34, "hearts-9-75.png");
            this.imageList1.Images.SetKeyName(35, "hearts-10-75.png");
            this.imageList1.Images.SetKeyName(36, "hearts-j-75.png");
            this.imageList1.Images.SetKeyName(37, "hearts-q-75.png");
            this.imageList1.Images.SetKeyName(38, "hearts-k-75.png");
            this.imageList1.Images.SetKeyName(39, "spades-a-75.png");
            this.imageList1.Images.SetKeyName(40, "spades-2-75.png");
            this.imageList1.Images.SetKeyName(41, "spades-3-75.png");
            this.imageList1.Images.SetKeyName(42, "spades-4-75.png");
            this.imageList1.Images.SetKeyName(43, "spades-5-75.png");
            this.imageList1.Images.SetKeyName(44, "spades-6-75.png");
            this.imageList1.Images.SetKeyName(45, "spades-7-75.png");
            this.imageList1.Images.SetKeyName(46, "spades-8-75.png");
            this.imageList1.Images.SetKeyName(47, "spades-9-75.png");
            this.imageList1.Images.SetKeyName(48, "spades-10-75.png");
            this.imageList1.Images.SetKeyName(49, "spades-j-75.png");
            this.imageList1.Images.SetKeyName(50, "spades-q-75.png");
            this.imageList1.Images.SetKeyName(51, "spades-k-75.png");
            this.imageList1.Images.SetKeyName(52, "back-red-75-2.png");
            // 
            // PictureBoxDeck
            // 
            this.PictureBoxDeck.Image = global::WinFormCards.Properties.Resources.back_red_75_2;
            this.PictureBoxDeck.Location = new System.Drawing.Point(33, 19);
            this.PictureBoxDeck.Name = "PictureBoxDeck";
            this.PictureBoxDeck.Size = new System.Drawing.Size(75, 108);
            this.PictureBoxDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxDeck.TabIndex = 0;
            this.PictureBoxDeck.TabStop = false;
            this.PictureBoxDeck.Click += new System.EventHandler(this.PictureBoxDeck_Click);
            // 
            // PictureBoxCard
            // 
            this.PictureBoxCard.Location = new System.Drawing.Point(151, 18);
            this.PictureBoxCard.Name = "PictureBoxCard";
            this.PictureBoxCard.Size = new System.Drawing.Size(75, 109);
            this.PictureBoxCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBoxCard.TabIndex = 1;
            this.PictureBoxCard.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureBoxCard);
            this.Controls.Add(this.PictureBoxDeck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox PictureBoxDeck;
        private System.Windows.Forms.PictureBox PictureBoxCard;
    }
}

