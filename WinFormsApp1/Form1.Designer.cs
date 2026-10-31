namespace WinFormsApp1
{
    partial class Form1
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
            btnCalculate = new Button();
            txtName = new TextBox();
            lblResult = new Label();
            dgvProducts = new DataGridView();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            lblUserRole = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(153, 201);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(90, 23);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(153, 74);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Название";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(153, 240);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "label1";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(355, 201);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(240, 150);
            dgvProducts.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(153, 112);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Стоимость";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(153, 156);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Количество";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 5;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Location = new Point(12, 9);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(87, 15);
            lblUserRole.TabIndex = 6;
            lblUserRole.Text = "Пользователь:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 482);
            Controls.Add(lblUserRole);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(dgvProducts);
            Controls.Add(lblResult);
            Controls.Add(txtName);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox txtName;
        private Label lblResult;
        private DataGridView dgvProducts;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label lblUserRole;
    }
}
