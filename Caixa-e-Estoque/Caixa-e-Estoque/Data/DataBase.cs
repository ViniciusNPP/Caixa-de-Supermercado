using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Caixa_e_Estoque.Data
{
    internal class DataBase
    {
        private string _connectionString = "Host=localhost;Username=postgres;Password=0l0k1nh0123;Database=CaixaDeSupermercado";
        private string _tableName = "Estoque";

        public List<string> Select(string comandoUsuario)
        {
            try
            {
                //Cria conexão com banco de dados
                using var connection = new NpgsqlConnection(_connectionString);
                connection.Open();

                using var command = new NpgsqlCommand($"SELECT * FROM \"{_tableName}\"", connection);
                using var reader = command.ExecuteReader();

                List<string> itens = [];

                while (reader.Read())
                {
                    int codigo = reader.GetInt32(4);
                    string nome = reader.GetString(1);
                    string categoria = reader.GetString(2);
                    int quantidade = reader.GetInt32(6);
                    decimal preco = reader.GetDecimal(5);
                    string? unidade_medida = !reader.IsDBNull(7) ? reader.GetString(7) : "";
                    DateTime? data_validade = !reader.IsDBNull(8)? reader.GetDateTime(8) : (DateTime?)null;
                    string fornecedor = reader.GetString(3);
                    string? descricao = !reader.IsDBNull(9) ? reader.GetString(9) : "";

                    string? data_validade_formatada = data_validade.HasValue ? data_validade.Value.ToString("dd/MM/yyyy") : "N/A";

                    itens.Add($"{codigo} - {nome} - {categoria} - {fornecedor} - {preco} - {quantidade} {unidade_medida} - {data_validade_formatada} - {descricao}");
                }
                return itens;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados\n" + ex);
                return [];
            }
        }

        public void Update()
        {
            try
            {
                //Cria conexão com banco de dados
                using var connection = new NpgsqlConnection(_connectionString);
                connection.Open();


            }
            catch (Exception)
            {

            }
        }

        public void Drop()
        {
            try
            {
                //Cria conexão com banco de dados
                using var connection = new NpgsqlConnection(_connectionString);
                connection.Open();


            }
            catch (Exception)
            {

            }
        }

        public bool Create(List<string> produto)
        {
            try
            {
                //Cria conexão com banco de dados
                using var connection = new NpgsqlConnection(_connectionString);
                connection.Open();

                string sql = $"INSERT INTO \"{_tableName}\" (nome, categoria, fornecedor, codigo, preco, quantidade, unidade_de_medida, validade, descricao) "+
                    "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9)";

                using var command = new NpgsqlCommand(sql, connection);

                for (int i = 0; i < produto.Count; i++)
                {
                    if (i is 3 or 5)
                    {
                        command.Parameters.AddWithValue($"p{i + 1}", int.Parse(produto[i]));
                    }
                    else if (i is 4)
                    {
                        command.Parameters.AddWithValue($"p{i + 1}", double.Parse(produto[i]));
                    }
                    else if (i is 7)
                    {
                        command.Parameters.AddWithValue($"p{i + 1}", DateTime.Parse(produto[i]));
                    }

                    else command.Parameters.AddWithValue($"p{i + 1}", produto[i]);
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Produto registrado com sucesso!");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de dados\n" + ex);
                return false;
            }
        }
    }
}
