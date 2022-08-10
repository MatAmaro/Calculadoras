namespace Calc
{
    partial class FrmMenu
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
            this.btnCalcSimple = new System.Windows.Forms.Button();
            this.btnCalcImc = new System.Windows.Forms.Button();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcSimple
            // 
            this.btnCalcSimple.BackColor = System.Drawing.Color.Khaki;
            this.btnCalcSimple.Location = new System.Drawing.Point(94, 111);
            this.btnCalcSimple.Name = "btnCalcSimple";
            this.btnCalcSimple.Size = new System.Drawing.Size(127, 50);
            this.btnCalcSimple.TabIndex = 0;
            this.btnCalcSimple.Text = "Calculadora Simples";
            this.btnCalcSimple.UseVisualStyleBackColor = false;
            this.btnCalcSimple.Click += new System.EventHandler(this.btnCalcSimple_Click);
            // 
            // btnCalcImc
            // 
            this.btnCalcImc.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnCalcImc.Location = new System.Drawing.Point(94, 167);
            this.btnCalcImc.Name = "btnCalcImc";
            this.btnCalcImc.Size = new System.Drawing.Size(127, 50);
            this.btnCalcImc.TabIndex = 1;
            this.btnCalcImc.Text = "Calculadora de IMC";
            this.btnCalcImc.UseVisualStyleBackColor = false;
            this.btnCalcImc.Click += new System.EventHandler(this.btnCalcImc_Click);
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPergunta.Location = new System.Drawing.Point(62, 76);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(199, 15);
            this.lblPergunta.TabIndex = 2;
            this.lblPergunta.Text = "Qual calculadora você precisa?";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(315, 320);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.btnCalcImc);
            this.Controls.Add(this.btnCalcSimple);
            this.Name = "FrmMenu";
            this.Text = "Calculadoras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcSimple;
        private Button btnCalcImc;
        private Label lblPergunta;
    }
}