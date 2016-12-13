using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularz
{
    public partial class Formularz : Form
    {
        public Formularz()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mężczyznaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kobietaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nowyToolStripMenuItem
            // 
            this.nowyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mężczyznaToolStripMenuItem,
            this.kobietaToolStripMenuItem});
            this.nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            this.nowyToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.nowyToolStripMenuItem.Text = "Nowy";
            this.nowyToolStripMenuItem.Click += new System.EventHandler(this.nowyToolStripMenuItem_Click);
            // 
            // mężczyznaToolStripMenuItem
            // 
            this.mężczyznaToolStripMenuItem.Name = "mężczyznaToolStripMenuItem";
            this.mężczyznaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mężczyznaToolStripMenuItem.Text = "Mężczyzna";
            // 
            // kobietaToolStripMenuItem
            // 
            this.kobietaToolStripMenuItem.Name = "kobietaToolStripMenuItem";
            this.kobietaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kobietaToolStripMenuItem.Text = "Kobieta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(808, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // Formularz
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::Formularz.Properties.Resources.piramidazywienia_2009_2016;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formularz";
            this.Load += new System.EventHandler(this.Formularz_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nowyToolStripMenuItem;

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Formularz_Load(object sender, EventArgs e)
        {

        }

        private ToolStripMenuItem mężczyznaToolStripMenuItem;
        private ToolStripMenuItem kobietaToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
    }
}
