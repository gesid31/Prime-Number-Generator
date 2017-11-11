namespace PrimeNum
{
    partial class PrimeGen
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
            this.label1 = new System.Windows.Forms.Label();
            this.InsertVal = new System.Windows.Forms.TextBox();
            this.getPrime = new System.Windows.Forms.Button();
            this.PrimeList = new System.Windows.Forms.ListBox();
            this.AddAll = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.timespan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prime Numbers upto : ";
            // 
            // InsertVal
            // 
            this.InsertVal.Location = new System.Drawing.Point(259, 45);
            this.InsertVal.Name = "InsertVal";
            this.InsertVal.Size = new System.Drawing.Size(210, 31);
            this.InsertVal.TabIndex = 1;
            // 
            // getPrime
            // 
            this.getPrime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getPrime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.getPrime.FlatAppearance.BorderSize = 2;
            this.getPrime.Location = new System.Drawing.Point(33, 103);
            this.getPrime.Name = "getPrime";
            this.getPrime.Size = new System.Drawing.Size(172, 81);
            this.getPrime.TabIndex = 2;
            this.getPrime.Text = "Get Prime Numbers";
            this.getPrime.UseVisualStyleBackColor = true;
            this.getPrime.Click += new System.EventHandler(this.getPrime_Click);
            // 
            // PrimeList
            // 
            this.PrimeList.FormattingEnabled = true;
            this.PrimeList.ItemHeight = 25;
            this.PrimeList.Location = new System.Drawing.Point(33, 205);
            this.PrimeList.Name = "PrimeList";
            this.PrimeList.Size = new System.Drawing.Size(290, 329);
            this.PrimeList.TabIndex = 3;
            // 
            // AddAll
            // 
            this.AddAll.Location = new System.Drawing.Point(420, 103);
            this.AddAll.Name = "AddAll";
            this.AddAll.Size = new System.Drawing.Size(164, 49);
            this.AddAll.TabIndex = 4;
            this.AddAll.Text = "Add All";
            this.AddAll.UseVisualStyleBackColor = true;
            this.AddAll.Click += new System.EventHandler(this.AddAll_Click);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(385, 232);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(218, 31);
            this.Value.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(396, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sum Of Primes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Count : ";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(457, 293);
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Size = new System.Drawing.Size(212, 31);
            this.count.TabIndex = 8;
            // 
            // timespan
            // 
            this.timespan.Location = new System.Drawing.Point(385, 444);
            this.timespan.Name = "timespan";
            this.timespan.ReadOnly = true;
            this.timespan.Size = new System.Drawing.Size(244, 31);
            this.timespan.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(349, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Execution Time : ";
            // 
            // PrimeGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 606);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timespan);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.AddAll);
            this.Controls.Add(this.PrimeList);
            this.Controls.Add(this.getPrime);
            this.Controls.Add(this.InsertVal);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrimeGen";
            this.Text = "Prime Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InsertVal;
        private System.Windows.Forms.Button getPrime;
        private System.Windows.Forms.ListBox PrimeList;
        private System.Windows.Forms.Button AddAll;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox timespan;
        private System.Windows.Forms.Label label4;
    }
}

