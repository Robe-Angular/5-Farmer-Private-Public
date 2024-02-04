
namespace _5_Farmer_Private_Public
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.calculateIt = new System.Windows.Forms.Button();
            this.bagsOfFeedEqual5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(26, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // calculateIt
            // 
            this.calculateIt.Location = new System.Drawing.Point(82, 92);
            this.calculateIt.Name = "calculateIt";
            this.calculateIt.Size = new System.Drawing.Size(75, 23);
            this.calculateIt.TabIndex = 1;
            this.calculateIt.Text = "Calculate";
            this.calculateIt.UseVisualStyleBackColor = true;
            this.calculateIt.Click += new System.EventHandler(this.calculateIt_Click);
            // 
            // bagsOfFeedEqual5
            // 
            this.bagsOfFeedEqual5.Location = new System.Drawing.Point(170, 12);
            this.bagsOfFeedEqual5.Name = "bagsOfFeedEqual5";
            this.bagsOfFeedEqual5.Size = new System.Drawing.Size(75, 74);
            this.bagsOfFeedEqual5.TabIndex = 2;
            this.bagsOfFeedEqual5.Text = "bags of feed = 5";
            this.bagsOfFeedEqual5.UseVisualStyleBackColor = true;
            this.bagsOfFeedEqual5.Click += new System.EventHandler(this.bagsOfFeedEqual5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 164);
            this.Controls.Add(this.bagsOfFeedEqual5);
            this.Controls.Add(this.calculateIt);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button calculateIt;
        private System.Windows.Forms.Button bagsOfFeedEqual5;
    }
}

