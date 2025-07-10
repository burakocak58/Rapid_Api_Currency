namespace Rapid_Api_Currency
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblDollar = new System.Windows.Forms.Label();
			this.lblEuro = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUnitPrice = new System.Windows.Forms.TextBox();
			this.rdbDollar = new System.Windows.Forms.RadioButton();
			this.rdbEuro = new System.Windows.Forms.RadioButton();
			this.rdbSterlin = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblSterlin = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblDollar
			// 
			this.lblDollar.AutoSize = true;
			this.lblDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDollar.Location = new System.Drawing.Point(2, 24);
			this.lblDollar.Name = "lblDollar";
			this.lblDollar.Size = new System.Drawing.Size(64, 25);
			this.lblDollar.TabIndex = 0;
			this.lblDollar.Text = "label1";
			// 
			// lblEuro
			// 
			this.lblEuro.AutoSize = true;
			this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblEuro.Location = new System.Drawing.Point(168, 24);
			this.lblEuro.Name = "lblEuro";
			this.lblEuro.Size = new System.Drawing.Size(64, 25);
			this.lblEuro.TabIndex = 2;
			this.lblEuro.Text = "label3";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(73, 141);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 25);
			this.label1.TabIndex = 4;
			this.label1.Text = "Birim Tutar :";
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.Location = new System.Drawing.Point(196, 145);
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.Size = new System.Drawing.Size(160, 22);
			this.txtUnitPrice.TabIndex = 5;
			this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
			// 
			// rdbDollar
			// 
			this.rdbDollar.AutoSize = true;
			this.rdbDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdbDollar.Location = new System.Drawing.Point(62, 95);
			this.rdbDollar.Name = "rdbDollar";
			this.rdbDollar.Size = new System.Drawing.Size(74, 26);
			this.rdbDollar.TabIndex = 6;
			this.rdbDollar.TabStop = true;
			this.rdbDollar.Text = "Dolar";
			this.rdbDollar.UseVisualStyleBackColor = true;
			// 
			// rdbEuro
			// 
			this.rdbEuro.AutoSize = true;
			this.rdbEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdbEuro.Location = new System.Drawing.Point(163, 95);
			this.rdbEuro.Name = "rdbEuro";
			this.rdbEuro.Size = new System.Drawing.Size(69, 26);
			this.rdbEuro.TabIndex = 7;
			this.rdbEuro.TabStop = true;
			this.rdbEuro.Text = "Euro";
			this.rdbEuro.UseVisualStyleBackColor = true;
			// 
			// rdbSterlin
			// 
			this.rdbSterlin.AutoSize = true;
			this.rdbSterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rdbSterlin.Location = new System.Drawing.Point(259, 95);
			this.rdbSterlin.Name = "rdbSterlin";
			this.rdbSterlin.Size = new System.Drawing.Size(82, 26);
			this.rdbSterlin.TabIndex = 8;
			this.rdbSterlin.TabStop = true;
			this.rdbSterlin.Text = "Sterlin";
			this.rdbSterlin.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(196, 201);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(160, 41);
			this.button1.TabIndex = 9;
			this.button1.Text = "Dönüştür";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Location = new System.Drawing.Point(196, 173);
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.Size = new System.Drawing.Size(160, 22);
			this.txtTotalPrice.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(25, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 25);
			this.label2.TabIndex = 10;
			this.label2.Text = "Ödenecek Tutar :";
			// 
			// lblSterlin
			// 
			this.lblSterlin.AutoSize = true;
			this.lblSterlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSterlin.Location = new System.Drawing.Point(325, 24);
			this.lblSterlin.Name = "lblSterlin";
			this.lblSterlin.Size = new System.Drawing.Size(64, 25);
			this.lblSterlin.TabIndex = 12;
			this.lblSterlin.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 263);
			this.Controls.Add(this.lblSterlin);
			this.Controls.Add(this.txtTotalPrice);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.rdbSterlin);
			this.Controls.Add(this.rdbEuro);
			this.Controls.Add(this.rdbDollar);
			this.Controls.Add(this.txtUnitPrice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblEuro);
			this.Controls.Add(this.lblDollar);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDollar;
		private System.Windows.Forms.Label lblEuro;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUnitPrice;
		private System.Windows.Forms.RadioButton rdbDollar;
		private System.Windows.Forms.RadioButton rdbEuro;
		private System.Windows.Forms.RadioButton rdbSterlin;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtTotalPrice;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblSterlin;
	}
}

