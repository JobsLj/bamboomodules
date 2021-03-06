﻿using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Bamboo.Attendance.MongoDB
{
    [ConnectionStringName(AttendanceDbProperties.ConnectionStringName)]
    public class AttendanceMongoDbContext : AbpMongoDbContext, IAttendanceMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureAttendance();
        }
    }
}