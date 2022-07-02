namespace Capstone
{
    partial class frmAddAccessories
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
            this.btnCancelAccessories = new System.Windows.Forms.Button();
            this.btnUpdateAccessories = new System.Windows.Forms.Button();
            this.btnSaveAccessories = new System.Windows.Forms.Button();
            this.txtAccessories = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseAccessories = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAccessories)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelAccessories
            // 
            this.btnCancelAccessories.BackColor = System.Drawing.Color.Red;
            this.btnCancelAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAccessories.FlatAppearance.BorderSize = 0;
            this.btnCancelAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAccessories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelAccessories.ForeColor = System.Drawing.Color.White;
            this.btnCancelAccessories.Location = new System.Drawing.Point(516, 171);
            this.btnCancelAccessories.Name = "btnCancelAccessories";
            this.btnCancelAccessories.Size = new System.Drawing.Size(153, 49);
            this.btnCancelAccessories.TabIndex = 23;
            this.btnCancelAccessories.Text = "Cancel";
            this.btnCancelAccessories.UseVisualStyleBackColor = false;
            this.btnCancelAccessories.Click += new System.EventHandler(this.btnCancelAccessories_Click);
            // 
            // btnUpdateAccessories
            // 
            this.btnUpdateAccessories.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAccessories.Enabled = false;
            this.btnUpdateAccessories.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccessories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateAccessories.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccessories.Location = new System.Drawing.Point(357, 171);
            this.btnUpdateAccessories.Name = "btnUpdateAccessories";
            this.btnUpdateAccessories.Size = new System.Drawing.Size(153, 49);
            this.btnUpdateAccessories.TabIndex = 22;
            this.btnUpdateAccessories.Text = "Update";
            this.btnUpdateAccessories.UseVisualStyleBackColor = false;
            // 
            // btnSaveAccessories
            // 
            this.btnSaveAccessories.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAccessories.FlatAppearance.BorderSize = 0;
            this.btnSaveAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAccessories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveAccessories.ForeColor = System.Drawing.Color.White;
            this.btnSaveAccessories.Location = new System.Drawing.Point(198, 171);
            this.btnSaveAccessories.Name = "btnSaveAccessories";
            this.btnSaveAccessories.Size = new System.Drawing.Size(153, 49);
            this.btnSaveAccessories.TabIndex = 21;
            this.btnSaveAccessories.Text = "Save";
            this.btnSaveAccessories.UseVisualStyleBackColor = false;
            this.btnSaveAccessories.Click += new System.EventHandler(this.btnSaveAccessories_Click);
            // 
            // txtAccessories
            // 
            this.txtAccessories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAccessories.Location = new System.Drawing.Point(198, 99);
            this.txtAccessories.Name = "txtAccessories";
            this.txtAccessories.Size = new System.Drawing.Size(582, 38);
            this.txtAccessories.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Accessories";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseAccessories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 57);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Accessories";
            // 
            // btnCloseAccessories
            // 
            this.btnCloseAccessories.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseAccessories.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseAccessories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseAccessories.Location = new System.Drawing.Point(824, 12);
            this.btnCloseAccessories.Name = "btnCloseAccessories";
            this.btnCloseAccessories.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseAccessories.Size = new System.Drawing.Size(40, 38);
            this.btnCloseAccessories.TabIndex = 0;
            this.btnCloseAccessories.TabStop = false;
            this.btnCloseAccessories.Click += new System.EventHandler(this.btnCloseAccessories_Click);
            // 
            // frmAddAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 256);
            this.Controls.Add(this.btnCancelAccessories);
            this.Controls.Add(this.btnUpdateAccessories);
            this.Controls.Add(this.btnSaveAccessories);
            this.Controls.Add(this.txtAccessories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAccessories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAccessories";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAccessories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCancelAccessories;
        private Button btnUpdateAccessories;
        private Button btnSaveAccessories;
        private TextBox txtAccessories;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseAccessories;
    }
}