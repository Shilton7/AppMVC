using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.UI.Site.Models
{
    public class Pedido
    {

        public Guid id { get; set; }

        public Pedido()
        {
            id = Guid.NewGuid();
        }

    }

}
