using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriquesEtDelegues
{
    /// <summary>
    /// Délégué qui compare deux machins et renvoie un booléen
    /// pour coder la comparaison que l'on veut
    /// </summary>
    /// <typeparam name="TypeDeMachin"></typeparam>
    /// <param name="machin1"></param>
    /// <param name="machin2"></param>
    /// <returns>le résultat de la comparaison</returns>
    public delegate bool DelegueQuiCompareDeuxMachins<TypeDeMachin>(TypeDeMachin machin1, TypeDeMachin machin2);
}
