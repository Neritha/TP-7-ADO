using MySql.Data.MySqlClient;

namespace WinFormsApp3
{
    public partial class Form_ListeAuteurs : Form
    {
        //private string connectionString = "server=btssio.dedyn.io; port=3306; Database=CARREVIC_PPE4; Uid=CARREVIC; password=16012004";

        //private MySqlConnection maConnection;
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;


        public Form_ListeAuteurs()
        {
            InitializeComponent();
            RemplirListe();

        }

        private void RemplirListe()
        {
            try
            {
                dgv_ListeAuteurs.Rows.Clear();

                //maConnection = new MySqlConnection(connectionString);
                Connection.MaConnection.Open();
                //maConnection.Open(); // ouvre la connexion

                maRequete = Connection.MaConnection.CreateCommand();
                maRequete.CommandText = "SELECT * FROM auteur ORDER BY nom";
                monReader = maRequete.ExecuteReader();

                while (monReader.Read())
                {
                    dgv_ListeAuteurs.Rows.Add(
                        monReader["num"].ToString(),
                        monReader["nom"].ToString(),
                        monReader["prenom"].ToString(),
                        monReader["nationalite"].ToString()
                    );

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur : " + ex.Message);
            }
            finally
            {
                monReader.Close();
                //maConnection.Close();
                Connection.MaConnection.Close();
            }
        }

        private void btn_Afficher_Click(object sender, EventArgs e)
        {
            int element = Convert.ToInt16( dgv_ListeAuteurs.SelectedRows[0].Cells[0].Value.ToString());
            FicheAuteur frm = new FicheAuteur(false, element);
            frm.Show();
                
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            int element = Convert.ToInt16(dgv_ListeAuteurs.SelectedRows[0].Cells[0].Value.ToString());
            FicheAuteur frm = new FicheAuteur(true, element);
            frm.Show();
            RemplirListe();
            dgv_ListeAuteurs.Refresh();
        }

    }
}