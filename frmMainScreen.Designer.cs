namespace Roll_Initiative
{
    partial class frmMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainScreen));
            this.lvwInitiative = new System.Windows.Forms.ListView();
            this.btnRollInitiative = new System.Windows.Forms.Button();
            this.btnAddCombatant = new System.Windows.Forms.Button();
            this.btnRemoveCombatant = new System.Windows.Forms.Button();
            this.btnRerollCombatant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwInitiative
            // 
            this.lvwInitiative.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvwInitiative.Location = new System.Drawing.Point(25, 27);
            this.lvwInitiative.Name = "lvwInitiative";
            this.lvwInitiative.Size = new System.Drawing.Size(457, 479);
            this.lvwInitiative.TabIndex = 0;
            this.lvwInitiative.UseCompatibleStateImageBehavior = false;
            // 
            // btnRollInitiative
            // 
            this.btnRollInitiative.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRollInitiative.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRollInitiative.FlatAppearance.BorderSize = 3;
            this.btnRollInitiative.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRollInitiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRollInitiative.Location = new System.Drawing.Point(501, 27);
            this.btnRollInitiative.Name = "btnRollInitiative";
            this.btnRollInitiative.Size = new System.Drawing.Size(294, 126);
            this.btnRollInitiative.TabIndex = 1;
            this.btnRollInitiative.Text = "Roll Initiative!";
            this.btnRollInitiative.UseVisualStyleBackColor = false;
            this.btnRollInitiative.Click += new System.EventHandler(this.btnRollInitiative_Click);
            // 
            // btnAddCombatant
            // 
            this.btnAddCombatant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCombatant.Location = new System.Drawing.Point(501, 295);
            this.btnAddCombatant.Name = "btnAddCombatant";
            this.btnAddCombatant.Size = new System.Drawing.Size(294, 48);
            this.btnAddCombatant.TabIndex = 2;
            this.btnAddCombatant.Text = "Add Combatant";
            this.btnAddCombatant.UseVisualStyleBackColor = true;
            this.btnAddCombatant.Click += new System.EventHandler(this.btnAddCombatant_Click);
            // 
            // btnRemoveCombatant
            // 
            this.btnRemoveCombatant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCombatant.Location = new System.Drawing.Point(501, 458);
            this.btnRemoveCombatant.Name = "btnRemoveCombatant";
            this.btnRemoveCombatant.Size = new System.Drawing.Size(294, 48);
            this.btnRemoveCombatant.TabIndex = 4;
            this.btnRemoveCombatant.Text = "Remove Combatant";
            this.btnRemoveCombatant.UseVisualStyleBackColor = true;
            this.btnRemoveCombatant.Click += new System.EventHandler(this.btnRemoveCombatant_Click);
            // 
            // btnRerollCombatant
            // 
            this.btnRerollCombatant.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRerollCombatant.Location = new System.Drawing.Point(501, 379);
            this.btnRerollCombatant.Name = "btnRerollCombatant";
            this.btnRerollCombatant.Size = new System.Drawing.Size(294, 48);
            this.btnRerollCombatant.TabIndex = 3;
            this.btnRerollCombatant.Text = "Reroll Combatant";
            this.btnRerollCombatant.UseVisualStyleBackColor = true;
            this.btnRerollCombatant.Click += new System.EventHandler(this.btnRerollCombatant_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 570);
            this.Controls.Add(this.btnRerollCombatant);
            this.Controls.Add(this.btnRemoveCombatant);
            this.Controls.Add(this.btnAddCombatant);
            this.Controls.Add(this.btnRollInitiative);
            this.Controls.Add(this.lvwInitiative);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainScreen";
            this.Text = "Roll Initiative!";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvwInitiative;
        private Button btnRollInitiative;
        private Button btnAddCombatant;
        private Button btnRemoveCombatant;
        private Button btnRerollCombatant;
    }
}