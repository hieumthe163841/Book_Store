namespace BookApplication.Customer
{
    partial class frmViewCart
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
            groupBox1 = new GroupBox();
            dgvListCartDetail = new DataGridView();
            groupBox2 = new GroupBox();
            txtTotalMoney = new TextBox();
            label6 = new Label();
            numericDiscount = new NumericUpDown();
            label5 = new Label();
            numericPrice = new NumericUpDown();
            label4 = new Label();
            numericQuantity = new NumericUpDown();
            txtName = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOrder = new Button();
            lbTotalMoney = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListCartDetail).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvListCartDetail);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(20, 14);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(622, 506);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Giỏ hàng";
            // 
            // dgvListCartDetail
            // 
            dgvListCartDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListCartDetail.Location = new Point(18, 36);
            dgvListCartDetail.Margin = new Padding(2, 2, 2, 2);
            dgvListCartDetail.Name = "dgvListCartDetail";
            dgvListCartDetail.RowHeadersWidth = 62;
            dgvListCartDetail.RowTemplate.Height = 33;
            dgvListCartDetail.Size = new Size(591, 456);
            dgvListCartDetail.TabIndex = 0;
            dgvListCartDetail.CellClick += dgvListCartDetail_CellClick;
            dgvListCartDetail.CellContentClick += dgvListCartDetail_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotalMoney);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numericDiscount);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericPrice);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(numericQuantity);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(654, 14);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(487, 566);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết giỏ hàng";
            // 
            // txtTotalMoney
            // 
            txtTotalMoney.BackColor = SystemColors.HighlightText;
            txtTotalMoney.Enabled = false;
            txtTotalMoney.Location = new Point(162, 284);
            txtTotalMoney.Margin = new Padding(2, 2, 2, 2);
            txtTotalMoney.Name = "txtTotalMoney";
            txtTotalMoney.ReadOnly = true;
            txtTotalMoney.ScrollBars = ScrollBars.Vertical;
            txtTotalMoney.Size = new Size(127, 29);
            txtTotalMoney.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 289);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 21);
            label6.TabIndex = 14;
            label6.Text = "Tổng tiền ($) :";
            // 
            // numericDiscount
            // 
            numericDiscount.BackColor = SystemColors.HighlightText;
            numericDiscount.Enabled = false;
            numericDiscount.Location = new Point(162, 178);
            numericDiscount.Margin = new Padding(2, 2, 2, 2);
            numericDiscount.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericDiscount.Name = "numericDiscount";
            numericDiscount.ReadOnly = true;
            numericDiscount.Size = new Size(126, 29);
            numericDiscount.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 182);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 12;
            label5.Text = "Chiết khấu (%) :";
            // 
            // numericPrice
            // 
            numericPrice.BackColor = SystemColors.HighlightText;
            numericPrice.Enabled = false;
            numericPrice.Location = new Point(162, 129);
            numericPrice.Margin = new Padding(2, 2, 2, 2);
            numericPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericPrice.Name = "numericPrice";
            numericPrice.ReadOnly = true;
            numericPrice.Size = new Size(126, 29);
            numericPrice.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 133);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 10;
            label4.Text = "Giá tiền :";
            // 
            // numericQuantity
            // 
            numericQuantity.BackColor = SystemColors.HighlightText;
            numericQuantity.Location = new Point(162, 228);
            numericQuantity.Margin = new Padding(2, 2, 2, 2);
            numericQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantity.Name = "numericQuantity";
            numericQuantity.Size = new Size(126, 29);
            numericQuantity.TabIndex = 9;
            numericQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericQuantity.ValueChanged += numericQuantity_ValueChanged;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.HighlightText;
            txtName.Location = new Point(162, 79);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.ScrollBars = ScrollBars.Vertical;
            txtName.Size = new Size(284, 29);
            txtName.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(27, 342);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 32);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(27, 409);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(203, 32);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa khỏi giỏ hàng";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(362, 524);
            btnExit.Margin = new Padding(2, 2, 2, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(113, 32);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 232);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 1;
            label3.Text = "Số lượng :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 81);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 547);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 4;
            label1.Text = "Tổng hóa đơn ($) :";
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(490, 538);
            btnOrder.Margin = new Padding(2, 2, 2, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(153, 32);
            btnOrder.TabIndex = 6;
            btnOrder.Text = "Đặt hàng";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // lbTotalMoney
            // 
            lbTotalMoney.AutoSize = true;
            lbTotalMoney.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbTotalMoney.Location = new Point(187, 547);
            lbTotalMoney.Margin = new Padding(2, 0, 2, 0);
            lbTotalMoney.Name = "lbTotalMoney";
            lbTotalMoney.Size = new Size(22, 25);
            lbTotalMoney.TabIndex = 7;
            lbTotalMoney.Text = "0";
            // 
            // frmViewCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 595);
            Controls.Add(lbTotalMoney);
            Controls.Add(btnOrder);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmViewCart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewCart";
            Load += ViewCart_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListCartDetail).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvListCartDetail;
        private GroupBox groupBox2;
        private Label label1;
        //private Label lbTotalMoney;
        private Button btnOrder;
        private NumericUpDown numericQuantity;
        private TextBox txtName;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Label label3;
        private Label label2;
        private NumericUpDown numericDiscount;
        private Label label5;
        private NumericUpDown numericPrice;
        private Label label4;
        private Label lbTotalMoney;
        private TextBox txtTotalMoney;
        private Label label6;
    }
}