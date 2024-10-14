namespace project1;

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
        lbxProducts = new ListBox();
        lblProducts = new Label();
        btnAddToCart = new Button();
        lbxCart = new ListBox();
        lblCart = new Label();
        btnRemoveFromTheCart = new Button();
        SuspendLayout();
        // 
        // lbxProducts
        // 
        lbxProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
        lbxProducts.FormattingEnabled = true;
        lbxProducts.ItemHeight = 28;
        lbxProducts.Location = new Point(12, 40);
        lbxProducts.Name = "lbxProducts";
        lbxProducts.Size = new Size(272, 284);
        lbxProducts.TabIndex = 0;
        lbxProducts.SelectedIndexChanged += lbxProducts_SelectedIndexChanged;
        // 
        // lblProducts
        // 
        lblProducts.AutoSize = true;
        lblProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
        lblProducts.Location = new Point(26, 9);
        lblProducts.Name = "lblProducts";
        lblProducts.Size = new Size(0, 28);
        lblProducts.TabIndex = 1;
        lblProducts.Click += lblProducts_Click;
        // 
        // btnAddToCart
        // 
        btnAddToCart.Location = new Point(310, 40);
        btnAddToCart.Name = "btnAddToCart";
        btnAddToCart.Size = new Size(147, 41);
        btnAddToCart.TabIndex = 2;
        btnAddToCart.UseVisualStyleBackColor = true;
        btnAddToCart.Click += btnAddToCart_Click;
        // 
        // lbxCart
        // 
        lbxCart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
        lbxCart.FormattingEnabled = true;
        lbxCart.ItemHeight = 28;
        lbxCart.Location = new Point(484, 40);
        lbxCart.Name = "lbxCart";
        lbxCart.Size = new Size(266, 284);
        lbxCart.TabIndex = 3;
        // 
        // lblCart
        // 
        lblCart.AutoSize = true;
        lblCart.Font = new Font("Segoe UI", 12F);
        lblCart.Location = new Point(484, 9);
        lblCart.Name = "lblCart";
        lblCart.Size = new Size(0, 28);
        lblCart.TabIndex = 4;
        // 
        // btnRemoveFromTheCart
        // 
        btnRemoveFromTheCart.Location = new Point(773, 39);
        btnRemoveFromTheCart.Name = "btnRemoveFromTheCart";
        btnRemoveFromTheCart.Size = new Size(147, 42);
        btnRemoveFromTheCart.TabIndex = 5;
        btnRemoveFromTheCart.UseVisualStyleBackColor = true;
        btnRemoveFromTheCart.Click += btnRemoveFromTheCart_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1148, 450);
        Controls.Add(btnRemoveFromTheCart);
        Controls.Add(lblCart);
        Controls.Add(lbxCart);
        Controls.Add(btnAddToCart);
        Controls.Add(lblProducts);
        Controls.Add(lbxProducts);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox lbxProducts;
    private Label lblProducts;
    private Button btnAddToCart;
    private ListBox lbxCart;
    private Label lblCart;
    private Button btnRemoveFromTheCart;
}
