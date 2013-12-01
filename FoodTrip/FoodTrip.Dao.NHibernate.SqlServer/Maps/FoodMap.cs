using FoodTrip.Dao.NHibernate.Repo;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace FoodTrip.Dao.NHibernate.SqlServer.Maps
{
    public class FoodMap : ClassMapping<FoodRepo>
    {
        public FoodMap()
        {
            Table("Food");
            Id(c => c.Id, c => c.Generator(Generators.Native));
            Property(c => c.Name, m => { m.Length(20); m.NotNullable(true); });
            Property(c => c.Description, m => { m.Length(250); m.NotNullable(true); });
            Bag(c => c.MenuItems, m =>
            {
                m.Cascade(Cascade.DeleteOrphans);
                m.Inverse(true);
                m.Key(k => k.Column("FoodId"));
                m.Lazy(CollectionLazy.NoLazy);
            }, ce => ce.OneToMany());
        }
    }
}
