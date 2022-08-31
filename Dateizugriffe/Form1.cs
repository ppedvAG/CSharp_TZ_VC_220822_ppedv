using Newtonsoft.Json;

namespace Dateizugriffe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.FileName = "datei.txt";
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveDialog.Filter = "Textdatei|*.txt|Stringdatei|*.string|Alle Dateien|*.*";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = null;

                try
                {
                    sw = new StreamWriter(saveDialog.FileName);

                    sw.WriteLine(Tbx_Input.Text);

                    sw.Write("ENDE DES TEXTS");

                    MessageBox.Show("Speichern erfolgreich");
                }
                catch
                {
                    MessageBox.Show("Speichern fehlgeschlagen");
                }
                finally
                {
                    if (sw != null)
                        sw.Close();
                }
            }
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            StreamReader sr = null;

            try
            {
                using (sr = new StreamReader("textdatei.txt"))
                {
                    string geladenerText = sr.ReadToEnd();

                    Tbx_Input.Text = geladenerText;
                }

                MessageBox.Show("Laden erfolgreich");
            }
            catch
            {
                MessageBox.Show("Laden fehlgeschlagen");
            }
        }

        private void Btn_SaveP_Click(object sender, EventArgs e)
        {
            List<Person> personenListe = new List<Person>();
            personenListe.Add(new Person() { Name = "Rainer Zufall", Alter = 34 });
            personenListe.Add(new Arbeitnehmer() { Name = "Anna Nass", Alter = 65, Abteilung = "Marketing" });

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;

            StreamWriter sw;

            try
            {
                using(sw = new StreamWriter("Personen.txt"))
                {
                    for (int i = 0; i < personenListe.Count; i++)
                    {
                        string personAlsString = JsonConvert.SerializeObject(personenListe[i], settings);

                        sw.WriteLine(personAlsString);
                    }

                    MessageBox.Show("Speichern von Personen erfolgreich");
                }
            }
            catch
            {
                MessageBox.Show("Speichern von Personen fehlgeschlagen");
            }
        }

        private void Btn_LoadP_Click(object sender, EventArgs e)
        {
            List<Person> personenListe = new List<Person>();

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.Objects;

            StreamReader sr;

            try
            {
                using (sr = new StreamReader("Personen.txt"))
                {
                    while(!sr.EndOfStream)
                    {
                        Person person = JsonConvert.DeserializeObject<Person>(sr.ReadLine(), settings);

                        personenListe.Add(person);
                    }

                    MessageBox.Show("Laden von Personen erfolgreich");

                    foreach (var item in personenListe)
                    {
                        MessageBox.Show(item.GetType().ToString() + ": " + item.Name);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Laden von Personen fehlgeschlagen");
            }
        }
    }

    class Person
    {
        public int Alter { get; set; }
        public string Name { get; set; }
    }

    class Arbeitnehmer : Person
    {
        public string Abteilung { get; set; }
    }
}