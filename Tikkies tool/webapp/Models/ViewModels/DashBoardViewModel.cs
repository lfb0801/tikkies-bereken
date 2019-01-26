using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models.ViewModels
{
    public class DashBoardViewModel
    {
        public string Naam { get; private set; }

        public DashBoardViewModel(string naam)
        {
            Naam = naam;
        }
    }
}
