using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AtividadeFinal-27-11-23
{
    public class Catalogo
    {
        private List<Equipamentos> lote;

        public List<Equipamentos> Lote { get => lote; set => lote = value; }

        public Catalogo()
        {
            lote = new List<Equipamentos>();
        }

        public void InserirTipoEquipamento(Equipamentos tipoequipamento)
        {
            lote.Add(tipoequipamento);
        }
    }
}
