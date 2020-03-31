using System;
using System.Collections.Generic;
using System.Text;

namespace Aula5Ferramenta
{
    public class FerramentaService
    {
        public static List<Ferramenta> ferramentas = new List<Ferramenta>();
        public void Adicionar(Ferramenta ferramenta)
        {
            ferramentas.Add(ferramenta);
        }
        public List<Ferramenta> Listar()
        {
            return ferramentas;
        }
    }
}
