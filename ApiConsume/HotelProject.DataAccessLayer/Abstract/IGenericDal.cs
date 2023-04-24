using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    //Bir T değeri alacağız ve bu T değeri garanti class olmalı
    public interface IGenericDal<T> where T : class
    {
        //şimdi içerisinde Api içerisindeki CRUD işlemleri için metotlarımızı tanımlayalım.

        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
    }
}
