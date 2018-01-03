﻿using Sinaf.DAL.Sinistro;
using Sinaf.VOL.Sinistro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinaf.BLL
{
    public class PreAvisoHistoricoBlo
    {
        public void Incluir(PreAvisoHistorico preAvisoHistorico)
        {
            PreAvisoHistoricoDao preAvisoDao = new PreAvisoHistoricoDao();
            preAvisoDao.Incluir(preAvisoHistorico);
            preAvisoDao.SaveChanges();
        }
    }
}
