namespace Capstone
{
    partial class frmAddFrame
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelFrame = new System.Windows.Forms.Button();
            this.btnUpdateFrame = new System.Windows.Forms.Button();
            this.btnSaveFrame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseFrame = new System.Windows.Forms.PictureBox();
            this.comBoxTypeFrame = new System.Windows.Forms.ComboBox();
            this.txtNameFrame = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPriceFrame = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GeneratePCodeFrame = new System.Windows.Forms.LinkLabel();
            this.txtPCodeFrame = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comBoxMaterialFrame = new System.Windows.Forms.ComboBox();
            this.comBoxShapeFrame = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(75, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Frame Material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(75, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Frame Shapes";
            // 
            // btnCancelFrame
            // 
            this.btnCancelFrame.BackColor = System.Drawing.Color.Red;
            this.btnCancelFrame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelFrame.FlatAppearance.BorderSize = 0;
            this.btnCancelFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelFrame.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelFrame.ForeColor = System.Drawing.Color.White;
            this.btnCancelFrame.Location = new System.Drawing.Point(522, 478);
            this.btnCancelFrame.Name = "btnCancelFrame";
            this.btnCancelFrame.Size = new System.Drawing.Size(153, 49);
            this.btnCancelFrame.TabIndex = 22;
            this.btnCancelFrame.Text = "Cancel";
            this.btnCancelFrame.UseVisualStyleBackColor = false;
            this.btnCancelFrame.Click += new System.EventHandler(this.btnCancelFrame_Click);
            // 
            // btnUpdateFrame
            // 
            this.btnUpdateFrame.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateFrame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateFrame.Enabled = false;
            this.btnUpdateFrame.FlatAppearance.BorderSize = 0;
            this.btnUpdateFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFrame.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateFrame.ForeColor = System.Drawing.Color.White;
            this.btnUpdateFrame.Location = new System.Drawing.Point(363, 478);
            this.btnUpdateFrame.Name = "btnUpdateFrame";
            this.btnUpdateFrame.Size = new System.Drawing.Size(153, 49);
            this.btnUpdateFrame.TabIndex = 21;
            this.btnUpdateFrame.Text = "Update";
            this.btnUpdateFrame.UseVisualStyleBackColor = false;
            // 
            // btnSaveFrame
            // 
            this.btnSaveFrame.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveFrame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveFrame.FlatAppearance.BorderSize = 0;
            this.btnSaveFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveFrame.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveFrame.ForeColor = System.Drawing.Color.White;
            this.btnSaveFrame.Location = new System.Drawing.Point(204, 478);
            this.btnSaveFrame.Name = "btnSaveFrame";
            this.btnSaveFrame.Size = new System.Drawing.Size(153, 49);
            this.btnSaveFrame.TabIndex = 20;
            this.btnSaveFrame.Text = "Save";
            this.btnSaveFrame.UseVisualStyleBackColor = false;
            this.btnSaveFrame.Click += new System.EventHandler(this.btnSaveFrame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Frame Types";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseFrame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 57);
            this.panel1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eyeglass Frame";
            // 
            // btnCloseFrame
            // 
            this.btnCloseFrame.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseFrame.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseFrame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseFrame.Location = new System.Drawing.Point(824, 12);
            this.btnCloseFrame.Name = "btnCloseFrame";
            this.btnCloseFrame.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseFrame.Size = new System.Drawing.Size(40, 38);
            this.btnCloseFrame.TabIndex = 0;
            this.btnCloseFrame.TabStop = false;
            this.btnCloseFrame.Click += new System.EventHandler(this.btnCloseFrame_Click);
            // 
            // comBoxTypeFrame
            // 
            this.comBoxTypeFrame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxTypeFrame.FormattingEnabled = true;
            this.comBoxTypeFrame.Location = new System.Drawing.Point(204, 142);
            this.comBoxTypeFrame.Name = "comBoxTypeFrame";
            this.comBoxTypeFrame.Size = new System.Drawing.Size(387, 36);
            this.comBoxTypeFrame.TabIndex = 30;
            // 
            // txtNameFrame
            // 
            this.txtNameFrame.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameFrame.Location = new System.Drawing.Point(244, 304);
            this.txtNameFrame.Name = "txtNameFrame";
            this.txtNameFrame.Size = new System.Drawing.Size(347, 38);
            this.txtNameFrame.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(75, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "Frame Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(35, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Price";
            // 
            // txtPriceFrame
            // 
            this.txtPriceFrame.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPriceFrame.Location = new System.Drawing.Point(204, 196);
            this.txtPriceFrame.Name = "txtPriceFrame";
            this.txtPriceFrame.PlaceholderText = "0.00";
            this.txtPriceFrame.Size = new System.Drawing.Size(199, 38);
            this.txtPriceFrame.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(35, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 28);
            this.label7.TabIndex = 33;
            this.label7.Text = "Description";
            // 
            // GeneratePCodeFrame
            // 
            this.GeneratePCodeFrame.AutoSize = true;
            this.GeneratePCodeFrame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeneratePCodeFrame.LinkColor = System.Drawing.Color.Navy;
            this.GeneratePCodeFrame.Location = new System.Drawing.Point(485, 97);
            this.GeneratePCodeFrame.Name = "GeneratePCodeFrame";
            this.GeneratePCodeFrame.Size = new System.Drawing.Size(103, 28);
            this.GeneratePCodeFrame.TabIndex = 38;
            this.GeneratePCodeFrame.TabStop = true;
            this.GeneratePCodeFrame.Text = "[Generate]";
            // 
            // txtPCodeFrame
            // 
            this.txtPCodeFrame.Enabled = false;
            this.txtPCodeFrame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPCodeFrame.Location = new System.Drawing.Point(204, 91);
            this.txtPCodeFrame.Name = "txtPCodeFrame";
            this.txtPCodeFrame.PlaceholderText = "P000000";
            this.txtPCodeFrame.Size = new System.Drawing.Size(256, 34);
            this.txtPCodeFrame.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(35, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 28);
            this.label8.TabIndex = 36;
            this.label8.Text = "Product Code";
            // 
            // comBoxMaterialFrame
            // 
            this.comBoxMaterialFrame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxMaterialFrame.FormattingEnabled = true;
            this.comBoxMaterialFrame.Location = new System.Drawing.Point(244, 420);
            this.comBoxMaterialFrame.Name = "comBoxMaterialFrame";
            this.comBoxMaterialFrame.Size = new System.Drawing.Size(347, 36);
            this.comBoxMaterialFrame.TabIndex = 35;
            // 
            // comBoxShapeFrame
            // 
            this.comBoxShapeFrame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxShapeFrame.FormattingEnabled = true;
            this.comBoxShapeFrame.Location = new System.Drawing.Point(244, 362);
            this.comBoxShapeFrame.Name = "comBoxShapeFrame";
            this.comBoxShapeFrame.Size = new System.Drawing.Size(347, 36);
            this.comBoxShapeFrame.TabIndex = 34;
            this.comBoxShapeFrame.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmAddFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 549);
            this.Controls.Add(this.GeneratePCodeFrame);
            this.Controls.Add(this.txtPCodeFrame);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comBoxMaterialFrame);
            this.Controls.Add(this.comBoxShapeFrame);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNameFrame);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comBoxTypeFrame);
            this.Controls.Add(this.txtPriceFrame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelFrame);
            this.Controls.Add(this.btnUpdateFrame);
            this.Controls.Add(this.btnSaveFrame);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmServiceList";
            this.Load += new System.EventHandler(this.frmServiceList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private Label label3;
        private Button btnCancelFrame;
        private Button btnUpdateFrame;
        private Button btnSaveFrame;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseFrame;
        private ComboBox comBoxTypeFrame;
        private TextBox txtNameFrame;
        private Label label6;
        private Label label5;
        private TextBox txtPriceFrame;
        private Label label7;
        private LinkLabel GeneratePCodeFrame;
        private TextBox txtPCodeFrame;
        private Label label8;
        private ComboBox comBoxMaterialFrame;
        private ComboBox comBoxShapeFrame;
    }
}