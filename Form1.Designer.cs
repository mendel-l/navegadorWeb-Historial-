
namespace navegadorWeb
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonIR = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masVisitadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masRecientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressBar = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonIR
            // 
            this.buttonIR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonIR.Location = new System.Drawing.Point(800, 3);
            this.buttonIR.Name = "buttonIR";
            this.buttonIR.Size = new System.Drawing.Size(81, 26);
            this.buttonIR.TabIndex = 0;
            this.buttonIR.Text = "IR";
            this.buttonIR.UseVisualStyleBackColor = true;
            this.buttonIR.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegarToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navegarToolStripMenuItem
            // 
            this.navegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.siguienteToolStripMenuItem,
            this.anteriorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.navegarToolStripMenuItem.Name = "navegarToolStripMenuItem";
            this.navegarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.navegarToolStripMenuItem.Text = "Navegar";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.inicioToolStripMenuItem.Text = "inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // siguienteToolStripMenuItem
            // 
            this.siguienteToolStripMenuItem.Name = "siguienteToolStripMenuItem";
            this.siguienteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.siguienteToolStripMenuItem.Text = "siguiente";
            this.siguienteToolStripMenuItem.Click += new System.EventHandler(this.siguienteToolStripMenuItem_Click);
            // 
            // anteriorToolStripMenuItem
            // 
            this.anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
            this.anteriorToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.anteriorToolStripMenuItem.Text = "anterior";
            this.anteriorToolStripMenuItem.Click += new System.EventHandler(this.anteriorToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.salirToolStripMenuItem.Text = "salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masVisitadasToolStripMenuItem,
            this.masRecientesToolStripMenuItem});
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.historialToolStripMenuItem.Text = "Historial";
            // 
            // masVisitadasToolStripMenuItem
            // 
            this.masVisitadasToolStripMenuItem.Name = "masVisitadasToolStripMenuItem";
            this.masVisitadasToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.masVisitadasToolStripMenuItem.Text = "mas visitadas";
            // 
            // masRecientesToolStripMenuItem
            // 
            this.masRecientesToolStripMenuItem.Name = "masRecientesToolStripMenuItem";
            this.masRecientesToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.masRecientesToolStripMenuItem.Text = "mas recientes";
            // 
            // addressBar
            // 
            this.addressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addressBar.FormattingEnabled = true;
            this.addressBar.Location = new System.Drawing.Point(3, 3);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(791, 28);
            this.addressBar.TabIndex = 4;
            this.addressBar.SelectedIndexChanged += new System.EventHandler(this.addressBar_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Controls.Add(this.addressBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonIR, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.webView21, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 487);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // webView21
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.webView21, 2);
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(2, 34);
            this.webView21.Margin = new System.Windows.Forms.Padding(2);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(880, 451);
            this.webView21.TabIndex = 5;
            this.webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonIR;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIR;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ComboBox addressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masVisitadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masRecientesToolStripMenuItem;
    }
}

