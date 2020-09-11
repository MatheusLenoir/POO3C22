using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3C22
{
    class BLL22
    {

        private DAL22 DaoBanco = new DAL22();
        public Boolean Autenticar(int idmusica, string Nome, string NomeAutor, int idgravadora, int idCd)
        {
            string consulta = string.Format($@"select * from tbl_musica where idmusica = '{idmusica}' and nome = '{nome}' and nomeAutor = '{nomeautor}' and idGravadora = '{idgravadora}' and idCD = '{idCd}' ;");

            DataTable dt = DaoBanco.executarConsulta(consulta);

            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public DataTable ListarMusicas()
        {
            string sql = string.Format($@"select * from tbl_musica;");
            return DaoBanco.executarConsulta(sql);
        }



        public void AdicionarMusica(DTO22 objMusica)
        {
            DTO22 musica = new DTO22();
            string sql = string.Format($@"insert into tbl_musica values (null, '{objMusica.Nome}', 
                                                                                '{objMusica.NomeAutor}',
                                                                                '{objMusica.Idgravadora}',
                                                                                '{objMusica.IdCD}'); ");
            DaoBanco.executarComando(sql);

        }

        public void ExcluirMusica(DTO22 objMusica)
        {
            string sql = string.Format($@"delete from tbl_musica where idMusica = '{objMusica.Idmusica}';");
            DaoBanco.executarComando(sql);
        }

        public void AlterarMusica(DTO22 objdto)
        {
            string sql = string.Format($@"UPDATE tbl_musica set nome = '{objdto.Nome}',
                                                                nomeAutor = '{objdto.NomeAutor}',
                                                                idGravadora = '{objdto.Idgravadora}',
                                                                idCD = '{objdto.IdCD}'
                                        where idMusica = '{objdto.Idmusica}';");
            DaoBanco.executarComando(sql);
        }
    }
}
