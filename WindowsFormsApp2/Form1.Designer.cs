
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TextboxX = new System.Windows.Forms.TextBox();
            this.ColorSelectX = new System.Windows.Forms.Button();
            this.Gracz1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textColorX = new System.Windows.Forms.Panel();
            this.InputNameX = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textColorO = new System.Windows.Forms.Panel();
            this.InputNameO = new System.Windows.Forms.Label();
            this.Gracz2 = new System.Windows.Forms.Label();
            this.ColorSelectO = new System.Windows.Forms.Button();
            this.TextboxO = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // TextboxX
            // 
            this.TextboxX.Location = new System.Drawing.Point(89, 169);
            this.TextboxX.Name = "TextboxX";
            this.TextboxX.Size = new System.Drawing.Size(174, 20);
            this.TextboxX.TabIndex = 0;
            // 
            // ColorSelectX
            // 
            this.ColorSelectX.Location = new System.Drawing.Point(111, 284);
            this.ColorSelectX.Name = "ColorSelectX";
            this.ColorSelectX.Size = new System.Drawing.Size(136, 23);
            this.ColorSelectX.TabIndex = 1;
            this.ColorSelectX.Text = "Wybierz kolor";
            this.ColorSelectX.UseVisualStyleBackColor = true;
            this.ColorSelectX.Click += new System.EventHandler(this.ColorSelect_Click);
            // 
            // Gracz1
            // 
            this.Gracz1.AutoSize = true;
            this.Gracz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gracz1.Location = new System.Drawing.Point(138, 10);
            this.Gracz1.Name = "Gracz1";
            this.Gracz1.Size = new System.Drawing.Size(80, 25);
            this.Gracz1.TabIndex = 2;
            this.Gracz1.Text = "Gracz 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textColorX);
            this.panel1.Controls.Add(this.InputNameX);
            this.panel1.Controls.Add(this.Gracz1);
            this.panel1.Controls.Add(this.ColorSelectX);
            this.panel1.Controls.Add(this.TextboxX);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 450);
            this.panel1.TabIndex = 3;
            // 
            // textColorX
            // 
            this.textColorX.Location = new System.Drawing.Point(254, 284);
            this.textColorX.Name = "textColorX";
            this.textColorX.Size = new System.Drawing.Size(22, 23);
            this.textColorX.TabIndex = 4;
            // 
            // InputNameX
            // 
            this.InputNameX.AutoSize = true;
            this.InputNameX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InputNameX.Location = new System.Drawing.Point(106, 105);
            this.InputNameX.Name = "InputNameX";
            this.InputNameX.Size = new System.Drawing.Size(157, 25);
            this.InputNameX.TabIndex = 3;
            this.InputNameX.Text = "Podaj swoje imie";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textColorO);
            this.panel2.Controls.Add(this.InputNameO);
            this.panel2.Controls.Add(this.Gracz2);
            this.panel2.Controls.Add(this.ColorSelectO);
            this.panel2.Controls.Add(this.TextboxO);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(458, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 450);
            this.panel2.TabIndex = 4;
            // 
            // textColorO
            // 
            this.textColorO.Location = new System.Drawing.Point(253, 284);
            this.textColorO.Name = "textColorO";
            this.textColorO.Size = new System.Drawing.Size(22, 23);
            this.textColorO.TabIndex = 5;
            // 
            // InputNameO
            // 
            this.InputNameO.AutoSize = true;
            this.InputNameO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InputNameO.Location = new System.Drawing.Point(106, 105);
            this.InputNameO.Name = "InputNameO";
            this.InputNameO.Size = new System.Drawing.Size(157, 25);
            this.InputNameO.TabIndex = 3;
            this.InputNameO.Text = "Podaj swoje imie";
            // 
            // Gracz2
            // 
            this.Gracz2.AutoSize = true;
            this.Gracz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Gracz2.Location = new System.Drawing.Point(138, 10);
            this.Gracz2.Name = "Gracz2";
            this.Gracz2.Size = new System.Drawing.Size(80, 25);
            this.Gracz2.TabIndex = 2;
            this.Gracz2.Text = "Gracz 1";
            // 
            // ColorSelectO
            // 
            this.ColorSelectO.Location = new System.Drawing.Point(111, 284);
            this.ColorSelectO.Name = "ColorSelectO";
            this.ColorSelectO.Size = new System.Drawing.Size(136, 23);
            this.ColorSelectO.TabIndex = 1;
            this.ColorSelectO.Text = "Wybierz kolor";
            this.ColorSelectO.UseVisualStyleBackColor = true;
            this.ColorSelectO.Click += new System.EventHandler(this.ColorSelect_Click);
            // 
            // TextboxO
            // 
            this.TextboxO.Location = new System.Drawing.Point(89, 169);
            this.TextboxO.Name = "TextboxO";
            this.TextboxO.Size = new System.Drawing.Size(174, 20);
            this.TextboxO.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Start.Location = new System.Drawing.Point(37, 213);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 41);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.start_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Start);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(322, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 450);
            this.panel3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox TextboxX;
        private System.Windows.Forms.Button ColorSelectX;
        private System.Windows.Forms.Label Gracz1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label InputNameX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label InputNameO;
        private System.Windows.Forms.Label Gracz2;
        private System.Windows.Forms.Button ColorSelectO;
        private System.Windows.Forms.TextBox TextboxO;
        private System.Windows.Forms.Panel textColorX;
        private System.Windows.Forms.Panel textColorO;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Panel panel3;
    }
}

