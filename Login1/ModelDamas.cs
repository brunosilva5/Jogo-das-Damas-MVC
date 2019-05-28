using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace CheckersGame
{
    public class ModelDamas
    {
        public event MetodosComSeisString AddPlayer;
        public event MensagemErro msg;
        public event MetodosSemParametros LoginSuccessful;

        public event ListCountries CountriesComboBox;

        public ModelDamas()
        {
            
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public void UserRegistered(string s1, string s2, string s3, string s4, string s5, string s6)
        {
            if (IsValidEmail(s5)==false)
            {
                if (msg != null) msg("Email not valid!");
                return;
            }

            //Obtem o caminho fisico para a pasta do código da aplicação
            //para poder reutilizar a base de dados, caso contrário, ele está sempre a substituir
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            //construir a ligação ao servidor SQL Server local com o caminho do ficheiro
            string sqlConnection = "Server=(localdb)\\MSSQLLocalDB;AttachDbFilename=" + folder + "Utilizadores.mdf" +
                                     ";Trusted_Connection=True;";

            //inicializar a ligação ao servidor
            SqlConnection server = new SqlConnection(sqlConnection);

            //abrir a ligação
            server.Open();

            //obter o nome do ficheiro
            string filename = System.IO.Path.GetFileName(s4);

            //Encriptar Password
            var hash = SecurePasswordHashed.Hash(s3);

            //construir a string SQL de insert nas tabelas
            // para aplicações reais devem usar SQL parameters e não string directas 
            string comando = String.Format("INSERT INTO Users" +
                                            "(UserName, Name, Password, Photo, Email, Country, NumGames, NumWins, NumDefeats, NumLeave) values " +
                                            "( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                                            s1, s2, hash, filename, s5, s6, "0", "0", "0", "0");

            //construir o comando SQL com a ligação ao servidor
            SqlCommand command = new SqlCommand(comando, server);

            //executar o comando sem expectativa de receber resultados (usar para INSERTS, UPDATES, DELETE)
            //o metodo devolve o numero de linhas modificadas pela query enviada
            int result = 0;
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                if (msg!=null)
                {
                    msg("Username já existe!");
                    return;
                }
            }
            

            //fechar sempre a ligação quando deixa de ser necessária
            server.Close();
            // se o resultado for 1, significa que adicionou correctamente o utilizador
            if (result == 1) System.IO.File.Copy(s4, "Photos\\" + filename, true); //guardar copia do ficheiro na pasta fotos

        }

        public void Login(string username, string password)
        {
            //para poder reutilizar a base de dados, caso contrário, ele está sempre a substituir
            var folder = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            //construir a ligação ao servidor SQL Server local com o caminho do ficheiro
            string sqlConnection = "Server=(localdb)\\MSSQLLocalDB;AttachDbFilename=" + folder + "Utilizadores.mdf" +
                                     ";Trusted_Connection=True;";

            //inicializar a ligação ao servidor
            SqlConnection server = new SqlConnection(sqlConnection);

            //abrir a ligação
            server.Open();

            //construir a string SQL de insert nas tabelas
            // para aplicações reais devem usar SQL parameters e não string directas 
            string cmdText = string.Format(" SELECT * FROM Users WHERE " +
                                            "username = '{0}'",
                                            username);

            //construir o comando SQL com a ligação ao servidor
            SqlCommand command = new SqlCommand(cmdText, server);

            //executar o comando e receber os dados resultantes dessa query 
            SqlDataReader dados = command.ExecuteReader();

            if (dados.HasRows) //vereficar se tem resultados, o que significa que há algum registo com aquele username e password
            {//o login é valido

                dados.Read(); //lê uma linha dos resultados, este metodo retorna um bool para informar se conseguiu ler ou não

                if (SecurePasswordHashed.Verify(password, dados["Password"].ToString()))
                {
                    if (AddPlayer != null) AddPlayer(dados["Name"].ToString(), dados["Username"].ToString(), dados["Password"].ToString(),
                           dados["Country"].ToString(), dados["Email"].ToString(), dados["Photo"].ToString());

                    //fechar sempre a ligação ao servidor quando não é mais necessária
                    server.Close();

                    if (LoginSuccessful != null) LoginSuccessful();
                }
                else
                {
                    if (msg != null) msg("Invalid login credentials");
                    server.Close();//
                }
            }
            else // Não encontrou username
            {
                if (msg != null) msg("Username not found");
            }
        }

        public void Quit()
        {
            System.Windows.Forms.Application.Exit();
        }

        public void UpdateComboBox()
        {
            if (CountriesComboBox!=null)
            {
                List<string> countries = new List<string>();
                FileStream fp = new FileStream("countries.txt", FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(fp);
                string countrytxt;
                while ((countrytxt = reader.ReadLine()) != null)
                {
                    countries.Add(countrytxt);
                }
                reader.Close();
                fp.Close();
                CountriesComboBox(countries);
            }
        }

    }
}
