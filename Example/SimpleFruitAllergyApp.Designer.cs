namespace SimpleFruitAllergyApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.fruitcheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.fruitListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY SIMPLE FRUIT ALLERGY APP";
            // 
            // fruitcheckedListBox1
            // 
            this.fruitcheckedListBox1.BackColor = System.Drawing.Color.SeaShell;
            this.fruitcheckedListBox1.FormattingEnabled = true;
            this.fruitcheckedListBox1.Location = new System.Drawing.Point(55, 119);
            this.fruitcheckedListBox1.Name = "fruitcheckedListBox1";
            this.fruitcheckedListBox1.Size = new System.Drawing.Size(183, 229);
            this.fruitcheckedListBox1.TabIndex = 1;
            this.fruitcheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.fruitcheckedListBox1_SelectedIndexChanged);
            // 
            // fruitListBox
            // 
            this.fruitListBox.BackColor = System.Drawing.Color.SeaShell;
            this.fruitListBox.FormattingEnabled = true;
            this.fruitListBox.Location = new System.Drawing.Point(263, 119);
            this.fruitListBox.Name = "fruitListBox";
            this.fruitListBox.Size = new System.Drawing.Size(172, 225);
            this.fruitListBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fruits List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "My Fruits List";
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.PeachPuff;
            this.delete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(481, 171);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(92, 32);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.PeachPuff;
            this.clear.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(481, 209);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(92, 33);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear All";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.PeachPuff;
            this.add.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(97, 365);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(109, 26);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(615, 414);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fruitListBox);
            this.Controls.Add(this.fruitcheckedListBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox fruitcheckedListBox1;
        private System.Windows.Forms.ListBox fruitListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
    }
}

