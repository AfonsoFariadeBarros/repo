using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacaofinalprojecto
{
    class Jogo
    {
        public User userajogar { get; set; }

        public static Jogo instance=null;
        public static Jogo getinstance()
        {
            if (instance == null)
            {
                instance= new Jogo();
            }
            return instance;
        }
        private Jogo()
        {
           
        }




    }
}
