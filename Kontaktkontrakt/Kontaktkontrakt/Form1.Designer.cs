namespace Kontaktkontrakt
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.removeButton = new System.Windows.Forms.Button();
            this.addForm = new System.Windows.Forms.Panel();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.addFormEmail = new System.Windows.Forms.TextBox();
            this.addFormNumber = new System.Windows.Forms.TextBox();
            this.addFormLName = new System.Windows.Forms.TextBox();
            this.addFormFName = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.firstnameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastnameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lnameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addFormAccept = new System.Windows.Forms.Button();
            this.addFormCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.addForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(5, 557);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 0);
            this.panel2.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.addButton, true);
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(569, 0);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 40);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Ny Kontakt";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.removeButton);
            this.flowLayoutPanel1.Controls.Add(this.addButton);
            this.flowLayoutPanel1.Controls.Add(this.addForm);
            this.flowLayoutPanel1.Controls.Add(this.listView1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(874, 552);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.removeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(724, 0);
            this.removeButton.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(150, 40);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "Radera Markerade";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addForm
            // 
            this.addForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.addForm.Controls.Add(this.addFormCancel);
            this.addForm.Controls.Add(this.addFormAccept);
            this.addForm.Controls.Add(this.label2);
            this.addForm.Controls.Add(this.label1);
            this.addForm.Controls.Add(this.lnameLabel);
            this.addForm.Controls.Add(this.fnameLabel);
            this.addForm.Controls.Add(this.addFormEmail);
            this.addForm.Controls.Add(this.addFormNumber);
            this.addForm.Controls.Add(this.addFormLName);
            this.addForm.Controls.Add(this.addFormFName);
            this.addForm.Location = new System.Drawing.Point(3, 43);
            this.addForm.Name = "addForm";
            this.addForm.Size = new System.Drawing.Size(868, 360);
            this.addForm.TabIndex = 3;
            this.addForm.Visible = false;
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.Location = new System.Drawing.Point(27, 17);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(68, 16);
            this.fnameLabel.TabIndex = 4;
            this.fnameLabel.Text = "Förnamn";
            // 
            // addFormEmail
            // 
            this.addFormEmail.Location = new System.Drawing.Point(30, 162);
            this.addFormEmail.Name = "addFormEmail";
            this.addFormEmail.Size = new System.Drawing.Size(150, 20);
            this.addFormEmail.TabIndex = 3;
            // 
            // addFormNumber
            // 
            this.addFormNumber.Location = new System.Drawing.Point(30, 120);
            this.addFormNumber.Name = "addFormNumber";
            this.addFormNumber.Size = new System.Drawing.Size(150, 20);
            this.addFormNumber.TabIndex = 2;
            // 
            // addFormLName
            // 
            this.addFormLName.Location = new System.Drawing.Point(30, 78);
            this.addFormLName.Name = "addFormLName";
            this.addFormLName.Size = new System.Drawing.Size(150, 20);
            this.addFormLName.TabIndex = 1;
            // 
            // addFormFName
            // 
            this.addFormFName.Location = new System.Drawing.Point(30, 36);
            this.addFormFName.Name = "addFormFName";
            this.addFormFName.Size = new System.Drawing.Size(150, 20);
            this.addFormFName.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstnameCol,
            this.lastnameCol,
            this.phoneCol,
            this.emailCol});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 409);
            this.listView1.MinimumSize = new System.Drawing.Size(868, 200);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(868, 506);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // firstnameCol
            // 
            this.firstnameCol.Text = "Förnamn";
            this.firstnameCol.Width = 150;
            // 
            // lastnameCol
            // 
            this.lastnameCol.Text = "Efternamn";
            this.lastnameCol.Width = 150;
            // 
            // phoneCol
            // 
            this.phoneCol.Text = "Telefonnummer";
            this.phoneCol.Width = 200;
            // 
            // emailCol
            // 
            this.emailCol.Text = "E-Mail";
            this.emailCol.Width = 364;
            // 
            // lnameLabel
            // 
            this.lnameLabel.AutoSize = true;
            this.lnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.Location = new System.Drawing.Point(27, 59);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(77, 16);
            this.lnameLabel.TabIndex = 5;
            this.lnameLabel.Text = "Efternamn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Telefonnummer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-mail";
            // 
            // addFormAccept
            // 
            this.addFormAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.addFormAccept.FlatAppearance.BorderSize = 0;
            this.addFormAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addFormAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.addFormAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFormAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addFormAccept.ForeColor = System.Drawing.Color.White;
            this.addFormAccept.Location = new System.Drawing.Point(5, 315);
            this.addFormAccept.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.addFormAccept.Name = "addFormAccept";
            this.addFormAccept.Size = new System.Drawing.Size(150, 40);
            this.addFormAccept.TabIndex = 8;
            this.addFormAccept.Text = "Lägg till Kontakt";
            this.addFormAccept.UseVisualStyleBackColor = false;
            this.addFormAccept.Click += new System.EventHandler(this.addFormAccept_Click);
            // 
            // addFormCancel
            // 
            this.addFormCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addFormCancel.FlatAppearance.BorderSize = 0;
            this.addFormCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.addFormCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.addFormCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFormCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addFormCancel.ForeColor = System.Drawing.Color.White;
            this.addFormCancel.Location = new System.Drawing.Point(160, 315);
            this.addFormCancel.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.addFormCancel.Name = "addFormCancel";
            this.addFormCancel.Size = new System.Drawing.Size(150, 40);
            this.addFormCancel.TabIndex = 9;
            this.addFormCancel.Text = "Avbryt";
            this.addFormCancel.UseVisualStyleBackColor = false;
            this.addFormCancel.Click += new System.EventHandler(this.addFormCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.addForm.ResumeLayout(false);
            this.addForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader firstnameCol;
        private System.Windows.Forms.ColumnHeader lastnameCol;
        private System.Windows.Forms.ColumnHeader phoneCol;
        private System.Windows.Forms.ColumnHeader emailCol;
        private System.Windows.Forms.Panel addForm;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.TextBox addFormEmail;
        private System.Windows.Forms.TextBox addFormNumber;
        private System.Windows.Forms.TextBox addFormLName;
        private System.Windows.Forms.TextBox addFormFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.Button addFormCancel;
        private System.Windows.Forms.Button addFormAccept;
    }
}

