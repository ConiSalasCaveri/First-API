using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Entity
{
    public class CityInfoContext
    {

        public static CityInfoContext Current { get; } = new CityInfoContext();
        //Devuelve una instancia nueva de cities Info Context
        public List<City> Cities { get; set; }

        public CityInfoContext()
        {
            Cities = new List<City>()
            {
                new API.Entity.City { Id=1, Descripcion="Una ciudad muy linda", Name="Super city",
                TuristicPoints=new List<TuristicPoint>()
                {
                    new TuristicPoint()
                    {
                        Id=1,
                        Description="Un hermoso lugar para apreciar la fauna",
                        Name="Centro de la ciudad"

                    },

                    new TuristicPoint()
                    {
                        Id=2,
                        Description="Desarrollo de la pesca",
                        Name="Punto pesca"

                    }
                }


                },
                new API.Entity.City { Id=2, Descripcion="Tiene muchos lagos", Name="Una ciudad",
                TuristicPoints= new List<TuristicPoint>(){

                    new TuristicPoint()
                    {
                        Id=3,
                        Description="Vistas panoramicas",
                        Name="Punto panoramico"

                    },

                    new TuristicPoint()
                    {
                        Id=4,
                        Description="Monumento a los militares",
                        Name="Monumento"

                    }
                }
                },

                new API.Entity.City { Id=3, Descripcion="Una ciudad inolvidable", Name="Moreno city",
                TuristicPoints=new List<TuristicPoint>()
                {
                    new TuristicPoint()
                    {
                        Id=5,
                        Description="El lugar mas preciado de esta ciudad",
                        Name="Monumento al ciervo"

                    },

                    new TuristicPoint()
                    {
                        Id=6,
                        Description="Emblema unico de la ciudad",
                        Name="Fuente de agua"

                    }
                }


                }

            };

        }

        
    } 
}
