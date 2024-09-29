namespace NotepadApp;

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
        label1 = new Label();
        open_notes = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("UD Digi Kyokasho NP-R", 24F, FontStyle.Bold, GraphicsUnit.Point, 128);
        label1.ForeColor = SystemColors.Control;
        label1.Location = new Point(25, 25);
        label1.Name = "label1";
        label1.Size = new Size(264, 37);
        label1.TabIndex = 0;
        label1.Text = "Welcome back!";
        label1.Click += label1_Click;
        // 
        // open_notes
        // 
        open_notes.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        open_notes.Location = new Point(45, 101);
        open_notes.Name = "open_notes";
        open_notes.Size = new Size(173, 40);
        open_notes.TabIndex = 1;
        open_notes.Text = "Open my Notes!";
        open_notes.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Navy;
        ClientSize = new Size(800, 450);
        Controls.Add(open_notes);
        Controls.Add(label1);
        Cursor = Cursors.Arrow;
        ForeColor = SystemColors.ControlText;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button open_notes;
}
