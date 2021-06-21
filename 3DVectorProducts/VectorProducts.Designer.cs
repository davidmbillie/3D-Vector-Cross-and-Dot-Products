
namespace Product
{
	partial class VectorProducts
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
			this.txtui = new System.Windows.Forms.TextBox();
			this.txtuj = new System.Windows.Forms.TextBox();
			this.txtuk = new System.Windows.Forms.TextBox();
			this.txtvi = new System.Windows.Forms.TextBox();
			this.txtvj = new System.Windows.Forms.TextBox();
			this.txtvk = new System.Windows.Forms.TextBox();
			this.crossProduct = new System.Windows.Forms.Button();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.dotProduct = new System.Windows.Forms.Button();
			this.btnSetU = new System.Windows.Forms.Button();
			this.btnSetV = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtui
			// 
			this.txtui.Location = new System.Drawing.Point(47, 91);
			this.txtui.Name = "txtui";
			this.txtui.Size = new System.Drawing.Size(125, 27);
			this.txtui.TabIndex = 0;
			// 
			// txtuj
			// 
			this.txtuj.Location = new System.Drawing.Point(197, 91);
			this.txtuj.Name = "txtuj";
			this.txtuj.Size = new System.Drawing.Size(125, 27);
			this.txtuj.TabIndex = 1;
			// 
			// txtuk
			// 
			this.txtuk.Location = new System.Drawing.Point(348, 91);
			this.txtuk.Name = "txtuk";
			this.txtuk.Size = new System.Drawing.Size(125, 27);
			this.txtuk.TabIndex = 2;
			// 
			// txtvi
			// 
			this.txtvi.Location = new System.Drawing.Point(47, 154);
			this.txtvi.Name = "txtvi";
			this.txtvi.Size = new System.Drawing.Size(125, 27);
			this.txtvi.TabIndex = 3;
			// 
			// txtvj
			// 
			this.txtvj.Location = new System.Drawing.Point(197, 154);
			this.txtvj.Name = "txtvj";
			this.txtvj.Size = new System.Drawing.Size(125, 27);
			this.txtvj.TabIndex = 4;
			// 
			// txtvk
			// 
			this.txtvk.Location = new System.Drawing.Point(348, 154);
			this.txtvk.Name = "txtvk";
			this.txtvk.Size = new System.Drawing.Size(125, 27);
			this.txtvk.TabIndex = 5;
			// 
			// crossProduct
			// 
			this.crossProduct.Location = new System.Drawing.Point(47, 228);
			this.crossProduct.Name = "crossProduct";
			this.crossProduct.Size = new System.Drawing.Size(169, 29);
			this.crossProduct.TabIndex = 6;
			this.crossProduct.Text = "Cross Product";
			this.crossProduct.UseVisualStyleBackColor = true;
			this.crossProduct.Click += new System.EventHandler(this.crossProduct_Click);
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(47, 294);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(275, 27);
			this.txtAnswer.TabIndex = 7;
			// 
			// dotProduct
			// 
			this.dotProduct.Location = new System.Drawing.Point(222, 228);
			this.dotProduct.Name = "dotProduct";
			this.dotProduct.Size = new System.Drawing.Size(192, 29);
			this.dotProduct.TabIndex = 8;
			this.dotProduct.Text = "Dot Product";
			this.dotProduct.UseVisualStyleBackColor = true;
			this.dotProduct.Click += new System.EventHandler(this.dotProduct_Click);
			// 
			// btnSetU
			// 
			this.btnSetU.Location = new System.Drawing.Point(47, 352);
			this.btnSetU.Name = "btnSetU";
			this.btnSetU.Size = new System.Drawing.Size(94, 29);
			this.btnSetU.TabIndex = 9;
			this.btnSetU.Text = "set u";
			this.btnSetU.UseVisualStyleBackColor = true;
			this.btnSetU.Click += new System.EventHandler(this.btnSetU_Click);
			// 
			// btnSetV
			// 
			this.btnSetV.Location = new System.Drawing.Point(163, 352);
			this.btnSetV.Name = "btnSetV";
			this.btnSetV.Size = new System.Drawing.Size(94, 29);
			this.btnSetV.TabIndex = 10;
			this.btnSetV.Text = "set v";
			this.btnSetV.UseVisualStyleBackColor = true;
			this.btnSetV.Click += new System.EventHandler(this.btnSetV_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 20);
			this.label1.TabIndex = 11;
			this.label1.Text = "u";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 131);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 20);
			this.label2.TabIndex = 12;
			this.label2.Text = "v";
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.ForeColor = System.Drawing.Color.DarkRed;
			this.lblError.Location = new System.Drawing.Point(47, 31);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(103, 20);
			this.lblError.TabIndex = 13;
			this.lblError.Text = "Error Message";
			this.lblError.Visible = false;
			// 
			// VectorProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 423);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSetV);
			this.Controls.Add(this.btnSetU);
			this.Controls.Add(this.dotProduct);
			this.Controls.Add(this.txtAnswer);
			this.Controls.Add(this.crossProduct);
			this.Controls.Add(this.txtvk);
			this.Controls.Add(this.txtvj);
			this.Controls.Add(this.txtvi);
			this.Controls.Add(this.txtuk);
			this.Controls.Add(this.txtuj);
			this.Controls.Add(this.txtui);
			this.Name = "VectorProducts";
			this.Text = "Vector Products";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtui;
		private System.Windows.Forms.TextBox txtuj;
		private System.Windows.Forms.TextBox txtuk;
		private System.Windows.Forms.TextBox txtvi;
		private System.Windows.Forms.TextBox txtvj;
		private System.Windows.Forms.TextBox txtvk;
		private System.Windows.Forms.Button crossProduct;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Button btnDot;
		private System.Windows.Forms.Button dotProduct;
		private System.Windows.Forms.Button btnSetU;
		private System.Windows.Forms.Button btnSetV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblError;
	}
}

