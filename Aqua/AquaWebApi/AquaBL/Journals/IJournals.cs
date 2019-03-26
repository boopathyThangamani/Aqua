using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaVM;
using AquaContext;

namespace AquaBL
{
   public interface IJournals
    {
        Journal CreateJournal(Journal journalVM);
        Journal UpdateJournal(Journal journalVM);
    }
}
