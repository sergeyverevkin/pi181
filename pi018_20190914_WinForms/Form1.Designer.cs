﻿namespace pi018_20190914_WinForms
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
      this.components = new System.ComponentModel.Container();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.labSiteName = new System.Windows.Forms.Label();
      this.lvNews = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnStart = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.btnForm = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 57);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(179, 20);
      this.textBox1.TabIndex = 0;
      this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // labSiteName
      // 
      this.labSiteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labSiteName.Location = new System.Drawing.Point(37, 9);
      this.labSiteName.Name = "labSiteName";
      this.labSiteName.Size = new System.Drawing.Size(360, 45);
      this.labSiteName.TabIndex = 2;
      // 
      // lvNews
      // 
      this.lvNews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.lvNews.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lvNews.FullRowSelect = true;
      this.lvNews.GridLines = true;
      this.lvNews.HideSelection = false;
      this.lvNews.Location = new System.Drawing.Point(0, 96);
      this.lvNews.Name = "lvNews";
      this.lvNews.Size = new System.Drawing.Size(593, 97);
      this.lvNews.TabIndex = 3;
      this.lvNews.UseCompatibleStateImageBehavior = false;
      this.lvNews.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Дата";
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Автор";
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Тема";
      // 
      // btnStart
      // 
      this.btnStart.Location = new System.Drawing.Point(414, 31);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(75, 23);
      this.btnStart.TabIndex = 4;
      this.btnStart.Text = "Демо";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(414, 60);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Демо";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // btnForm
      // 
      this.btnForm.Location = new System.Drawing.Point(495, 31);
      this.btnForm.Name = "btnForm";
      this.btnForm.Size = new System.Drawing.Size(75, 23);
      this.btnForm.TabIndex = 6;
      this.btnForm.Text = "Форма";
      this.btnForm.UseVisualStyleBackColor = true;
      this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(495, 60);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 7;
      this.button2.Text = "Клавиатура";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 41);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "label1";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(12, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(78, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Текст ошибки";
      this.label2.Visible = false;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(333, 59);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 10;
      this.button3.Text = "OX";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(593, 193);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnForm);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnStart);
      this.Controls.Add(this.lvNews);
      this.Controls.Add(this.labSiteName);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.Label labSiteName;
    private System.Windows.Forms.ListView lvNews;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button btnForm;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button3;
  }
}

