
namespace WindowsFormsApp1
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
            this.Tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.box = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Groups = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Fam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Info = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.referense = new System.Windows.Forms.LinkLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.Tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.box.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Info)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab1
            // 
            this.Tab1.Controls.Add(this.tabPage1);
            this.Tab1.Controls.Add(this.tabPage2);
            this.Tab1.Controls.Add(this.tabPage3);
            this.Tab1.Location = new System.Drawing.Point(3, 0);
            this.Tab1.Name = "Tab1";
            this.Tab1.SelectedIndex = 0;
            this.Tab1.Size = new System.Drawing.Size(793, 317);
            this.Tab1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.Tab1.TabIndex = 0;
            this.Tab1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.Tab1_DrawItem);
            this.Tab1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Tab1_Selecting);
            this.Tab1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Tab1_MouseDown);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.box);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вкладка 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // box
            // 
            this.box.AutoSize = true;
            this.box.Controls.Add(this.button1);
            this.box.Controls.Add(this.Groups);
            this.box.Controls.Add(this.Name);
            this.box.Controls.Add(this.Fam);
            this.box.Controls.Add(this.label3);
            this.box.Controls.Add(this.label2);
            this.box.Controls.Add(this.label1);
            this.box.Location = new System.Drawing.Point(24, 17);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(521, 258);
            this.box.TabIndex = 0;
            this.box.TabStop = false;
            this.box.Text = "Информация";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Groups
            // 
            this.Groups.Location = new System.Drawing.Point(113, 125);
            this.Groups.Name = "Groups";
            this.Groups.Size = new System.Drawing.Size(256, 20);
            this.Groups.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(113, 89);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(256, 20);
            this.Name.TabIndex = 4;
            // 
            // Fam
            // 
            this.Fam.Location = new System.Drawing.Point(113, 51);
            this.Fam.Name = "Fam";
            this.Fam.Size = new System.Drawing.Size(256, 20);
            this.Fam.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(38, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.Info);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage2.Size = new System.Drawing.Size(785, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вкладка 2";
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Info.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Info.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.Info.Location = new System.Drawing.Point(3, 6);
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Info.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Info.Size = new System.Drawing.Size(779, 291);
            this.Info.TabIndex = 0;
            this.Info.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Info_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(785, 291);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ссылка на гит";
            // 
            // referense
            // 
            this.referense.AutoSize = true;
            this.referense.Location = new System.Drawing.Point(123, 371);
            this.referense.Name = "referense";
            this.referense.Size = new System.Drawing.Size(46, 13);
            this.referense.TabIndex = 2;
            this.referense.TabStop = true;
            this.referense.Text = "Ссылка";
            this.referense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Настройки";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tab1);
            this.Controls.Add(this.referense);
            this.Controls.Add(this.label4);
          
            this.Text = "Form1";
            this.Tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.box.ResumeLayout(false);
            this.box.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab1;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Groups;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Fam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel referense;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataGridView Info;
    }
}

