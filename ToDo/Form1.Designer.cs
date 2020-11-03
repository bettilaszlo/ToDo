namespace ToDo
{
    partial class FrmKezdo
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
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.Lista = new System.Windows.Forms.ToolStripMenuItem();
            this.mbeolvas = new System.Windows.Forms.ToolStripMenuItem();
            this.mMentes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mKilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEltavolit = new System.Windows.Forms.Button();
            this.btnKivesz = new System.Windows.Forms.Button();
            this.btnListabol = new System.Windows.Forms.Button();
            this.btnFelvitel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ofdMegnyitas = new System.Windows.Forms.OpenFileDialog();
            this.sfdMentes = new System.Windows.Forms.SaveFileDialog();
            this.mMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lista});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mMenu.Size = new System.Drawing.Size(645, 24);
            this.mMenu.TabIndex = 0;
            this.mMenu.Text = "menuStrip1";
            // 
            // Lista
            // 
            this.Lista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbeolvas,
            this.mMentes,
            this.toolStripMenuItem1,
            this.mKilepes});
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(95, 20);
            this.Lista.Text = "Listák kezelése";
            // 
            // mbeolvas
            // 
            this.mbeolvas.Name = "mbeolvas";
            this.mbeolvas.Size = new System.Drawing.Size(180, 22);
            this.mbeolvas.Text = "Beolvasás";
            this.mbeolvas.Click += new System.EventHandler(this.mbeolvas_Click);
            // 
            // mMentes
            // 
            this.mMentes.Name = "mMentes";
            this.mMentes.Size = new System.Drawing.Size(180, 22);
            this.mMentes.Text = "Mentés";
            this.mMentes.Click += new System.EventHandler(this.mMentes_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // mKilepes
            // 
            this.mKilepes.Name = "mKilepes";
            this.mKilepes.Size = new System.Drawing.Size(180, 22);
            this.mKilepes.Text = "Kilépés";
            this.mKilepes.Click += new System.EventHandler(this.mKilepes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btnEltavolit);
            this.panel1.Controls.Add(this.btnKivesz);
            this.panel1.Controls.Add(this.btnListabol);
            this.panel1.Controls.Add(this.btnFelvitel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(20, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 422);
            this.panel1.TabIndex = 1;
            // 
            // btnEltavolit
            // 
            this.btnEltavolit.BackgroundImage = global::ToDo.Properties.Resources.garbage;
            this.btnEltavolit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEltavolit.Location = new System.Drawing.Point(401, 356);
            this.btnEltavolit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEltavolit.Name = "btnEltavolit";
            this.btnEltavolit.Size = new System.Drawing.Size(53, 50);
            this.btnEltavolit.TabIndex = 6;
            this.btnEltavolit.UseVisualStyleBackColor = true;
            this.btnEltavolit.Click += new System.EventHandler(this.btnEltavolit_Click);
            // 
            // btnKivesz
            // 
            this.btnKivesz.BackgroundImage = global::ToDo.Properties.Resources.minus;
            this.btnKivesz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKivesz.Location = new System.Drawing.Point(401, 156);
            this.btnKivesz.Margin = new System.Windows.Forms.Padding(4);
            this.btnKivesz.Name = "btnKivesz";
            this.btnKivesz.Size = new System.Drawing.Size(53, 50);
            this.btnKivesz.TabIndex = 5;
            this.btnKivesz.UseVisualStyleBackColor = true;
            this.btnKivesz.Click += new System.EventHandler(this.btnKivesz_Click);
            // 
            // btnListabol
            // 
            this.btnListabol.BackgroundImage = global::ToDo.Properties.Resources.plus;
            this.btnListabol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListabol.Location = new System.Drawing.Point(401, 98);
            this.btnListabol.Margin = new System.Windows.Forms.Padding(4);
            this.btnListabol.Name = "btnListabol";
            this.btnListabol.Size = new System.Drawing.Size(53, 50);
            this.btnListabol.TabIndex = 4;
            this.btnListabol.UseVisualStyleBackColor = true;
            this.btnListabol.Click += new System.EventHandler(this.btnListabol_Click);
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.BackgroundImage = global::ToDo.Properties.Resources.plus;
            this.btnFelvitel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFelvitel.Location = new System.Drawing.Point(401, 9);
            this.btnFelvitel.Margin = new System.Windows.Forms.Padding(4);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(53, 50);
            this.btnFelvitel.TabIndex = 3;
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tennivalók";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(23, 98);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 308);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Image = global::ToDo.Properties.Resources.exit_small;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(515, 400);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 7, 0);
            this.button1.Size = new System.Drawing.Size(118, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Kilépés";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofdMegnyitas
            // 
            this.ofdMegnyitas.Filter = "ToDo lista|*.txt";
            this.ofdMegnyitas.Title = "ToDo lista beolvasása";
            // 
            // sfdMentes
            // 
            this.sfdMentes.DefaultExt = "txt";
            this.sfdMentes.Filter = "ToDo lista|*.txt";
            this.sfdMentes.Title = "ToDo lista mentése";
            // 
            // FrmKezdo
            // 
            this.AcceptButton = this.btnFelvitel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKezdo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo";
            this.Shown += new System.EventHandler(this.FrmKezdo_Shown);
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem Lista;
        private System.Windows.Forms.ToolStripMenuItem mbeolvas;
        private System.Windows.Forms.ToolStripMenuItem mMentes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mKilepes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEltavolit;
        private System.Windows.Forms.Button btnKivesz;
        private System.Windows.Forms.Button btnListabol;
        private System.Windows.Forms.Button btnFelvitel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog ofdMegnyitas;
        private System.Windows.Forms.SaveFileDialog sfdMentes;
    }
}

