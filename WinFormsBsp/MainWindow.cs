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
    //PARTIAL besagt, dass diese Klasse in mehrere Teile (Dateien) aufgeteilt ist
    public partial class MainWindow : Form
    {
        //Konstruktor für das Form (Fenster)
        public MainWindow()
        {
            InitializeComponent();

            //Befüllung der ComboBox mit weiterem Eintrag
            Cbb_Auswahl.Items.Add("Eintrag4");
        }

        //EventHandler, welche auf einen Klick auf den Button 'Klick Mich' reagiert
        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            //Neuzuweisung einer Eigenschaft des Forms
            this.BackColor = Color.DarkOrange;

            //Neuzuweisung einer Property eines Buttons
            Btn_KlickMich.Text = "Button wurde angeklickt";

            //Prüfung, ob die Checkbox abgehakt wurde
            if (Cbx_HakMichAb.Checked)
                //Neuzuweisung einer Property des Auslösers des Events (hier der Button)
                (sender as Button).Left += 100;

            //Prüfung, ob in der ComboBox ein Element angewählt wurde
            if (Cbb_Auswahl.SelectedItem != null)
                //Übertrag des Elements in den Titel des Fensters
                this.Text = Cbb_Auswahl.SelectedItem.ToString();

            //Übertrag des Textbox-Inhalts in das Label
            Lbl_Output.Text = Tbx_Input.Text;
        }

        private void schließenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox und Prüfung des geklickten Buttons
            if (MessageBox.Show("Möchstest du das Programm wirklich beenden?", "Programm schließen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                //Schließend des Fensters
                this.Close();

            //Schließend der Applikation (= alle Fenster)
            //Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            MainWindow neuesFenster = new MainWindow();

            //Verändern von Eigenschaften des neuen Fensters
            neuesFenster.Text = "Dies ist ein neues Fenster";
            neuesFenster.BackColor = Color.LightGreen;
            neuesFenster.Btn_KlickMich.Text = "Klick mich auch";

            //Öffnen des Forms als gleichberechtigtes Fenster
            neuesFenster.Show();
        }

        private void neuesDialogFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            MainWindow neuesFenster = new MainWindow();

            //Verändern von Eigenschaften des neuen Fensters
            neuesFenster.Text = "Dies ist ein neues Dialog-Fenster";
            neuesFenster.BackColor = Color.LightGreen;
            neuesFenster.Btn_KlickMich.Text = "Klick mich auch";

            //Öffen des Forms als Dialogfenster (muss exklusiv bearbeitet werden) und Überprüfung des DialogResults (s.u.)
            if (neuesFenster.ShowDialog() == DialogResult.OK)
                this.Lbl_Output.Text = "Du hast auf OK geklickt";
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            //Setzen des DialogResults (= Rückgabe der ShowDialog()-Methode). Dies schließt des Fenster automatisch
            this.DialogResult = DialogResult.OK;
        }
    }
}
