namespace Dicegame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonForDicing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelForResult = new System.Windows.Forms.Label();
            this.buttonForCheating = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonForDicing
            // 
            this.buttonForDicing.Location = new System.Drawing.Point(68, 86);
            this.buttonForDicing.Name = "buttonForDicing";
            this.buttonForDicing.Size = new System.Drawing.Size(193, 118);
            this.buttonForDicing.TabIndex = 0;
            this.buttonForDicing.Text = "Бросить кубики!";
            this.buttonForDicing.UseVisualStyleBackColor = true;
            this.buttonForDicing.Click += new System.EventHandler(this.buttonForDicing_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Игра, в которой три шестигранных кубика. Бросайте кубики по очереди. У кого больш" +
    "е сумма очков, тот и победит!";
            // 
            // labelForResult
            // 
            this.labelForResult.AutoSize = true;
            this.labelForResult.Location = new System.Drawing.Point(52, 242);
            this.labelForResult.Name = "labelForResult";
            this.labelForResult.Size = new System.Drawing.Size(0, 17);
            this.labelForResult.TabIndex = 2;
            // 
            // buttonForCheating
            // 
            this.buttonForCheating.Location = new System.Drawing.Point(316, 298);
            this.buttonForCheating.Name = "buttonForCheating";
            this.buttonForCheating.Size = new System.Drawing.Size(17, 17);
            this.buttonForCheating.TabIndex = 3;
            this.buttonForCheating.UseVisualStyleBackColor = true;
            this.buttonForCheating.Click += new System.EventHandler(this.buttonForCheating_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 310);
            this.Controls.Add(this.buttonForCheating);
            this.Controls.Add(this.labelForResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonForDicing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonForDicing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelForResult;
        private System.Windows.Forms.Button buttonForCheating;
    }
}

