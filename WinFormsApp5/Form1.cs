using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Cr�ation d'une liste de tableaux (nom, �ge) 
            List<string[]> personnes = new List<string[]>
            {
                new string[] { "Alice", "25" },
                new string[] { "Bob", "30" },
                new string[] { "Charlie", "35" }
            };
            // Convertir en DataTable pour le lier � la DataGridView 
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Nom");
            dataTable.Columns.Add("Age");
            foreach (string[] personne in personnes)
            {
                dataTable.Rows.Add(personne[0], personne[1]);
            }

            //commentaire de test
            // Liaison de la DataGridView au DataTable 
            //dataGridView1.DataSource = dataTable;

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //r�cuper les valeur de txtNom et txtEmail
        //Afficher ces valeurs dans une MessageBox
        string Nom = txtNom.Text;
        string email = txtEmail.Text;

        if(Nom==""||Email=="")

        
    { 
        MessageBox.Show("Veuillez compl�ter tout les champs"); 
     

{
    MessageBox.Show($"nom : {Nom}\nEmail : {Email}", "Informations Utilisateur");
    }


}

private void label3_TextChanged(object sender, EventArgs e)
{

    if (!txtEmail.Text.Contains("@"))
    {
        this.label3.Visible = false;
    }
    else
    {
        this.label3.Visible = true;
    }
}
