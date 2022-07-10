namespace sqlform
{
    partial class ContactDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.Carcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(188, 50);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(171, 22);
            this.txtname.TabIndex = 2;
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(188, 95);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(171, 22);
            this.txtlast.TabIndex = 2;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(188, 207);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(171, 22);
            this.txtaddress.TabIndex = 5;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(188, 152);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(171, 22);
            this.txtphone.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(23, 145);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(81, 29);
            this.Phone.TabIndex = 3;
            this.Phone.Text = "phone";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(56, 301);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 7;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Carcel
            // 
            this.Carcel.Location = new System.Drawing.Point(170, 301);
            this.Carcel.Name = "Carcel";
            this.Carcel.Size = new System.Drawing.Size(75, 23);
            this.Carcel.TabIndex = 7;
            this.Carcel.Text = "Cancel";
            this.Carcel.UseVisualStyleBackColor = true;
            this.Carcel.Click += new System.EventHandler(this.Carcel_Click);
            // 
            // ContactDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Carcel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.txtlast);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ContactDetails";
            this.Text = "ContactDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button Carcel;
    }
}