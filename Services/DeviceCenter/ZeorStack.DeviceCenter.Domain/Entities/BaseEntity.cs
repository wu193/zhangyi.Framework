using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeorStack.DeviceCenter.Domain.Entities
{
    public abstract class BaseEntity
    {
        public abstract Object[] GetKeys();
    }
    public abstract class BaseEntity<Tkey> : BaseEntity
    {
       public Tkey Id { get; set; }
        public override object[] GetKeys()
        {
            return new object[] { Id! };
        }
    }
}
