
namespace OpenTK3_StandardTemplate_WinForms
{
    partial class MainForm
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
            this.showAxes = new System.Windows.Forms.CheckBox();
            this.changeBackground = new System.Windows.Forms.Button();
            this.lblOx = new System.Windows.Forms.Label();
            this.lblOy = new System.Windows.Forms.Label();
            this.lblOz = new System.Windows.Forms.Label();
            this.resetScene = new System.Windows.Forms.Button();
            this.enableRotation = new System.Windows.Forms.CheckBox();
            this.enableObjectRotation = new System.Windows.Forms.CheckBox();
            this.btnNegRot = new System.Windows.Forms.Button();
            this.btnPosRot = new System.Windows.Forms.Button();
            this.btnNegTran = new System.Windows.Forms.Button();
            this.btnPosTran = new System.Windows.Forms.Button();
            this.btnNegScal = new System.Windows.Forms.Button();
            this.btnPosScal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showAxes
            // 
            this.showAxes.AutoSize = true;
            this.showAxes.Checked = true;
            this.showAxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAxes.Location = new System.Drawing.Point(1116, 16);
            this.showAxes.Margin = new System.Windows.Forms.Padding(4);
            this.showAxes.Name = "showAxes";
            this.showAxes.Size = new System.Drawing.Size(95, 20);
            this.showAxes.TabIndex = 0;
            this.showAxes.Text = "Show Axes";
            this.showAxes.UseVisualStyleBackColor = true;
            this.showAxes.CheckedChanged += new System.EventHandler(this.showAxes_CheckedChanged);
            // 
            // changeBackground
            // 
            this.changeBackground.Location = new System.Drawing.Point(1116, 133);
            this.changeBackground.Margin = new System.Windows.Forms.Padding(4);
            this.changeBackground.Name = "changeBackground";
            this.changeBackground.Size = new System.Drawing.Size(267, 39);
            this.changeBackground.TabIndex = 1;
            this.changeBackground.Text = "Change background color";
            this.changeBackground.UseVisualStyleBackColor = true;
            this.changeBackground.Click += new System.EventHandler(this.changeBackground_Click);
            // 
            // lblOx
            // 
            this.lblOx.BackColor = System.Drawing.Color.Red;
            this.lblOx.Location = new System.Drawing.Point(1145, 43);
            this.lblOx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOx.Name = "lblOx";
            this.lblOx.Size = new System.Drawing.Size(53, 25);
            this.lblOx.TabIndex = 2;
            this.lblOx.Text = "Ox";
            this.lblOx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOy
            // 
            this.lblOy.BackColor = System.Drawing.Color.Green;
            this.lblOy.Location = new System.Drawing.Point(1207, 43);
            this.lblOy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOy.Name = "lblOy";
            this.lblOy.Size = new System.Drawing.Size(53, 25);
            this.lblOy.TabIndex = 3;
            this.lblOy.Text = "Oy";
            this.lblOy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOz
            // 
            this.lblOz.BackColor = System.Drawing.Color.Blue;
            this.lblOz.Location = new System.Drawing.Point(1268, 43);
            this.lblOz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOz.Name = "lblOz";
            this.lblOz.Size = new System.Drawing.Size(53, 25);
            this.lblOz.TabIndex = 4;
            this.lblOz.Text = "Oz";
            this.lblOz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetScene
            // 
            this.resetScene.Location = new System.Drawing.Point(1116, 180);
            this.resetScene.Margin = new System.Windows.Forms.Padding(4);
            this.resetScene.Name = "resetScene";
            this.resetScene.Size = new System.Drawing.Size(267, 39);
            this.resetScene.TabIndex = 5;
            this.resetScene.Text = "Reset scene";
            this.resetScene.UseVisualStyleBackColor = true;
            this.resetScene.Click += new System.EventHandler(this.resetScene_Click);
            // 
            // enableRotation
            // 
            this.enableRotation.AutoSize = true;
            this.enableRotation.Location = new System.Drawing.Point(1116, 71);
            this.enableRotation.Margin = new System.Windows.Forms.Padding(4);
            this.enableRotation.Name = "enableRotation";
            this.enableRotation.Size = new System.Drawing.Size(163, 20);
            this.enableRotation.TabIndex = 6;
            this.enableRotation.Text = "Enable mouse rotation";
            this.enableRotation.UseVisualStyleBackColor = true;
            // 
            // enableObjectRotation
            // 
            this.enableObjectRotation.AutoSize = true;
            this.enableObjectRotation.Location = new System.Drawing.Point(1116, 102);
            this.enableObjectRotation.Margin = new System.Windows.Forms.Padding(4);
            this.enableObjectRotation.Name = "enableObjectRotation";
            this.enableObjectRotation.Size = new System.Drawing.Size(159, 20);
            this.enableObjectRotation.TabIndex = 7;
            this.enableObjectRotation.Text = "Enable object rotation";
            this.enableObjectRotation.UseVisualStyleBackColor = true;
            // 
            // btnNegRot
            // 
            this.btnNegRot.Location = new System.Drawing.Point(1116, 226);
            this.btnNegRot.Name = "btnNegRot";
            this.btnNegRot.Size = new System.Drawing.Size(75, 23);
            this.btnNegRot.TabIndex = 8;
            this.btnNegRot.Text = "-Rotate";
            this.btnNegRot.UseVisualStyleBackColor = true;
            // 
            // btnPosRot
            // 
            this.btnPosRot.Location = new System.Drawing.Point(1197, 226);
            this.btnPosRot.Name = "btnPosRot";
            this.btnPosRot.Size = new System.Drawing.Size(75, 23);
            this.btnPosRot.TabIndex = 9;
            this.btnPosRot.Text = "+Rotate";
            this.btnPosRot.UseVisualStyleBackColor = true;
            // 
            // btnNegTran
            // 
            this.btnNegTran.Location = new System.Drawing.Point(1116, 255);
            this.btnNegTran.Name = "btnNegTran";
            this.btnNegTran.Size = new System.Drawing.Size(95, 23);
            this.btnNegTran.TabIndex = 10;
            this.btnNegTran.Text = "-Translate";
            this.btnNegTran.UseVisualStyleBackColor = true;
            // 
            // btnPosTran
            // 
            this.btnPosTran.Location = new System.Drawing.Point(1217, 255);
            this.btnPosTran.Name = "btnPosTran";
            this.btnPosTran.Size = new System.Drawing.Size(90, 23);
            this.btnPosTran.TabIndex = 11;
            this.btnPosTran.Text = "+Translate";
            this.btnPosTran.UseVisualStyleBackColor = true;
            // 
            // btnNegScal
            // 
            this.btnNegScal.Location = new System.Drawing.Point(1116, 284);
            this.btnNegScal.Name = "btnNegScal";
            this.btnNegScal.Size = new System.Drawing.Size(75, 23);
            this.btnNegScal.TabIndex = 12;
            this.btnNegScal.Text = "-Scale";
            this.btnNegScal.UseVisualStyleBackColor = true;
            // 
            // btnPosScal
            // 
            this.btnPosScal.Location = new System.Drawing.Point(1200, 284);
            this.btnPosScal.Name = "btnPosScal";
            this.btnPosScal.Size = new System.Drawing.Size(75, 23);
            this.btnPosScal.TabIndex = 13;
            this.btnPosScal.Text = "+Scale";
            this.btnPosScal.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 673);
            this.Controls.Add(this.btnPosScal);
            this.Controls.Add(this.btnNegScal);
            this.Controls.Add(this.btnPosTran);
            this.Controls.Add(this.btnNegTran);
            this.Controls.Add(this.btnPosRot);
            this.Controls.Add(this.btnNegRot);
            this.Controls.Add(this.enableObjectRotation);
            this.Controls.Add(this.enableRotation);
            this.Controls.Add(this.resetScene);
            this.Controls.Add(this.lblOz);
            this.Controls.Add(this.lblOy);
            this.Controls.Add(this.lblOx);
            this.Controls.Add(this.changeBackground);
            this.Controls.Add(this.showAxes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "OpenTK 3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showAxes;
        private System.Windows.Forms.Button changeBackground;
        private System.Windows.Forms.Label lblOx;
        private System.Windows.Forms.Label lblOy;
        private System.Windows.Forms.Label lblOz;
        private System.Windows.Forms.Button resetScene;
        private System.Windows.Forms.CheckBox enableRotation;
        private System.Windows.Forms.CheckBox enableObjectRotation;
        private System.Windows.Forms.Button btnNegRot;
        private System.Windows.Forms.Button btnPosRot;
        private System.Windows.Forms.Button btnNegTran;
        private System.Windows.Forms.Button btnPosTran;
        private System.Windows.Forms.Button btnNegScal;
        private System.Windows.Forms.Button btnPosScal;
    }
}

