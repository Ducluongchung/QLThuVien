﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMVC.Model;

namespace WebMVC.Service
{
    public interface IMuonSachService : IService<MuonSach>
    {

    }
    public class MuonSachService : IMuonSachService
    {
        public int Add(MuonSach item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<MuonSach> GetAll()
        {
            throw new NotImplementedException();
        }

        public MuonSach GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(MuonSach item)
        {
            throw new NotImplementedException();
        }
    }
}
