using FoodTrip.Dao.NHibernate.Repo;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;


namespace FoodTrip.Dao.NHibernate.SqlServer.Maps
{
    public class UserMap : ClassMapping<UserRepo>
    {
        public UserMap()
        {
            Table("`User`");
            Id(c => c.Id, m => m.Generator(Generators.Native));
            Property(c => c.Username, m =>
            {
                m.Length(20);
                m.NotNullable(true);
            });
            Property(c => c.Password, m =>
            {
                m.Length(20);
                m.NotNullable(true);
            });
            Property(c => c.FullName, m =>
            {
                m.NotNullable(true);
                m.Length(50);
            });
            Property(c => c.Email, m =>
            {
                m.Length(50);
                m.NotNullable(false);
            });
            Property(c => c.ContactNo, m =>
            {
                m.Length(20);
                m.NotNullable(true);
            });
            Property(c => c.UserType, m =>
            {
                m.NotNullable(true);
                m.Column(c => c.SqlType("TINYINT"));
            });
            Bag(c => c.MenuList, m =>
            {
                m.Key(k => k.Column("UserId"));
                m.Inverse(true);
                m.Cascade(Cascade.DeleteOrphans);
                m.Lazy(CollectionLazy.NoLazy);
            }, ce => ce.OneToMany());
        }
    }
}
