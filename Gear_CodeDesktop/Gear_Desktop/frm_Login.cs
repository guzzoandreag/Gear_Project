namespace Gear_Desktop
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();

            // Initialize contextMenu1
            this.contextMenuStrip1.Items.AddRange(
                new System.Windows.Forms.ToolStripItem[] { this.toolStripMenuItem1 }
            );

            // Initialize menuItem1
            this.toolStripMenuItem1.Text = "E&xit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);

            // Set up how the form should be displayed.
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Text = "Gear - Software";

            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);

            notifyIcon1.Icon = new Icon("gear.ico");

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;

            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon.
            notifyIcon1.Text = "Gear (by: André Guzzo)";
            notifyIcon1.Visible = true;

            // Handle the DoubleClick event to activate the form.
            notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_DoubleClick(object? sender, EventArgs e)
        {
            /* Exibindo novamente o programa */
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            /* Minimizando aplicação na bandeja do windows */
            this.Visible = true;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
        }

        private void frm_Login_Resize(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                this.Visible = true;
            }
            else
            {
                this.Visible = false;
            }
            
            this.WindowState = FormWindowState.Maximized;
            notifyIcon1.Visible = true;
        }
    }
}