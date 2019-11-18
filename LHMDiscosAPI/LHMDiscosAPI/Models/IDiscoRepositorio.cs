using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LHMDiscosAPI.Models
{
    interface IDiscoRepositorio
    {
        IEnumerable<Disco> GetAll();

        Disco Get(int id);
        
        Disco Add(Disco item);
        
        void Remove(int id);
        
        bool Update(Disco item);
    }
}