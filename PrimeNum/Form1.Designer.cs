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
            this.btnGetPrime = new System.Windows.Forms.Button();
            this.PrimeList = new System.Windows.Forms.ListBox();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.timespan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prime Numbers upto : ";
            // 
            // InsertVal
            // 
            this.InsertVal.Location = new System.Drawing.Point(263, 33);
            this.InsertVal.Name = "InsertVal";
            this.InsertVal.Size = new System.Drawing.Size(210, 31);
            this.InsertVal.TabIndex = 1;
            // 
            // btnGetPrime
            // 
            this.btnGetPrime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGetPrime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetPrime.FlatAppearance.BorderSize = 2;
            this.btnGetPrime.Location = new System.Drawing.Point(37, 91);
            this.btnGetPrime.Name = "btnGetPrime";
            this.btnGetPrime.Size = new System.Drawing.Size(172, 81);
            this.btnGetPrime.TabIndex = 2;
            this.btnGetPrime.Text = "Get Prime Numbers";
            this.btnGetPrime.UseVisualStyleBackColor = true;
            this.btnGetPrime.Click += new System.EventHandler(this.getPrime_Click);
            // 
            // PrimeList
            // 
            this.PrimeList.FormattingEnabled = true;
            this.PrimeList.ItemHeight = 25;
            this.PrimeList.Location = new System.Drawing.Point(37, 193);
            this.PrimeList.Name = "PrimeList";
            this.PrimeList.Size = new System.Drawing.Size(290, 329);
            this.PrimeList.TabIndex = 3;
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(424, 91);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(164, 49);
            this.btnAddAll.TabIndex = 4;
            this.btnAddAll.Text = "Add All";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.AddAll_Click);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(389, 220);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(218, 31);
            this.Value.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.PaleGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sum Of Primes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Count : ";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(461, 281);
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Size = new System.Drawing.Size(153, 31);
            this.count.TabIndex = 8;
            // 
            // timespan
            // 
            this.timespan.Location = new System.Drawing.Point(363, 432);
            this.timespan.Name = "timespan";
            this.timespan.ReadOnly = true;
            this.timespan.Size = new System.Drawing.Size(244, 31);
            this.timespan.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Execution Time : ";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox.Controls.Add(this.PrimeList);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.timespan);
            this.groupBox.Controls.Add(this.InsertVal);
            this.groupBox.Controls.Add(this.count);
            this.groupBox.Controls.Add(this.btnGetPrime);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.btnAddAll);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.Value);
            this.groupBox.Location = new System.Drawing.Point(12, 27);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(665, 552);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            // 
            // PrimeGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(722, 626);
            this.Controls.Add(this.groupBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrimeGen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Prime Number Generator";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InsertVal;
        private System.Windows.Forms.Button btnGetPrime;
        private System.Windows.Forms.ListBox PrimeList;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.TextBox timespan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox;
    }
}

