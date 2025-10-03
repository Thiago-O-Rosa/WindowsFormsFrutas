using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFrutas
{
    public class ClassListaFrutas
    {
        //propriedades 
        private List<string> _fruta = new List<string>();

        //Construtor
        public ClassListaFrutas (List<string> fruta)
        {
            this._fruta = fruta;
        }
        
        //Adicionar
        public void Adicionar (string fruta)
        {
            _fruta.Add(fruta);
            Ordenar();
            //ListarTodos();
        }

        //Remover
        public void Remover (string fruta)
        {
            _fruta.Remove(fruta);
            ListarTodos();
        }

        //Ordenar
        public void Ordenar()
        {
            _fruta.Sort();
        }

        //Listar
        public List<string> ListarTodos() =>
            new List<string>(_fruta);
        

            
        

       
    }
}
