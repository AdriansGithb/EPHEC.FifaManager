using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd_DAL
{
    public partial class Fifa_ManagerEntities : DbContext
    {
        [DbFunction("FifaManagerModel.Store", "FN_CheckGnrClndrPossible")]
        public string FN_CheckGnrClndrPossible(int champ_id)
        {
            var objectContext = ((IObjectContextAdapter)this).ObjectContext;

            var parameters = new List<ObjectParameter>();
            parameters.Add(new ObjectParameter("champ_id", champ_id));

            return objectContext.CreateQuery<string>("FifaManagerModel.Store.FN_CheckGnrClndrPossible(@champ_id)", parameters.ToArray())
                .Execute(MergeOption.NoTracking)
                .FirstOrDefault();
        }
    }
}
