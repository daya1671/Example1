using KendoUIApp1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace KendoUIApp1.Config
{
    public class EntityConfig<T> : EntityTypeConfig<T> where T : class, IEntity
    {
        public EntityConfig()
        {
              
        }
    }
}