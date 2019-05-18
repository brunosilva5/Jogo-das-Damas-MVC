using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Login1
{
    public class ModelDamas
    {
        public event ListaJogadoresDelegate PlayerAdd;

        public List<PReal> Players { get; private set; }

        public ModelDamas()
        {
            Players = new List<PReal>();
        }



        public void AddPlayer(PReal p)
        {
            Players.Add(p);
            if (PlayerAdd != null) PlayerAdd(Players);
        }

        public void WantSignup()
        {
            Program.V_Login.Hide();
            ViewRegistar registar = new ViewRegistar();

            registar.UserRegistered += Registar_UserRegistered;

            if (registar.ShowDialog() == System.Windows.Forms.DialogResult.Yes)
            {
                PReal p = new PReal();
                p.Name = registar.Name;
                p.Username = registar.Username;
                p.Password = registar.Password;
                p.Photo = Image.FromFile("Photos\\" + Path.GetFileName(registar.Photo));
                p.Email = registar.Email;
                p.Country = registar.Country;

                AddPlayer(p);

                Program.V_ModoJogo.ShowDialog();
            }
            else
            {
                Program.V_Login.ShowDialog();
            }
        }

        private void Registar_UserRegistered(string s1, string s2, string s3, string s4, string s5, string s6)
        {
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

            //construir a string SQL de insert nas tabelas
            // para aplicações reais devem usar SQL parameters e não string directas 
            string comando = String.Format("INSERT INTO Users" +
                                            "(UserName, Name, Password, Photo, Email, Country, NumGames, NumWins, NumDefeats, NumLeave) values " +
                                            "( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                                            s1, s2, s3, filename, s5, s6, "0", "0", "0", "0");

            //construir o comando SQL com a ligação ao servidor
            SqlCommand command = new SqlCommand(comando, server);

            //executar o comando sem expectativa de receber resultados (usar para INSERTS, UPDATES, DELETE)
            //o metodo devolve o numero de linhas modificadas pela query enviada
            int result = command.ExecuteNonQuery();

            //fechar sempre a ligação quando deixa de ser necessária
            server.Close();

            if (result == 1)  // se o resultado for 1, significa que adicionou correctamente o utilizador
            {
                //guardar copia do ficheiro na pasta fotos
                System.IO.File.Copy(s4,"Photos\\" + filename, true);

            }
            else
            {
                // não inseriu na base de dados, não fazemos nada

            }
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
                                            "username = '{0}' and password = '{1}'",
                                            username, password);

            //construir o comando SQL com a ligação ao servidor
            SqlCommand command = new SqlCommand(cmdText, server);

            //executar o comando e receber os dados resultantes dessa query 
            SqlDataReader dados = command.ExecuteReader();

            if (dados.HasRows) //vereficar se tem resultados, o que significa que há algum registo com aquele username e password
            {//o login é valido

                dados.Read(); //lê uma linha dos resultados, este metodo retorna um bool para informar se conseguiu ler ou não

                PReal p = new PReal();
                //ler os dados, com o nome das colunas como identificador
                p.Name = dados["Name"].ToString();
                p.Username = dados["Username"].ToString();
                p.Password = dados["Password"].ToString();

                p.Photo = Image.FromFile("Photos\\" + dados["Photo"].ToString());

                //fechar sempre a ligação ao servidor quando não é mais necessária
                server.Close();

                AddPlayer(p); // assume que o jogador entrou e adiciona-o ao jogo
                Program.V_Login.Hide();
                Program.V_ModoJogo.ShowDialog();
            }
            else // o login é invalido
            {
                MessageBox.Show("Credenciais erradas!","Login",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void Quit()
        {
            System.Windows.Forms.Application.Exit();
        }

    }
}
