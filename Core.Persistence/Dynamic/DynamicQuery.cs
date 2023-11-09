namespace Core.Persistence.Dynamic;

public class DynamicQuery
{
    public IEnumerable<Sort>? Sort { get; set; }
    public Filter? Filter { get; set; }
    public DynamicQuery()
    {

    }
    public DynamicQuery(IEnumerable<Sort>? sort, Filter? filter)
    {
        Filter = filter;
        Sort = sort;
    }
}

//Select * From Cars Where dailyPrice<100 and (transmission = 1 or color ='blue') => Böyle bir sql cümlesinin linq versiyonunu System.Linq.Dynamic.Core kütüphanesi oluşturabilir.

//p=>p.DailyPrice <= 100 && (p.Transmission = 1 || p.Color = 'blue')

//System.Linq.Dynamic.Core kütüphanesi şunu yapar. Bizim string formatta oluşturduğumuz sql cümlesini, linq yapısına çevirir.