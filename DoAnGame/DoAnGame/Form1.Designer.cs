namespace DoAnGame
{
    partial class StrMenu
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
            this.button1 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.Rule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(381, 475);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 109);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bắt Đầu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(111, 475);
            this.exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(171, 109);
            this.exit.TabIndex = 1;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Rule
            // 
            this.Rule.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Rule.Location = new System.Drawing.Point(645, 475);
            this.Rule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rule.Name = "Rule";
            this.Rule.Size = new System.Drawing.Size(171, 109);
            this.Rule.TabIndex = 2;
            this.Rule.Text = "Luật chơi";
            this.Rule.UseVisualStyleBackColor = true;
            this.Rule.Click += new System.EventHandler(this.Rule_Click);
            // 
            // StrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoAnGame.Properties.Resources.cuphead_promo_casino_no_text;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.Rule);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StrMenu";
            this.Text = "StartMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button exit;
        private Button Rule;
    }
}