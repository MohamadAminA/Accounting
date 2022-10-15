namespace Acconting.App
{
    partial class UICustomers
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.pbCustomerImage = new System.Windows.Forms.PictureBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.tbName.Location = new System.Drawing.Point(249, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(270, 91);
            this.tbName.TabIndex = 0;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatName);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(104, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 84);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(104, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 84);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone : ";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.tbPhone.Location = new System.Drawing.Point(249, 119);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(270, 91);
            this.tbPhone.TabIndex = 2;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(104, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 84);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email : ";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.tbEmail.Location = new System.Drawing.Point(249, 209);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(270, 91);
            this.tbEmail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(104, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 84);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address : ";
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Comic Sans MS", 18F);
            this.tbAddress.Location = new System.Drawing.Point(249, 300);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAddress.Size = new System.Drawing.Size(371, 145);
            this.tbAddress.TabIndex = 6;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("G2 Geometr885 BT", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(530, 558);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(250, 74);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // pbCustomerImage
            // 
            this.pbCustomerImage.BackColor = System.Drawing.Color.Transparent;
            this.pbCustomerImage.ErrorImage = global::Acconting.App.Properties.Resources.no_profile_image;
            this.pbCustomerImage.Image = global::Acconting.App.Properties.Resources.no_profile_image;
            this.pbCustomerImage.Location = new System.Drawing.Point(873, 41);
            this.pbCustomerImage.Name = "pbCustomerImage";
            this.pbCustomerImage.Size = new System.Drawing.Size(266, 416);
            this.pbCustomerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCustomerImage.TabIndex = 9;
            this.pbCustomerImage.TabStop = false;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Font = new System.Drawing.Font("G2 Geometr885 BT", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPicture.Location = new System.Drawing.Point(873, 484);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(266, 77);
            this.btnAddPicture.TabIndex = 10;
            this.btnAddPicture.Text = "Add Picture";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // UICustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(32F, 74F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Acconting.App.Properties.Resources.Programing;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1190, 666);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.pbCustomerImage);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Font = new System.Drawing.Font("Comic Sans MS", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "UICustomers";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Customer";
            ((System.ComponentModel.ISupportInitialize)(this.pbCustomerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.PictureBox pbCustomerImage;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.ErrorProvider errorProviderName;
    }
}