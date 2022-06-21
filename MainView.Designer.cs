
namespace UkrPochtaInternationShippingCalc
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            this.countriesList = new System.Windows.Forms.ListBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.calculateShippingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.getCountriesButton = new System.Windows.Forms.Button();
            this.byAir = new System.Windows.Forms.RadioButton();
            this.shippingMethod = new System.Windows.Forms.GroupBox();
            this.combined = new System.Windows.Forms.RadioButton();
            this.shippingCostOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.shippingMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // countriesList
            // 
            this.countriesList.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countriesList.FormattingEnabled = true;
            this.countriesList.ItemHeight = 21;
            this.countriesList.Location = new System.Drawing.Point(12, 12);
            this.countriesList.Name = "countriesList";
            this.countriesList.Size = new System.Drawing.Size(350, 403);
            this.countriesList.TabIndex = 0;
            // 
            // messageBox
            // 
            this.messageBox.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.messageBox.Location = new System.Drawing.Point(387, 12);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(490, 200);
            this.messageBox.TabIndex = 1;
            // 
            // calculateShippingButton
            // 
            this.calculateShippingButton.Enabled = false;
            this.calculateShippingButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateShippingButton.Location = new System.Drawing.Point(387, 424);
            this.calculateShippingButton.Name = "calculateShippingButton";
            this.calculateShippingButton.Size = new System.Drawing.Size(150, 50);
            this.calculateShippingButton.TabIndex = 2;
            this.calculateShippingButton.Text = "Рассчитать";
            this.calculateShippingButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(383, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Формула расчета:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(383, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "тариф за посылку + N × тариф за кг, где N — вес посылки, кг";
            // 
            // weightInput
            // 
            this.weightInput.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightInput.Location = new System.Drawing.Point(387, 318);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(75, 28);
            this.weightInput.TabIndex = 5;
            this.weightInput.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(383, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вес посылки, кг:";
            // 
            // getCountriesButton
            // 
            this.getCountriesButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getCountriesButton.Location = new System.Drawing.Point(12, 424);
            this.getCountriesButton.Name = "getCountriesButton";
            this.getCountriesButton.Size = new System.Drawing.Size(280, 50);
            this.getCountriesButton.TabIndex = 9;
            this.getCountriesButton.Text = "Загрузить тарифную сетку";
            this.getCountriesButton.UseVisualStyleBackColor = true;
            // 
            // byAir
            // 
            this.byAir.AutoSize = true;
            this.byAir.Checked = true;
            this.byAir.Location = new System.Drawing.Point(6, 27);
            this.byAir.Name = "byAir";
            this.byAir.Size = new System.Drawing.Size(70, 25);
            this.byAir.TabIndex = 10;
            this.byAir.TabStop = true;
            this.byAir.Text = "Авиа";
            this.byAir.UseVisualStyleBackColor = true;
            // 
            // shippingMethod
            // 
            this.shippingMethod.Controls.Add(this.combined);
            this.shippingMethod.Controls.Add(this.byAir);
            this.shippingMethod.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shippingMethod.Location = new System.Drawing.Point(627, 294);
            this.shippingMethod.Name = "shippingMethod";
            this.shippingMethod.Size = new System.Drawing.Size(250, 64);
            this.shippingMethod.TabIndex = 12;
            this.shippingMethod.TabStop = false;
            this.shippingMethod.Text = "Способ доставки";
            // 
            // combined
            // 
            this.combined.AutoSize = true;
            this.combined.Location = new System.Drawing.Point(110, 27);
            this.combined.Name = "combined";
            this.combined.Size = new System.Drawing.Size(111, 25);
            this.combined.TabIndex = 11;
            this.combined.Text = "Наземный";
            this.combined.UseVisualStyleBackColor = true;
            // 
            // shippingCostOutput
            // 
            this.shippingCostOutput.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shippingCostOutput.Location = new System.Drawing.Point(387, 373);
            this.shippingCostOutput.Name = "shippingCostOutput";
            this.shippingCostOutput.ReadOnly = true;
            this.shippingCostOutput.Size = new System.Drawing.Size(75, 28);
            this.shippingCostOutput.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(383, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Стоимость, $:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 482);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 26);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(480, 20);
            this.toolStripStatusLabel1.Text = "Для начала работы нажмите на кнопку \"Загрузить тарифную сетку\"";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 508);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shippingCostOutput);
            this.Controls.Add(this.shippingMethod);
            this.Controls.Add(this.getCountriesButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weightInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateShippingButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.countriesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(970, 555);
            this.Name = "MainView";
            this.Text = "UkrPochtaParser v1.0";
            this.shippingMethod.ResumeLayout(false);
            this.shippingMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calculateShippingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        public System.Windows.Forms.ListBox countriesList;
        private System.Windows.Forms.Button getCountriesButton;
        private System.Windows.Forms.RadioButton byAir;
        private System.Windows.Forms.GroupBox shippingMethod;
        private System.Windows.Forms.RadioButton combined;
        private System.Windows.Forms.TextBox shippingCostOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

