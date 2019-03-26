using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AquaVM;
using AutoMapper;
using AquaContext;

namespace AquaBL
{
    public class Journals : IJournals
    {
        public Journal CreateJournal(Journal journal)
        {
            journal.CreatedDateTime = DateTime.Now;
            using (AquaContext.AquaContext context = new AquaContext.AquaContext())
            {
                context.Journals.Add(journal);
                 context.SaveChanges();
                return journal;
            }
        }

        public Journal UpdateJournal(Journal journal)
        {
            using (AquaContext.AquaContext context = new AquaContext.AquaContext())
            {
                    var journalToDelete = context.Journals.Where(x => x.PKID == journal.PKID).First();
                    context.Journals.Remove(journalToDelete);
                    journal.PKID = 0;
                    context.Journals.Add(journal);
                    context.SaveChanges();
                    return journal;
            }
        }

    }
}
