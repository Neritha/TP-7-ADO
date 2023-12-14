using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp3
{
    public partial class FicheAuteur : Form
    {
        //private string connectionString = "server=btssio.dedyn.io; port=3306; Database=CARREVIC_PPE4; Uid=CARREVIC; password=16012004";

        //private MySqlConnection maConnection;
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;
        private int numAuteur;

        public FicheAuteur(bool modification, int num)
        {
            InitializeComponent();
            numAuteur = num;

            try
            {
                //maConnection = new MySqlConnection(connectionString);
                //maConnection.Open();
                Connection.MaConnection.Open();
                maRequete = Connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from auteur where num=@paramNum";
                
                maRequete.Parameters.AddWithValue("@paramNum", num);
                maRequete.Prepare();
                monReader = maRequete.ExecuteReader();

                if (monReader.Read())
                {
                    txt_Num.Text = num.ToString();
                    txt_Nom.Text = monReader["nom"].ToString();
                    txt_Prenom.Text = monReader["prenom"].ToString();
                    txt_Nation.Text = monReader["nationalite"].ToString();
                }
                else
                {
                    MessageBox.Show("Erreur : auteur introuvable");
                }

                if(modification == false)
                {
                    txt_Nom.Enabled = false;
                    txt_Prenom.Enabled = false;
                    txt_Nation.Enabled = false;

                    btn_Valider.Enabled = false;

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                monReader.Close();
                //maConnection.Close();
                Connection.MaConnection.Close();
            }
        }

        private void btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            if (ControleSaisies() == true)
            {
                maRequete.CommandText = "update auteur set " +
                    "nom=@paramNom, prenom=@paramPrenom, nationalite=@paramNation where num=@paramNum";
                maRequete.Parameters.Clear();
                maRequete.Parameters.AddWithValue("@paramNom", txt_Nom.Text);
                maRequete.Parameters.AddWithValue("@paramPrenom", txt_Prenom.Text);
                maRequete.Parameters.AddWithValue("@paramNation", txt_Nation.Text);
                maRequete.Parameters.AddWithValue("@paramNum", numAuteur);

                try
                {
                    Connection.MaConnection.Open();
                    int resultat = maRequete.ExecuteNonQuery();
                    if(resultat > 0)
                    {
                        MessageBox.Show("L'auteur a bien été mis à jour");
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite, l'auteur n'a pas été mis à jour");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Connection.MaConnection.Close();
                    this.Close();
                }

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        private bool ControleSaisies()
        {
            bool controle = true;
            if (txt_Nom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un nom");
                controle = false;
            }
            if (txt_Prenom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prenom");
                controle = false;
            }
            if (txt_Nation.Text == "")
            {
                MessageBox.Show("Vous devez saisir une nationalité");
                controle = false;
            }
            return controle;
        }


    }
}
