namespace BookApplication.Customer
{
    partial class frmViewOrder
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
            label1 = new Label();
            label2 = new Label();
            lbIdOrder = new Label();
            dgvOrder = new DataGridView();
            dgvOrderDetail = new DataGridView();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            txtComment = new TextBox();
            numericRatingPoint = new NumericUpDown();
            btnRating = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            txtTotalMoney = new TextBox();
            label6 = new Label();
            numericDiscount = new NumericUpDown();
            label5 = new Label();
            numericPrice = new NumericUpDown();
            label4 = new Label();
            numericQuantity = new NumericUpDown();
            txtName = new TextBox();
            btnUpdate = new Button();
            btnExit = new Button();
            label3 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericRatingPoint).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 23);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 0;
            label1.Text = "Danh sách đơn hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(482, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 1;
            label2.Text = "Chi tiết đơn hàng :";
            // 
            // lbIdOrder
            // 
            lbIdOrder.AutoSize = true;
            lbIdOrder.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbIdOrder.Location = new Point(654, 23);
            lbIdOrder.Margin = new Padding(2, 0, 2, 0);
            lbIdOrder.Name = "lbIdOrder";
            lbIdOrder.Size = new Size(22, 25);
            lbIdOrder.TabIndex = 2;
            lbIdOrder.Text = "0";
            // 
            // dgvOrder
            // 
            dgvOrder.BackgroundColor = SystemColors.Control;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(5, 60);
            dgvOrder.Margin = new Padding(2, 2, 2, 2);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.RowTemplate.Height = 33;
            dgvOrder.Size = new Size(464, 518);
            dgvOrder.TabIndex = 3;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.BackgroundColor = SystemColors.Control;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(482, 60);
            dgvOrderDetail.Margin = new Padding(2, 2, 2, 2);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.RowHeadersWidth = 62;
            dgvOrderDetail.RowTemplate.Height = 33;
            dgvOrderDetail.Size = new Size(246, 518);
            dgvOrderDetail.TabIndex = 4;
            dgvOrderDetail.CellContentClick += dgvOrderDetail_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(txtComment);
            groupBox2.Controls.Add(numericRatingPoint);
            groupBox2.Controls.Add(btnRating);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtTotalMoney);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(numericDiscount);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(numericPrice);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(numericQuantity);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(739, 13);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(412, 566);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(20, 476);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 32);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtComment
            // 
            txtComment.Enabled = false;
            txtComment.Location = new Point(188, 362);
            txtComment.Margin = new Padding(2, 2, 2, 2);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.ScrollBars = ScrollBars.Vertical;
            txtComment.Size = new Size(213, 101);
            txtComment.TabIndex = 21;
            // 
            // numericRatingPoint
            // 
            numericRatingPoint.Enabled = false;
            numericRatingPoint.Location = new Point(188, 315);
            numericRatingPoint.Margin = new Padding(2, 2, 2, 2);
            numericRatingPoint.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericRatingPoint.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericRatingPoint.Name = "numericRatingPoint";
            numericRatingPoint.Size = new Size(126, 29);
            numericRatingPoint.TabIndex = 20;
            numericRatingPoint.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnRating
            // 
            btnRating.Enabled = false;
            btnRating.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRating.Location = new Point(286, 476);
            btnRating.Margin = new Padding(2, 2, 2, 2);
            btnRating.Name = "btnRating";
            btnRating.Size = new Size(113, 32);
            btnRating.TabIndex = 19;
            btnRating.Text = "Đánh giá";
            btnRating.UseVisualStyleBackColor = true;
            btnRating.Click += btnRating_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(83, 366);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(82, 21);
            label10.TabIndex = 18;
            label10.Text = "Bình luận :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(139, 241);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(139, 41);
            label9.TabIndex = 17;
            label9.Text = "Đánh Giá";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 316);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(156, 21);
            label8.TabIndex = 16;
            label8.Text = "Điểm đánh giá (1-5) :";
            // 
            // txtTotalMoney
            // 
            txtTotalMoney.BackColor = SystemColors.HighlightText;
            txtTotalMoney.Enabled = false;
            txtTotalMoney.Location = new Point(188, 198);
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
            label6.Location = new Point(58, 202);
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
            numericDiscount.Location = new Point(188, 126);
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
            label5.Location = new Point(45, 130);
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
            numericPrice.Location = new Point(188, 91);
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
            label4.Location = new Point(97, 95);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 10;
            label4.Text = "Giá tiền :";
            // 
            // numericQuantity
            // 
            numericQuantity.BackColor = SystemColors.HighlightText;
            numericQuantity.Enabled = false;
            numericQuantity.Location = new Point(188, 163);
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
            txtName.Location = new Point(188, 47);
            txtName.Margin = new Padding(2, 2, 2, 2);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.ScrollBars = ScrollBars.Vertical;
            txtName.Size = new Size(213, 29);
            txtName.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(155, 476);
            btnUpdate.Margin = new Padding(2, 2, 2, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 32);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Chỉnh sửa";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(312, 536);
            btnExit.Margin = new Padding(2, 2, 2, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(88, 26);
            btnExit.TabIndex = 4;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 167);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 1;
            label3.Text = "Số lượng :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 49);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 21);
            label7.TabIndex = 0;
            label7.Text = "Tên sản phẩm :";
            // 
            // frmViewOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 595);
            Controls.Add(groupBox2);
            Controls.Add(dgvOrderDetail);
            Controls.Add(dgvOrder);
            Controls.Add(lbIdOrder);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmViewOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrder";
            Load += frmViewOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericRatingPoint).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericDiscount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbIdOrder;
        private DataGridView dgvOrder;
        private DataGridView dgvOrderDetail;
        private GroupBox groupBox2;
        private TextBox txtTotalMoney;
        private Label label6;
        private NumericUpDown numericDiscount;
        private Label label5;
        private NumericUpDown numericPrice;
        private Label label4;
        private NumericUpDown numericQuantity;
        private TextBox txtName;
        private Button btnUpdate;
        private Button btnExit;
        private Label label3;
        private Label label7;
        private TextBox txtComment;
        private NumericUpDown numericRatingPoint;
        private Button btnRating;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnDelete;
    }
}