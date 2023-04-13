using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_pessoa1.VO;
using projeto_pessoa1.DAO;
namespace projeto_pessoa1.BE
{
    class pessoafisicaBE
    {
        public fisica pessoa { get; set;}
        private pessoafisicaDAO dao { get; set; }

        public pessoafisicaBE()
        {
            dao = new pessoafisicaDAO();
        }


        public void create()
        {
            dao.pessoa = pessoa;
            dao.create();
        }
        public void update()
        {

        }
        public void delete()
        {

        }
        public List <fisica> list()
        {
            return dao.list();
        }
    }
}
