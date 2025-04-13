namespace CarInventory
{
    partial class MainVehicle
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
            dgvCarInventory = new DataGridView();
            txtbxVehicle = new TextBox();
            txtbxModel = new TextBox();
            txtbxYear = new TextBox();
            txtbxColor = new TextBox();
            txtbxPrice = new TextBox();
            lblMake = new Label();
            lblModel = new Label();
            lblYear = new Label();
            lblColor = new Label();
            lblPrice = new Label();
            btnAddVehicle = new Button();
            btnRemove = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarInventory).BeginInit();
            SuspendLayout();
            // 
            // dgvCarInventory
            // 
            dgvCarInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarInventory.Location = new Point(392, 88);
            dgvCarInventory.Name = "dgvCarInventory";
            dgvCarInventory.Size = new Size(380, 250);
            dgvCarInventory.TabIndex = 0;
            // 
            // txtbxVehicle
            // 
            txtbxVehicle.Location = new Point(217, 88);
            txtbxVehicle.Name = "txtbxVehicle";
            txtbxVehicle.Size = new Size(100, 23);
            txtbxVehicle.TabIndex = 1;
            txtbxVehicle.TextChanged += txtbxVehicle_TextChanged;
            // 
            // txtbxModel
            // 
            txtbxModel.Location = new Point(217, 134);
            txtbxModel.Name = "txtbxModel";
            txtbxModel.Size = new Size(100, 23);
            txtbxModel.TabIndex = 2;
            // 
            // txtbxYear
            // 
            txtbxYear.Location = new Point(217, 190);
            txtbxYear.Name = "txtbxYear";
            txtbxYear.Size = new Size(100, 23);
            txtbxYear.TabIndex = 3;
            // 
            // txtbxColor
            // 
            txtbxColor.Location = new Point(217, 250);
            txtbxColor.Name = "txtbxColor";
            txtbxColor.Size = new Size(100, 23);
            txtbxColor.TabIndex = 4;
            // 
            // txtbxPrice
            // 
            txtbxPrice.Location = new Point(217, 315);
            txtbxPrice.Name = "txtbxPrice";
            txtbxPrice.Size = new Size(100, 23);
            txtbxPrice.TabIndex = 5;
            // 
            // lblMake
            // 
            lblMake.AutoSize = true;
            lblMake.Location = new Point(99, 96);
            lblMake.Name = "lblMake";
            lblMake.Size = new Size(96, 15);
            lblMake.TabIndex = 6;
            lblMake.Text = "Make of Vehicle: ";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(99, 142);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(98, 15);
            lblModel.TabIndex = 7;
            lblModel.Text = "Model of Vehicle:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(99, 198);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(89, 15);
            lblYear.TabIndex = 8;
            lblYear.Text = "Year of Vehicle: ";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(99, 253);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(90, 15);
            lblColor.TabIndex = 9;
            lblColor.Text = "Color of Vehicle";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(99, 323);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(90, 15);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price of Vehicle:";
            // 
            // btnAddVehicle
            // 
            btnAddVehicle.Location = new Point(392, 372);
            btnAddVehicle.Name = "btnAddVehicle";
            btnAddVehicle.Size = new Size(114, 23);
            btnAddVehicle.TabIndex = 11;
            btnAddVehicle.Text = "Add Vehicle";
            btnAddVehicle.UseVisualStyleBackColor = true;
            btnAddVehicle.Click += this.btnAddVehicle_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(594, 372);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(125, 23);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "Remove Vehicle ";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += this.btnRemove_Click; 
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(556, 46);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 13;
            label1.Text = "Vehicle List : ";
            // 
            // MainVehicle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnRemove);
            Controls.Add(btnAddVehicle);
            Controls.Add(lblPrice);
            Controls.Add(lblColor);
            Controls.Add(lblYear);
            Controls.Add(lblModel);
            Controls.Add(lblMake);
            Controls.Add(txtbxPrice);
            Controls.Add(txtbxColor);
            Controls.Add(txtbxYear);
            Controls.Add(txtbxModel);
            Controls.Add(txtbxVehicle);
            Controls.Add(dgvCarInventory);
            Name = "MainVehicle";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCarInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCarInventory;
        private TextBox txtbxVehicle;
        private TextBox txtbxModel;
        private TextBox txtbxYear;
        private TextBox txtbxColor;
        private TextBox txtbxPrice;
        private Label lblMake;
        private Label lblModel;
        private Label lblYear;
        private Label lblColor;
        private Label lblPrice;
        private Button btnAddVehicle;
        private Button btnRemove;
        private Label label1;
    }
}
