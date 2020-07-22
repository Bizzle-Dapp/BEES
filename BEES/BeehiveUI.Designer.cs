namespace BEES
{
    partial class BeehiveUI
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
            this.components = new System.ComponentModel.Container();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.beehiveUIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_InsectRepellent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.beehiveUIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewPanel
            // 
            this.viewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewPanel.Location = new System.Drawing.Point(22, 52);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(754, 371);
            this.viewPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Beehive";
            // 
            // beehiveUIBindingSource
            // 
            this.beehiveUIBindingSource.DataSource = typeof(BEES.BeehiveUI);
            // 
            // btn_InsectRepellent
            // 
            this.btn_InsectRepellent.Location = new System.Drawing.Point(172, 12);
            this.btn_InsectRepellent.Name = "btn_InsectRepellent";
            this.btn_InsectRepellent.Size = new System.Drawing.Size(147, 34);
            this.btn_InsectRepellent.TabIndex = 2;
            this.btn_InsectRepellent.Text = "Insect Repellent";
            this.btn_InsectRepellent.UseVisualStyleBackColor = true;
            this.btn_InsectRepellent.Click += new System.EventHandler(this.Btn_InsectRepellent_Click);
            // 
            // BeehiveUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_InsectRepellent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewPanel);
            this.Name = "BeehiveUI";
            this.Text = "BeehiveUI";
            ((System.ComponentModel.ISupportInitialize)(this.beehiveUIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource beehiveUIBindingSource;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_InsectRepellent;
    }
}

