namespace pi018_20190914_WinForms
{
  partial class OXForm
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
      if (disposing && (components != null)) {
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.label1 = new System.Windows.Forms.Label();
      this.edPlayer1 = new System.Windows.Forms.TextBox();
      this.edPlayer2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.numSize = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(800, 450);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.button1);
      this.tabPage1.Controls.Add(this.label3);
      this.tabPage1.Controls.Add(this.numSize);
      this.tabPage1.Controls.Add(this.edPlayer2);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.edPlayer1);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Location = new System.Drawing.Point(4, 25);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(792, 421);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Новая игра";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 25);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(792, 421);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Игра";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(24, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Игрок №1";
      // 
      // edPlayer1
      // 
      this.edPlayer1.Location = new System.Drawing.Point(27, 31);
      this.edPlayer1.Name = "edPlayer1";
      this.edPlayer1.Size = new System.Drawing.Size(147, 20);
      this.edPlayer1.TabIndex = 1;
      // 
      // edPlayer2
      // 
      this.edPlayer2.Location = new System.Drawing.Point(27, 70);
      this.edPlayer2.Name = "edPlayer2";
      this.edPlayer2.Size = new System.Drawing.Size(147, 20);
      this.edPlayer2.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(24, 54);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(58, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Игрок №2";
      // 
      // numSize
      // 
      this.numSize.Location = new System.Drawing.Point(27, 109);
      this.numSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
      this.numSize.Name = "numSize";
      this.numSize.Size = new System.Drawing.Size(147, 20);
      this.numSize.TabIndex = 4;
      this.numSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(24, 93);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(102, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Размерность поля";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(27, 148);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "Новая игра";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // OXForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tabControl1);
      this.Name = "OXForm";
      this.Text = "OXForm";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox edPlayer1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox edPlayer2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numSize;
    private System.Windows.Forms.Button button1;
  }
}