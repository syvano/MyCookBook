﻿namespace CookBook.UI
{
    partial class IngredientsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NameTxt = new TextBox();
            TypeTxt = new TextBox();
            WeightNum = new NumericUpDown();
            KcalPer100gNum = new NumericUpDown();
            PricePer100gNum = new NumericUpDown();
            AddToFridgeBtn = new Button();
            IngredientsGrid = new DataGridView();
            SearchTxt = new TextBox();
            ClearAllFieldsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)WeightNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1073, 96);
            label1.Name = "label1";
            label1.Size = new Size(105, 45);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1073, 168);
            label2.Name = "label2";
            label2.Size = new Size(86, 45);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1073, 237);
            label3.Name = "label3";
            label3.Size = new Size(170, 45);
            label3.TabIndex = 2;
            label3.Text = "Weight (g)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1073, 309);
            label4.Name = "label4";
            label4.Size = new Size(177, 45);
            label4.TabIndex = 3;
            label4.Text = "Kcal (100g)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1073, 385);
            label5.Name = "label5";
            label5.Size = new Size(188, 45);
            label5.TabIndex = 4;
            label5.Text = "Price (100g)";
            // 
            // NameTxt
            // 
            NameTxt.BorderStyle = BorderStyle.FixedSingle;
            NameTxt.Location = new Point(1261, 91);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(301, 49);
            NameTxt.TabIndex = 5;
            // 
            // TypeTxt
            // 
            TypeTxt.BorderStyle = BorderStyle.FixedSingle;
            TypeTxt.Location = new Point(1261, 158);
            TypeTxt.Name = "TypeTxt";
            TypeTxt.Size = new Size(301, 49);
            TypeTxt.TabIndex = 6;
            // 
            // WeightNum
            // 
            WeightNum.DecimalPlaces = 2;
            WeightNum.Location = new Point(1261, 227);
            WeightNum.Margin = new Padding(5, 6, 5, 6);
            WeightNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            WeightNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WeightNum.Name = "WeightNum";
            WeightNum.Size = new Size(301, 49);
            WeightNum.TabIndex = 7;
            WeightNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // KcalPer100gNum
            // 
            KcalPer100gNum.DecimalPlaces = 2;
            KcalPer100gNum.Location = new Point(1261, 304);
            KcalPer100gNum.Margin = new Padding(9, 12, 9, 12);
            KcalPer100gNum.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            KcalPer100gNum.Name = "KcalPer100gNum";
            KcalPer100gNum.Size = new Size(301, 49);
            KcalPer100gNum.TabIndex = 8;
            // 
            // PricePer100gNum
            // 
            PricePer100gNum.DecimalPlaces = 2;
            PricePer100gNum.Location = new Point(1261, 380);
            PricePer100gNum.Margin = new Padding(9, 12, 9, 12);
            PricePer100gNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            PricePer100gNum.Name = "PricePer100gNum";
            PricePer100gNum.Size = new Size(301, 49);
            PricePer100gNum.TabIndex = 9;
            // 
            // AddToFridgeBtn
            // 
            AddToFridgeBtn.Location = new Point(1073, 462);
            AddToFridgeBtn.Name = "AddToFridgeBtn";
            AddToFridgeBtn.Size = new Size(489, 57);
            AddToFridgeBtn.TabIndex = 10;
            AddToFridgeBtn.Text = "Add to fridge";
            AddToFridgeBtn.UseVisualStyleBackColor = true;
            AddToFridgeBtn.Click += AddToFridgeBtn_Click;
            // 
            // IngredientsGrid
            // 
            IngredientsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            IngredientsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            IngredientsGrid.DefaultCellStyle = dataGridViewCellStyle1;
            IngredientsGrid.Location = new Point(29, 81);
            IngredientsGrid.Name = "IngredientsGrid";
            IngredientsGrid.RowHeadersWidth = 62;
            IngredientsGrid.RowTemplate.Height = 25;
            IngredientsGrid.Size = new Size(1012, 510);
            IngredientsGrid.TabIndex = 11;
            IngredientsGrid.CellClick += IngredientsGrid_CellClick;
            // 
            // SearchTxt
            // 
            SearchTxt.BorderStyle = BorderStyle.FixedSingle;
            SearchTxt.Location = new Point(29, 30);
            SearchTxt.Name = "SearchTxt";
            SearchTxt.PlaceholderText = "Type ingredient name...";
            SearchTxt.Size = new Size(1012, 49);
            SearchTxt.TabIndex = 12;
            SearchTxt.TextChanged += SearchTxt_TextChanged;
            // 
            // ClearAllFieldsBtn
            // 
            ClearAllFieldsBtn.Location = new Point(1073, 534);
            ClearAllFieldsBtn.Name = "ClearAllFieldsBtn";
            ClearAllFieldsBtn.Size = new Size(489, 57);
            ClearAllFieldsBtn.TabIndex = 14;
            ClearAllFieldsBtn.Text = "Clear all fields";
            ClearAllFieldsBtn.UseVisualStyleBackColor = true;
            ClearAllFieldsBtn.Click += ClearAllFieldsBtn_Click;
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1606, 668);
            Controls.Add(ClearAllFieldsBtn);
            Controls.Add(SearchTxt);
            Controls.Add(IngredientsGrid);
            Controls.Add(AddToFridgeBtn);
            Controls.Add(PricePer100gNum);
            Controls.Add(KcalPer100gNum);
            Controls.Add(WeightNum);
            Controls.Add(TypeTxt);
            Controls.Add(NameTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "IngredientsForm";
            Text = "My Fridge";
            Load += IngredientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)WeightNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameTxt;
        private TextBox TypeTxt;
        private NumericUpDown WeightNum;
        private NumericUpDown KcalPer100gNum;
        private NumericUpDown PricePer100gNum;
        private Button AddToFridgeBtn;
        private DataGridView IngredientsGrid;
        private TextBox SearchTxt;
        private Button ClearAllFieldsBtn;
    }
}