using Core.Entities;
using System.Reflection.Metadata.Ecma335;

namespace Core.DataAccess;

public interface IEntityRepository<TEntity, TEntityId> //Repository Design Pattern
{
    public IList<TEntity> GetList(Func< TEntity, bool>? predicate=null);

    //Func fonksiyonları tutabileceğimiz bir type'dir.
    //Jenerik yapısında en son type argümanı fonksiyonun dönüş  tipidir.
    //Ondan önce gelen type argümanları fonksiyonun dönüş tipleridir.

    //Ornek kullanımlar;
    //Func<TEntity, bool> predicate = (TEntity Entity) => { return Entity.Name == ""; };
    // bool predicate (TEntity etity)
    //{
    //bool result = Entity.Name == "";
    // return result;
    //}
    // Func<TEntity, bool> predicateFunc=predicate;


    public TEntity? Get(Func<TEntity, bool> predicate );
    public TEntity Add(TEntity entity);
    public TEntity Update(TEntity entity);
    public TEntity Delete(TEntity entity);
}
