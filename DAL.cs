using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBank
{
    class DAL
    {
        string _strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jooaodito\documents\visual studio 2015\Projects\SystemBank\SystemBank\BDSystemBank.mdf;Integrated Security=True;Connect Timeout=30";
        string vsql = "";
        SqlConnection objCon = null;

        #region "Metodos de Conexão com o banco"
        private bool conectar()
        {
            objCon = new SqlConnection(_strCon);
            try
            {
                objCon.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool desconectar()
        {
            if(objCon.State != ConnectionState.Closed)
            {
                objCon.Close();
                return true;
            }
            else
            {
                objCon.Dispose();
                return false;
            }
        }
        #endregion

        #region "Metodos Execução SQL"
        public bool Insert(ContaModelo conta)
        {
            vsql = "INSERT INTO Conta ([nConta], [agencia], [Saldo], [tipoConta], [nome], [cpf]) VALUES (@nConta, @agencia, @Saldo, @tipoConta, @nome, @cpf)";

            SqlCommand objcmd = null;

            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add("@nConta", SqlDbType.Int).Value = conta.numero;
                    objcmd.Parameters.Add("@agencia", SqlDbType.Int).Value = conta.agencia;
                    objcmd.Parameters.Add("@Saldo", SqlDbType.Decimal).Value = conta.saldo;
                    objcmd.Parameters.Add("@tipoConta", SqlDbType.VarChar).Value = conta.tipo;
                    objcmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = conta.nome;
                    objcmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = conta.cpf;

                    objcmd.ExecuteNonQuery();

                    return true;
                }
                catch(SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }

        public bool Alterar(int nConta, decimal saldo)
        {
            vsql ="UPDATE Conta SET Saldo = Saldo - @Saldo WHERE nconta = @nconta";

            SqlCommand objcmd = null;

            if (conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.AddWithValue("@nConta", nConta);
                    objcmd.Parameters.AddWithValue("@Saldo", saldo);

                    objcmd.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }

        public bool Depositar(int nConta, decimal saldo)
        {
            vsql = "UPDATE Conta SET Saldo = Saldo + @Saldo WHERE nconta = @nconta";

            SqlCommand objcmd = null;

            if (conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.AddWithValue("@nConta", nConta);
                    objcmd.Parameters.AddWithValue("@Saldo", saldo);

                    objcmd.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }

        public bool Transferencia(int nConta, int destino, decimal valor)
        {

            SqlCommand objcmd = null;

            if (conectar())
            {
                try
                {

                    vsql = "SELECT Saldo FROM Conta WHERE nConta LIKE @nConta";
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.AddWithValue("@nConta", nConta);
                    objcmd.ExecuteNonQuery();

                    objcmd.Parameters.Clear();

                    vsql = "UPDATE Conta SET Saldo = Saldo - @Saldo WHERE nConta LIKE @nConta ";
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.AddWithValue("@Saldo", valor);
                    objcmd.Parameters.AddWithValue("@nConta", nConta);
                    objcmd.ExecuteNonQuery();

                    objcmd.Parameters.Clear();

                    vsql = "SELECT Saldo FROM Conta WHERE nConta LIKE @destino";
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.AddWithValue("@destino", destino);
                    objcmd.ExecuteNonQuery();

                    objcmd.Parameters.Clear();

                    vsql = "UPDATE Conta SET Saldo = Saldo + @Saldo WHERE nConta LIKE @destino";
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.AddWithValue("@Saldo", valor);
                    objcmd.Parameters.AddWithValue("@destino", destino);
                    objcmd.ExecuteNonQuery();

                    return true;

                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }

        public bool Excluir(int nConta)
        {
            vsql = "DELETE FROM Conta WHERE nConta = @nConta";

            SqlCommand objcmd = null;

            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.AddWithValue("@nConta", nConta);

                    objcmd.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }

        }
       #endregion

        #region "metodos Lista"
       public DataTable ListarGrid()
       {
            vsql = "SELECT [nConta], [agencia], [Saldo], [tipoConta], [nome], [cpf] FROM Conta";

            SqlCommand objcmd = null;

            if(this.conectar())
            {

                try
                {
                    objcmd = new SqlCommand(vsql, objCon);
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;
                }
                catch(SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }
       }

       public DataTable PesquisaConta(string param)
        {
            if (conectar())
            {

                SqlCommand objcmd = null;

                try
                {
                    vsql = "SELECT [nConta], [agencia], [Saldo], [tipoConta], [nome], [cpf] FROM Conta WHERE nConta LIKE @valor";

                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@valor", param));
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }
        }

       public DataTable PesquisaAgencia(string param)
        {
            if (conectar())
            {

                SqlCommand objcmd = null;

                try
                {
                    vsql = "SELECT [nConta], [agencia], [Saldo], [tipoConta], [nome], [cpf] FROM Conta WHERE agencia LIKE @valor";

                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@valor", param));
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }
        }

       public DataTable PesquisaCPF(string param)
        {
            if (conectar())
            {

                SqlCommand objcmd = null;

                try
                {
                    vsql = "SELECT [nConta], [agencia], [Saldo], [tipoConta], [nome], [cpf] FROM Conta WHERE cpf LIKE @valor";

                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@valor", param));
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }
        }

       public DataTable PesquisaNome(string param)
        {
            if (conectar())
            {

                SqlCommand objcmd = null;

                try
                {
                    vsql = "SELECT [nConta], [agencia], [Saldo], [tipoConta], [nome], [cpf] FROM Conta WHERE nome LIKE @valor";

                    objcmd = new SqlCommand(vsql, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@valor", param));
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }
        }

        #endregion
    }
}
