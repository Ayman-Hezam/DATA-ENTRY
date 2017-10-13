namespace DATA_ENTRY
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textid = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.butselectphoto = new System.Windows.Forms.Button();
            this.picperson = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picperson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textid
            // 
            this.textid.Location = new System.Drawing.Point(200, 108);
            this.textid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(312, 30);
            this.textid.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textid, "ادخل رقم التعريفي");
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(200, 150);
            this.textname.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(312, 30);
            this.textname.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textname, "ادخل اسم الشخص");
            // 
            // textaddress
            // 
            this.textaddress.Location = new System.Drawing.Point(200, 191);
            this.textaddress.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(312, 30);
            this.textaddress.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textaddress, "ادخل عنوان الشخص");
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add.Location = new System.Drawing.Point(54, 266);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 32);
            this.add.TabIndex = 4;
            this.add.Tag = "";
            this.add.Text = "Add";
            this.toolTip1.SetToolTip(this.add, "اضافة العناصر");
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(164, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Find";
            this.toolTip1.SetToolTip(this.button2, "بحث");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(276, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 32);
            this.button3.TabIndex = 6;
            this.button3.Text = "Show all";
            this.toolTip1.SetToolTip(this.button3, "اظهار الكل");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Location = new System.Drawing.Point(432, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 10;
            this.button4.Text = "Exit";
            this.toolTip1.SetToolTip(this.button4, "خروج");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // butselectphoto
            // 
            this.butselectphoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butselectphoto.Location = new System.Drawing.Point(598, 266);
            this.butselectphoto.Name = "butselectphoto";
            this.butselectphoto.Size = new System.Drawing.Size(155, 32);
            this.butselectphoto.TabIndex = 12;
            this.butselectphoto.Text = "Select Photo";
            this.toolTip1.SetToolTip(this.butselectphoto, "اختر الصوره");
            this.butselectphoto.UseVisualStyleBackColor = false;
            this.butselectphoto.Click += new System.EventHandler(this.butselectphoto_Click);
            // 
            // picperson
            // 
            this.picperson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picperson.Location = new System.Drawing.Point(598, 76);
            this.picperson.Name = "picperson";
            this.picperson.Size = new System.Drawing.Size(155, 184);
            this.picperson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picperson.TabIndex = 11;
            this.picperson.TabStop = false;
            this.picperson.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 326);
            this.Controls.Add(this.butselectphoto);
            this.Controls.Add(this.picperson);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.textaddress);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picperson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picperson;
        private System.Windows.Forms.Button butselectphoto;
    }
}

