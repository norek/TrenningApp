namespace TrenningApp
{
    partial class TrainingApp
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
            this.btnGetCustomers = new System.Windows.Forms.Button();
            this.txtCustomerList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGetCustomers
            // 
            this.btnGetCustomers.Location = new System.Drawing.Point(12, 12);
            this.btnGetCustomers.Name = "btnGetCustomers";
            this.btnGetCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnGetCustomers.TabIndex = 0;
            this.btnGetCustomers.Text = "Pobierz kontrahentów";
            this.btnGetCustomers.UseVisualStyleBackColor = true;
            this.btnGetCustomers.Click += new System.EventHandler(this.btnGetCustomers_Click);
            // 
            // txtCustomerList
            // 
            this.txtCustomerList.Location = new System.Drawing.Point(106, 12);
            this.txtCustomerList.Multiline = true;
            this.txtCustomerList.Name = "txtCustomerList";
            this.txtCustomerList.Size = new System.Drawing.Size(166, 154);
            this.txtCustomerList.TabIndex = 1;
            // 
            // TrainingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtCustomerList);
            this.Controls.Add(this.btnGetCustomers);
            this.Name = "TrainingApp";
            this.Text = "TrainingApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetCustomers;
        private System.Windows.Forms.TextBox txtCustomerList;
    }
}

