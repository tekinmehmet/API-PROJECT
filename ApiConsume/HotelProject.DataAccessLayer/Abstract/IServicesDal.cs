using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    //Bu şekilde yaptık ve Service Entitysi artık generic Daldan haberdar oldu. Eğer sadece Service özelinde bir metod varsa yazın çekinmeyin.
    public interface IServicesDal:IGenericDal<Service>
    {
    }
}
