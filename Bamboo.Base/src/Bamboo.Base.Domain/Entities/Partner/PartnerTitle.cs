using Bamboo.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Bamboo.Base.Entities
{
    public class PartnerTitle : FullAuditedAggregateRoot<long>, IHasExtraProperties
    { 
        public PartnerTitle()
        {

        }
        public PartnerTitle(long id)
            :base(id)
        {

        }
        //public Guid? TenantId { get; set; }

#if HAS_DB_POSTGRESQL
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "bigserial")]
#endif
        public long Sequence { get; set; }

        public string Name { get; set; }

        public string Shortcut { get; set; }


        //[Column(TypeName = "jsonb")]
        //public PartnerTitleExtraData ExtraData { get; set; }
#if HAS_DB_POSTGRESQL
        [Column(TypeName = "jsonb")]
#endif
        public override ExtraPropertyDictionary ExtraProperties { get; protected set; }
    }
}