using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBsp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Cbb_Auswahl.Items.Add("Eintrag4");
        }

        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrange;

            Btn_KlickMich.Text = "Button wurde angeklickt";

            if(Cbx_HakMichAb.Checked)
                (sender as Button).Left += 100;

            if (Cbb_Auswahl.SelectedItem != null)
                this.Text = Cbb_Auswahl.SelectedItem.ToString();

            Lbl_Output.Text = Tbx_Input.Text;
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            //Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow neuesFenster = new MainWindow();

            neuesFenster.Text = "Dies ist ein neues Fenster";
            neuesFenster.BackColor = Color.LightGreen;
            neuesFenster.Btn_KlickMich.Text = "Klick mich auch";

            neuesFenster.Show();
        }

        private void neuesDialogFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow neuesFenster = new MainWindow();

            neuesFenster.Text = "Dies ist ein neues Dialog-Fenster";
            neuesFenster.BackColor = Color.LightGreen;
            neuesFenster.Btn_KlickMich.Text = "Klick mich auch";

            if (neuesFenster.ShowDialog() == DialogResult.OK)
                this.Lbl_Output.Text = "Du hast auf OK geklickt";
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
