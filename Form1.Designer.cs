namespace Tvonlin
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
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.txtline = new System.Windows.Forms.TextBox();
            this.lblno = new System.Windows.Forms.Label();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnprv = new System.Windows.Forms.Button();
            this.btnaft = new System.Windows.Forms.Button();
            this.btnfrt = new System.Windows.Forms.Button();
            this.lsbline = new System.Windows.Forms.ListBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(-6, -3);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(908, 491);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // txtline
            // 
            this.txtline.Location = new System.Drawing.Point(158, 373);
            this.txtline.Name = "txtline";
            this.txtline.Size = new System.Drawing.Size(197, 20);
            this.txtline.TabIndex = 1;
            this.txtline.Visible = false;
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Location = new System.Drawing.Point(841, 9);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(51, 13);
            this.lblno.TabIndex = 2;
            this.lblno.Text = "رقم القناه";
            // 
            // btnlast
            // 
            this.btnlast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast.Location = new System.Drawing.Point(582, 452);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(111, 32);
            this.btnlast.TabIndex = 3;
            this.btnlast.Text = "||>>";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnprv
            // 
            this.btnprv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprv.Location = new System.Drawing.Point(500, 451);
            this.btnprv.Name = "btnprv";
            this.btnprv.Size = new System.Drawing.Size(77, 32);
            this.btnprv.TabIndex = 4;
            this.btnprv.Text = ">>";
            this.btnprv.UseVisualStyleBackColor = true;
            this.btnprv.Click += new System.EventHandler(this.btnprv_Click);
            // 
            // btnaft
            // 
            this.btnaft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaft.Location = new System.Drawing.Point(416, 450);
            this.btnaft.Name = "btnaft";
            this.btnaft.Size = new System.Drawing.Size(81, 32);
            this.btnaft.TabIndex = 5;
            this.btnaft.Text = "<<";
            this.btnaft.UseVisualStyleBackColor = true;
            this.btnaft.Click += new System.EventHandler(this.btnaft_Click);
            // 
            // btnfrt
            // 
            this.btnfrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrt.Location = new System.Drawing.Point(325, 448);
            this.btnfrt.Name = "btnfrt";
            this.btnfrt.Size = new System.Drawing.Size(85, 32);
            this.btnfrt.TabIndex = 6;
            this.btnfrt.Text = "<<||";
            this.btnfrt.UseVisualStyleBackColor = true;
            this.btnfrt.Click += new System.EventHandler(this.btnfrt_Click);
            // 
            // lsbline
            // 
            this.lsbline.FormattingEnabled = true;
            this.lsbline.Location = new System.Drawing.Point(-6, 1);
            this.lsbline.Name = "lsbline";
            this.lsbline.Size = new System.Drawing.Size(908, 4);
            this.lsbline.TabIndex = 7;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(622, 346);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(218, 20);
            this.txtsearch.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 495);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lsbline);
            this.Controls.Add(this.btnfrt);
            this.Controls.Add(this.btnaft);
            this.Controls.Add(this.btnprv);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.lblno);
            this.Controls.Add(this.txtline);
            this.Controls.Add(this.axVLCPlugin21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.TextBox txtline;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnprv;
        private System.Windows.Forms.Button btnaft;
        private System.Windows.Forms.Button btnfrt;
        private System.Windows.Forms.ListBox lsbline;
        private System.Windows.Forms.TextBox txtsearch;
    }
}

