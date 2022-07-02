namespace Capstone
{
    partial class frmAddLense
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
            this.txtFeature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelLense = new System.Windows.Forms.Button();
            this.btnUpdateLense = new System.Windows.Forms.Button();
            this.btnSaveLense = new System.Windows.Forms.Button();
            this.txtLenseTypes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseLense = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLense)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFeature
            // 
            this.txtFeature.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFeature.Location = new System.Drawing.Point(209, 156);
            this.txtFeature.Name = "txtFeature";
            this.txtFeature.Size = new System.Drawing.Size(582, 38);
            this.txtFeature.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(40, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Features";
            // 
            // btnCancelLense
            // 
            this.btnCancelLense.BackColor = System.Drawing.Color.Red;
            this.btnCancelLense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelLense.FlatAppearance.BorderSize = 0;
            this.btnCancelLense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelLense.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelLense.ForeColor = System.Drawing.Color.White;
            this.btnCancelLense.Location = new System.Drawing.Point(527, 217);
            this.btnCancelLense.Name = "btnCancelLense";
            this.btnCancelLense.Size = new System.Drawing.Size(153, 49);
            this.btnCancelLense.TabIndex = 23;
            this.btnCancelLense.Text = "Cancel";
            this.btnCancelLense.UseVisualStyleBackColor = false;
            this.btnCancelLense.Click += new System.EventHandler(this.btnCancelLense_Click);
            // 
            // btnUpdateLense
            // 
            this.btnUpdateLense.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateLense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateLense.Enabled = false;
            this.btnUpdateLense.FlatAppearance.BorderSize = 0;
            this.btnUpdateLense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLense.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateLense.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLense.Location = new System.Drawing.Point(368, 217);
            this.btnUpdateLense.Name = "btnUpdateLense";
            this.btnUpdateLense.Size = new System.Drawing.Size(153, 49);
            this.btnUpdateLense.TabIndex = 22;
            this.btnUpdateLense.Text = "Update";
            this.btnUpdateLense.UseVisualStyleBackColor = false;
            // 
            // btnSaveLense
            // 
            this.btnSaveLense.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveLense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLense.FlatAppearance.BorderSize = 0;
            this.btnSaveLense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLense.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveLense.ForeColor = System.Drawing.Color.White;
            this.btnSaveLense.Location = new System.Drawing.Point(209, 217);
            this.btnSaveLense.Name = "btnSaveLense";
            this.btnSaveLense.Size = new System.Drawing.Size(153, 49);
            this.btnSaveLense.TabIndex = 21;
            this.btnSaveLense.Text = "Save";
            this.btnSaveLense.UseVisualStyleBackColor = false;
            this.btnSaveLense.Click += new System.EventHandler(this.btnSaveLense_Click);
            // 
            // txtLenseTypes
            // 
            this.txtLenseTypes.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLenseTypes.Location = new System.Drawing.Point(209, 94);
            this.txtLenseTypes.Name = "txtLenseTypes";
            this.txtLenseTypes.Size = new System.Drawing.Size(582, 38);
            this.txtLenseTypes.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lense Types";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseLense);
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
            this.label1.Size = new System.Drawing.Size(200, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eyeglass Lense";
            // 
            // btnCloseLense
            // 
            this.btnCloseLense.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLense.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseLense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseLense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseLense.Location = new System.Drawing.Point(824, 12);
            this.btnCloseLense.Name = "btnCloseLense";
            this.btnCloseLense.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseLense.Size = new System.Drawing.Size(40, 38);
            this.btnCloseLense.TabIndex = 0;
            this.btnCloseLense.TabStop = false;
            this.btnCloseLense.Click += new System.EventHandler(this.btnCloseLense_Click);
            // 
            // frmAddLense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 309);
            this.Controls.Add(this.txtFeature);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelLense);
            this.Controls.Add(this.btnUpdateLense);
            this.Controls.Add(this.btnSaveLense);
            this.Controls.Add(this.txtLenseTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddLense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddLense";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtFeature;
        private Label label3;
        private Button btnCancelLense;
        private Button btnUpdateLense;
        private Button btnSaveLense;
        private TextBox txtLenseTypes;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseLense;
    }
}