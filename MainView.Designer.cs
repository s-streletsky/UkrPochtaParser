
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
            this.countryDetails = new System.Windows.Forms.TextBox();
            this.calculateShippingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.less10 = new System.Windows.Forms.RadioButton();
            this.more10 = new System.Windows.Forms.RadioButton();
            this.getCountriesButton = new System.Windows.Forms.Button();
            this.byAir = new System.Windows.Forms.RadioButton();
            this.parcelProperties = new System.Windows.Forms.GroupBox();
            this.shippingMethod = new System.Windows.Forms.GroupBox();
            this.combined = new System.Windows.Forms.RadioButton();
            this.shippingCostOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.parcelProperties.SuspendLayout();
            this.shippingMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
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
            // countryDetails
            // 
            this.countryDetails.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryDetails.Location = new System.Drawing.Point(387, 12);
            this.countryDetails.Multiline = true;
            this.countryDetails.Name = "countryDetails";
            this.countryDetails.Size = new System.Drawing.Size(520, 200);
            this.countryDetails.TabIndex = 1;
            // 
            // calculateShippingButton
            // 
            this.calculateShippingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            // less10
            // 
            this.less10.AutoSize = true;
            this.less10.Checked = true;
            this.less10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.less10.Location = new System.Drawing.Point(6, 27);
            this.less10.Name = "less10";
            this.less10.Size = new System.Drawing.Size(178, 25);
            this.less10.TabIndex = 7;
            this.less10.TabStop = true;
            this.less10.Text = "<10 кг, без оценки";
            this.less10.UseVisualStyleBackColor = true;
            // 
            // more10
            // 
            this.more10.AutoSize = true;
            this.more10.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.more10.Location = new System.Drawing.Point(6, 60);
            this.more10.Name = "more10";
            this.more10.Size = new System.Drawing.Size(198, 25);
            this.more10.TabIndex = 8;
            this.more10.Text = ">10 кг или с оценкой";
            this.more10.UseVisualStyleBackColor = true;
            // 
            // getCountriesButton
            // 
            this.getCountriesButton.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getCountriesButton.Location = new System.Drawing.Point(12, 424);
            this.getCountriesButton.Name = "getCountriesButton";
            this.getCountriesButton.Size = new System.Drawing.Size(250, 50);
            this.getCountriesButton.TabIndex = 9;
            this.getCountriesButton.Text = "Получить список стран";
            this.getCountriesButton.UseVisualStyleBackColor = true;
            // 
            // byAir
            // 
            this.byAir.AutoSize = true;
            this.byAir.Checked = true;
            this.byAir.Location = new System.Drawing.Point(6, 24);
            this.byAir.Name = "byAir";
            this.byAir.Size = new System.Drawing.Size(70, 25);
            this.byAir.TabIndex = 10;
            this.byAir.TabStop = true;
            this.byAir.Text = "Авиа";
            this.byAir.UseVisualStyleBackColor = true;
            // 
            // parcelProperties
            // 
            this.parcelProperties.Controls.Add(this.more10);
            this.parcelProperties.Controls.Add(this.less10);
            this.parcelProperties.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.parcelProperties.Location = new System.Drawing.Point(551, 294);
            this.parcelProperties.Name = "parcelProperties";
            this.parcelProperties.Size = new System.Drawing.Size(250, 100);
            this.parcelProperties.TabIndex = 11;
            this.parcelProperties.TabStop = false;
            this.parcelProperties.Text = "Св-ва посылки";
            // 
            // shippingMethod
            // 
            this.shippingMethod.Controls.Add(this.combined);
            this.shippingMethod.Controls.Add(this.byAir);
            this.shippingMethod.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shippingMethod.Location = new System.Drawing.Point(807, 294);
            this.shippingMethod.Name = "shippingMethod";
            this.shippingMethod.Size = new System.Drawing.Size(250, 100);
            this.shippingMethod.TabIndex = 12;
            this.shippingMethod.TabStop = false;
            this.shippingMethod.Text = "Способ доставки";
            // 
            // combined
            // 
            this.combined.AutoSize = true;
            this.combined.Location = new System.Drawing.Point(6, 60);
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(957, 451);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 489);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shippingCostOutput);
            this.Controls.Add(this.shippingMethod);
            this.Controls.Add(this.parcelProperties);
            this.Controls.Add(this.getCountriesButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.weightInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateShippingButton);
            this.Controls.Add(this.countryDetails);
            this.Controls.Add(this.countriesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1082, 530);
            this.Name = "MainView";
            this.Text = "Form1";
            this.parcelProperties.ResumeLayout(false);
            this.parcelProperties.PerformLayout();
            this.shippingMethod.ResumeLayout(false);
            this.shippingMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calculateShippingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton less10;
        private System.Windows.Forms.RadioButton more10;
        public System.Windows.Forms.TextBox countryDetails;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        public System.Windows.Forms.ListBox countriesList;
        private System.Windows.Forms.Button getCountriesButton;
        private System.Windows.Forms.RadioButton byAir;
        private System.Windows.Forms.GroupBox parcelProperties;
        private System.Windows.Forms.GroupBox shippingMethod;
        private System.Windows.Forms.RadioButton combined;
        private System.Windows.Forms.TextBox shippingCostOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

