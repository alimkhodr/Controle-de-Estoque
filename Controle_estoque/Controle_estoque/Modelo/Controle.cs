using Controle_estoque.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_estoque.Modelo
{
    class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(String registro_usuario, String senha_usuario)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(registro_usuario, senha_usuario);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }


        public String cadastrar(String nome_usuario, String registro_usuario, String setor_usuario, String senha_usuario, String confsenha_usuario, String tipo_usuario)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(nome_usuario, registro_usuario, setor_usuario, senha_usuario, confsenha_usuario, tipo_usuario);
            if(loginDao.tem)//a mensagem vai vir com sucesso
            {
                this.tem = true;
    }
            return mensagem;
        }
    }
}
