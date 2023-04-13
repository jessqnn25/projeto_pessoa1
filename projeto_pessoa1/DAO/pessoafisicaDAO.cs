using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_pessoa1.DAO;
using projeto_pessoa1.VO;

namespace projeto_pessoa1.DAO
{
    class pessoafisicaDAO
    {

        public static List <fisica> listaPessoaFisica;

            public fisica pessoa { get; set;}

        public pessoafisicaDAO()
        {
            if (listaPessoaFisica == null)
            {
                listaPessoaFisica = new List<fisica>();
            }
        }

        public void create()
        {
        listaPessoaFisica.Add(pessoa);
        }
        public void update()
        {

        }

        public void delete()
        {

        }
        public List<fisica> list()
        {
            return listaPessoaFisica;
        }
    }
}
