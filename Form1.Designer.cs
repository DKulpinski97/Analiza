
namespace Analiza
{
    partial class Form1
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
            this.Path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PathToFile = new System.Windows.Forms.Button();
            this.HowMenyChar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Check = new System.Windows.Forms.Button();
            this.HowMenyResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sumary = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MinRedudation = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.SavePath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PathToSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(12, 34);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(172, 23);
            this.Path.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ścieżka do pliku";
            // 
            // PathToFile
            // 
            this.PathToFile.Location = new System.Drawing.Point(12, 63);
            this.PathToFile.Name = "PathToFile";
            this.PathToFile.Size = new System.Drawing.Size(172, 28);
            this.PathToFile.TabIndex = 2;
            this.PathToFile.Text = "Wybierz ścieżkę do pliku";
            this.PathToFile.UseVisualStyleBackColor = true;
            this.PathToFile.Click += new System.EventHandler(this.PathToFile_Click);
            // 
            // HowMenyChar
            // 
            this.HowMenyChar.Location = new System.Drawing.Point(203, 34);
            this.HowMenyChar.Name = "HowMenyChar";
            this.HowMenyChar.Size = new System.Drawing.Size(179, 23);
            this.HowMenyChar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Minimalna długość wiadomości ";
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(203, 152);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(179, 51);
            this.Check.TabIndex = 6;
            this.Check.Text = "Sprawdź ";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // HowMenyResult
            // 
            this.HowMenyResult.Location = new System.Drawing.Point(203, 79);
            this.HowMenyResult.Name = "HowMenyResult";
            this.HowMenyResult.Size = new System.Drawing.Size(179, 23);
            this.HowMenyResult.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maksymalna ilość wyników";
            // 
            // Sumary
            // 
            this.Sumary.FormattingEnabled = true;
            this.Sumary.ItemHeight = 15;
            this.Sumary.Location = new System.Drawing.Point(447, 34);
            this.Sumary.Name = "Sumary";
            this.Sumary.Size = new System.Drawing.Size(262, 169);
            this.Sumary.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Wyniki analizy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Minimalna ilość wystąpień";
            // 
            // MinRedudation
            // 
            this.MinRedudation.Location = new System.Drawing.Point(203, 123);
            this.MinRedudation.Name = "MinRedudation";
            this.MinRedudation.Size = new System.Drawing.Size(179, 23);
            this.MinRedudation.TabIndex = 12;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(443, 209);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(266, 53);
            this.Create.TabIndex = 13;
            this.Create.Text = "Stwórz plik";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // SavePath
            // 
            this.SavePath.Location = new System.Drawing.Point(12, 112);
            this.SavePath.Name = "SavePath";
            this.SavePath.Size = new System.Drawing.Size(172, 23);
            this.SavePath.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Miejsce zapisania pliku";
            // 
            // PathToSave
            // 
            this.PathToSave.Location = new System.Drawing.Point(12, 141);
            this.PathToSave.Name = "PathToSave";
            this.PathToSave.Size = new System.Drawing.Size(172, 48);
            this.PathToSave.TabIndex = 16;
            this.PathToSave.Text = "Wybierz ścieżkę zapisu danych";
            this.PathToSave.UseVisualStyleBackColor = true;
            this.PathToSave.Click += new System.EventHandler(this.PathToSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 272);
            this.Controls.Add(this.PathToSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SavePath);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.MinRedudation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sumary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HowMenyResult);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HowMenyChar);
            this.Controls.Add(this.PathToFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Path);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PathToFile;
        private System.Windows.Forms.TextBox HowMenyChar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TextBox HowMenyResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Sumary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MinRedudation;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.TextBox SavePath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PathToSave;
    }
}

