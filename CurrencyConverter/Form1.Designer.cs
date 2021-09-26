
namespace CurrencyConverter
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
            this.picUs = new System.Windows.Forms.PictureBox();
            this.picCurrency = new System.Windows.Forms.PictureBox();
            this.btnPound = new System.Windows.Forms.Button();
            this.btnFranc = new System.Windows.Forms.Button();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnYen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblUsDollars = new System.Windows.Forms.Label();
            this.lblTextCurrency = new System.Windows.Forms.Label();
            this.txtDollars = new System.Windows.Forms.TextBox();
            this.txtBoxCurrency = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrency)).BeginInit();
            this.SuspendLayout();
            // 
            // picUs
            // 
            this.picUs.Image = global::CurrencyConverter.Properties.Resources.usa;
            this.picUs.Location = new System.Drawing.Point(111, 72);
            this.picUs.Name = "picUs";
            this.picUs.Size = new System.Drawing.Size(128, 89);
            this.picUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUs.TabIndex = 0;
            this.picUs.TabStop = false;
            // 
            // picCurrency
            // 
            this.picCurrency.Location = new System.Drawing.Point(111, 167);
            this.picCurrency.Name = "picCurrency";
            this.picCurrency.Size = new System.Drawing.Size(128, 89);
            this.picCurrency.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCurrency.TabIndex = 1;
            this.picCurrency.TabStop = false;
            // 
            // btnPound
            // 
            this.btnPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPound.Location = new System.Drawing.Point(191, 298);
            this.btnPound.Name = "btnPound";
            this.btnPound.Size = new System.Drawing.Size(92, 33);
            this.btnPound.TabIndex = 2;
            this.btnPound.Text = "Pounds";
            this.btnPound.UseVisualStyleBackColor = true;
            this.btnPound.Click += new System.EventHandler(this.btnPound_Click);
            // 
            // btnFranc
            // 
            this.btnFranc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFranc.Location = new System.Drawing.Point(350, 298);
            this.btnFranc.Name = "btnFranc";
            this.btnFranc.Size = new System.Drawing.Size(92, 33);
            this.btnFranc.TabIndex = 3;
            this.btnFranc.Text = "Francs";
            this.btnFranc.UseVisualStyleBackColor = true;
            this.btnFranc.Click += new System.EventHandler(this.btnFranc_Click);
            // 
            // btnMark
            // 
            this.btnMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.Location = new System.Drawing.Point(501, 298);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(92, 33);
            this.btnMark.TabIndex = 4;
            this.btnMark.Text = "Marks";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // btnYen
            // 
            this.btnYen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYen.Location = new System.Drawing.Point(272, 337);
            this.btnYen.Name = "btnYen";
            this.btnYen.Size = new System.Drawing.Size(92, 33);
            this.btnYen.TabIndex = 5;
            this.btnYen.Text = "Yen";
            this.btnYen.UseVisualStyleBackColor = true;
            this.btnYen.Click += new System.EventHandler(this.btnYen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(426, 337);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 33);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblUsDollars
            // 
            this.lblUsDollars.AutoSize = true;
            this.lblUsDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsDollars.Location = new System.Drawing.Point(330, 107);
            this.lblUsDollars.Name = "lblUsDollars";
            this.lblUsDollars.Size = new System.Drawing.Size(67, 24);
            this.lblUsDollars.TabIndex = 7;
            this.lblUsDollars.Text = "Dollars";
            // 
            // lblTextCurrency
            // 
            this.lblTextCurrency.AutoSize = true;
            this.lblTextCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextCurrency.Location = new System.Drawing.Point(330, 200);
            this.lblTextCurrency.Name = "lblTextCurrency";
            this.lblTextCurrency.Size = new System.Drawing.Size(144, 24);
            this.lblTextCurrency.TabIndex = 8;
            this.lblTextCurrency.Text = "Select Currency";
            // 
            // txtDollars
            // 
            this.txtDollars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDollars.Location = new System.Drawing.Point(501, 104);
            this.txtDollars.Name = "txtDollars";
            this.txtDollars.Size = new System.Drawing.Size(212, 29);
            this.txtDollars.TabIndex = 9;
            // 
            // txtBoxCurrency
            // 
            this.txtBoxCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCurrency.Location = new System.Drawing.Point(501, 200);
            this.txtBoxCurrency.Name = "txtBoxCurrency";
            this.txtBoxCurrency.Size = new System.Drawing.Size(212, 29);
            this.txtBoxCurrency.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxCurrency);
            this.Controls.Add(this.txtDollars);
            this.Controls.Add(this.lblTextCurrency);
            this.Controls.Add(this.lblUsDollars);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnYen);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.btnFranc);
            this.Controls.Add(this.btnPound);
            this.Controls.Add(this.picCurrency);
            this.Controls.Add(this.picUs);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.picUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCurrency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUs;
        private System.Windows.Forms.PictureBox picCurrency;
        private System.Windows.Forms.Button btnPound;
        private System.Windows.Forms.Button btnFranc;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnYen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblUsDollars;
        private System.Windows.Forms.Label lblTextCurrency;
        private System.Windows.Forms.TextBox txtDollars;
        private System.Windows.Forms.TextBox txtBoxCurrency;
    }
}

