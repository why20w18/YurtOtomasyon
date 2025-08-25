
namespace YurtOtomasyon.UI.WinForms
{
    partial class frmHome
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            pnTop = new Panel();
            programPageTittle = new Label();
            picboxSidebar = new PictureBox();
            sidebarContainer = new FlowLayoutPanel();
            ogrContainer = new FlowLayoutPanel();
            pnOGRIslemBase = new Panel();
            btnOGRIslemBase = new Button();
            pnOGREkleSilGuncelle = new Panel();
            btnOGREkleSilGuncelle = new Button();
            pnOGRFiltreListeleme = new Panel();
            btnOGRFiltreListe = new Button();
            pnOGROdaDegisGecmis = new Panel();
            btnOGROdaDegisGecmis = new Button();
            pnOGRIzinIslem = new Panel();
            btnOGRIzinIslem = new Button();
            ogrIslemBaseTimer = new System.Windows.Forms.Timer(components);
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxSidebar).BeginInit();
            sidebarContainer.SuspendLayout();
            ogrContainer.SuspendLayout();
            pnOGRIslemBase.SuspendLayout();
            pnOGREkleSilGuncelle.SuspendLayout();
            pnOGRFiltreListeleme.SuspendLayout();
            pnOGROdaDegisGecmis.SuspendLayout();
            pnOGRIzinIslem.SuspendLayout();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.Controls.Add(programPageTittle);
            pnTop.Controls.Add(picboxSidebar);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1201, 42);
            pnTop.TabIndex = 0;
            // 
            // programPageTittle
            // 
            programPageTittle.AutoSize = true;
            programPageTittle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programPageTittle.Location = new Point(44, 4);
            programPageTittle.Name = "programPageTittle";
            programPageTittle.Size = new Size(289, 31);
            programPageTittle.TabIndex = 3;
            programPageTittle.Text = "Yurt Otomasyon | Anasayfa";
            // 
            // picboxSidebar
            // 
            picboxSidebar.Image = (Image)resources.GetObject("picboxSidebar.Image");
            picboxSidebar.Location = new Point(12, 7);
            picboxSidebar.Name = "picboxSidebar";
            picboxSidebar.Size = new Size(28, 26);
            picboxSidebar.TabIndex = 2;
            picboxSidebar.TabStop = false;
            picboxSidebar.Click += picboxSidebar_Click;
            // 
            // sidebarContainer
            // 
            sidebarContainer.BackColor = Color.FromArgb(44, 62, 80);
            sidebarContainer.Controls.Add(ogrContainer);
            sidebarContainer.Dock = DockStyle.Left;
            sidebarContainer.Location = new Point(0, 42);
            sidebarContainer.Name = "sidebarContainer";
            sidebarContainer.Size = new Size(250, 637);
            sidebarContainer.TabIndex = 1;
            // 
            // ogrContainer
            // 
            ogrContainer.BackColor = Color.FromArgb(44, 62, 80);
            ogrContainer.Controls.Add(pnOGRIslemBase);
            ogrContainer.Controls.Add(pnOGREkleSilGuncelle);
            ogrContainer.Controls.Add(pnOGRFiltreListeleme);
            ogrContainer.Controls.Add(pnOGROdaDegisGecmis);
            ogrContainer.Controls.Add(pnOGRIzinIslem);
            ogrContainer.Location = new Point(0, 0);
            ogrContainer.Margin = new Padding(0);
            ogrContainer.Name = "ogrContainer";
            ogrContainer.Size = new Size(250, 69);
            ogrContainer.TabIndex = 3;
            // 
            // pnOGRIslemBase
            // 
            pnOGRIslemBase.Controls.Add(btnOGRIslemBase);
            pnOGRIslemBase.Location = new Point(3, 3);
            pnOGRIslemBase.Name = "pnOGRIslemBase";
            pnOGRIslemBase.Size = new Size(248, 63);
            pnOGRIslemBase.TabIndex = 2;
            // 
            // btnOGRIslemBase
            // 
            btnOGRIslemBase.BackColor = Color.FromArgb(44, 62, 80);
            btnOGRIslemBase.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOGRIslemBase.ForeColor = Color.White;
            btnOGRIslemBase.Image = (Image)resources.GetObject("btnOGRIslemBase.Image");
            btnOGRIslemBase.ImageAlign = ContentAlignment.MiddleLeft;
            btnOGRIslemBase.Location = new Point(-14, -7);
            btnOGRIslemBase.Name = "btnOGRIslemBase";
            btnOGRIslemBase.Padding = new Padding(30, 0, 0, 0);
            btnOGRIslemBase.Size = new Size(277, 79);
            btnOGRIslemBase.TabIndex = 3;
            btnOGRIslemBase.Text = "Öğrenci İşlemleri";
            btnOGRIslemBase.UseVisualStyleBackColor = false;
            btnOGRIslemBase.Click += btnOGRIslemBase_Click;
            // 
            // pnOGREkleSilGuncelle
            // 
            pnOGREkleSilGuncelle.BackColor = Color.FromArgb(52, 73, 94);
            pnOGREkleSilGuncelle.Controls.Add(btnOGREkleSilGuncelle);
            pnOGREkleSilGuncelle.Location = new Point(3, 72);
            pnOGREkleSilGuncelle.Name = "pnOGREkleSilGuncelle";
            pnOGREkleSilGuncelle.Size = new Size(248, 63);
            pnOGREkleSilGuncelle.TabIndex = 2;
            // 
            // btnOGREkleSilGuncelle
            // 
            btnOGREkleSilGuncelle.BackColor = Color.FromArgb(52, 73, 94);
            btnOGREkleSilGuncelle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOGREkleSilGuncelle.ForeColor = Color.White;
            btnOGREkleSilGuncelle.Image = (Image)resources.GetObject("btnOGREkleSilGuncelle.Image");
            btnOGREkleSilGuncelle.ImageAlign = ContentAlignment.MiddleLeft;
            btnOGREkleSilGuncelle.Location = new Point(-14, -7);
            btnOGREkleSilGuncelle.Name = "btnOGREkleSilGuncelle";
            btnOGREkleSilGuncelle.Padding = new Padding(30, 0, 0, 0);
            btnOGREkleSilGuncelle.Size = new Size(277, 79);
            btnOGREkleSilGuncelle.TabIndex = 3;
            btnOGREkleSilGuncelle.Text = "Kayıt Ekle/Sil/Güncelle";
            btnOGREkleSilGuncelle.UseVisualStyleBackColor = false;
            btnOGREkleSilGuncelle.Click += btnOGREkleSilGuncelle_Click;
            // 
            // pnOGRFiltreListeleme
            // 
            pnOGRFiltreListeleme.Controls.Add(btnOGRFiltreListe);
            pnOGRFiltreListeleme.Location = new Point(3, 141);
            pnOGRFiltreListeleme.Name = "pnOGRFiltreListeleme";
            pnOGRFiltreListeleme.Size = new Size(248, 63);
            pnOGRFiltreListeleme.TabIndex = 2;
            // 
            // btnOGRFiltreListe
            // 
            btnOGRFiltreListe.BackColor = Color.FromArgb(52, 73, 94);
            btnOGRFiltreListe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOGRFiltreListe.ForeColor = Color.White;
            btnOGRFiltreListe.Image = (Image)resources.GetObject("btnOGRFiltreListe.Image");
            btnOGRFiltreListe.ImageAlign = ContentAlignment.MiddleLeft;
            btnOGRFiltreListe.Location = new Point(-14, -7);
            btnOGRFiltreListe.Name = "btnOGRFiltreListe";
            btnOGRFiltreListe.Padding = new Padding(30, 0, 0, 0);
            btnOGRFiltreListe.Size = new Size(277, 79);
            btnOGRFiltreListe.TabIndex = 3;
            btnOGRFiltreListe.Text = "Filtreleme/Listeleme";
            btnOGRFiltreListe.UseVisualStyleBackColor = false;
            btnOGRFiltreListe.Click += btnOGRFiltreListe_Click;
            // 
            // pnOGROdaDegisGecmis
            // 
            pnOGROdaDegisGecmis.Controls.Add(btnOGROdaDegisGecmis);
            pnOGROdaDegisGecmis.Location = new Point(3, 210);
            pnOGROdaDegisGecmis.Name = "pnOGROdaDegisGecmis";
            pnOGROdaDegisGecmis.Size = new Size(248, 63);
            pnOGROdaDegisGecmis.TabIndex = 2;
            // 
            // btnOGROdaDegisGecmis
            // 
            btnOGROdaDegisGecmis.BackColor = Color.FromArgb(52, 73, 94);
            btnOGROdaDegisGecmis.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOGROdaDegisGecmis.ForeColor = Color.White;
            btnOGROdaDegisGecmis.Image = (Image)resources.GetObject("btnOGROdaDegisGecmis.Image");
            btnOGROdaDegisGecmis.ImageAlign = ContentAlignment.MiddleLeft;
            btnOGROdaDegisGecmis.Location = new Point(-14, -7);
            btnOGROdaDegisGecmis.Name = "btnOGROdaDegisGecmis";
            btnOGROdaDegisGecmis.Padding = new Padding(30, 0, 0, 0);
            btnOGROdaDegisGecmis.Size = new Size(277, 79);
            btnOGROdaDegisGecmis.TabIndex = 3;
            btnOGROdaDegisGecmis.Text = "Oda Değiştirme/Geçmiş";
            btnOGROdaDegisGecmis.UseVisualStyleBackColor = false;
            // 
            // pnOGRIzinIslem
            // 
            pnOGRIzinIslem.Controls.Add(btnOGRIzinIslem);
            pnOGRIzinIslem.Location = new Point(3, 279);
            pnOGRIzinIslem.Name = "pnOGRIzinIslem";
            pnOGRIzinIslem.Size = new Size(248, 63);
            pnOGRIzinIslem.TabIndex = 2;
            // 
            // btnOGRIzinIslem
            // 
            btnOGRIzinIslem.BackColor = Color.FromArgb(52, 73, 94);
            btnOGRIzinIslem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOGRIzinIslem.ForeColor = Color.White;
            btnOGRIzinIslem.Image = (Image)resources.GetObject("btnOGRIzinIslem.Image");
            btnOGRIzinIslem.ImageAlign = ContentAlignment.MiddleLeft;
            btnOGRIzinIslem.Location = new Point(-14, -7);
            btnOGRIzinIslem.Name = "btnOGRIzinIslem";
            btnOGRIzinIslem.Padding = new Padding(30, 0, 0, 0);
            btnOGRIzinIslem.Size = new Size(277, 79);
            btnOGRIzinIslem.TabIndex = 3;
            btnOGRIzinIslem.Text = "İzin İşlemleri";
            btnOGRIzinIslem.UseVisualStyleBackColor = false;
            // 
            // ogrIslemBaseTimer
            // 
            ogrIslemBaseTimer.Interval = 10;
            ogrIslemBaseTimer.Tick += ogrIslemBaseTimer_Tick;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 679);
            Controls.Add(sidebarContainer);
            Controls.Add(pnTop);
            IsMdiContainer = true;
            Name = "frmHome";
            RightToLeftLayout = true;
            Text = "Form1";
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxSidebar).EndInit();
            sidebarContainer.ResumeLayout(false);
            ogrContainer.ResumeLayout(false);
            pnOGRIslemBase.ResumeLayout(false);
            pnOGREkleSilGuncelle.ResumeLayout(false);
            pnOGRFiltreListeleme.ResumeLayout(false);
            pnOGROdaDegisGecmis.ResumeLayout(false);
            pnOGRIzinIslem.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel pnTop;
        private PictureBox picboxSidebar;
        private Label programPageTittle;
        private FlowLayoutPanel sidebarContainer;
        private Panel pnOGRIslemBase;
        private Button btnOGRIslemBase;
        private FlowLayoutPanel ogrContainer;
        private Panel pnOGREkleSilGuncelle;
        private Button btnOGREkleSilGuncelle;
        private Panel pnOGRFiltreListeleme;
        private Button btnOGRFiltreListe;
        private Panel pnOGROdaDegisGecmis;
        private Button btnOGROdaDegisGecmis;
        private System.Windows.Forms.Timer ogrIslemBaseTimer;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel pnOGRIzinIslem;
        private Button btnOGRIzinIslem;
    }
}
