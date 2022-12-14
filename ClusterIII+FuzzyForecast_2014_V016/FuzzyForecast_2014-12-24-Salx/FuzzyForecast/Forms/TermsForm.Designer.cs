namespace FuzzyForecast {
  partial class TermsForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
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
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.graphControl = new ZedGraph.ZedGraphControl();
      this.SuspendLayout();
      // 
      // graphControl
      // 
      this.graphControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.graphControl.Location = new System.Drawing.Point(0, 0);
      this.graphControl.Name = "graphControl";
      this.graphControl.ScrollGrace = 0;
      this.graphControl.ScrollMaxX = 0;
      this.graphControl.ScrollMaxY = 0;
      this.graphControl.ScrollMaxY2 = 0;
      this.graphControl.ScrollMinX = 0;
      this.graphControl.ScrollMinY = 0;
      this.graphControl.ScrollMinY2 = 0;
      this.graphControl.Size = new System.Drawing.Size(598, 321);
      this.graphControl.TabIndex = 1;
      // 
      // TermsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(598, 321);
      this.Controls.Add(this.graphControl);
      this.Name = "TermsForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Функции принадлежности";
      this.ResumeLayout(false);

    }

    #endregion

    private ZedGraph.ZedGraphControl graphControl;
  }
}