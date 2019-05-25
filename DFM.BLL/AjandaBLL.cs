using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DFM.DAL;

namespace DFM.BLL
{
    public class AjandaBLL
    {
        List<Ajanda> db = new List<Ajanda>();

        public AjandaBLL()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(Sabitler.appPath + @"db\Ajanda.txt");

            string row;
            while ((row = file.ReadLine()) != null)
            {
                string[] column = row.Split('#');
                Ajanda model = new Ajanda();
                model.Id = Convert.ToInt32(column[0]);
                model.Icerik = column[1];
                model.BaslamaTarihi = Convert.ToDateTime(column[2]);
                model.BitisTarihi = Convert.ToDateTime(column[3]);
                model.Durumu = Convert.ToBoolean(column[4]);

                db.Add(model);
            }

            file.Close();
            file.Dispose();
        }

        public void SetTable()
        {
            

            System.IO.StreamWriter file = new System.IO.StreamWriter(Sabitler.appPath + @"db\Ajanda.txt");

            foreach (var item in db)
            {
                string row = item.Id + "#" + item.Icerik + "#"
                    + item.BaslamaTarihi + "#" + item.BitisTarihi + "#" + item.Durumu;

                file.WriteLine(row);
            }

            file.Close();
            file.Dispose();
        }

        public Ajanda GetFirst()
        {
            return db.First();
        }
        public Ajanda GetLast()
        {
            return db.Last();
        }
        public int GetCount(Func<Ajanda, bool> predicate)
        {
            return db.Where(predicate).Count();
        }
        public List<Ajanda> Get()
        {
            return db.ToList();
        }
        public List<Ajanda> Get(Func<Ajanda, bool> predicate)
        {
            return db.Where(predicate).ToList();
        }
        public void Update(int Id, Ajanda model)
        {
            var update = GetById(Id);
            update.Icerik = model.Icerik;
            update.BaslamaTarihi = model.BaslamaTarihi;
            update.BitisTarihi = model.BitisTarihi;
            update.Durumu = model.Durumu;
            SetTable();
        }
        public void Delete(int Id)
        {
            var del = GetById(Id);
            db.Remove(del);
            SetTable();
        }
        public Ajanda GetById(int Id)
        {
            var model = db.Find(f => f.Id == Id);
            if (model != null)
            {
                return model;
            }
            else
            {
                return new Ajanda();
            }
        }
        public void Insert(Ajanda model)
        {
            model.Id = GenelAraclar.GetId("Ajanda");
            db.Add(model);
            SetTable();
        }
    }

}



