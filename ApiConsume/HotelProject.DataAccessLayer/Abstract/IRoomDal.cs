using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    //Bu şekilde yaptık ve room Entitysi artık generic Daldan haberdar oldu. Eğer sadece Room özelinde bir metod varsa yazın çekinmeyin.
    public interface IRoomDal:IGenericDal<Room>
    {
    }
}
