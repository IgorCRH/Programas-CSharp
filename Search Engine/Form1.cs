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
using System.Configuration;

namespace SearchEngine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string tabelaSelecionada = comboBoxopcaoTabela.SelectedItem.ToString();
                string campoPesquisa = campotextoPesquisa.Text;

                string query = string.Empty;

                using (MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString))
                {
                    connection.Open();

                    switch (tabelaSelecionada)
                    {
                        case "Aluno":

                            query = "SELECT * FROM Aluno WHERE Nome LIKE @param OR CPF LIKE @param";
                            break;

                        case "Disciplina":

                            query = "SELECT * FROM Disciplinas WHERE NomeDisciplina LIKE @param OR CodigoDisciplina LIKE @param";
                            break;

                        case "Turma":

                            query = "SELECT * FROM Turma_Aluno WHERE NumeroTurma LIKE @param";
                            break;

                        default:
                            MessageBox.Show("Opção de tabela inválida");
                            return;
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@param", "%" + campoPesquisa + "%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Exiba os resultados no DataGridView
                            dataGridViewResultados.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
