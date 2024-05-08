namespace CafeApp
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
            Welcomlabel = new Label();
            label1 = new Label();
            comboBoxItems = new ComboBox();
            btnAddToOrder = new Button();
            Quantitylabel = new Label();
            btnDisplayReceipt = new Button();
            numericUpDownQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // Welcomlabel
            // 
            Welcomlabel.AutoSize = true;
            Welcomlabel.Font = new Font("MV Boli", 13.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Welcomlabel.Location = new Point(283, 22);
            Welcomlabel.Name = "Welcomlabel";
            Welcomlabel.Size = new Size(176, 49);
            Welcomlabel.TabIndex = 0;
            Welcomlabel.Text = "Welcome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(24, 69);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 1;
            label1.Text = "Pick an item";
            // 
            // comboBoxItems
            // 
            comboBoxItems.FormattingEnabled = true;
            comboBoxItems.Location = new Point(24, 125);
            comboBoxItems.Name = "comboBoxItems";
            comboBoxItems.Size = new Size(242, 40);
            comboBoxItems.TabIndex = 2;
            comboBoxItems.SelectedIndexChanged += comboBoxItems_SelectedIndexChanged;
            // 
            // btnAddToOrder
            // 
            btnAddToOrder.Location = new Point(24, 380);
            btnAddToOrder.Name = "btnAddToOrder";
            btnAddToOrder.Size = new Size(150, 46);
            btnAddToOrder.TabIndex = 3;
            btnAddToOrder.Text = "Order";
            btnAddToOrder.UseVisualStyleBackColor = true;
            btnAddToOrder.Click += btnAddToOrder_Click;
            // 
            // Quantitylabel
            // 
            Quantitylabel.AutoSize = true;
            Quantitylabel.ForeColor = Color.Red;
            Quantitylabel.Location = new Point(24, 204);
            Quantitylabel.Name = "Quantitylabel";
            Quantitylabel.Size = new Size(106, 32);
            Quantitylabel.TabIndex = 5;
            Quantitylabel.Text = "Quantity";
            // 
            // btnDisplayReceipt
            // 
            btnDisplayReceipt.Location = new Point(574, 380);
            btnDisplayReceipt.Name = "btnDisplayReceipt";
            btnDisplayReceipt.Size = new Size(150, 46);
            btnDisplayReceipt.TabIndex = 6;
            btnDisplayReceipt.Text = "Receipt";
            btnDisplayReceipt.UseVisualStyleBackColor = true;
            btnDisplayReceipt.Click += btnDisplayReceipt_Click;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(24, 261);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(240, 39);
            numericUpDownQuantity.TabIndex = 7;
            numericUpDownQuantity.ValueChanged += numericUpDownQuantity_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 450);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(btnDisplayReceipt);
            Controls.Add(Quantitylabel);
            Controls.Add(btnAddToOrder);
            Controls.Add(comboBoxItems);
            Controls.Add(label1);
            Controls.Add(Welcomlabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Welcomlabel;
        private Label label1;
        private ComboBox comboBoxItems;
        private Button btnAddToOrder;
        private Label Quantitylabel;
        private Button btnDisplayReceipt;
        private NumericUpDown numericUpDownQuantity;
    }
}
