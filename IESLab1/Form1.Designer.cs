
namespace IESLab1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DimensionTrackbar = new System.Windows.Forms.TrackBar();
            this.DimensionLabel = new System.Windows.Forms.Label();
            this.DimensionValueLabel = new System.Windows.Forms.Label();
            this.StartField = new System.Windows.Forms.TextBox();
            this.ParametersLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthPath = new System.Windows.Forms.TextBox();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.DepthPath = new System.Windows.Forms.TextBox();
            this.Errors = new System.Windows.Forms.Label();
            this.ButtonRandom = new System.Windows.Forms.Button();
            this.EndLabel = new System.Windows.Forms.Label();
            this.EndField = new System.Windows.Forms.TextBox();
            this.WidthSteps = new System.Windows.Forms.Label();
            this.DepthSteps = new System.Windows.Forms.Label();
            this.StatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DimensionTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.LightCyan;
            this.StatusPanel.Controls.Add(this.CloseButton);
            this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.StatusPanel.Location = new System.Drawing.Point(730, 0);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(20, 500);
            this.StatusPanel.TabIndex = 0;
            this.StatusPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StatusPanel_MouseDown);
            this.StatusPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StatusPanel_MouseMove);
            this.StatusPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StatusPanel_MouseUp);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Crimson;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseButton.Location = new System.Drawing.Point(0, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DimensionTrackbar
            // 
            this.DimensionTrackbar.Location = new System.Drawing.Point(12, 390);
            this.DimensionTrackbar.Maximum = 8;
            this.DimensionTrackbar.Minimum = 4;
            this.DimensionTrackbar.Name = "DimensionTrackbar";
            this.DimensionTrackbar.Size = new System.Drawing.Size(208, 45);
            this.DimensionTrackbar.TabIndex = 1;
            this.DimensionTrackbar.Value = 4;
            this.DimensionTrackbar.Scroll += new System.EventHandler(this.DimensionTrackBar_Scroll);
            // 
            // DimensionLabel
            // 
            this.DimensionLabel.AutoSize = true;
            this.DimensionLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DimensionLabel.Location = new System.Drawing.Point(8, 366);
            this.DimensionLabel.Name = "DimensionLabel";
            this.DimensionLabel.Size = new System.Drawing.Size(212, 21);
            this.DimensionLabel.TabIndex = 3;
            this.DimensionLabel.Text = "Выберите размерность матрицы";
            // 
            // DimensionValueLabel
            // 
            this.DimensionValueLabel.AutoSize = true;
            this.DimensionValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DimensionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DimensionValueLabel.Location = new System.Drawing.Point(107, 422);
            this.DimensionValueLabel.Name = "DimensionValueLabel";
            this.DimensionValueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DimensionValueLabel.Size = new System.Drawing.Size(109, 20);
            this.DimensionValueLabel.TabIndex = 4;
            this.DimensionValueLabel.Text = "Размерность";
            // 
            // StartField
            // 
            this.StartField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartField.Location = new System.Drawing.Point(572, 45);
            this.StartField.MaxLength = 1;
            this.StartField.Multiline = true;
            this.StartField.Name = "StartField";
            this.StartField.Size = new System.Drawing.Size(30, 25);
            this.StartField.TabIndex = 5;
            this.StartField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterEnter);
            // 
            // ParametersLabel
            // 
            this.ParametersLabel.AutoSize = true;
            this.ParametersLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParametersLabel.Location = new System.Drawing.Point(419, 9);
            this.ParametersLabel.Name = "ParametersLabel";
            this.ParametersLabel.Size = new System.Drawing.Size(215, 28);
            this.ParametersLabel.TabIndex = 6;
            this.ParametersLabel.Text = "Введите параметры:";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartLabel.Location = new System.Drawing.Point(432, 48);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(134, 21);
            this.StartLabel.TabIndex = 7;
            this.StartLabel.Text = "Начальная точка:";
            // 
            // ButtonFind
            // 
            this.ButtonFind.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFind.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFind.Location = new System.Drawing.Point(491, 123);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ButtonFind.Size = new System.Drawing.Size(75, 23);
            this.ButtonFind.TabIndex = 8;
            this.ButtonFind.Text = "Найти";
            this.ButtonFind.UseVisualStyleBackColor = false;
            this.ButtonFind.Click += new System.EventHandler(this.ButtonFind_Click);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthLabel.Location = new System.Drawing.Point(371, 168);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(118, 21);
            this.WidthLabel.TabIndex = 10;
            this.WidthLabel.Text = "Путь в ширину:";
            // 
            // WidthPath
            // 
            this.WidthPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthPath.Location = new System.Drawing.Point(511, 165);
            this.WidthPath.Multiline = true;
            this.WidthPath.Name = "WidthPath";
            this.WidthPath.ReadOnly = true;
            this.WidthPath.Size = new System.Drawing.Size(213, 25);
            this.WidthPath.TabIndex = 9;
            this.WidthPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepthLabel.Location = new System.Drawing.Point(371, 222);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(116, 21);
            this.DepthLabel.TabIndex = 12;
            this.DepthLabel.Text = "Путь в глубину:";
            // 
            // DepthPath
            // 
            this.DepthPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepthPath.Location = new System.Drawing.Point(511, 219);
            this.DepthPath.Multiline = true;
            this.DepthPath.Name = "DepthPath";
            this.DepthPath.ReadOnly = true;
            this.DepthPath.Size = new System.Drawing.Size(213, 25);
            this.DepthPath.TabIndex = 11;
            this.DepthPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Errors
            // 
            this.Errors.AutoSize = true;
            this.Errors.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Errors.Location = new System.Drawing.Point(390, 264);
            this.Errors.Name = "Errors";
            this.Errors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Errors.Size = new System.Drawing.Size(42, 21);
            this.Errors.TabIndex = 13;
            this.Errors.Text = "Errors";
            // 
            // ButtonRandom
            // 
            this.ButtonRandom.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ButtonRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRandom.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRandom.Location = new System.Drawing.Point(34, 304);
            this.ButtonRandom.Name = "ButtonRandom";
            this.ButtonRandom.Size = new System.Drawing.Size(161, 46);
            this.ButtonRandom.TabIndex = 14;
            this.ButtonRandom.Text = "Заполнить случайными значениями";
            this.ButtonRandom.UseVisualStyleBackColor = false;
            this.ButtonRandom.Click += new System.EventHandler(this.ButtonRandom_Click);
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndLabel.Location = new System.Drawing.Point(432, 85);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(126, 21);
            this.EndLabel.TabIndex = 16;
            this.EndLabel.Text = "Конечная точка:";
            // 
            // EndField
            // 
            this.EndField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndField.Location = new System.Drawing.Point(572, 82);
            this.EndField.MaxLength = 1;
            this.EndField.Multiline = true;
            this.EndField.Name = "EndField";
            this.EndField.Size = new System.Drawing.Size(30, 25);
            this.EndField.TabIndex = 15;
            this.EndField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterEnter);
            // 
            // WidthSteps
            // 
            this.WidthSteps.AutoSize = true;
            this.WidthSteps.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthSteps.Location = new System.Drawing.Point(572, 141);
            this.WidthSteps.Name = "WidthSteps";
            this.WidthSteps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WidthSteps.Size = new System.Drawing.Size(126, 21);
            this.WidthSteps.TabIndex = 17;
            this.WidthSteps.Text = "Количество шагов: ";
            // 
            // DepthSteps
            // 
            this.DepthSteps.AutoSize = true;
            this.DepthSteps.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepthSteps.Location = new System.Drawing.Point(572, 195);
            this.DepthSteps.Name = "DepthSteps";
            this.DepthSteps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DepthSteps.Size = new System.Drawing.Size(126, 21);
            this.DepthSteps.TabIndex = 18;
            this.DepthSteps.Text = "Количество шагов: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.DepthSteps);
            this.Controls.Add(this.WidthSteps);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.EndField);
            this.Controls.Add(this.ButtonRandom);
            this.Controls.Add(this.Errors);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.DepthPath);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.WidthPath);
            this.Controls.Add(this.ButtonFind);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.ParametersLabel);
            this.Controls.Add(this.StartField);
            this.Controls.Add(this.DimensionValueLabel);
            this.Controls.Add(this.DimensionLabel);
            this.Controls.Add(this.DimensionTrackbar);
            this.Controls.Add(this.StatusPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.StatusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DimensionTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TrackBar DimensionTrackbar;
        private System.Windows.Forms.Label DimensionLabel;
        private System.Windows.Forms.Label DimensionValueLabel;
        private System.Windows.Forms.TextBox StartField;
        private System.Windows.Forms.Label ParametersLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Button ButtonFind;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox WidthPath;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.TextBox DepthPath;
        private System.Windows.Forms.Label Errors;
        private System.Windows.Forms.Button ButtonRandom;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.TextBox EndField;
        private System.Windows.Forms.Label WidthSteps;
        private System.Windows.Forms.Label DepthSteps;
    }
}

