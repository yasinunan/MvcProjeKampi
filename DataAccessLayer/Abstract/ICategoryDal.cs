﻿
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        //CRUD
        //Type Name();

        List<Category> List();

        void Insert(Category P);

        void Update(Category P);

        void Delete(Category P);


    }
}
