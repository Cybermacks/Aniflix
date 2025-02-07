namespace Aniflix.Views
{
    partial class AniflixView
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
            roundedButton1 = new Custom.RoundedButton();
            anyCombo1 = new Custom.AnyCombo();
            anyText1 = new Custom.AnyText();
            SuspendLayout();
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.MediumSlateBlue;
            roundedButton1.BackgroundColor = Color.MediumSlateBlue;
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 0;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(197, 211);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(150, 137);
            roundedButton1.TabIndex = 1;
            roundedButton1.Text = "Filmes";
            roundedButton1.TextColor = Color.White;
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // anyCombo1
            // 
            anyCombo1.BackColor = Color.WhiteSmoke;
            anyCombo1.BorderColor = Color.MediumSlateBlue;
            anyCombo1.BorderSize = 1;
            anyCombo1.DropDownStyle = ComboBoxStyle.DropDown;
            anyCombo1.Font = new Font("Segoe UI", 10F);
            anyCombo1.ForeColor = Color.DimGray;
            anyCombo1.IconColor = Color.MediumSlateBlue;
            anyCombo1.ListBackColor = Color.FromArgb(230, 228, 245);
            anyCombo1.ListTextColor = Color.DimGray;
            anyCombo1.Location = new Point(561, 242);
            anyCombo1.MinimumSize = new Size(200, 30);
            anyCombo1.Name = "anyCombo1";
            anyCombo1.Padding = new Padding(1);
            anyCombo1.Size = new Size(200, 30);
            anyCombo1.TabIndex = 2;
            anyCombo1.Texts = "";
            // 
            // anyText1
            // 
            anyText1.BorderColor = Color.MediumSlateBlue;
            anyText1.BorderFocusColor = Color.HotPink;
            anyText1.BorderRadius = 0;
            anyText1.BorderSize = 2;
            anyText1.Location = new Point(385, 371);
            anyText1.Multiline = false;
            anyText1.Name = "anyText1";
            anyText1.PasswordChar = false;
            anyText1.PlaceholderColor = Color.DarkGray;
            anyText1.PlaceholderText = "";
            anyText1.Size = new Size(526, 23);
            anyText1.TabIndex = 3;
            anyText1.Texts = "";
            anyText1.UnderlinedStyle = false;
            // 
            // AniflixView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 613);
            Controls.Add(anyText1);
            Controls.Add(anyCombo1);
            Controls.Add(roundedButton1);
            Name = "AniflixView";
            Text = "AniflixView";
            ResumeLayout(false);
        }

        #endregion

        private Custom.RoundedButton roundedButton1;
        private Custom.AnyCombo anyCombo1;
        private Custom.AnyText anyText1;
    }
}