namespace finalExam1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ayranBox = new System.Windows.Forms.TextBox();
            this.suBox = new System.Windows.Forms.TextBox();
            this.sodaBox = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ayranBox
            // 
            this.ayranBox.Location = new System.Drawing.Point(348, 54);
            this.ayranBox.Name = "ayranBox";
            this.ayranBox.Size = new System.Drawing.Size(100, 22);
            this.ayranBox.TabIndex = 1;
            // 
            // suBox
            // 
            this.suBox.Location = new System.Drawing.Point(348, 92);
            this.suBox.Name = "suBox";
            this.suBox.Size = new System.Drawing.Size(100, 22);
            this.suBox.TabIndex = 2;
            // 
            // sodaBox
            // 
            this.sodaBox.Location = new System.Drawing.Point(348, 131);
            this.sodaBox.Name = "sodaBox";
            this.sodaBox.Size = new System.Drawing.Size(100, 22);
            this.sodaBox.TabIndex = 3;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(368, 220);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 4;
            this.show.Text = "button1";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show);
            this.Controls.Add(this.sodaBox);
            this.Controls.Add(this.suBox);
            this.Controls.Add(this.ayranBox);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox ayranBox;
        private System.Windows.Forms.TextBox suBox;
        private System.Windows.Forms.TextBox sodaBox;
        private System.Windows.Forms.Button show;
    }
}

