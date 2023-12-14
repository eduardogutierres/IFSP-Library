using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPLibrary.domain.Base
{
    public abstract class BaseEntity<IId> : IBaseEntity
    {
        protected BaseEntity()
        {

        }

        protected BaseEntity(IId id)
        {
            Id = id;
        }

        public IId? Id { get; set; }
    }
}
