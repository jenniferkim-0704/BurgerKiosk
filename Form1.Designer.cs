namespace BurgerKiosk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            grpMenu = new GroupBox();
            radioButton1 = new RadioButton();
            picChickenBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picHamBurger = new PictureBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpOption = new GroupBox();
            lstOrder = new ListBox();
            label2 = new Label();
            lblTotalCost = new Label();
            grpOrder = new GroupBox();
            btnOrder = new Button();
            btnInit = new Button();
            lblError = new Label();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴산뜻돋움", 30F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(18, 9);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(430, 65);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 12.5F, FontStyle.Bold);
            rdoHamBurger.ForeColor = Color.DarkMagenta;
            rdoHamBurger.Location = new Point(6, 40);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(97, 34);
            rdoHamBurger.TabIndex = 1;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 12.5F, FontStyle.Bold);
            rdoBulgogiBurger.ForeColor = Color.DarkMagenta;
            rdoBulgogiBurger.Location = new Point(6, 149);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(139, 34);
            rdoBulgogiBurger.TabIndex = 2;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 12.5F, FontStyle.Bold);
            rdoChickenBurger.ForeColor = Color.DarkMagenta;
            rdoChickenBurger.Location = new Point(6, 257);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(118, 34);
            rdoChickenBurger.TabIndex = 3;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(radioButton1);
            grpMenu.Controls.Add(picChickenBurger);
            grpMenu.Controls.Add(picBulgogiBurger);
            grpMenu.Controls.Add(picHamBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(18, 77);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(298, 361);
            grpMenu.TabIndex = 4;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            radioButton1.Location = new Point(6, 314);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(37, 32);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = ".";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            // 
            // picChickenBurger
            // 
            picChickenBurger.Image = (Image)resources.GetObject("picChickenBurger.Image");
            picChickenBurger.Location = new Point(151, 257);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(134, 89);
            picChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picChickenBurger.TabIndex = 7;
            picChickenBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Image = (Image)resources.GetObject("picBulgogiBurger.Image");
            picBulgogiBurger.Location = new Point(151, 149);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(134, 89);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogiBurger.TabIndex = 6;
            picBulgogiBurger.TabStop = false;
            // 
            // picHamBurger
            // 
            picHamBurger.Image = (Image)resources.GetObject("picHamBurger.Image");
            picHamBurger.Location = new Point(151, 40);
            picHamBurger.Name = "picHamBurger";
            picHamBurger.Size = new Size(134, 89);
            picHamBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picHamBurger.TabIndex = 5;
            picHamBurger.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 12.58F, FontStyle.Bold);
            chkPotato.ForeColor = Color.DarkMagenta;
            chkPotato.Location = new Point(6, 40);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(119, 34);
            chkPotato.TabIndex = 5;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 12.5F, FontStyle.Bold);
            chkCola.ForeColor = Color.DarkMagenta;
            chkCola.Location = new Point(6, 81);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(77, 34);
            chkCola.TabIndex = 6;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 12.5F, FontStyle.Bold);
            chkCheese.ForeColor = Color.DarkMagenta;
            chkCheese.Location = new Point(6, 122);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(126, 34);
            chkCheese.TabIndex = 7;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 12.5F, FontStyle.Bold);
            chkSauce.ForeColor = Color.DarkMagenta;
            chkSauce.Location = new Point(6, 163);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(126, 34);
            chkSauce.TabIndex = 8;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkPotato);
            grpOption.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(333, 77);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(154, 207);
            grpOption.TabIndex = 9;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(6, 40);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(263, 144);
            lstOrder.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 229);
            label2.Name = "label2";
            label2.Size = new Size(0, 35);
            label2.TabIndex = 11;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 14F, FontStyle.Bold);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(6, 197);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(154, 32);
            lblTotalCost.TabIndex = 12;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(label2);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(503, 77);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(275, 238);
            grpOrder.TabIndex = 13;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Green;
            btnOrder.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(503, 340);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(128, 45);
            btnOrder.TabIndex = 14;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.Red;
            btnInit.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnInit.ForeColor = Color.White;
            btnInit.Location = new Point(650, 340);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(128, 45);
            btnInit.TabIndex = 15;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("맑은 고딕", 15.5F, FontStyle.Bold);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(503, 391);
            lblError.Name = "lblError";
            lblError.Size = new Size(275, 36);
            lblError.TabIndex = 16;
            lblError.Text = "메뉴 선택을 해주세요!";
            lblError.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private GroupBox grpMenu;
        private PictureBox picChickenBurger;
        private PictureBox picBulgogiBurger;
        private PictureBox picHamBurger;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpOption;
        private ListBox lstOrder;
        private Label label2;
        private Label lblTotalCost;
        private GroupBox grpOrder;
        private Button btnOrder;
        private Button btnInit;
        private RadioButton radioButton1;
        private Label lblError;
    }
}
