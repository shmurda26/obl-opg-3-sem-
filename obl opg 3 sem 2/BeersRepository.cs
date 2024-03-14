﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obl_opg_3_sem_2_
{
    public class BeersRepository
    {
        private int nextId = 6;
        private List<Beer> beers = new()
        {
            new Beer{Id=1, Name="beauty",Abv=16},
            new Beer{Id=2, Name = "lively",Abv=17.5},
            new Beer{Id=3, Name = "beerious",Abv=42},
            new Beer{Id=4, Name="smooth criminal",Abv=33},
            new Beer{Id=5,Name="desireble",Abv=43},

        };
        public List<Beer> GetBeers(string? nameStart = null, string? sortby = null)
        {
            List<Beer> result = new List<Beer>(beers);
            if (nameStart != null)

            {
                result = result.FindAll(b => b.Name.StartsWith(nameStart));
            }
            if (sortby != null)
            {
                switch (sortby)
                {
                    case "name":
                        result.Sort((b1, b2) => b1.Name.CompareTo(b2.Name));
                        break;
                    case "abv":
                        result.Sort((b1, b2) => b1.Abv.CompareTo(b2.Abv));
                        break;

                }
            }
            return result;
        }
        public Beer? GetById(int id)
        {
            return beers.Find(beer => beer.Id == id);
        }
        public Beer AddBeer(Beer beer)
        {
            beer.Id = nextId++;
            beers.Add(beer);
            return beer;

        }
        public Beer? GetBeer(int id)
        {
            return beers.Find(b => b.Id == id);
        }
        public Beer? DeleteBeer(int id)
        {
            Beer? beer = beers.Find(b => b.Id == id);
            if (beer != null)
            {
                beers.Remove(beer);
            }
            return beer;
        }
        public Beer? UpdateBeers(int Id,Beer data)
        {
            Beer? beerToUpdate=beers.Find(b => b.Id == Id);
            if (beerToUpdate != null)
            { 
                beerToUpdate.Name = data.Name;
                beerToUpdate.Abv=data.Abv;
            }
            return beerToUpdate;
        }



        

    }
}
