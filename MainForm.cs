namespace Proje
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            var s = new SoundboardForm();
            s.ShowDialog();
            //ChangePanel(new SoundsForm());
        }

        private void buttonSongs_Click(object sender, EventArgs e)
        {
            
        }
        //void ChangePanel(Form form)
        //{
        //    switch (form)
        //    {
        //        case SoundsForm:
        //            buttonSongs.BackColor = Color.FromArgb(18, 26, 54);
        //            break;
        //    }
        //    form.TopLevel = false;
        //    form.FormBorderStyle = FormBorderStyle.None;
        //    form.Dock = DockStyle.Fill;
        //    panelMain.Controls.Add(form);
        //    panelMain.Tag = form;
        //    form.BringToFront();
        //    form.Size = panelMain.Size;
        //    form.Show();
        //}
    }
}
