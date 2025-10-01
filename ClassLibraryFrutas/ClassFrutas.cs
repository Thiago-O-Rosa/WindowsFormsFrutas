using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFrutas
{
    public class ClassListaFrutas
    {
        private string Fruta { get; set;}
        private List<ClassListaFrutas> _fruta = new List<ClassListaFrutas>();

        //Construtor
        public ClassListaFrutas (string fruta)
        {
            this.Fruta = fruta;
        }
        
        public void Adicionar (ClassListaFrutas fruta)
        {
            _fruta.Add(fruta);
        }

        public void Remover (ClassListaFrutas fruta)
        {
            _fruta.Remove(fruta);
        }

       
    }
}
