using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace WinPay
{
    public partial class frmConta : Form
    {
        public frmConta() => InitializeComponent();




        private void btcadastro_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcod.Text.Trim(), out int codigo) || codigo <= 0)
            {
                MessageBox.Show("Informe um código numérico maior que zero.",
                                "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcod.Focus();
                return;
            }

            string descricao = txtdesc.Text.Trim();
            if (descricao.Length == 0)
            {
                MessageBox.Show("Informe uma descrição.",
                                "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdesc.Focus();
                return;
            }

            const string insertSql = @"
        INSERT INTO contas (codigo, descricao)
        VALUES (@codigo, @descricao)
        RETURNING id;";

            try
            {
                var conn = Db.Conexao;
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using var cmd = new NpgsqlCommand(insertSql, conn)
                {
                    CommandTimeout = 60
                };
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@descricao", descricao);

                var newId = cmd.ExecuteScalar();
                MessageBox.Show($"Conta inserida com sucesso! (ID: {newId})",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtcod.Clear(); txtdesc.Clear(); txtcod.Focus();
            }
            catch (PostgresException pgEx) when (pgEx.SqlState == "23505")
            {
                MessageBox.Show("Já existe uma conta com esse código.",
                                "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir conta:\n{ex}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            const string sql = @"
        SELECT codigo, descricao
          FROM contas
      ORDER BY codigo;";

            try
            {
                var conn = Db.Conexao;
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using var da = new NpgsqlDataAdapter(sql, conn);
                da.SelectCommand.CommandTimeout = 60;

                var tabela = new DataTable();
                da.Fill(tabela);

                dgvdois.DataSource = tabela;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar contas:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void frmConta_Load(object sender, EventArgs e)
        {

        }

        private void btpesquisa_Click(object sender, EventArgs e)
        {
            int? codigo = null;
            if (int.TryParse(txtodigoconta.Text.Trim(), out int codTmp) && codTmp > 0)
                codigo = codTmp;          // pesquisa exata por código

            string descricao = txtDescricaoconta.Text.Trim();   // pode estar vazio

            // --- 2) Montar SQL dinâmico com filtros opcionais ---------------
            string sql = @"
SELECT id, codigo, descricao
  FROM contas
 WHERE 1=1";               // truque para anexar ANDs facilmente

            if (codigo.HasValue)
                sql += " AND codigo = @codigo";       // filtro exato

            if (descricao.Length > 0)
                sql += " AND descricao ILIKE @descricao"; // filtro parcial

            sql += " ORDER BY codigo;";

            // --- 3) Executar e preencher o DataGridView ---------------------
            try
            {
                var conn = Db.Conexao;
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using var da = new NpgsqlDataAdapter(sql, conn);
                da.SelectCommand.CommandTimeout = 60;

                if (codigo.HasValue)
                    da.SelectCommand.Parameters.AddWithValue("@codigo", codigo.Value);

                if (descricao.Length > 0)
                    da.SelectCommand.Parameters.AddWithValue("@descricao", $"%{descricao}%");

                var tabela = new DataTable();
                da.Fill(tabela);

                dgvcontas.DataSource = tabela;            // mostra resultado
                dgvcontas.RowTemplate.Height = 15;  // define altura em pixels, padrão é algo em torno de 22-24

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if (dgvcontas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma conta na lista.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Pega a chave da conta
            var drv = dgvcontas.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null)
            {
                MessageBox.Show("Seleção inválida.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long id = drv.Row.Table.Columns.Contains("id")
                        ? (long)drv["id"]         // preferindo id
                        : (long)drv["codigo"];    // ou codigo, se for chave única

            string descricao = drv["descricao"].ToString();

            // 3) Confirma com o usuário
            var resp = MessageBox.Show(
                $"Deseja realmente excluir a conta:\n\n{descricao} (ID/Código: {id}) ?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resp != DialogResult.Yes) return;

            // 4) Executa o DELETE no PostgreSQL
            const string sql = "DELETE FROM contas WHERE id = @id;";   // ou codigo=@id
            try
            {
                var conn = Db.Conexao;
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using var cmd = new NpgsqlCommand(sql, conn)
                {
                    CommandTimeout = 60
                };
                cmd.Parameters.AddWithValue("@id", id);

                int afetados = cmd.ExecuteNonQuery();
                if (afetados == 0)
                {
                    MessageBox.Show("Conta não encontrada no banco.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 5) Remove a linha da grade sem novo SELECT
                drv.Delete();   // DataRowView → sai da grade

                MessageBox.Show("Conta excluída com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PostgresException pgEx) when (pgEx.SqlState == "23503")   // violação FK
            {
                MessageBox.Show("Não é possível excluir: a conta está sendo usada em outros lançamentos.",
                                "Restrição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btexcluir_Click(object sender, EventArgs e)
        {

            if (dgvdois.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma conta na lista.",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2) Pega a chave da conta
            var drv = dgvdois.CurrentRow.DataBoundItem as DataRowView;
            if (drv == null)
            {
                MessageBox.Show("Seleção inválida.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long id = drv.Row.Table.Columns.Contains("id")
                        ? (long)drv["id"]         // preferindo id
                        : (long)drv["codigo"];    // ou codigo, se for chave única

            string descricao = drv["descricao"].ToString();

            // 3) Confirma com o usuário
            var resp = MessageBox.Show(
                $"Deseja realmente excluir a conta:\n\n{descricao} (ID/Código: {id}) ?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resp != DialogResult.Yes) return;

            // 4) Executa o DELETE no PostgreSQL
            const string sql = "DELETE FROM contas WHERE id = @id;";   // ou codigo=@id
            try
            {
                var conn = Db.Conexao;
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using var cmd = new NpgsqlCommand(sql, conn)
                {
                    CommandTimeout = 60
                };
                cmd.Parameters.AddWithValue("@id", id);

                int afetados = cmd.ExecuteNonQuery();
                if (afetados == 0)
                {
                    MessageBox.Show("Conta não encontrada no banco.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 5) Remove a linha da grade sem novo SELECT
                drv.Delete();   // DataRowView → sai da grade

                MessageBox.Show("Conta excluída com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (PostgresException pgEx) when (pgEx.SqlState == "23503")   // violação FK
            {
                MessageBox.Show("Não é possível excluir: a conta está sendo usada em outros lançamentos.",
                                "Restrição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir:\n{ex.Message}",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}


