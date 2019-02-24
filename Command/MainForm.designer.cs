using Gushwell.DesignPatterns.Drawer;

namespace Gushwell.DesignPatterns {
    partial class MainForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        private void InitializeComponent() {
            this.clearButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.drawCanvas1 = new Gushwell.DesignPatterns.Drawer.DrawCanvas();
            this.SuspendLayout();
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(55, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(136, 3);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(75, 23);
            this.undoButton.TabIndex = 2;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.UndoButton_Click);
            // 
            // drawCanvas1
            // 
            this.drawCanvas1.BackColor = System.Drawing.SystemColors.Window;
            this.drawCanvas1.Location = new System.Drawing.Point(1, 32);
            this.drawCanvas1.Name = "drawCanvas1";
            this.drawCanvas1.Size = new System.Drawing.Size(290, 239);
            this.drawCanvas1.TabIndex = 0;
            this.drawCanvas1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas1_MouseDown);
            this.drawCanvas1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas1_MouseMove);
            this.drawCanvas1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DrawCanvas1_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.drawCanvas1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "Command Pattern Sample";
            this.ResumeLayout(false);

        }

        #endregion

        private DrawCanvas drawCanvas1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button undoButton;
    }
}

