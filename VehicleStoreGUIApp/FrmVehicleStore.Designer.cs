namespace VehicleStoreGUIApp
{
    partial class FrmVehicleStore
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
            groupBox1 = new GroupBox();
            lblColorError = new Label();
            txtColor = new TextBox();
            label9 = new Label();
            lblWheelsError = new Label();
            lblPriceError = new Label();
            lblYearError = new Label();
            lblModelError = new Label();
            lblMakeError = new Label();
            lblVehicleTypeError = new Label();
            groupBox2 = new GroupBox();
            lblSpecialtyDecimalError = new Label();
            lblSpecialtyBooleanError = new Label();
            rdoSpecialtyNo = new RadioButton();
            rdoSpecialtyYes = new RadioButton();
            txtSpecialtyDecimal = new TextBox();
            lblSpecialtyDecimal = new Label();
            lblSpecialtyBoolean = new Label();
            btnCreate = new Button();
            txtWheels = new TextBox();
            txtPrice = new TextBox();
            txtYear = new TextBox();
            txtModel = new TextBox();
            txtMake = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            rdoVehicle = new RadioButton();
            rdoPickup = new RadioButton();
            rdoMotorcycle = new RadioButton();
            rdoCar = new RadioButton();
            lblIsNewError = new Label();
            rdoIsNewNo = new RadioButton();
            rdoIsNewYes = new RadioButton();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lstInventory = new ListBox();
            btnAddToCart = new Button();
            groupBox4 = new GroupBox();
            lstShoppingCart = new ListBox();
            btnCheckout = new Button();
            label8 = new Label();
            lblTotal = new Label();
            btnRemoveFromCart = new Button();
            grpIsNew = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            grpIsNew.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblColorError);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(lblWheelsError);
            groupBox1.Controls.Add(lblPriceError);
            groupBox1.Controls.Add(lblYearError);
            groupBox1.Controls.Add(lblModelError);
            groupBox1.Controls.Add(lblMakeError);
            groupBox1.Controls.Add(lblVehicleTypeError);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtWheels);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtModel);
            groupBox1.Controls.Add(txtMake);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(rdoVehicle);
            groupBox1.Controls.Add(rdoPickup);
            groupBox1.Controls.Add(rdoMotorcycle);
            groupBox1.Controls.Add(rdoCar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 511);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a Vehicle";
            // 
            // lblColorError
            // 
            lblColorError.AutoSize = true;
            lblColorError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColorError.ForeColor = Color.Red;
            lblColorError.Location = new Point(73, 327);
            lblColorError.Name = "lblColorError";
            lblColorError.Size = new Size(186, 15);
            lblColorError.TabIndex = 23;
            lblColorError.Text = "Please enter a valid wheel count";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(73, 301);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 309);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 8;
            label9.Text = "Color: ";
            // 
            // lblWheelsError
            // 
            lblWheelsError.AutoSize = true;
            lblWheelsError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWheelsError.ForeColor = Color.Red;
            lblWheelsError.Location = new Point(72, 283);
            lblWheelsError.Name = "lblWheelsError";
            lblWheelsError.Size = new Size(186, 15);
            lblWheelsError.TabIndex = 0;
            lblWheelsError.Text = "Please enter a valid wheel count";
            // 
            // lblPriceError
            // 
            lblPriceError.AutoSize = true;
            lblPriceError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceError.ForeColor = Color.Red;
            lblPriceError.Location = new Point(72, 239);
            lblPriceError.Name = "lblPriceError";
            lblPriceError.Size = new Size(145, 15);
            lblPriceError.TabIndex = 19;
            lblPriceError.Text = "Please enter a valid price";
            // 
            // lblYearError
            // 
            lblYearError.AutoSize = true;
            lblYearError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearError.ForeColor = Color.Red;
            lblYearError.Location = new Point(72, 198);
            lblYearError.Name = "lblYearError";
            lblYearError.Size = new Size(141, 15);
            lblYearError.TabIndex = 18;
            lblYearError.Text = "Please enter a valid year";
            // 
            // lblModelError
            // 
            lblModelError.AutoSize = true;
            lblModelError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModelError.ForeColor = Color.Red;
            lblModelError.Location = new Point(72, 164);
            lblModelError.Name = "lblModelError";
            lblModelError.Size = new Size(123, 15);
            lblModelError.TabIndex = 17;
            lblModelError.Text = "Please enter a model";
            // 
            // lblMakeError
            // 
            lblMakeError.AutoSize = true;
            lblMakeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMakeError.ForeColor = Color.Red;
            lblMakeError.Location = new Point(72, 120);
            lblMakeError.Name = "lblMakeError";
            lblMakeError.Size = new Size(119, 15);
            lblMakeError.TabIndex = 16;
            lblMakeError.Text = "Please enter a make";
            // 
            // lblVehicleTypeError
            // 
            lblVehicleTypeError.AutoSize = true;
            lblVehicleTypeError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleTypeError.ForeColor = Color.Red;
            lblVehicleTypeError.Location = new Point(29, 69);
            lblVehicleTypeError.Name = "lblVehicleTypeError";
            lblVehicleTypeError.Size = new Size(166, 15);
            lblVehicleTypeError.TabIndex = 5;
            lblVehicleTypeError.Text = "Please Choose a Vehicle Type";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSpecialtyDecimalError);
            groupBox2.Controls.Add(lblSpecialtyBooleanError);
            groupBox2.Controls.Add(rdoSpecialtyNo);
            groupBox2.Controls.Add(rdoSpecialtyYes);
            groupBox2.Controls.Add(txtSpecialtyDecimal);
            groupBox2.Controls.Add(lblSpecialtyDecimal);
            groupBox2.Controls.Add(lblSpecialtyBoolean);
            groupBox2.Location = new Point(6, 367);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 138);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Specialty Properties";
            // 
            // lblSpecialtyDecimalError
            // 
            lblSpecialtyDecimalError.AutoSize = true;
            lblSpecialtyDecimalError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialtyDecimalError.ForeColor = Color.Red;
            lblSpecialtyDecimalError.Location = new Point(6, 120);
            lblSpecialtyDecimalError.Name = "lblSpecialtyDecimalError";
            lblSpecialtyDecimalError.Size = new Size(161, 15);
            lblSpecialtyDecimalError.TabIndex = 22;
            lblSpecialtyDecimalError.Text = "Please enter a valid number";
            // 
            // lblSpecialtyBooleanError
            // 
            lblSpecialtyBooleanError.AutoSize = true;
            lblSpecialtyBooleanError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpecialtyBooleanError.ForeColor = Color.Red;
            lblSpecialtyBooleanError.Location = new Point(6, 66);
            lblSpecialtyBooleanError.Name = "lblSpecialtyBooleanError";
            lblSpecialtyBooleanError.Size = new Size(133, 15);
            lblSpecialtyBooleanError.TabIndex = 21;
            lblSpecialtyBooleanError.Text = "Please select Yes or No";
            // 
            // rdoSpecialtyNo
            // 
            rdoSpecialtyNo.AutoSize = true;
            rdoSpecialtyNo.Location = new Point(72, 44);
            rdoSpecialtyNo.Name = "rdoSpecialtyNo";
            rdoSpecialtyNo.Size = new Size(41, 19);
            rdoSpecialtyNo.TabIndex = 16;
            rdoSpecialtyNo.TabStop = true;
            rdoSpecialtyNo.Text = "No";
            rdoSpecialtyNo.UseVisualStyleBackColor = true;
            // 
            // rdoSpecialtyYes
            // 
            rdoSpecialtyYes.AutoSize = true;
            rdoSpecialtyYes.Location = new Point(11, 44);
            rdoSpecialtyYes.Name = "rdoSpecialtyYes";
            rdoSpecialtyYes.Size = new Size(42, 19);
            rdoSpecialtyYes.TabIndex = 15;
            rdoSpecialtyYes.TabStop = true;
            rdoSpecialtyYes.Text = "Yes";
            rdoSpecialtyYes.UseVisualStyleBackColor = true;
            // 
            // txtSpecialtyDecimal
            // 
            txtSpecialtyDecimal.Location = new Point(138, 88);
            txtSpecialtyDecimal.Name = "txtSpecialtyDecimal";
            txtSpecialtyDecimal.Size = new Size(100, 23);
            txtSpecialtyDecimal.TabIndex = 17;
            // 
            // lblSpecialtyDecimal
            // 
            lblSpecialtyDecimal.AutoSize = true;
            lblSpecialtyDecimal.Location = new Point(11, 96);
            lblSpecialtyDecimal.Name = "lblSpecialtyDecimal";
            lblSpecialtyDecimal.Size = new Size(103, 15);
            lblSpecialtyDecimal.TabIndex = 1;
            lblSpecialtyDecimal.Text = "Specialty Decimal:";
            // 
            // lblSpecialtyBoolean
            // 
            lblSpecialtyBoolean.AutoSize = true;
            lblSpecialtyBoolean.Location = new Point(6, 26);
            lblSpecialtyBoolean.Name = "lblSpecialtyBoolean";
            lblSpecialtyBoolean.Size = new Size(103, 15);
            lblSpecialtyBoolean.TabIndex = 0;
            lblSpecialtyBoolean.Text = "Specialty Boolean:";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(218, 540);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(92, 63);
            btnCreate.TabIndex = 20;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += BtnCreateClickEH;
            // 
            // txtWheels
            // 
            txtWheels.Location = new Point(72, 257);
            txtWheels.Name = "txtWheels";
            txtWheels.Size = new Size(100, 23);
            txtWheels.TabIndex = 13;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(72, 216);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 12;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(72, 175);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 11;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(72, 138);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 10;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(72, 96);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(100, 23);
            txtMake.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 265);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 8;
            label5.Text = "Wheels:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 224);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 183);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 6;
            label3.Text = "Year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 146);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Model:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 104);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Make:";
            // 
            // rdoVehicle
            // 
            rdoVehicle.AutoSize = true;
            rdoVehicle.Location = new Point(144, 47);
            rdoVehicle.Name = "rdoVehicle";
            rdoVehicle.Size = new Size(62, 19);
            rdoVehicle.TabIndex = 3;
            rdoVehicle.TabStop = true;
            rdoVehicle.Text = "Vehicle";
            rdoVehicle.UseVisualStyleBackColor = true;
            rdoVehicle.Click += RdoVehicleClickEH;
            // 
            // rdoPickup
            // 
            rdoPickup.AutoSize = true;
            rdoPickup.Location = new Point(0, 47);
            rdoPickup.Name = "rdoPickup";
            rdoPickup.Size = new Size(61, 19);
            rdoPickup.TabIndex = 2;
            rdoPickup.TabStop = true;
            rdoPickup.Text = "Pickup";
            rdoPickup.UseVisualStyleBackColor = true;
            rdoPickup.Click += RdoPickupClickEH;
            // 
            // rdoMotorcycle
            // 
            rdoMotorcycle.AutoSize = true;
            rdoMotorcycle.Location = new Point(144, 22);
            rdoMotorcycle.Name = "rdoMotorcycle";
            rdoMotorcycle.Size = new Size(85, 19);
            rdoMotorcycle.TabIndex = 1;
            rdoMotorcycle.TabStop = true;
            rdoMotorcycle.Text = "Motorcycle";
            rdoMotorcycle.UseVisualStyleBackColor = true;
            rdoMotorcycle.Click += RdoMotorcycleClickEH;
            // 
            // rdoCar
            // 
            rdoCar.AutoSize = true;
            rdoCar.Location = new Point(0, 22);
            rdoCar.Name = "rdoCar";
            rdoCar.Size = new Size(43, 19);
            rdoCar.TabIndex = 0;
            rdoCar.TabStop = true;
            rdoCar.Text = "Car";
            rdoCar.UseVisualStyleBackColor = true;
            rdoCar.Click += RdoCarClickEH;
            // 
            // lblIsNewError
            // 
            lblIsNewError.AutoSize = true;
            lblIsNewError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsNewError.ForeColor = Color.Red;
            lblIsNewError.Location = new Point(31, 59);
            lblIsNewError.Name = "lblIsNewError";
            lblIsNewError.Size = new Size(133, 15);
            lblIsNewError.TabIndex = 26;
            lblIsNewError.Text = "Please select Yes or No";
            // 
            // rdoIsNewNo
            // 
            rdoIsNewNo.AutoSize = true;
            rdoIsNewNo.Location = new Point(105, 37);
            rdoIsNewNo.Name = "rdoIsNewNo";
            rdoIsNewNo.Size = new Size(41, 19);
            rdoIsNewNo.TabIndex = 19;
            rdoIsNewNo.TabStop = true;
            rdoIsNewNo.Text = "No";
            rdoIsNewNo.UseVisualStyleBackColor = true;
            // 
            // rdoIsNewYes
            // 
            rdoIsNewYes.AutoSize = true;
            rdoIsNewYes.Location = new Point(44, 37);
            rdoIsNewYes.Name = "rdoIsNewYes";
            rdoIsNewYes.Size = new Size(42, 19);
            rdoIsNewYes.TabIndex = 18;
            rdoIsNewYes.TabStop = true;
            rdoIsNewYes.Text = "Yes";
            rdoIsNewYes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 19);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 23;
            label6.Text = "Is New?";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstInventory);
            groupBox3.Location = new Point(330, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(461, 393);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Store Inventory";
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.Location = new Point(6, 22);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(449, 364);
            lstInventory.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(791, 147);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(81, 44);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += BtnAddToCartClickEH;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstShoppingCart);
            groupBox4.Location = new Point(872, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(461, 393);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Shopping Cart";
            // 
            // lstShoppingCart
            // 
            lstShoppingCart.FormattingEnabled = true;
            lstShoppingCart.Location = new Point(6, 22);
            lstShoppingCart.Name = "lstShoppingCart";
            lstShoppingCart.Size = new Size(449, 364);
            lstShoppingCart.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(790, 430);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(75, 23);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += BtnCheckoutClickEH;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(788, 465);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 5;
            label8.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(837, 465);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(19, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "$0";
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(918, 430);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(117, 23);
            btnRemoveFromCart.TabIndex = 7;
            btnRemoveFromCart.Text = "Remove Item";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += BtnRemoveFromCartClickEH;
            // 
            // grpIsNew
            // 
            grpIsNew.Controls.Add(lblIsNewError);
            grpIsNew.Controls.Add(label6);
            grpIsNew.Controls.Add(rdoIsNewNo);
            grpIsNew.Controls.Add(rdoIsNewYes);
            grpIsNew.Location = new Point(12, 529);
            grpIsNew.Name = "grpIsNew";
            grpIsNew.Size = new Size(200, 100);
            grpIsNew.TabIndex = 8;
            grpIsNew.TabStop = false;
            grpIsNew.Text = "Condition";
            // 
            // FrmVehicleStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 691);
            Controls.Add(grpIsNew);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(btnCheckout);
            Controls.Add(groupBox4);
            Controls.Add(btnAddToCart);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(btnCreate);
            Name = "FrmVehicleStore";
            Text = "Vehicle Store";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            grpIsNew.ResumeLayout(false);
            grpIsNew.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoVehicle;
        private RadioButton rdoPickup;
        private RadioButton rdoMotorcycle;
        private RadioButton rdoCar;
        private Button btnCreate;
        private TextBox txtWheels;
        private TextBox txtPrice;
        private TextBox txtYear;
        private TextBox txtModel;
        private TextBox txtMake;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton rdoSpecialtyNo;
        private RadioButton rdoSpecialtyYes;
        private TextBox txtSpecialtyDecimal;
        private Label label7;
        private Label lblSpecialtyBoolean;
        private Label lblSpecialtyDecimal;
        private GroupBox groupBox3;
        private ListBox lstInventory;
        private Button btnAddToCart;
        private GroupBox groupBox4;
        private ListBox lstShoppingCart;
        private Button btnCheckout;
        private Label lblVehicleTypeError;
        private Label label8;
        private Label lblTotal;
        private Label lblWheelsError;
        private Label lblPriceError;
        private Label lblYearError;
        private Label lblModelError;
        private Label lblMakeError;
        private Label lblColorError;
        private Label label10;
        private Label lblSpecialtyBooleanError;
        private Label lblSpecialtyDecimalError;
        private RadioButton rdoIsNewNo;
        private RadioButton rdoIsNewYes;
        private Label label6;
        private TextBox txtColor;
        private Label label9;
        private Label lblIsNewError;
        private Button btnRemoveFromCart;
        private GroupBox grpIsNew;
    }
}
