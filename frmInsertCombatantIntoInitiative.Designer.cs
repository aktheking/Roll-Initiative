namespace Roll_Initiative
{
    partial class frmInsertCombatantIntoInitiative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertCombatantIntoInitiative));
            this.txtCombatant = new System.Windows.Forms.TextBox();
            this.txtInitiative = new System.Windows.Forms.TextBox();
            this.lblCombatant = new System.Windows.Forms.Label();
            this.lblInitiative = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCombatant
            // 
            this.txtCombatant.Location = new System.Drawing.Point(17, 52);
            this.txtCombatant.Name = "txtCombatant";
            this.txtCombatant.Size = new System.Drawing.Size(125, 27);
            this.txtCombatant.TabIndex = 0;
            // 
            // txtInitiative
            // 
            this.txtInitiative.Location = new System.Drawing.Point(196, 52);
            this.txtInitiative.Name = "txtInitiative";
            this.txtInitiative.Size = new System.Drawing.Size(69, 27);
            this.txtInitiative.TabIndex = 1;
            // 
            // lblCombatant
            // 
            this.lblCombatant.AutoSize = true;
            this.lblCombatant.Location = new System.Drawing.Point(17, 18);
            this.lblCombatant.Name = "lblCombatant";
            this.lblCombatant.Size = new System.Drawing.Size(86, 20);
            this.lblCombatant.TabIndex = 2;
            this.lblCombatant.Text = "Combatant:";
            // 
            // lblInitiative
            // 
            this.lblInitiative.AutoSize = true;
            this.lblInitiative.Location = new System.Drawing.Point(196, 18);
            this.lblInitiative.Name = "lblInitiative";
            this.lblInitiative.Size = new System.Drawing.Size(69, 20);
            this.lblInitiative.TabIndex = 3;
            this.lblInitiative.Text = "Initiative:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(332, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(332, 12);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 29);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // frmInsertCombatantIntoInitiative
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRemove;
            this.ClientSize = new System.Drawing.Size(451, 103);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblInitiative);
            this.Controls.Add(this.lblCombatant);
            this.Controls.Add(this.txtInitiative);
            this.Controls.Add(this.txtCombatant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInsertCombatantIntoInitiative";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Combatant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCombatant;
        private TextBox txtInitiative;
        private Label lblCombatant;
        private Label lblInitiative;
        private Button btnAdd;
        private Button btnRemove;
    }
}