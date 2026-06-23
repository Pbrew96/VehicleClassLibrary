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
            txtSpecialty = new TextBox();
            this.lblSpecialtyDecimal = new Label();
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
            groupBox3 = new GroupBox();
            lstInventory = new ListBox();
            btnAddToCart = new Button();
            groupBox4 = new GroupBox();
            lstShoppingCart = new ListBox();
            btnCheckout = new Button();
            label8 = new Label();
            lblTotal = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblWheelsError);
            groupBox1.Controls.Add(lblPriceError);
            groupBox1.Controls.Add(lblYearError);
            groupBox1.Controls.Add(lblModelError);
            groupBox1.Controls.Add(lblMakeError);
            groupBox1.Controls.Add(lblVehicleTypeError);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnCreate);
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
            groupBox1.Size = new Size(267, 511);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Create a Vehicle";
            // 
            // lblWheelsError
            // 
            lblWheelsError.AutoSize = true;
            lblWheelsError.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWheelsError.ForeColor = Color.Red;
            lblWheelsError.Location = new Point(72, 283);
            lblWheelsError.Name = "lblWheelsError";
            lblWheelsError.Size = new Size(186, 15);
            lblWheelsError.TabIndex = 20;
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
            groupBox2.Controls.Add(txtSpecialty);
            groupBox2.Controls.Add(this.lblSpecialtyDecimal);
            groupBox2.Controls.Add(lblSpecialtyBoolean);
            groupBox2.Location = new Point(6, 335);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(227, 138);
            groupBox2.TabIndex = 15;
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
            rdoSpecialtyNo.TabIndex = 4;
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
            rdoSpecialtyYes.TabIndex = 3;
            rdoSpecialtyYes.TabStop = true;
            rdoSpecialtyYes.Text = "Yes";
            rdoSpecialtyYes.UseVisualStyleBackColor = true;
            // 
            // txtSpecialty
            // 
            txtSpecialty.Location = new Point(116, 88);
            txtSpecialty.Name = "txtSpecialty";
            txtSpecialty.Size = new Size(100, 23);
            txtSpecialty.TabIndex = 2;
            // 
            // lblSpecialtyDecimal
            // 
            this.lblSpecialtyDecimal.AutoSize = true;
            this.lblSpecialtyDecimal.Location = new Point(11, 96);
            this.lblSpecialtyDecimal.Name = "lblSpecialtyDecimal";
            this.lblSpecialtyDecimal.Size = new Size(103, 15);
            this.lblSpecialtyDecimal.TabIndex = 1;
            this.lblSpecialtyDecimal.Text = "Specialty Decimal:";
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
            btnCreate.Location = new Point(29, 306);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(lstInventory);
            groupBox3.Location = new Point(285, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(219, 393);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Store Inventory";
            // 
            // lstInventory
            // 
            lstInventory.FormattingEnabled = true;
            lstInventory.Location = new Point(6, 22);
            lstInventory.Name = "lstInventory";
            lstInventory.Size = new Size(207, 364);
            lstInventory.TabIndex = 0;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(504, 150);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(75, 44);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Add to Cart";
            btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lstShoppingCart);
            groupBox4.Location = new Point(588, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(200, 393);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Store Inventory";
            // 
            // lstShoppingCart
            // 
            lstShoppingCart.FormattingEnabled = true;
            lstShoppingCart.Location = new Point(6, 22);
            lstShoppingCart.Name = "lstShoppingCart";
            lstShoppingCart.Size = new Size(188, 364);
            lstShoppingCart.TabIndex = 0;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(646, 415);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(75, 23);
            btnCheckout.TabIndex = 4;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(644, 450);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 5;
            label8.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(693, 450);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(19, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "$0";
            // 
            // FrmVehicleStore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(btnCheckout);
            Controls.Add(groupBox4);
            Controls.Add(btnAddToCart);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "FrmVehicleStore";
            Text = "Vehicle Store";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
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
        private TextBox txtSpecialty;
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
        private Label label10;
        private Label lblSpecialtyBooleanError;
        private Label lblSpecialtyDecimalError;
    }
}
