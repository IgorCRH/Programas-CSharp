using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AplicativodeNotasdeLembrete
{
    public partial class formlembrete : Form
    {
        DataTable dados;

        public formlembrete()
        {
            InitializeComponent();
            this.FormClosing += formlembrete_FormClosing;
        }

        private void dgvlembretes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvlembretes.Columns[e.ColumnIndex].Name == "Título" || dgvlembretes.Columns[e.ColumnIndex].Name == "Corpo da Mensagem")
            {

                e.CellStyle.BackColor = Color.DarkRed;
            }
        }


        private void formlembrete_Load(object sender, EventArgs e)
        {
            dados = new DataTable();
            dados.Columns.Add("Título", typeof(string));
            dados.Columns.Add("Corpo da Mensagem", typeof(string));

            dgvlembretes.DataSource = dados;
            dgvlembretes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            dgvlembretes.CellFormatting += dgvlembretes_CellFormatting;
            LoadDataFromCsv();
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            textoTitulo.Clear();
            textoCorpoMensagem.Clear();
        }

        private void salvarButton_Click(object sender, EventArgs e)
        {
            dados.Rows.Add(textoTitulo.Text, textoCorpoMensagem.Text);
            adicionarButton.PerformClick();
        }

        private void lembreteButton_Click(object sender, EventArgs e)
        {
            int indice = dgvlembretes.CurrentCell.RowIndex;
            if (indice > -1) {
                textoTitulo.Text = dados.Rows[indice].ItemArray[0].ToString();
                textoCorpoMensagem.Text = dados.Rows[indice].ItemArray[1].ToString();
            }
        }

        private void deletarButton_Click(object sender, EventArgs e)
        {
            int indice = dgvlembretes.CurrentCell.RowIndex;
            dados.Rows[indice].Delete();
        }

        private void SaveDataToCsv()
        {
            using (CsvFileWriter writer = new CsvFileWriter("data.csv"))
            {
                CsvRow header = new CsvRow();
                foreach (DataColumn column in dados.Columns)
                {
                    header.Add(column.ColumnName);
                }
                writer.WriteRow(header);

                foreach (DataRow row in dados.Rows)
                {
                    CsvRow csvRow = new CsvRow();
                    foreach (var item in row.ItemArray)
                    {
                        csvRow.Add(item.ToString());
                    }
                    writer.WriteRow(csvRow);
                }
            }
        }

        private void LoadDataFromCsv()
        {
            if (File.Exists("data.csv"))
            {
                using (CsvFileReader reader = new CsvFileReader("data.csv"))
                {
                    CsvRow header = new CsvRow();
                    if (reader.ReadRow(header))
                    {
                        dados.Columns.Clear();
                        foreach (string columnName in header)
                        {
                            dados.Columns.Add(columnName, typeof(string));
                        }

                        while (reader.ReadRow(header))
                        {
                            DataRow row = dados.NewRow();
                            for (int i = 0; i < header.Count; i++)
                            {
                                row[i] = header[i];
                            }
                            dados.Rows.Add(row);
                        }
                    }
                }

                dgvlembretes.DataSource = dados;
            }
        }

        private void formlembrete_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveDataToCsv();
        }

    }
}

public class CsvRow : List<string>
{
    public string LineText { get; set; }
}

public class CsvFileWriter : StreamWriter
{
    public CsvFileWriter(Stream stream)
        : base(stream)
    {
    }

    public CsvFileWriter(string filename)
        : base(filename)
    {
    }

    /// <param name="row">The row to be written</param>
    public void WriteRow(CsvRow row)
    {
        StringBuilder builder = new StringBuilder();
        bool firstColumn = true;
        foreach (string value in row)
        {

            if (!firstColumn)
                builder.Append(',');

            if (value.IndexOfAny(new char[] { '"', ',' }) != -1)
                builder.AppendFormat("\"{0}\"", value.Replace("\"", "\"\""));
            else
                builder.Append(value);
            firstColumn = false;
        }
        row.LineText = builder.ToString();
        WriteLine(row.LineText);
    }
}

public class CsvFileReader : StreamReader
{
    public CsvFileReader(Stream stream)
        : base(stream)
    {
    }

    public CsvFileReader(string filename)
        : base(filename)
    {
    }

    /// <param name="row"></param>
    /// <returns></returns>
    public bool ReadRow(CsvRow row)
    {
        row.LineText = ReadLine();
        if (String.IsNullOrEmpty(row.LineText))
            return false;

        int pos = 0;
        int rows = 0;

        while (pos < row.LineText.Length)
        {
            string value;

            if (row.LineText[pos] == '"')
            {

                pos++;

                int start = pos;
                while (pos < row.LineText.Length)
                {

                    if (row.LineText[pos] == '"')
                    {

                        pos++;

                        if (pos >= row.LineText.Length || row.LineText[pos] != '"')
                        {
                            pos--;
                            break;
                        }
                    }
                    pos++;
                }
                value = row.LineText.Substring(start, pos - start);
                value = value.Replace("\"\"", "\"");
            }
            else
            {

                int start = pos;
                while (pos < row.LineText.Length && row.LineText[pos] != ',')
                    pos++;
                value = row.LineText.Substring(start, pos - start);
            }

            if (rows < row.Count)
                row[rows] = value;
            else
                row.Add(value);
            rows++;

            while (pos < row.LineText.Length && row.LineText[pos] != ',')
                pos++;
            if (pos < row.LineText.Length)
                pos++;
        }

        while (row.Count > rows)
            row.RemoveAt(rows);

        return (row.Count > 0);
    }
}
