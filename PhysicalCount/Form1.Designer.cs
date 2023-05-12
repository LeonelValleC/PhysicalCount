
namespace PhysicalCount
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PN = new System.Windows.Forms.TextBox();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Loc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tagno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_IdEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Part N#:";
            // 
            // txt_PN
            // 
            this.txt_PN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PN.Location = new System.Drawing.Point(85, 80);
            this.txt_PN.Name = "txt_PN";
            this.txt_PN.Size = new System.Drawing.Size(345, 26);
            this.txt_PN.TabIndex = 1;
            this.txt_PN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_PN_KeyUp);
            // 
            // txt_Qty
            // 
            this.txt_Qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qty.Location = new System.Drawing.Point(85, 159);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(345, 26);
            this.txt_Qty.TabIndex = 3;
            this.txt_Qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Qty_KeyPress);
            this.txt_Qty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Qty_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "QTY:";
            // 
            // txt_Loc
            // 
            this.txt_Loc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Loc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Loc.Location = new System.Drawing.Point(85, 203);
            this.txt_Loc.Name = "txt_Loc";
            this.txt_Loc.Size = new System.Drawing.Size(345, 26);
            this.txt_Loc.TabIndex = 5;
            this.txt_Loc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Loc_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loc:";
            // 
            // txt_Tagno
            // 
            this.txt_Tagno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Tagno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tagno.Location = new System.Drawing.Point(85, 248);
            this.txt_Tagno.Name = "txt_Tagno";
            this.txt_Tagno.Size = new System.Drawing.Size(345, 26);
            this.txt_Tagno.TabIndex = 7;
            this.txt_Tagno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Tagno_KeyUp);
            this.txt_Tagno.Leave += new System.EventHandler(this.txt_Tagno_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tag NO:";
            // 
            // txt_IdEmp
            // 
            this.txt_IdEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_IdEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdEmp.Location = new System.Drawing.Point(85, 27);
            this.txt_IdEmp.Name = "txt_IdEmp";
            this.txt_IdEmp.Size = new System.Drawing.Size(345, 26);
            this.txt_IdEmp.TabIndex = 100;
            this.txt_IdEmp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_IdEmp_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID Emp:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 473);
            this.Controls.Add(this.txt_IdEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Tagno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Loc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Qty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Physical Count [V1.3]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_PN;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Loc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tagno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_IdEmp;
        private System.Windows.Forms.Label label5;
    }
}

