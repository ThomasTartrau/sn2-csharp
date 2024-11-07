using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriquesEtDelegues
{
    internal class Liste<T> : IEnumerable<T>
    {
        private readonly ArrayList list;
        public Liste() {
            list = new ArrayList();
        }
        public int Count => list.Count;

        //indexeur
        public T this[int index] => (T)list[index];


        public void Ajouter(T element)
        {
            list.Add(element);
        }

        public void Trier(DelegueQuiCompareDeuxMachins<T> test)
        {
            //tri par inversion
            //on va convertir les T en int 
            //et on va trier les int
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (test((T)list[i], (T)list[j]))
                    {
                        var temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
            => list.OfType<T>().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
